using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_
{
    public class ATM
    {
        public ATM()
        {
            this.bankNotes = new Dictionary<string, int>(6);
            this.bankNotes.Add("10", 0);
            this.bankNotes.Add("50", 0);
            this.bankNotes.Add("100", 0);
            this.bankNotes.Add("500", 0);
            this.bankNotes.Add("1000", 0);
            this.bankNotes.Add("5000", 0);
            this.maxQuantityofBankNotes = 100000;
            this.currentQuantityOfBankNotes = quantityOfBankNotes();
        }

        Dictionary<string, int> bankNotes;

        public int maxQuantityofBankNotes
        {
            get; set;
        }

        public int currentQuantityOfBankNotes
        {
            get; set;
        }

    public int quantityOfBankNotes()
        {
            int sum = 0;
            foreach (int value in bankNotes.Values)
            {
                sum += value;
            }
            return sum;
        }

        public Dictionary<string, int> GetQuantityOfBankNotes()
        {
            return bankNotes;
        }

        public void AddBankNotes(Dictionary<string, int> bankNotesToAdd)
        {
            foreach(KeyValuePair<string, int> element in bankNotesToAdd)
            {
                bankNotes[element.Key] += element.Value;
                currentQuantityOfBankNotes += element.Value;
            }
        }

        public void GiveBankNotes(Dictionary<string, int> bankNotesToGive)
        {
            foreach (KeyValuePair<string, int> element in bankNotesToGive)
            {
                bankNotes[element.Key] -= element.Value;
                currentQuantityOfBankNotes -= element.Value;
            }
        }

        public bool EnoughMoneyToGive(int sumMoneyToGive)
        {
            int sumMoneyInATM = 0;
            foreach (KeyValuePair<string, int> element in bankNotes)
            {
                sumMoneyInATM += element.Value * Convert.ToInt32(element.Key);
            }
            return sumMoneyInATM >= sumMoneyToGive;
        }

        public bool EnoughSpaceToAddBankNotes(Dictionary<string, int> bankNotesToAdd)
        {
            int quantityOfBankNotesToAdd = 0;
            foreach (KeyValuePair<string, int> element in bankNotes)
            {
                quantityOfBankNotesToAdd += element.Value;
            }
            return quantityOfBankNotesToAdd + currentQuantityOfBankNotes <= maxQuantityofBankNotes;

        }
    }
}
