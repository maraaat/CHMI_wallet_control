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
    public partial class PlanningForm : Form
    {
        public static Plans PlanList = new Plans();

        List<Goal> Goals = PlanList.goals;

        



        public PlanningForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();



            foreach (Goal go in Goals) {
                BudgetCb1.Items.Add(go.name);


            }
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            TransViewForm frm1 = new TransViewForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BudgetAddForm frm1 = new BudgetAddForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void BudgetCb1_TextChanged(object sender, EventArgs e)
        {

            foreach (Goal go in Goals)
            {
                if(BudgetCb1.Text == go.name)
                {
                    LabelBal.Text = go.bal.ToString();
                    LabelPlan.Text = go.total.ToString();
                }

            }
        }

        private void DepBtn1_Click(object sender, EventArgs e)
        {
            foreach (Goal go in Goals)
            {
                if (BudgetCb1.Text == go.name)
                {
                    int tmp = Convert.ToInt32(DepTb1.Text);
                    if (tmp <= TransViewForm.wallet.GetBalance())
                    {
                        Transaction res = new Transaction("Цель", go.name, "Пополнение", " ", tmp);
                        TransViewForm.wallet.AddTransaction(res);

                        TransViewForm.wallet.DownBalance(tmp);
                        go.PlanDep(tmp);
                        BudgetCb1.Text = "";
                    }
                }

            }
        }

        private void WthdrwBtn1_Click(object sender, EventArgs e)
        {
            foreach (Goal go in Goals)
            {
                if (BudgetCb1.Text == go.name)
                {
                    int tmp = Convert.ToInt32(WthdrwTb1.Text);

                    Transaction res = new Transaction("Цель", go.name, "Вывод", " ", tmp);
                    TransViewForm.wallet.AddTransaction(res);

                    
                    if (tmp <= go.bal){
                        TransViewForm.wallet.UpBalance(tmp);
                        go.PlanWithd(tmp);
                        BudgetCb1.Text = ""; }
                }

            }
        }


    }
}
