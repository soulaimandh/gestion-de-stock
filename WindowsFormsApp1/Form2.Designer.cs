namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelnav = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.commandebtn = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.categoriebtn = new System.Windows.Forms.Button();
            this.produitbtn = new System.Windows.Forms.Button();
            this.clientbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.settings2 = new WindowsFormsApp1.settings();
            this.produit2 = new WindowsFormsApp1.produit();
            this.commande1 = new WindowsFormsApp1.commande();
            this.categorie2 = new WindowsFormsApp1.categorie();
            this.client2 = new WindowsFormsApp1.client();
            this.dashboard1 = new WindowsFormsApp1.dashboard();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand3 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand4 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panelnav);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.commandebtn);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.settingsbtn);
            this.panel1.Controls.Add(this.categoriebtn);
            this.panel1.Controls.Add(this.produitbtn);
            this.panel1.Controls.Add(this.clientbtn);
            this.panel1.Controls.Add(this.dashboardbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 679);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelnav
            // 
            this.panelnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelnav.Location = new System.Drawing.Point(1, 308);
            this.panelnav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelnav.Name = "panelnav";
            this.panelnav.Size = new System.Drawing.Size(3, 100);
            this.panelnav.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.cmd;
            this.pictureBox5.Location = new System.Drawing.Point(18, 370);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // commandebtn
            // 
            this.commandebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandebtn.FlatAppearance.BorderSize = 0;
            this.commandebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commandebtn.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandebtn.ForeColor = System.Drawing.Color.White;
            this.commandebtn.Location = new System.Drawing.Point(0, 362);
            this.commandebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commandebtn.Name = "commandebtn";
            this.commandebtn.Size = new System.Drawing.Size(222, 46);
            this.commandebtn.TabIndex = 4;
            this.commandebtn.Text = "Commandes";
            this.commandebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.commandebtn.UseVisualStyleBackColor = true;
            this.commandebtn.Click += new System.EventHandler(this.commandebtn_Click);
            this.commandebtn.Leave += new System.EventHandler(this.commandebtn_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.settings;
            this.pictureBox7.Location = new System.Drawing.Point(18, 642);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.calendar;
            this.pictureBox6.Location = new System.Drawing.Point(18, 324);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Lrg_diagram;
            this.pictureBox4.Location = new System.Drawing.Point(18, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Conact;
            this.pictureBox3.Location = new System.Drawing.Point(18, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(18, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // settingsbtn
            // 
            this.settingsbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsbtn.FlatAppearance.BorderSize = 0;
            this.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbtn.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsbtn.ForeColor = System.Drawing.Color.White;
            this.settingsbtn.Location = new System.Drawing.Point(0, 633);
            this.settingsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(222, 46);
            this.settingsbtn.TabIndex = 1;
            this.settingsbtn.Text = "Settings";
            this.settingsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.settingsbtn.UseVisualStyleBackColor = true;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            this.settingsbtn.Leave += new System.EventHandler(this.settingsbtn_Leave);
            // 
            // categoriebtn
            // 
            this.categoriebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriebtn.FlatAppearance.BorderSize = 0;
            this.categoriebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriebtn.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriebtn.ForeColor = System.Drawing.Color.White;
            this.categoriebtn.Location = new System.Drawing.Point(0, 316);
            this.categoriebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriebtn.Name = "categoriebtn";
            this.categoriebtn.Size = new System.Drawing.Size(222, 46);
            this.categoriebtn.TabIndex = 1;
            this.categoriebtn.Text = "Catégories";
            this.categoriebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.categoriebtn.UseVisualStyleBackColor = true;
            this.categoriebtn.Click += new System.EventHandler(this.categoriebtn_Click);
            this.categoriebtn.Leave += new System.EventHandler(this.categoriebtn_Leave);
            // 
            // produitbtn
            // 
            this.produitbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.produitbtn.FlatAppearance.BorderSize = 0;
            this.produitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produitbtn.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitbtn.ForeColor = System.Drawing.Color.White;
            this.produitbtn.Location = new System.Drawing.Point(0, 270);
            this.produitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produitbtn.Name = "produitbtn";
            this.produitbtn.Size = new System.Drawing.Size(222, 46);
            this.produitbtn.TabIndex = 1;
            this.produitbtn.Text = "Produits";
            this.produitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.produitbtn.UseVisualStyleBackColor = true;
            this.produitbtn.Click += new System.EventHandler(this.produitbtn_Click);
            this.produitbtn.Leave += new System.EventHandler(this.produitbtn_Leave);
            // 
            // clientbtn
            // 
            this.clientbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientbtn.FlatAppearance.BorderSize = 0;
            this.clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientbtn.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientbtn.ForeColor = System.Drawing.Color.White;
            this.clientbtn.Location = new System.Drawing.Point(0, 224);
            this.clientbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientbtn.Name = "clientbtn";
            this.clientbtn.Size = new System.Drawing.Size(222, 46);
            this.clientbtn.TabIndex = 1;
            this.clientbtn.Text = "Clients";
            this.clientbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.clientbtn.UseVisualStyleBackColor = true;
            this.clientbtn.Click += new System.EventHandler(this.clientbtn_Click_1);
            this.clientbtn.Leave += new System.EventHandler(this.clientbtn_Leave);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardbtn.FlatAppearance.BorderSize = 0;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 178);
            this.dashboardbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(222, 46);
            this.dashboardbtn.TabIndex = 1;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = true;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            this.dashboardbtn.Leave += new System.EventHandler(this.dashboardbtn_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 178);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 115);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(222, 36);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(56, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 679);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.settings2);
            this.panel4.Controls.Add(this.produit2);
            this.panel4.Controls.Add(this.commande1);
            this.panel4.Controls.Add(this.categorie2);
            this.panel4.Controls.Add(this.client2);
            this.panel4.Controls.Add(this.dashboard1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(222, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(934, 679);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // settings2
            // 
            this.settings2.Location = new System.Drawing.Point(-3, 0);
            this.settings2.Name = "settings2";
            this.settings2.Size = new System.Drawing.Size(934, 679);
            this.settings2.TabIndex = 5;
            // 
            // produit2
            // 
            this.produit2.Location = new System.Drawing.Point(0, 0);
            this.produit2.Name = "produit2";
            this.produit2.Size = new System.Drawing.Size(934, 679);
            this.produit2.TabIndex = 4;
            // 
            // commande1
            // 
            this.commande1.Location = new System.Drawing.Point(0, 0);
            this.commande1.Margin = new System.Windows.Forms.Padding(6);
            this.commande1.Name = "commande1";
            this.commande1.Size = new System.Drawing.Size(934, 679);
            this.commande1.TabIndex = 3;
            // 
            // categorie2
            // 
            this.categorie2.Location = new System.Drawing.Point(0, 0);
            this.categorie2.Name = "categorie2";
            this.categorie2.Size = new System.Drawing.Size(934, 679);
            this.categorie2.TabIndex = 2;
            // 
            // client2
            // 
            this.client2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.client2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.client2.Location = new System.Drawing.Point(0, 0);
            this.client2.Name = "client2";
            this.client2.Size = new System.Drawing.Size(934, 679);
            this.client2.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(934, 679);
            this.dashboard1.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // mySqlCommand3
            // 
            this.mySqlCommand3.CacheAge = 0;
            this.mySqlCommand3.Connection = null;
            this.mySqlCommand3.EnableCaching = false;
            this.mySqlCommand3.Transaction = null;
            // 
            // mySqlCommand4
            // 
            this.mySqlCommand4.CacheAge = 0;
            this.mySqlCommand4.Connection = null;
            this.mySqlCommand4.EnableCaching = false;
            this.mySqlCommand4.Transaction = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1156, 679);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 193);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de stock";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button categoriebtn;
        private System.Windows.Forms.Button produitbtn;
        private System.Windows.Forms.Button clientbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private settings settings1;
        private produit produit1;
        private categorie categorie1;
        private client client1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button commandebtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand4;
        private dashboard dashboard1;
        private categorie categorie2;
        private client client2;
        private commande commande1;
        private produit produit2;
        private settings settings2;
        private System.Windows.Forms.Panel panelnav;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}