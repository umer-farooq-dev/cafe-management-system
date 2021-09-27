namespace CafeManagementSystem.UserControles
{
    partial class UC_Items
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.Btn_Add = new Telerik.WinControls.UI.RadButton();
            this.Txt_Price = new Telerik.WinControls.UI.RadTextBox();
            this.Txt_ItemName = new Telerik.WinControls.UI.RadTextBox();
            this.Txt_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.Btn_Add);
            this.radPanel1.Controls.Add(this.Txt_Price);
            this.radPanel1.Controls.Add(this.Txt_ItemName);
            this.radPanel1.Controls.Add(this.Txt_category);
            this.radPanel1.Controls.Add(this.radLabel4);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(781, 514);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel1_Paint);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(328, 370);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(122, 38);
            this.Btn_Add.TabIndex = 7;
            this.Btn_Add.Text = "ADD Item";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Txt_Price
            // 
            this.Txt_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.Location = new System.Drawing.Point(210, 317);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Size = new System.Drawing.Size(323, 27);
            this.Txt_Price.TabIndex = 6;
            this.Txt_Price.TextChanged += new System.EventHandler(this.Txt_Price_TextChanged);
            // 
            // Txt_ItemName
            // 
            this.Txt_ItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ItemName.Location = new System.Drawing.Point(210, 239);
            this.Txt_ItemName.Name = "Txt_ItemName";
            this.Txt_ItemName.Size = new System.Drawing.Size(323, 27);
            this.Txt_ItemName.TabIndex = 5;
            this.Txt_ItemName.TextChanged += new System.EventHandler(this.Txt_ItemName_TextChanged);
            // 
            // Txt_category
            // 
            this.Txt_category.BackColor = System.Drawing.Color.Transparent;
            this.Txt_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Txt_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_category.FocusedState.Parent = this.Txt_category;
            this.Txt_category.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Txt_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Txt_category.HoverState.Parent = this.Txt_category;
            this.Txt_category.ItemHeight = 30;
            this.Txt_category.Items.AddRange(new object[] {
            "Cold Drink",
            "Burger",
            "Nashta",
            "Biscuit",
            "Tea",
            "Ice-Cream"});
            this.Txt_category.ItemsAppearance.Parent = this.Txt_category;
            this.Txt_category.Location = new System.Drawing.Point(210, 150);
            this.Txt_category.Name = "Txt_category";
            this.Txt_category.ShadowDecoration.Parent = this.Txt_category;
            this.Txt_category.Size = new System.Drawing.Size(323, 36);
            this.Txt_category.TabIndex = 4;
            this.Txt_category.SelectedIndexChanged += new System.EventHandler(this.Txt_category_SelectedIndexChanged);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(210, 278);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(55, 31);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Price";
            this.radLabel4.Click += new System.EventHandler(this.radLabel4_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(210, 197);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(116, 31);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Item Name";
            this.radLabel3.Click += new System.EventHandler(this.radLabel3_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(210, 113);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 31);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Category";
            this.radLabel2.Click += new System.EventHandler(this.radLabel2_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(328, 68);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(165, 34);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Add New Item";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(781, 28);
            this.radPanel2.TabIndex = 0;
            this.radPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel2_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radPanel1);
            this.Name = "UC_Items";
            this.Size = new System.Drawing.Size(781, 514);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton Btn_Add;
        private Telerik.WinControls.UI.RadTextBox Txt_Price;
        private Telerik.WinControls.UI.RadTextBox Txt_ItemName;
        private Guna.UI2.WinForms.Guna2ComboBox Txt_category;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
