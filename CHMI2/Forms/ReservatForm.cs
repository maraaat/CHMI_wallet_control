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
    public partial class ReservatForm : Form
    {
        public ReservatForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            ResBal.Text = TransViewForm.wallet.GetReservedBalance().ToString();
            ResProc.Text = TransViewForm.wallet.GetReservedProcent().ToString();
        }

        private void BackBtn2_Click(object sender, EventArgs e)
        {
            TransViewForm frm1 = new TransViewForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void ReservatForm_Load(object sender, EventArgs e)
        {

        }

        private void ProcBtn1_Click(object sender, EventArgs e)
        {
            int proc = Convert.ToInt32(ProcTb1.Text);
            if (proc <= 100)
            {
                TransViewForm.wallet.SetReservedProcent(proc);
                ProcTb1.Clear();
                ResProc.Text = TransViewForm.wallet.GetReservedProcent().ToString();
            }
        }

        private void WthdrBtn2_Click(object sender, EventArgs e)
        {
            int tmp = TransViewForm.wallet.GetBalance();
            int tmpres = TransViewForm.wallet.GetReservedBalance();
            int withd_value = Convert.ToInt32(WithdrawTb1.Text);
            if (withd_value <= tmpres)
            {
                TransViewForm.wallet.SetBalance(tmp + withd_value);
                TransViewForm.wallet.SetReservedBalance(tmpres - withd_value);

                Transaction res = new Transaction("Копилка", "", "Вывод", " ", withd_value);
                TransViewForm.wallet.AddTransaction(res);


                WithdrawTb1.Clear();
                ResBal.Text = TransViewForm.wallet.GetReservedBalance().ToString();
            }
        }
    }
}
