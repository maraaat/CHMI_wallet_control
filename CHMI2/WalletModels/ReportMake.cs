using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHMI2.WalletModels
{
    public class ReportMake
    {
        public int costs = 0;
        public int products = 0;
        public int shoes = 0;
        public int healh = 0;
        public int transport = 0;
        public int activities = 0;
        public int car = 0;
        public int other = 0;
        public int profit = 0;

        public ReportMake(Wallet wallet)
        {
            foreach (Transaction trans in wallet.transactions)
            {
                //if( trans.type == "Копилка") break;

                if (trans.category == "Продукты питания")
                {
                    products += trans.value;
                }
                else if (trans.category == "Одежда и обувь")
                {
                    shoes += trans.value;
                }
                else if (trans.category == "Здоровье")
                {
                    healh += trans.value;
                }
                else if (trans.category == "Транспорт")
                {
                    transport += trans.value;
                }
                else if (trans.category == "Равзлечения")
                {
                    activities += trans.value;
                }
                else if (trans.category == "Автоуслуги")
                {
                    car += trans.value;
                }
                else if (trans.category == "Другое")
                {
                    other += trans.value;
                }
                else
                {
                    profit += trans.value;
                }

            }
            costs += products + shoes + healh + transport + activities + car + other;
        }


    }
}
