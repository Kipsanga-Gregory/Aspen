using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuImageButtonScm_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(inventoryUC1);
            bunifuTransition1.HideSync(default2UC1);
            bunifuTransition2.ShowSync(smcUC1);
        }

        private void bunifuImageButtonInventory_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(smcUC1);
            bunifuTransition1.HideSync(default2UC1);
            bunifuTransition2.ShowSync(inventoryUC1);
        }

        private void default2UC1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
