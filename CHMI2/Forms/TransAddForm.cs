using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHMI2.WalletModels;

namespace CHMI2.Forms
{


    public partial class TransAddForm : Form
    {
       
        public TransAddForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

     
        }

        private void BackBtn3_Click(object sender, EventArgs e)
        {
            TransViewForm frm1 = new TransViewForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
            
            if (cbTrType1.Text != "" && tbName1.Text != "" && cbCtgry1.Text != "" && dtp1.Text != "")
            {
                int Val = Convert.ToInt32(SumTb1.Text);
                Transaction trans = new Transaction(cbTrType1.Text, tbName1.Text, cbCtgry1.Text, dtp1.Text, Val);
                TransViewForm.wallet.AddTransaction(trans);

                if (trans.type == "Доход")
                {
                    Transaction res = new Transaction("Копилка", " ", "Пополнение", "", Val / 100 * TransViewForm.wallet.GetReservedProcent());
                    TransViewForm.wallet.AddTransaction(res);
                }

                cbCtgry1.SelectedIndex = -1;
                cbTrType1.SelectedIndex = -1;
                tbName1.Clear();
                dtp1.Value = DateTime.Today;
                SumTb1.Clear();

                TransViewForm frm1 = new TransViewForm();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
                this.Close();
            }

 
        }

        private void cbTrType1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void cbTrType1_DropDownClosed(object sender, EventArgs e)
        {

        }



        private void cbTrType1_DropDown(object sender, EventArgs e)
        {

        }

        private void cbTrType1_TextChanged(object sender, EventArgs e)
        {
            cbCtgry1.Items.Clear();
            if (cbTrType1.Text == "Доход")
            {
                //cbCtgry1.Visible = false;
                string[] prof = { "Стипендия", "Зарплата", "Пенсия", "Подарок", "Другое" };
                cbCtgry1.Items.AddRange(prof);


            }
            else
            {
                cbCtgry1.Visible = true;
                string[] cats = { "Продукты питания", "Одежда и обувь", "Здоровье", "Транспорт", "Равзлечения", "Автоуслуги", "Другое" };
                cbCtgry1.Items.AddRange(cats);
            }
        }
    }
}
