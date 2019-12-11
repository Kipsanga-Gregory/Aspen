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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuFlatButtonMilkProc_Click(object sender, EventArgs e)
        {

            panelSlide2.Height = bunifuFlatButtonMilkProc.Height;
            panelSlide2.Top = bunifuFlatButtonMilkProc.Top;

            bunifuTransition1.HideSync(storageUC1);
            bunifuTransition1.HideSync(packingUC1);
            bunifuTransition1.HideSync(defaultUC1);
            bunifuTransition1.ShowSync(milkProcessingUC1);

        }

        private void bunifuFlatButtonPacking_Click(object sender, EventArgs e)
        {
           

            panelSlide2.Height = bunifuFlatButtonPacking.Height;
            panelSlide2.Top = bunifuFlatButtonPacking.Top;

            bunifuTransition1.HideSync(milkProcessingUC1);
            bunifuTransition1.HideSync(storageUC1);
            bunifuTransition1.HideSync(defaultUC1);
            bunifuTransition1.ShowSync(packingUC1);
        }

        private void bunifuFlatButtonStorage_Click(object sender, EventArgs e)
        {
           

            panelSlide2.Height = bunifuFlatButtonStorage.Height;
            panelSlide2.Top = bunifuFlatButtonStorage.Top;

            bunifuTransition1.HideSync(packingUC1);
            bunifuTransition1.HideSync(milkProcessingUC1);
            bunifuTransition1.HideSync(defaultUC1);
            bunifuTransition1.ShowSync(storageUC1);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogoutStaff_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
