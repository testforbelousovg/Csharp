using System;
using System.Windows.Forms;

namespace ATM_
{
    public partial class ChooseAction : Form
    {
        public ChooseAction(ATM aTM)
        {
            InitializeComponent();
            this.aTM = aTM;
        }

        ATM aTM;

        private void SumChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {        

            if (radioButtonCashIn.Checked)
            {
                int sum;
                if (textSum.Text != "")
                {
                    sum = Convert.ToInt32(textSum.Text);
                }
                else
                {
                    MessageBox.Show("Введите сумму!", "Ошибка!");
                    return;
                }
                CashOut cashOut = new CashOut(aTM, sum, this);
                cashOut.Show();
                this.Hide();
            }
            else
            {
                CashIn cashIn = new CashIn(aTM, this);
                cashIn.Show();
                this.Hide();
            }
        }
    }
 
}
