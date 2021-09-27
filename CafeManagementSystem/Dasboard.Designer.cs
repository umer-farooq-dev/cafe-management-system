namespace CafeManagementSystem
{
    partial class Dasboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dasboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Remove = new Telerik.WinControls.UI.RadButton();
            this.Btn_Update = new Telerik.WinControls.UI.RadButton();
            this.Btn_Add = new Telerik.WinControls.UI.RadButton();
            this.Btn_PlaceOrder = new Telerik.WinControls.UI.RadButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_RemovedItems1 = new CafeManagementSystem.UserControles.UC_RemovedItems();
            this.updateItems1 = new CafeManagementSystem.UserControles.UpdateItems();
            this.UC_placeOrder1 = new CafeManagementSystem.UserControles.Uc_PlaceOrder1();
            this.uC_Items1 = new CafeManagementSystem.UserControles.UC_Items();
            this.uC_Welcom1 = new CafeManagementSystem.UserControles.UC_Welcom();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_PlaceOrder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Btn_Remove);
            this.panel1.Controls.Add(this.Btn_Update);
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.Btn_PlaceOrder);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.linkLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(120, 485);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 19);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.Btn_Remove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Btn_Remove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove.Location = new System.Drawing.Point(47, 257);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(184, 39);
            this.Btn_Remove.TabIndex = 1;
            this.Btn_Remove.Text = "Remove Items";
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.Btn_Update, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(47, 191);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(184, 39);
            this.Btn_Update.TabIndex = 1;
            this.Btn_Update.Text = "Update Items";
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.Btn_Add, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Btn_Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(47, 127);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(184, 39);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Add Items";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_PlaceOrder
            // 
            this.Btn_PlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Btn_PlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.Btn_PlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Btn_PlaceOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PlaceOrder.Location = new System.Drawing.Point(47, 60);
            this.Btn_PlaceOrder.Name = "Btn_PlaceOrder";
            // 
            // 
            // 
            this.Btn_PlaceOrder.RootElement.BorderHighlightThickness = 0;
            this.Btn_PlaceOrder.RootElement.HighlightColor = System.Drawing.Color.White;
            this.Btn_PlaceOrder.RootElement.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Btn_PlaceOrder.Size = new System.Drawing.Size(184, 39);
            this.Btn_PlaceOrder.TabIndex = 0;
            this.Btn_PlaceOrder.Text = "Place Order";
            this.Btn_PlaceOrder.Click += new System.EventHandler(this.Btn_Order_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_RemovedItems1);
            this.panel2.Controls.Add(this.updateItems1);
            this.panel2.Controls.Add(this.UC_placeOrder1);
            this.panel2.Controls.Add(this.uC_Items1);
            this.panel2.Controls.Add(this.uC_Welcom1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(214, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.panel2;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uC_RemovedItems1
            // 
            this.uC_RemovedItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemovedItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemovedItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemovedItems1.Name = "uC_RemovedItems1";
            this.uC_RemovedItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemovedItems1.TabIndex = 4;
            this.uC_RemovedItems1.Load += new System.EventHandler(this.uC_RemovedItems1_Load);
            // 
            // updateItems1
            // 
            this.updateItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.updateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateItems1.Location = new System.Drawing.Point(0, 0);
            this.updateItems1.Name = "updateItems1";
            this.updateItems1.Size = new System.Drawing.Size(781, 514);
            this.updateItems1.TabIndex = 3;
            // 
            // UC_placeOrder1
            // 
            this.UC_placeOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.UC_placeOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UC_placeOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_placeOrder1.Location = new System.Drawing.Point(0, 0);
            this.UC_placeOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.UC_placeOrder1.Name = "UC_placeOrder1";
            this.UC_placeOrder1.Size = new System.Drawing.Size(781, 514);
            this.UC_placeOrder1.TabIndex = 2;
            // 
            // uC_Items1
            // 
            this.uC_Items1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Items1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Items1.Location = new System.Drawing.Point(-9, 0);
            this.uC_Items1.Name = "uC_Items1";
            this.uC_Items1.Size = new System.Drawing.Size(790, 511);
            this.uC_Items1.TabIndex = 1;
            this.uC_Items1.Load += new System.EventHandler(this.uC_Items1_Load);
            // 
            // uC_Welcom1
            // 
            this.uC_Welcom1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcom1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcom1.Location = new System.Drawing.Point(0, 0);
            this.uC_Welcom1.Name = "uC_Welcom1";
            this.uC_Welcom1.Size = new System.Drawing.Size(781, 514);
            this.uC_Welcom1.TabIndex = 0;
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dasboard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dasboard";
            this.Load += new System.EventHandler(this.Dasboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_PlaceOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadButton Btn_Remove;
        private Telerik.WinControls.UI.RadButton Btn_Update;
        private Telerik.WinControls.UI.RadButton Btn_Add;
        private Telerik.WinControls.UI.RadButton Btn_PlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private UserControles.UC_Welcom uC_Welcom1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UserControles.UC_Items uC_Items1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UserControles.Uc_PlaceOrder1 UC_placeOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UserControles.UpdateItems updateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UserControles.UC_RemovedItems uC_RemovedItems1;
    }
}
