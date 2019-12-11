namespace Aspen.UserControls
{
    partial class InventoryUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryUC));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.PanelSlide = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanelSlide = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButtonProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonMaterials = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonIngredients = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.default3UC1 = new Aspen.UserControls.Default3UC();
            this.finishedProductsUC1 = new Aspen.UserControls.FinishedProductsUC();
            this.materialsUC1 = new Aspen.UserControls.MaterialsUC();
            this.ingredientsUC1 = new Aspen.UserControls.IngredientsUC();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelSlide.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSlide
            // 
            this.PanelSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSlide.BackgroundImage")));
            this.PanelSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelSlide.Controls.Add(this.bunifuGradientPanelSlide);
            this.PanelSlide.Controls.Add(this.bunifuFlatButtonProducts);
            this.PanelSlide.Controls.Add(this.bunifuFlatButtonMaterials);
            this.PanelSlide.Controls.Add(this.bunifuFlatButtonIngredients);
            this.bunifuTransition2.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlide.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PanelSlide.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PanelSlide.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PanelSlide.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PanelSlide.Location = new System.Drawing.Point(0, 0);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Quality = 10;
            this.PanelSlide.Size = new System.Drawing.Size(186, 568);
            this.PanelSlide.TabIndex = 0;
            // 
            // bunifuGradientPanelSlide
            // 
            this.bunifuGradientPanelSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelSlide.BackgroundImage")));
            this.bunifuGradientPanelSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition2.SetDecoration(this.bunifuGradientPanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanelSlide.GradientBottomLeft = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanelSlide.GradientBottomRight = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanelSlide.GradientTopLeft = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanelSlide.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanelSlide.Location = new System.Drawing.Point(170, 158);
            this.bunifuGradientPanelSlide.Name = "bunifuGradientPanelSlide";
            this.bunifuGradientPanelSlide.Quality = 10;
            this.bunifuGradientPanelSlide.Size = new System.Drawing.Size(7, 60);
            this.bunifuGradientPanelSlide.TabIndex = 4;
            // 
            // bunifuFlatButtonProducts
            // 
            this.bunifuFlatButtonProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonProducts.BorderRadius = 0;
            this.bunifuFlatButtonProducts.ButtonText = "Products";
            this.bunifuFlatButtonProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButtonProducts, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButtonProducts, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonProducts.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonProducts.Iconimage = null;
            this.bunifuFlatButtonProducts.Iconimage_right = null;
            this.bunifuFlatButtonProducts.Iconimage_right_Selected = null;
            this.bunifuFlatButtonProducts.Iconimage_Selected = null;
            this.bunifuFlatButtonProducts.IconMarginLeft = 0;
            this.bunifuFlatButtonProducts.IconMarginRight = 0;
            this.bunifuFlatButtonProducts.IconRightVisible = true;
            this.bunifuFlatButtonProducts.IconRightZoom = 0D;
            this.bunifuFlatButtonProducts.IconVisible = true;
            this.bunifuFlatButtonProducts.IconZoom = 90D;
            this.bunifuFlatButtonProducts.IsTab = false;
            this.bunifuFlatButtonProducts.Location = new System.Drawing.Point(12, 158);
            this.bunifuFlatButtonProducts.Name = "bunifuFlatButtonProducts";
            this.bunifuFlatButtonProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonProducts.OnHoverTextColor = System.Drawing.Color.Magenta;
            this.bunifuFlatButtonProducts.selected = false;
            this.bunifuFlatButtonProducts.Size = new System.Drawing.Size(153, 60);
            this.bunifuFlatButtonProducts.TabIndex = 1;
            this.bunifuFlatButtonProducts.Text = "Products";
            this.bunifuFlatButtonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButtonProducts.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonProducts.TextFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButtonProducts.Click += new System.EventHandler(this.bunifuFlatButtonProducts_Click);
            // 
            // bunifuFlatButtonMaterials
            // 
            this.bunifuFlatButtonMaterials.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonMaterials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonMaterials.BorderRadius = 0;
            this.bunifuFlatButtonMaterials.ButtonText = "Materials";
            this.bunifuFlatButtonMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButtonMaterials, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButtonMaterials, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonMaterials.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonMaterials.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonMaterials.Iconimage = null;
            this.bunifuFlatButtonMaterials.Iconimage_right = null;
            this.bunifuFlatButtonMaterials.Iconimage_right_Selected = null;
            this.bunifuFlatButtonMaterials.Iconimage_Selected = null;
            this.bunifuFlatButtonMaterials.IconMarginLeft = 0;
            this.bunifuFlatButtonMaterials.IconMarginRight = 0;
            this.bunifuFlatButtonMaterials.IconRightVisible = true;
            this.bunifuFlatButtonMaterials.IconRightZoom = 0D;
            this.bunifuFlatButtonMaterials.IconVisible = true;
            this.bunifuFlatButtonMaterials.IconZoom = 90D;
            this.bunifuFlatButtonMaterials.IsTab = false;
            this.bunifuFlatButtonMaterials.Location = new System.Drawing.Point(12, 270);
            this.bunifuFlatButtonMaterials.Name = "bunifuFlatButtonMaterials";
            this.bunifuFlatButtonMaterials.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonMaterials.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonMaterials.OnHoverTextColor = System.Drawing.Color.Magenta;
            this.bunifuFlatButtonMaterials.selected = false;
            this.bunifuFlatButtonMaterials.Size = new System.Drawing.Size(153, 61);
            this.bunifuFlatButtonMaterials.TabIndex = 2;
            this.bunifuFlatButtonMaterials.Text = "Materials";
            this.bunifuFlatButtonMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButtonMaterials.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonMaterials.TextFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButtonMaterials.Click += new System.EventHandler(this.bunifuFlatButtonMaterials_Click);
            // 
            // bunifuFlatButtonIngredients
            // 
            this.bunifuFlatButtonIngredients.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonIngredients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonIngredients.BorderRadius = 0;
            this.bunifuFlatButtonIngredients.ButtonText = "Ingredients";
            this.bunifuFlatButtonIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButtonIngredients, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButtonIngredients, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonIngredients.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonIngredients.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonIngredients.Iconimage = null;
            this.bunifuFlatButtonIngredients.Iconimage_right = null;
            this.bunifuFlatButtonIngredients.Iconimage_right_Selected = null;
            this.bunifuFlatButtonIngredients.Iconimage_Selected = null;
            this.bunifuFlatButtonIngredients.IconMarginLeft = 0;
            this.bunifuFlatButtonIngredients.IconMarginRight = 0;
            this.bunifuFlatButtonIngredients.IconRightVisible = true;
            this.bunifuFlatButtonIngredients.IconRightZoom = 0D;
            this.bunifuFlatButtonIngredients.IconVisible = true;
            this.bunifuFlatButtonIngredients.IconZoom = 90D;
            this.bunifuFlatButtonIngredients.IsTab = false;
            this.bunifuFlatButtonIngredients.Location = new System.Drawing.Point(12, 379);
            this.bunifuFlatButtonIngredients.Name = "bunifuFlatButtonIngredients";
            this.bunifuFlatButtonIngredients.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonIngredients.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButtonIngredients.OnHoverTextColor = System.Drawing.Color.Magenta;
            this.bunifuFlatButtonIngredients.selected = false;
            this.bunifuFlatButtonIngredients.Size = new System.Drawing.Size(153, 60);
            this.bunifuFlatButtonIngredients.TabIndex = 3;
            this.bunifuFlatButtonIngredients.Text = "Ingredients";
            this.bunifuFlatButtonIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButtonIngredients.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonIngredients.TextFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButtonIngredients.Click += new System.EventHandler(this.bunifuFlatButtonIngredients_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuTransition2.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(186, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(888, 77);
            this.bunifuGradientPanel2.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(315, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(238, 33);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "CURRENT STANDS";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.default3UC1);
            this.bunifuGradientPanel3.Controls.Add(this.finishedProductsUC1);
            this.bunifuGradientPanel3.Controls.Add(this.materialsUC1);
            this.bunifuGradientPanel3.Controls.Add(this.ingredientsUC1);
            this.bunifuTransition2.SetDecoration(this.bunifuGradientPanel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(186, 77);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(888, 491);
            this.bunifuGradientPanel3.TabIndex = 0;
            // 
            // default3UC1
            // 
            this.bunifuTransition1.SetDecoration(this.default3UC1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.default3UC1, BunifuAnimatorNS.DecorationType.None);
            this.default3UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.default3UC1.Location = new System.Drawing.Point(0, 0);
            this.default3UC1.Name = "default3UC1";
            this.default3UC1.Size = new System.Drawing.Size(888, 491);
            this.default3UC1.TabIndex = 3;
            // 
            // finishedProductsUC1
            // 
            this.finishedProductsUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuTransition1.SetDecoration(this.finishedProductsUC1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.finishedProductsUC1, BunifuAnimatorNS.DecorationType.None);
            this.finishedProductsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishedProductsUC1.Location = new System.Drawing.Point(0, 0);
            this.finishedProductsUC1.Name = "finishedProductsUC1";
            this.finishedProductsUC1.Size = new System.Drawing.Size(888, 491);
            this.finishedProductsUC1.TabIndex = 2;
            // 
            // materialsUC1
            // 
            this.materialsUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuTransition1.SetDecoration(this.materialsUC1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.materialsUC1, BunifuAnimatorNS.DecorationType.None);
            this.materialsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsUC1.Location = new System.Drawing.Point(0, 0);
            this.materialsUC1.Name = "materialsUC1";
            this.materialsUC1.Size = new System.Drawing.Size(888, 491);
            this.materialsUC1.TabIndex = 1;
            // 
            // ingredientsUC1
            // 
            this.ingredientsUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuTransition1.SetDecoration(this.ingredientsUC1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ingredientsUC1, BunifuAnimatorNS.DecorationType.None);
            this.ingredientsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsUC1.Location = new System.Drawing.Point(0, 0);
            this.ingredientsUC1.Name = "ingredientsUC1";
            this.ingredientsUC1.Size = new System.Drawing.Size(888, 491);
            this.ingredientsUC1.TabIndex = 0;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // InventoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.PanelSlide);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "InventoryUC";
            this.Size = new System.Drawing.Size(1074, 568);
            this.PanelSlide.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelSlide;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonProducts;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonMaterials;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonIngredients;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private FinishedProductsUC finishedProductsUC1;
        private MaterialsUC materialsUC1;
        private IngredientsUC ingredientsUC1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSlide;
        private Default3UC default3UC1;
    }
}
