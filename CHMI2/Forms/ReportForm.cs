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
    public partial class ReportForm : Form
    {
        
        public ReportForm()
        {
            ReportMake ValuesToRep = new ReportMake(TransViewForm.wallet);
      
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            OutL1.Text = ValuesToRep.costs.ToString();
            ProdL1.Text = ValuesToRep.products.ToString();
            ClothesL1.Text = ValuesToRep.shoes.ToString();
            HealthL1.Text = ValuesToRep.healh.ToString();
            TranspL1.Text = ValuesToRep.transport.ToString();
            FunL1.Text = ValuesToRep.activities.ToString();
            CarL1.Text = ValuesToRep.car.ToString();
            OtherL1.Text = ValuesToRep.other.ToString();
            InputL1.Text = ValuesToRep.profit.ToString();

        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            TransViewForm frm1 = new TransViewForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void ClothesL1_Click(object sender, EventArgs e)
        {
          
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
