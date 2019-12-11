using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspen.UserControls
{
    public partial class InventoryUC : UserControl
    {
        public InventoryUC()
        {
            InitializeComponent();
        }

        private void bunifuFlatButtonProducts_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(ingredientsUC1);
            bunifuTransition1.HideSync(default3UC1);
            bunifuTransition2.HideSync(materialsUC1);
            bunifuTransition1.ShowSync(finishedProductsUC1);

            bunifuGradientPanelSlide.Height = bunifuFlatButtonProducts.Height;
            bunifuGradientPanelSlide.Top = bunifuFlatButtonProducts.Top;

          
        }

        private void bunifuFlatButtonMaterials_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(ingredientsUC1);
            bunifuTransition1.HideSync(default3UC1);
            bunifuTransition2.HideSync(finishedProductsUC1);
            bunifuTransition1.ShowSync(materialsUC1);

            bunifuGradientPanelSlide.Height = bunifuFlatButtonMaterials.Height;
            bunifuGradientPanelSlide.Top = bunifuFlatButtonMaterials.Top;

           
        }

        private void bunifuFlatButtonIngredients_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(materialsUC1);
            bunifuTransition1.HideSync(default3UC1);
            bunifuTransition2.HideSync(finishedProductsUC1);
            bunifuTransition1.ShowSync(ingredientsUC1);

            bunifuGradientPanelSlide.Height = bunifuFlatButtonIngredients.Height;
            bunifuGradientPanelSlide.Top = bunifuFlatButtonIngredients.Top;

           
        }
    }
}
