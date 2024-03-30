﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CHMI2
{
    public class Wallet
    {
        public int Balance = 0;

        public List<Transaction> transactions = new List<Transaction>();

        public Wallet()
        {
        }


       

        public void SetBalance(int balance)
        {
            Balance = balance;
        }

        public int GetBalance()
        {
            foreach (Transaction trans in transactions) {
                if (trans.type == "Доход")
                {
                    Balance += trans.value;
                }
                else Balance -= trans.value;

            }
            return Balance;
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
            //Transaction trans = new(Type, Name, Category, Date, Value);
            transactions.Add(trans);
        }


    }


}
