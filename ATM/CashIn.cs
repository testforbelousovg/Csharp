using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATM_
{
    public partial class CashIn : Form
    {
        public CashIn(ATM aTM, ChooseAction first)
        {
            InitializeComponent();
            totalSpaceInATM = aTM.maxQuantityofBankNotes - aTM.currentQuantityOfBankNotes;
            labelTotalSpaceInATM.Text = Convert.ToString(totalSpaceInATM);
            this.aTM = aTM;
            this.chooseAction = first;
        }
        ChooseAction chooseAction;
        ATM aTM;
        int totalSpaceInATM;

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, int> usersBankNotes = new Dictionary<string, int>(6);
            if (textBox6.Text != "")
            {
                usersBankNotes.Add("10", Convert.ToInt32(textBox6.Text));
            }
            else
            {
                usersBankNotes.Add("10", 0);
            }

            if (textBox5.Text != "")
            {
                usersBankNotes.Add("50", Convert.ToInt32(textBox5.Text));
            }
            else
            {
                usersBankNotes.Add("50", 0);
            }
            if (textBox4.Text != "")
            {
                usersBankNotes.Add("100", Convert.ToInt32(textBox4.Text));
            }
            else
            {
                usersBankNotes.Add("100", 0);
            }
            if (textBox3.Text != "")
            {
                usersBankNotes.Add("500", Convert.ToInt32(textBox3.Text));
            }
            else
            {
                usersBankNotes.Add("500", 0);
            }
            if (textBox2.Text != "")
            {
                usersBankNotes.Add("1000", Convert.ToInt32(textBox2.Text));
            }
            else
            {
                usersBankNotes.Add("1000", 0);
            }
            if (textBox1.Text != "")
            {
                usersBankNotes.Add("5000", Convert.ToInt32(textBox1.Text));
            }
            else
            {
                usersBankNotes.Add("5000", 0);
            }
            int sum = 0;
            foreach(int quantity in usersBankNotes.Values)
            {
                sum += quantity;
            }
            if(sum > totalSpaceInATM)
            {
                MessageBox.Show("В банкомате недостаточно места!", "Ошибка!");
                return;
            }
            else
            {
                aTM.AddBankNotes(usersBankNotes);
                MessageBox.Show("Средства успешно внесены!", "Чек");
                this.Close();
                chooseAction.Show();

            }
            
        }

        private void Deposite_FormClosed(object sender, FormClosedEventArgs e)
        {
            chooseAction.Show();
        }
    }
    
}
