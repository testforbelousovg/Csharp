using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATM_
{

    public partial class CashOut : Form
    {
        public CashOut(ATM aTM, int sum, ChooseAction chooseAction)
        {
            InitializeComponent();
            this.aTM = aTM;
            this.chooseAction = chooseAction;
            this.sum = sum;
            CalculateAndUpdateAvailableBankNotesToGive(sum, aTM.GetQuantityOfBankNotes());            
            UpdateQuantityOfBankNotesInATM();

        }
        ChooseAction chooseAction;
        ATM aTM;
        private int sum;
        private int localSum;

        public static int Min(int x, int y, int z)
        {
            return Math.Min(x, Math.Min(y, z));
        }


        private void CalculateAndUpdateAvailableBankNotesToGive(int sum, Dictionary<string, int> usersBankNotes)
        {
            if (sum < 0)
            {
                MessageBox.Show("Слишком большое число!", "Ошибка!");
            }
            Dictionary<string, int> quantityOfBankNotes = aTM.GetQuantityOfBankNotes();
            labelAvailable10sToCashOut.Text = Convert.ToString(Math.Min(sum / 10, quantityOfBankNotes["10"] - usersBankNotes["10"]));
            labelAvailable50sToCashOut.Text = Convert.ToString(Math.Min(sum / 50, quantityOfBankNotes["50"] - usersBankNotes["50"]));
            labelAvailable100sToCashOut.Text = Convert.ToString(Math.Min(sum / 100, quantityOfBankNotes["100"] - usersBankNotes["100"]));
            labelAvailable500sToCashOut.Text = Convert.ToString(Math.Min(sum / 500, quantityOfBankNotes["500"] - usersBankNotes["500"]));
            labelAvailable1000sToCashOut.Text = Convert.ToString(Math.Min(sum / 1000, quantityOfBankNotes["1000"] - usersBankNotes["1000"]));
            labelAvailable5000sToCashOut.Text = Convert.ToString(Math.Min(sum / 5000, quantityOfBankNotes["5000"] - usersBankNotes["5000"]));
            
        }

        private void UpdateQuantityOfBankNotesInATM()
        {
            Dictionary<string, int> quantityOfBankNotes = aTM.GetQuantityOfBankNotes();
            labelQuantity10sInATM.Text = quantityOfBankNotes["10"].ToString();
            labelQuantity50sInATM.Text = quantityOfBankNotes["50"].ToString();
            labelQuantity100sInATM.Text = quantityOfBankNotes["100"].ToString();
            labelQuantity500sInATM.Text = quantityOfBankNotes["500"].ToString();
            labelQuantity1000sInATM.Text = quantityOfBankNotes["1000"].ToString();
            labelQuantity5000sInATM.Text = quantityOfBankNotes["5000"].ToString();
        }

       
        

        private bool QuantityOfBankNotesChanged()
        {
            localSum = sum;
            Dictionary<string, int> usersBankNotes = GetQuantityOfUsersBankNotes();
            localSum = sum - 10 * usersBankNotes["10"] - 50 * usersBankNotes["50"]
                - 100 * usersBankNotes["100"] - 500 * usersBankNotes["500"] - 1000 * usersBankNotes["1000"] - 5000 * usersBankNotes["5000"];
            if(localSum < 0)
            {
                return false;
            }
            else
            {
                CalculateAndUpdateAvailableBankNotesToGive(localSum, usersBankNotes);
                return true;
            }

        }


        private Dictionary<string, int> GetQuantityOfUsersBankNotes()
        {
            Dictionary<string, int> usersBankNotes = new Dictionary<string, int>(6);
            Dictionary<string, int> bankNotesInATM = aTM.GetQuantityOfBankNotes();
            if (textBox6.Text != "")
            {
                if (Convert.ToInt32(textBox6.Text) <= bankNotesInATM["10"])
                {
                    usersBankNotes.Add("10", Convert.ToInt32(textBox6.Text));
                }   
                else
                {
                    MessageBox.Show("Слишком большое число!", "Ошибка!");
                    textBox6.Text = "";
                    usersBankNotes.Add("10", 0);
                }
            }
            else
            {
                usersBankNotes.Add("10", 0);
            }

            if (textBox5.Text != "")
            {
                if (Convert.ToInt32(textBox5.Text) <= bankNotesInATM["10"])
                {
                    usersBankNotes.Add("50", Convert.ToInt32(textBox5.Text));
                }
                else
                {
                    MessageBox.Show("Слишком большое число!", "Ошибка!");
                    textBox5.Text = "";
                    usersBankNotes.Add("50", 0);
                }
            }
            else
            {
                usersBankNotes.Add("50", 0);
            }
            if (textBox4.Text != "")
            {
                if (Convert.ToInt32(textBox4.Text) <= bankNotesInATM["10"])
                {
                    usersBankNotes.Add("100", Convert.ToInt32(textBox4.Text));
                }
                else
                {
                    MessageBox.Show("Слишком большое число!", "Ошибка!");
                    textBox4.Text = "";
                    usersBankNotes.Add("100", 0);
                }
            }
            else
            {
                usersBankNotes.Add("100", 0);
            }
            if (textBox3.Text != "")
            {
                if (Convert.ToInt32(textBox3.Text) <= bankNotesInATM["10"])
                {
                    usersBankNotes.Add("500", Convert.ToInt32(textBox3.Text));
                }
                else
                {
                    MessageBox.Show("Слишком большое число!", "Ошибка!");
                    textBox3.Text = "";
                    usersBankNotes.Add("500", 0);
                }
            }
            else
            {
                usersBankNotes.Add("500", 0);
            }
            if (textBox2.Text != "")
            {
                if (Convert.ToInt32(textBox2.Text) <= bankNotesInATM["10"])
                {
                    usersBankNotes.Add("1000", Convert.ToInt32(textBox2.Text));
                }
                else
                {
                    MessageBox.Show("Слишком большое число!", "Ошибка!");
                    textBox2.Text = "";
                    usersBankNotes.Add("1000", 0);
                }
            }
            else
            {
                usersBankNotes.Add("1000", 0);
            }            
            if (textBox1.Text != "")
            {
                if (Convert.ToInt32(textBox1.Text) <= bankNotesInATM["10"])
                {
                    usersBankNotes.Add("5000", Convert.ToInt32(textBox1.Text));
                }   
                else
                {
                    MessageBox.Show("Слишком большое число!", "Ошибка!");
                    textBox1.Text = "";
                    usersBankNotes.Add("5000", 0);
                }
            }
            else
            {
                usersBankNotes.Add("5000", 0);
            }
            return usersBankNotes;
        }

        private void QuantityOf10sChanged(object sender, EventArgs e)
        {
            if (!QuantityOfBankNotesChanged())
            {
                textBox6.Text = "";
                MessageBox.Show("Cлишком большое число купюр!", "Ошибка!");
            }
        }

        private void QuantityOf50sChanged(object sender, EventArgs e)
        {
            if (!QuantityOfBankNotesChanged())
            {
                textBox5.Text = "";
                MessageBox.Show("Cлишком большое число купюр!", "Ошибка!");
            }
        }

        private void QuantityOf100sChanged(object sender, EventArgs e)
        {
            if (!QuantityOfBankNotesChanged())
            {
                textBox4.Text = "";
                MessageBox.Show("Cлишком большое число купюр!", "Ошибка!");
            }
        }

        private void QuantityOf500sChanged(object sender, EventArgs e)
        {
            if (!QuantityOfBankNotesChanged())
            {
                textBox3.Text = "";
                MessageBox.Show("Cлишком большое число купюр!", "Ошибка!");
            }
        }

        private void QuantityOf1000sChanged(object sender, EventArgs e)
        {
            if (!QuantityOfBankNotesChanged())
            {
                textBox2.Text = "";
                MessageBox.Show("Cлишком большое число купюр!", "Ошибка!");
            }
        }

        private void QuantityOf5000sChanged(object sender, EventArgs e)
        {
            if (!QuantityOfBankNotesChanged())
            {
                textBox1.Text = "";
                MessageBox.Show("Cлишком большое число купюр!", "Ошибка!");
            }
        }
        

        private void CashOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            chooseAction.Show();
        }

        private void buttonCashOut_Click(object sender, EventArgs e)
        {
            if (localSum != 0)
            {
                MessageBox.Show("Неверное число купюр!", "Ошибка!");
                return;
            }
            aTM.GiveBankNotes(GetQuantityOfUsersBankNotes());
            UpdateQuantityOfBankNotesInATM();
            MessageBox.Show("Операция выполнена!", "Успешно!");
            chooseAction.Show();
            this.Close();
        }
    }

}
