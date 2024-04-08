using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHMI2.WalletModels
{
    public class Transaction
    {
        public string type;
        public string name;
        public string category;
        public string date;
        public int value;

        public Transaction()
        {

        }
        public Transaction(string Type, string Name, string Category, string Date, int Value)
        {
            type = Type;
            name = Name;
            category = Category;
            date = Date;
            value = Value;
        }

        ~Transaction() { }
    }
}
