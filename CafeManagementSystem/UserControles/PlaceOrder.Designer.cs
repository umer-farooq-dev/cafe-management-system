namespace CafeManagementSystem.UserControles
{
    partial class Uc_PlaceOrder1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_QuantityUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.Txt_Total = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_AddCart = new Guna.UI2.WinForms.Guna2Button();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Print = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_TotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_QuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place Order";
            // 
            // txt_ComboBox
            // 
            this.txt_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.txt_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ComboBox.FocusedState.Parent = this.txt_ComboBox;
            this.txt_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.txt_ComboBox.HoverState.Parent = this.txt_ComboBox;
            this.txt_ComboBox.ItemHeight = 30;
            this.txt_ComboBox.Items.AddRange(new object[] {
            "Cold Drink",
            "Smosy",
            "Chana Chart",
            "Chips",
            "Tea",
            "Ice-Cream"});
            this.txt_ComboBox.ItemsAppearance.Parent = this.txt_ComboBox;
            this.txt_ComboBox.Location = new System.Drawing.Point(44, 82);
            this.txt_ComboBox.Name = "txt_ComboBox";
            this.txt_ComboBox.ShadowDecoration.Parent = this.txt_ComboBox;
            this.txt_ComboBox.Size = new System.Drawing.Size(137, 36);
            this.txt_ComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_ComboBox.TabIndex = 2;
            this.txt_ComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Guna2_Combox_SelectedIndexChanged);
            // 
            // Txt_search
            // 
            this.Txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_search.DefaultText = "";
            this.Txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_search.DisabledState.Parent = this.Txt_search;
            this.Txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_search.FocusedState.Parent = this.Txt_search;
            this.Txt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_search.ForeColor = System.Drawing.Color.Black;
            this.Txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_search.HoverState.Parent = this.Txt_search;
            this.Txt_search.Location = new System.Drawing.Point(44, 137);
            this.Txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_search.Name = "Txt_search";
            this.Txt_search.PasswordChar = '\0';
            this.Txt_search.PlaceholderText = "Search";
            this.Txt_search.SelectedText = "";
            this.Txt_search.ShadowDecoration.Parent = this.Txt_search;
            this.Txt_search.Size = new System.Drawing.Size(137, 36);
            this.Txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Txt_search.TabIndex = 3;
            this.Txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_search.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(44, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 224);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(272, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(539, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(272, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(539, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ItemName.DefaultText = "";
            this.txt_ItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ItemName.DisabledState.Parent = this.txt_ItemName;
            this.txt_ItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ItemName.FocusedState.Parent = this.txt_ItemName;
            this.txt_ItemName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ItemName.HoverState.Parent = this.txt_ItemName;
            this.txt_ItemName.Location = new System.Drawing.Point(277, 93);
            this.txt_ItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.PasswordChar = '\0';
            this.txt_ItemName.PlaceholderText = "";
            this.txt_ItemName.SelectedText = "";
            this.txt_ItemName.ShadowDecoration.Parent = this.txt_ItemName;
            this.txt_ItemName.Size = new System.Drawing.Size(200, 36);
            this.txt_ItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_ItemName.TabIndex = 9;
            this.txt_ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ItemName.TextChanged += new System.EventHandler(this.txt_ItemName_TextChanged);
            // 
            // Txt_Price
            // 
            this.Txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Price.DefaultText = "";
            this.Txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Price.DisabledState.Parent = this.Txt_Price;
            this.Txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Price.FocusedState.Parent = this.Txt_Price;
            this.Txt_Price.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Price.HoverState.Parent = this.Txt_Price;
            this.Txt_Price.Location = new System.Drawing.Point(544, 93);
            this.Txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.PasswordChar = '\0';
            this.Txt_Price.PlaceholderText = "";
            this.Txt_Price.SelectedText = "";
            this.Txt_Price.ShadowDecoration.Parent = this.Txt_Price;
            this.Txt_Price.Size = new System.Drawing.Size(200, 36);
            this.Txt_Price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Txt_Price.TabIndex = 10;
            this.Txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_QuantityUpDown
            // 
            this.Txt_QuantityUpDown.BackColor = System.Drawing.Color.Transparent;
            this.Txt_QuantityUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_QuantityUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_QuantityUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_QuantityUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_QuantityUpDown.DisabledState.Parent = this.Txt_QuantityUpDown;
            this.Txt_QuantityUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Txt_QuantityUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.Txt_QuantityUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_QuantityUpDown.FocusedState.Parent = this.Txt_QuantityUpDown;
            this.Txt_QuantityUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_QuantityUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Txt_QuantityUpDown.Location = new System.Drawing.Point(277, 164);
            this.Txt_QuantityUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_QuantityUpDown.Name = "Txt_QuantityUpDown";
            this.Txt_QuantityUpDown.ShadowDecoration.Parent = this.Txt_QuantityUpDown;
            this.Txt_QuantityUpDown.Size = new System.Drawing.Size(200, 36);
            this.Txt_QuantityUpDown.TabIndex = 11;
            this.Txt_QuantityUpDown.ValueChanged += new System.EventHandler(this.Txt_QuantityUpDown_ValueChanged);
            // 
            // Txt_Total
            // 
            this.Txt_Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Total.DefaultText = "";
            this.Txt_Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Total.DisabledState.Parent = this.Txt_Total;
            this.Txt_Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Total.FocusedState.Parent = this.Txt_Total;
            this.Txt_Total.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Total.HoverState.Parent = this.Txt_Total;
            this.Txt_Total.Location = new System.Drawing.Point(544, 164);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.PasswordChar = '\0';
            this.Txt_Total.PlaceholderText = "";
            this.Txt_Total.SelectedText = "";
            this.Txt_Total.ShadowDecoration.Parent = this.Txt_Total;
            this.Txt_Total.Size = new System.Drawing.Size(200, 36);
            this.Txt_Total.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Txt_Total.TabIndex = 12;
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AddCart
            // 
            this.btn_AddCart.BorderRadius = 21;
            this.btn_AddCart.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_AddCart.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_AddCart.CheckedState.Parent = this.btn_AddCart;
            this.btn_AddCart.CustomImages.Parent = this.btn_AddCart;
            this.btn_AddCart.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCart.ForeColor = System.Drawing.Color.White;
            this.btn_AddCart.HoverState.Parent = this.btn_AddCart;
            this.btn_AddCart.Location = new System.Drawing.Point(577, 209);
            this.btn_AddCart.Name = "btn_AddCart";
            this.btn_AddCart.ShadowDecoration.Parent = this.btn_AddCart;
            this.btn_AddCart.Size = new System.Drawing.Size(146, 45);
            this.btn_AddCart.TabIndex = 13;
            this.btn_AddCart.Text = "Add to Cart";
            this.btn_AddCart.Click += new System.EventHandler(this.btn_AddCart_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(781, 32);
            this.radPanel1.TabIndex = 14;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView2.ColumnHeadersHeight = 21;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView2.EnableHeadersVisualStyles = false;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(277, 260);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView2.Size = new System.Drawing.Size(467, 131);
            this.guna2DataGridView2.TabIndex = 16;
            this.guna2DataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BorderRadius = 21;
            this.btn_Remove.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Remove.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Remove.CheckedState.Parent = this.btn_Remove;
            this.btn_Remove.CustomImages.Parent = this.btn_Remove;
            this.btn_Remove.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.HoverState.Parent = this.btn_Remove;
            this.btn_Remove.Location = new System.Drawing.Point(277, 416);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.ShadowDecoration.Parent = this.btn_Remove;
            this.btn_Remove.Size = new System.Drawing.Size(112, 45);
            this.btn_Remove.TabIndex = 17;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BorderRadius = 21;
            this.btn_Print.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Print.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Print.CheckedState.Parent = this.btn_Print;
            this.btn_Print.CustomImages.Parent = this.btn_Print;
            this.btn_Print.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.HoverState.Parent = this.btn_Print;
            this.btn_Print.Location = new System.Drawing.Point(619, 416);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.ShadowDecoration.Parent = this.btn_Print;
            this.btn_Print.Size = new System.Drawing.Size(125, 45);
            this.btn_Print.TabIndex = 18;
            this.btn_Print.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(449, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Grand Total";
            // 
            // Lbl_TotalAmount
            // 
            this.Lbl_TotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Lbl_TotalAmount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TotalAmount.Location = new System.Drawing.Point(432, 429);
            this.Lbl_TotalAmount.Name = "Lbl_TotalAmount";
            this.Lbl_TotalAmount.Size = new System.Drawing.Size(137, 53);
            this.Lbl_TotalAmount.TabIndex = 20;
            this.Lbl_TotalAmount.Text = "Rs. 00";
            this.Lbl_TotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Uc_PlaceOrder1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lbl_TotalAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.btn_AddCart);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Txt_QuantityUpDown);
            this.Controls.Add(this.Txt_Price);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Txt_search);
            this.Controls.Add(this.txt_ComboBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_PlaceOrder1";
            this.Size = new System.Drawing.Size(781, 514);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_QuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_search;
        private Guna.UI2.WinForms.Guna2ComboBox txt_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_TotalAmount;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btn_Print;
        private Guna.UI2.WinForms.Guna2Button btn_Remove;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_AddCart;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Total;
        private Guna.UI2.WinForms.Guna2NumericUpDown Txt_QuantityUpDown;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Price;
        private Guna.UI2.WinForms.Guna2TextBox txt_ItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
