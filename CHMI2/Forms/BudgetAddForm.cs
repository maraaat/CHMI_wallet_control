using CHMI2.BudgetPlanning;
using CHMI2.WalletModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHMI2.Forms
{
    public partial class BudgetAddForm : Form
    {
        public BudgetAddForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void BackBtn2_Click(object sender, EventArgs e)
        {
            PlanningForm frm1 = new PlanningForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            Goal tmp = new Goal(NameTb1.Text, Convert.ToInt32(ValTb1.Text), Convert.ToInt32(StartTb1.Text));
            if (tmp.start <= TransViewForm.wallet.GetBalance())
            {
                PlanningForm.PlanList.AddGoal(tmp);
                Transaction res = new Transaction("Цель", NameTb1.Text,"Пополнение", " ", tmp.start);
                TransViewForm.wallet.AddTransaction(res);


                NameTb1.Clear();
                ValTb1.Clear();
                StartTb1.Clear();

                PlanningForm frm1 = new PlanningForm();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
                this.Close();
            }
        }
    }
}
