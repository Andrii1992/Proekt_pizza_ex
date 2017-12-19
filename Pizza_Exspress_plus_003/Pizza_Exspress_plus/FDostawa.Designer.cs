namespace Pizza_Exspress_plus
{
    partial class FDostawa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDostawa));
            this.formaPlatnosciW = new System.Windows.Forms.Label();
            this.kartaRB = new System.Windows.Forms.RadioButton();
            this.gotowkaRB = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.uwagiW = new System.Windows.Forms.Label();
            this.adresNum2 = new System.Windows.Forms.TextBox();
            this.adresNum = new System.Windows.Forms.TextBox();
            this.adresW = new System.Windows.Forms.Label();
            this.numerTelW = new System.Windows.Forms.Label();
            this.statusW = new System.Windows.Forms.Label();
            this.nazwiskoW = new System.Windows.Forms.Label();
            this.imieW = new System.Windows.Forms.Label();
            this.UwagiBox = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.CheckBox();
            this.imieBox = new System.Windows.Forms.TextBox();
            this.nazwiskoBox = new System.Windows.Forms.TextBox();
            this.numerTelBox = new System.Windows.Forms.TextBox();
            this.adresBox = new System.Windows.Forms.TextBox();
            this.dodajKlienta = new System.Windows.Forms.Button();
            this.panelB = new System.Windows.Forms.Panel();
            this.PizzaW = new System.Windows.Forms.Label();
            this.panelG = new System.Windows.Forms.Panel();
            this.zamknijO = new System.Windows.Forms.Button();
            this.minimalizujO = new System.Windows.Forms.Button();
            this.powienkszPomniejszO = new System.Windows.Forms.Button();
            this.panelB.SuspendLayout();
            this.panelG.SuspendLayout();
            this.SuspendLayout();
            // 
            // formaPlatnosciW
            // 
            this.formaPlatnosciW.AutoSize = true;
            this.formaPlatnosciW.ForeColor = System.Drawing.Color.White;
            this.formaPlatnosciW.Location = new System.Drawing.Point(435, 356);
            this.formaPlatnosciW.Name = "formaPlatnosciW";
            this.formaPlatnosciW.Size = new System.Drawing.Size(83, 13);
            this.formaPlatnosciW.TabIndex = 45;
            this.formaPlatnosciW.Text = "Forma płatności";
            // 
            // kartaRB
            // 
            this.kartaRB.AutoSize = true;
            this.kartaRB.ForeColor = System.Drawing.Color.White;
            this.kartaRB.Location = new System.Drawing.Point(554, 376);
            this.kartaRB.Name = "kartaRB";
            this.kartaRB.Size = new System.Drawing.Size(50, 17);
            this.kartaRB.TabIndex = 44;
            this.kartaRB.TabStop = true;
            this.kartaRB.Text = "Karta";
            this.kartaRB.UseVisualStyleBackColor = true;
            this.kartaRB.CheckedChanged += new System.EventHandler(this.kartaZmien);
            // 
            // gotowkaRB
            // 
            this.gotowkaRB.AutoSize = true;
            this.gotowkaRB.ForeColor = System.Drawing.Color.White;
            this.gotowkaRB.Location = new System.Drawing.Point(554, 354);
            this.gotowkaRB.Name = "gotowkaRB";
            this.gotowkaRB.Size = new System.Drawing.Size(68, 17);
            this.gotowkaRB.TabIndex = 43;
            this.gotowkaRB.TabStop = true;
            this.gotowkaRB.Text = "Gotówka";
            this.gotowkaRB.UseVisualStyleBackColor = true;
            this.gotowkaRB.CheckedChanged += new System.EventHandler(this.gotowkaZmien);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(545, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "/";
            // 
            // uwagiW
            // 
            this.uwagiW.AutoSize = true;
            this.uwagiW.ForeColor = System.Drawing.Color.White;
            this.uwagiW.Location = new System.Drawing.Point(250, 214);
            this.uwagiW.Name = "uwagiW";
            this.uwagiW.Size = new System.Drawing.Size(37, 13);
            this.uwagiW.TabIndex = 41;
            this.uwagiW.Text = "Uwagi";
            // 
            // adresNum2
            // 
            this.adresNum2.Location = new System.Drawing.Point(563, 188);
            this.adresNum2.Name = "adresNum2";
            this.adresNum2.Size = new System.Drawing.Size(40, 20);
            this.adresNum2.TabIndex = 40;
            this.adresNum2.TextChanged += new System.EventHandler(this.adresNum2Zmien);
            // 
            // adresNum
            // 
            this.adresNum.Location = new System.Drawing.Point(504, 188);
            this.adresNum.Name = "adresNum";
            this.adresNum.Size = new System.Drawing.Size(35, 20);
            this.adresNum.TabIndex = 39;
            this.adresNum.TextChanged += new System.EventHandler(this.adresNumZmien);
            // 
            // adresW
            // 
            this.adresW.AutoSize = true;
            this.adresW.ForeColor = System.Drawing.Color.White;
            this.adresW.Location = new System.Drawing.Point(253, 191);
            this.adresW.Name = "adresW";
            this.adresW.Size = new System.Drawing.Size(34, 13);
            this.adresW.TabIndex = 38;
            this.adresW.Text = "Adres";
            // 
            // numerTelW
            // 
            this.numerTelW.AutoSize = true;
            this.numerTelW.ForeColor = System.Drawing.Color.White;
            this.numerTelW.Location = new System.Drawing.Point(208, 165);
            this.numerTelW.Name = "numerTelW";
            this.numerTelW.Size = new System.Drawing.Size(79, 13);
            this.numerTelW.TabIndex = 37;
            this.numerTelW.Text = "Numer telefonu";
            // 
            // statusW
            // 
            this.statusW.AutoSize = true;
            this.statusW.ForeColor = System.Drawing.Color.White;
            this.statusW.Location = new System.Drawing.Point(250, 139);
            this.statusW.Name = "statusW";
            this.statusW.Size = new System.Drawing.Size(37, 13);
            this.statusW.TabIndex = 36;
            this.statusW.Text = "Status";
            // 
            // nazwiskoW
            // 
            this.nazwiskoW.AutoSize = true;
            this.nazwiskoW.ForeColor = System.Drawing.Color.White;
            this.nazwiskoW.Location = new System.Drawing.Point(234, 113);
            this.nazwiskoW.Name = "nazwiskoW";
            this.nazwiskoW.Size = new System.Drawing.Size(53, 13);
            this.nazwiskoW.TabIndex = 35;
            this.nazwiskoW.Text = "Nazwisko";
            // 
            // imieW
            // 
            this.imieW.AutoSize = true;
            this.imieW.ForeColor = System.Drawing.Color.White;
            this.imieW.Location = new System.Drawing.Point(261, 87);
            this.imieW.Name = "imieW";
            this.imieW.Size = new System.Drawing.Size(26, 13);
            this.imieW.TabIndex = 34;
            this.imieW.Text = "Imie";
            // 
            // UwagiBox
            // 
            this.UwagiBox.Location = new System.Drawing.Point(296, 214);
            this.UwagiBox.Multiline = true;
            this.UwagiBox.Name = "UwagiBox";
            this.UwagiBox.Size = new System.Drawing.Size(307, 120);
            this.UwagiBox.TabIndex = 33;
            this.UwagiBox.TextChanged += new System.EventHandler(this.UwagiZmien);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(296, 140);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(43, 17);
            this.status.TabIndex = 32;
            this.status.Text = "VIP";
            this.status.UseVisualStyleBackColor = true;
            this.status.CheckedChanged += new System.EventHandler(this.statusZmien);
            // 
            // imieBox
            // 
            this.imieBox.Location = new System.Drawing.Point(296, 87);
            this.imieBox.Name = "imieBox";
            this.imieBox.Size = new System.Drawing.Size(307, 20);
            this.imieBox.TabIndex = 31;
            this.imieBox.TextChanged += new System.EventHandler(this.imieZmien);
            // 
            // nazwiskoBox
            // 
            this.nazwiskoBox.Location = new System.Drawing.Point(296, 113);
            this.nazwiskoBox.Name = "nazwiskoBox";
            this.nazwiskoBox.Size = new System.Drawing.Size(307, 20);
            this.nazwiskoBox.TabIndex = 30;
            this.nazwiskoBox.TextChanged += new System.EventHandler(this.nazwiskoZmien);
            // 
            // numerTelBox
            // 
            this.numerTelBox.Location = new System.Drawing.Point(296, 162);
            this.numerTelBox.Name = "numerTelBox";
            this.numerTelBox.Size = new System.Drawing.Size(307, 20);
            this.numerTelBox.TabIndex = 29;
            this.numerTelBox.TextChanged += new System.EventHandler(this.numerTelZmien);
            // 
            // adresBox
            // 
            this.adresBox.Location = new System.Drawing.Point(296, 188);
            this.adresBox.Name = "adresBox";
            this.adresBox.Size = new System.Drawing.Size(189, 20);
            this.adresBox.TabIndex = 28;
            this.adresBox.TextChanged += new System.EventHandler(this.adresZmien);
            // 
            // dodajKlienta
            // 
            this.dodajKlienta.Location = new System.Drawing.Point(516, 415);
            this.dodajKlienta.Name = "dodajKlienta";
            this.dodajKlienta.Size = new System.Drawing.Size(87, 23);
            this.dodajKlienta.TabIndex = 27;
            this.dodajKlienta.Text = "Dodaj klienta";
            this.dodajKlienta.UseVisualStyleBackColor = true;
            this.dodajKlienta.Click += new System.EventHandler(this.dodajKlientaP);
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelB.Controls.Add(this.PizzaW);
            this.panelB.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelB.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelB.Location = new System.Drawing.Point(0, 0);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(200, 500);
            this.panelB.TabIndex = 46;
            // 
            // PizzaW
            // 
            this.PizzaW.AutoSize = true;
            this.PizzaW.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaW.ForeColor = System.Drawing.Color.Red;
            this.PizzaW.Location = new System.Drawing.Point(12, 14);
            this.PizzaW.Name = "PizzaW";
            this.PizzaW.Size = new System.Drawing.Size(181, 24);
            this.PizzaW.TabIndex = 14;
            this.PizzaW.Text = "PIZZA express +";
            // 
            // panelG
            // 
            this.panelG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelG.Controls.Add(this.zamknijO);
            this.panelG.Controls.Add(this.minimalizujO);
            this.panelG.Controls.Add(this.powienkszPomniejszO);
            this.panelG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelG.Location = new System.Drawing.Point(200, 0);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(450, 62);
            this.panelG.TabIndex = 47;
            this.panelG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.przesunD);
            this.panelG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.przesunM);
            // 
            // zamknijO
            // 
            this.zamknijO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijO.AutoSize = true;
            this.zamknijO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zamknijO.FlatAppearance.BorderSize = 0;
            this.zamknijO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknijO.Image = ((System.Drawing.Image)(resources.GetObject("zamknijO.Image")));
            this.zamknijO.Location = new System.Drawing.Point(403, 6);
            this.zamknijO.Name = "zamknijO";
            this.zamknijO.Size = new System.Drawing.Size(42, 42);
            this.zamknijO.TabIndex = 9;
            this.zamknijO.UseVisualStyleBackColor = true;
            this.zamknijO.Click += new System.EventHandler(this.zamknij);
            // 
            // minimalizujO
            // 
            this.minimalizujO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimalizujO.AutoSize = true;
            this.minimalizujO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimalizujO.FlatAppearance.BorderSize = 0;
            this.minimalizujO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizujO.Image = ((System.Drawing.Image)(resources.GetObject("minimalizujO.Image")));
            this.minimalizujO.Location = new System.Drawing.Point(311, 6);
            this.minimalizujO.Name = "minimalizujO";
            this.minimalizujO.Size = new System.Drawing.Size(38, 41);
            this.minimalizujO.TabIndex = 10;
            this.minimalizujO.UseVisualStyleBackColor = true;
            this.minimalizujO.Click += new System.EventHandler(this.zminimalizuj);
            // 
            // powienkszPomniejszO
            // 
            this.powienkszPomniejszO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powienkszPomniejszO.AutoSize = true;
            this.powienkszPomniejszO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.powienkszPomniejszO.FlatAppearance.BorderSize = 0;
            this.powienkszPomniejszO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powienkszPomniejszO.Image = ((System.Drawing.Image)(resources.GetObject("powienkszPomniejszO.Image")));
            this.powienkszPomniejszO.Location = new System.Drawing.Point(355, 6);
            this.powienkszPomniejszO.Name = "powienkszPomniejszO";
            this.powienkszPomniejszO.Size = new System.Drawing.Size(42, 42);
            this.powienkszPomniejszO.TabIndex = 13;
            this.powienkszPomniejszO.UseVisualStyleBackColor = true;
            this.powienkszPomniejszO.Click += new System.EventHandler(this.powiekszPomiejsz);
            // 
            // FDostawa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.panelG);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.formaPlatnosciW);
            this.Controls.Add(this.kartaRB);
            this.Controls.Add(this.gotowkaRB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uwagiW);
            this.Controls.Add(this.adresNum2);
            this.Controls.Add(this.adresNum);
            this.Controls.Add(this.adresW);
            this.Controls.Add(this.numerTelW);
            this.Controls.Add(this.statusW);
            this.Controls.Add(this.nazwiskoW);
            this.Controls.Add(this.imieW);
            this.Controls.Add(this.UwagiBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.imieBox);
            this.Controls.Add(this.nazwiskoBox);
            this.Controls.Add(this.numerTelBox);
            this.Controls.Add(this.adresBox);
            this.Controls.Add(this.dodajKlienta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDostawa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dostawa";
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panelG.ResumeLayout(false);
            this.panelG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label formaPlatnosciW;
        private System.Windows.Forms.RadioButton kartaRB;
        private System.Windows.Forms.RadioButton gotowkaRB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uwagiW;
        private System.Windows.Forms.TextBox adresNum2;
        private System.Windows.Forms.TextBox adresNum;
        private System.Windows.Forms.Label adresW;
        private System.Windows.Forms.Label numerTelW;
        private System.Windows.Forms.Label statusW;
        private System.Windows.Forms.Label nazwiskoW;
        private System.Windows.Forms.Label imieW;
        private System.Windows.Forms.TextBox UwagiBox;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.TextBox imieBox;
        private System.Windows.Forms.TextBox nazwiskoBox;
        private System.Windows.Forms.TextBox numerTelBox;
        private System.Windows.Forms.TextBox adresBox;
        private System.Windows.Forms.Button dodajKlienta;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Label PizzaW;
        private System.Windows.Forms.Panel panelG;
        private System.Windows.Forms.Button zamknijO;
        private System.Windows.Forms.Button minimalizujO;
        private System.Windows.Forms.Button powienkszPomniejszO;
    }
}