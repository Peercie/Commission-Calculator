//35244119, van der Merwe, P.R
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commission_Calculator
{
    public partial class frmMain : Form
    {
        int revenue = 0, commission=0, total=0;
     
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateCommission()
        {
            revenue = int.Parse(txtbxRevenue.Text);
            commission = int.Parse(txtbxCommission.Text);
            total = revenue * commission;
            lblOutput.Text = total.ToString("C");
           
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            CalculateCommission();

        }
    }
}
