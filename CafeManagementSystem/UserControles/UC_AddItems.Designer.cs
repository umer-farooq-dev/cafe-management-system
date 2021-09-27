namespace CafeManagementSystem.UserControles
{
    partial class UC_AddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddItems));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_itemName = new Telerik.WinControls.UI.RadTextBox();
            this.txt_price = new Telerik.WinControls.UI.RadTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addItem = new Telerik.WinControls.UI.RadButton();
            this.txt_combox = new Guna.UI.WinForms.GunaComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.txt_itemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(278, 288);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(302, 31);
            this.txt_itemName.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(278, 359);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(302, 31);
            this.txt_price.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.Location = new System.Drawing.Point(368, 408);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(115, 33);
            this.btn_addItem.TabIndex = 9;
            this.btn_addItem.Text = "Add Item";
            // 
            // txt_combox
            // 
            this.txt_combox.BackColor = System.Drawing.Color.Transparent;
            this.txt_combox.BaseColor = System.Drawing.Color.White;
            this.txt_combox.BorderColor = System.Drawing.Color.Silver;
            this.txt_combox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_combox.FocusedColor = System.Drawing.Color.Empty;
            this.txt_combox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_combox.ForeColor = System.Drawing.Color.Black;
            this.txt_combox.FormattingEnabled = true;
            this.txt_combox.Items.AddRange(new object[] {
            "Cold Drink",
            "Tea",
            "Coffee",
            "Burger",
            "Piza",
            "Chips"});
            this.txt_combox.Location = new System.Drawing.Point(278, 206);
            this.txt_combox.Name = "txt_combox";
            this.txt_combox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_combox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txt_combox.Size = new System.Drawing.Size(302, 34);
            this.txt_combox.TabIndex = 10;
            // 
            // UC_AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_combox);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddItems";
            this.Size = new System.Drawing.Size(781, 514);
            ((System.ComponentModel.ISupportInitialize)(this.txt_itemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txt_itemName;
        private Telerik.WinControls.UI.RadTextBox txt_price;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton btn_addItem;
        private Guna.UI.WinForms.GunaComboBox txt_combox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}
