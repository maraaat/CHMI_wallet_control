using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms.VisualStyles;

namespace CHMI2.WalletModels
{
    public class Wallet
    {
        public int Balance = 0;
        public int ReservedBalance = 0;
        public int ReservedProcent = 10;

        public List<Transaction> transactions = new List<Transaction>();

        public Wallet()
        {
        }




        public void SetBalance(int balance)
        {
            Balance = balance;
        }

        public void DownBalance(int balance)
        {
            Balance -= balance;
        }
        public void UpBalance(int balance)
        {
            Balance += balance;
        }

        public int GetBalance()
        {
            //int bal = 0;
            //foreach (Transaction trans in transactions) {
            //    if (trans.type == "Доход")
            //    {
            //        bal += trans.value;
            //    }
            //    else bal -= trans.value;

            //}
            //return bal;
            return Balance;
        }


        public void SetReservedProcent(int proc)
        {
            ReservedProcent = proc;
        }

        public int GetReservedBalance()
        {
            return ReservedBalance;
        }
        public void SetReservedBalance(int val)
        {
            ReservedBalance = val;
        }

        public int GetReservedProcent()
        {
            return ReservedProcent;
        }
        public int GetCount()
        {
            return transactions.Count;
        }

        public List<Transaction> GetList()
        {
            return transactions;
        }


        public void AddTransaction(Transaction trans)
        {
            if (trans.type == "Доход")
            {
                int tmp = trans.value;
                ReservedBalance += tmp / 100 * ReservedProcent;

                trans.value -= tmp / 100 * ReservedProcent;
            }

            transactions.Add(trans);

            if (trans.type == "Доход")
            {
                Balance += trans.value;
            }
            else if (trans.type == "Расход")
                Balance -= trans.value;

        }



    }


}
