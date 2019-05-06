namespace Generator_MD5
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.topMenu = new System.Windows.Forms.Panel();
            this.zamknijPomocButton = new System.Windows.Forms.Button();
            this.pomocButton = new System.Windows.Forms.Button();
            this.minimalizujButton = new System.Windows.Forms.Button();
            this.zamknijButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bottomMenu = new System.Windows.Forms.Panel();
            this.stopka2 = new System.Windows.Forms.Label();
            this.stopka1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.distanceRight = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.assistantLabel2 = new System.Windows.Forms.Label();
            this.assistantLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.saveStatusLabel = new System.Windows.Forms.Label();
            this.openStatusLabel = new System.Windows.Forms.Label();
            this.wygenerujPlikButton = new System.Windows.Forms.Button();
            this.wybierzLokalizacjeButton = new System.Windows.Forms.Button();
            this.wybierzPlikButton = new System.Windows.Forms.Button();
            this.pomoc1 = new Generator_MD5.Pomoc();
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.bottomMenu.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.White;
            this.topMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topMenu.Controls.Add(this.zamknijPomocButton);
            this.topMenu.Controls.Add(this.pomocButton);
            this.topMenu.Controls.Add(this.minimalizujButton);
            this.topMenu.Controls.Add(this.zamknijButton);
            this.topMenu.Controls.Add(this.logo);
            this.topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenu.ForeColor = System.Drawing.Color.Transparent;
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(784, 55);
            this.topMenu.TabIndex = 0;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            this.topMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseUp);
            // 
            // zamknijPomocButton
            // 
            this.zamknijPomocButton.BackColor = System.Drawing.Color.Transparent;
            this.zamknijPomocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zamknijPomocButton.FlatAppearance.BorderSize = 0;
            this.zamknijPomocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknijPomocButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknijPomocButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.zamknijPomocButton.Image = ((System.Drawing.Image)(resources.GetObject("zamknijPomocButton.Image")));
            this.zamknijPomocButton.Location = new System.Drawing.Point(582, 10);
            this.zamknijPomocButton.Name = "zamknijPomocButton";
            this.zamknijPomocButton.Size = new System.Drawing.Size(125, 26);
            this.zamknijPomocButton.TabIndex = 4;
            this.zamknijPomocButton.Text = "Zamknij Pomoc";
            this.zamknijPomocButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.zamknijPomocButton.UseVisualStyleBackColor = false;
            this.zamknijPomocButton.Visible = false;
            this.zamknijPomocButton.Click += new System.EventHandler(this.zamknijPomocButton_Click);
            // 
            // pomocButton
            // 
            this.pomocButton.BackColor = System.Drawing.Color.Transparent;
            this.pomocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pomocButton.FlatAppearance.BorderSize = 0;
            this.pomocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pomocButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomocButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.pomocButton.Image = ((System.Drawing.Image)(resources.GetObject("pomocButton.Image")));
            this.pomocButton.Location = new System.Drawing.Point(630, 11);
            this.pomocButton.Name = "pomocButton";
            this.pomocButton.Size = new System.Drawing.Size(81, 26);
            this.pomocButton.TabIndex = 3;
            this.pomocButton.Text = "Pomoc";
            this.pomocButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.pomocButton.UseVisualStyleBackColor = false;
            this.pomocButton.Click += new System.EventHandler(this.pomocButton_Click);
            // 
            // minimalizujButton
            // 
            this.minimalizujButton.BackColor = System.Drawing.Color.Transparent;
            this.minimalizujButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalizujButton.FlatAppearance.BorderSize = 0;
            this.minimalizujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizujButton.Image = ((System.Drawing.Image)(resources.GetObject("minimalizujButton.Image")));
            this.minimalizujButton.Location = new System.Drawing.Point(711, 12);
            this.minimalizujButton.Name = "minimalizujButton";
            this.minimalizujButton.Size = new System.Drawing.Size(32, 26);
            this.minimalizujButton.TabIndex = 2;
            this.minimalizujButton.Text = "     ";
            this.minimalizujButton.UseVisualStyleBackColor = false;
            this.minimalizujButton.Click += new System.EventHandler(this.minimalizujButton_Click);
            // 
            // zamknijButton
            // 
            this.zamknijButton.BackColor = System.Drawing.Color.Transparent;
            this.zamknijButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zamknijButton.FlatAppearance.BorderSize = 0;
            this.zamknijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknijButton.Image = ((System.Drawing.Image)(resources.GetObject("zamknijButton.Image")));
            this.zamknijButton.Location = new System.Drawing.Point(740, 12);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(32, 26);
            this.zamknijButton.TabIndex = 1;
            this.zamknijButton.Text = "     ";
            this.zamknijButton.UseVisualStyleBackColor = false;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 8);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(120, 47);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // bottomMenu
            // 
            this.bottomMenu.BackColor = System.Drawing.Color.White;
            this.bottomMenu.Controls.Add(this.stopka2);
            this.bottomMenu.Controls.Add(this.stopka1);
            this.bottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomMenu.Location = new System.Drawing.Point(0, 430);
            this.bottomMenu.Name = "bottomMenu";
            this.bottomMenu.Size = new System.Drawing.Size(784, 55);
            this.bottomMenu.TabIndex = 1;
            // 
            // stopka2
            // 
            this.stopka2.AutoSize = true;
            this.stopka2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.stopka2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.stopka2.Location = new System.Drawing.Point(571, 18);
            this.stopka2.Name = "stopka2";
            this.stopka2.Size = new System.Drawing.Size(206, 16);
            this.stopka2.TabIndex = 1;
            this.stopka2.Text = "Licencja open source.  Wersja 1.0";
            // 
            // stopka1
            // 
            this.stopka1.AutoSize = true;
            this.stopka1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopka1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.stopka1.Location = new System.Drawing.Point(17, 18);
            this.stopka1.Name = "stopka1";
            this.stopka1.Size = new System.Drawing.Size(198, 16);
            this.stopka1.TabIndex = 0;
            this.stopka1.Text = "DBMS Sp. z o.o. Copyright 2019";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 375);
            this.panel1.TabIndex = 2;
            // 
            // distanceRight
            // 
            this.distanceRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.distanceRight.Location = new System.Drawing.Point(764, 55);
            this.distanceRight.Name = "distanceRight";
            this.distanceRight.Size = new System.Drawing.Size(20, 375);
            this.distanceRight.TabIndex = 3;
            // 
            // main
            // 
            this.main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main.BackgroundImage")));
            this.main.Controls.Add(this.pomoc1);
            this.main.Controls.Add(this.assistantLabel2);
            this.main.Controls.Add(this.assistantLabel);
            this.main.Controls.Add(this.statusLabel);
            this.main.Controls.Add(this.saveStatusLabel);
            this.main.Controls.Add(this.openStatusLabel);
            this.main.Controls.Add(this.wygenerujPlikButton);
            this.main.Controls.Add(this.wybierzLokalizacjeButton);
            this.main.Controls.Add(this.wybierzPlikButton);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(20, 55);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(744, 375);
            this.main.TabIndex = 4;
            // 
            // assistantLabel2
            // 
            this.assistantLabel2.AutoSize = true;
            this.assistantLabel2.BackColor = System.Drawing.Color.Transparent;
            this.assistantLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistantLabel2.Location = new System.Drawing.Point(53, 359);
            this.assistantLabel2.Name = "assistantLabel2";
            this.assistantLabel2.Size = new System.Drawing.Size(0, 13);
            this.assistantLabel2.TabIndex = 7;
            this.assistantLabel2.Visible = false;
            // 
            // assistantLabel
            // 
            this.assistantLabel.AutoSize = true;
            this.assistantLabel.BackColor = System.Drawing.Color.Transparent;
            this.assistantLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistantLabel.Location = new System.Drawing.Point(17, 362);
            this.assistantLabel.Name = "assistantLabel";
            this.assistantLabel.Size = new System.Drawing.Size(0, 13);
            this.assistantLabel.TabIndex = 6;
            this.assistantLabel.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.ForeColor = System.Drawing.Color.Transparent;
            this.statusLabel.Location = new System.Drawing.Point(522, 263);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(151, 15);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Trwa generowanie pliku...";
            this.statusLabel.Visible = false;
            // 
            // saveStatusLabel
            // 
            this.saveStatusLabel.AutoSize = true;
            this.saveStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.saveStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStatusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveStatusLabel.ForeColor = System.Drawing.Color.Transparent;
            this.saveStatusLabel.Location = new System.Drawing.Point(291, 263);
            this.saveStatusLabel.Name = "saveStatusLabel";
            this.saveStatusLabel.Size = new System.Drawing.Size(174, 15);
            this.saveStatusLabel.TabIndex = 4;
            this.saveStatusLabel.Text = "Nie wybrano pliku wynikowego";
            this.saveStatusLabel.Visible = false;
            // 
            // openStatusLabel
            // 
            this.openStatusLabel.AutoSize = true;
            this.openStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.openStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openStatusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openStatusLabel.ForeColor = System.Drawing.Color.Transparent;
            this.openStatusLabel.Location = new System.Drawing.Point(59, 263);
            this.openStatusLabel.Name = "openStatusLabel";
            this.openStatusLabel.Size = new System.Drawing.Size(179, 15);
            this.openStatusLabel.TabIndex = 3;
            this.openStatusLabel.Text = "Nie wybrano pliku wejściowego";
            // 
            // wygenerujPlikButton
            // 
            this.wygenerujPlikButton.BackColor = System.Drawing.Color.Transparent;
            this.wygenerujPlikButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wygenerujPlikButton.BackgroundImage")));
            this.wygenerujPlikButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wygenerujPlikButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wygenerujPlikButton.FlatAppearance.BorderSize = 0;
            this.wygenerujPlikButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wygenerujPlikButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wygenerujPlikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wygenerujPlikButton.ForeColor = System.Drawing.Color.Transparent;
            this.wygenerujPlikButton.Location = new System.Drawing.Point(562, 301);
            this.wygenerujPlikButton.Name = "wygenerujPlikButton";
            this.wygenerujPlikButton.Size = new System.Drawing.Size(156, 45);
            this.wygenerujPlikButton.TabIndex = 2;
            this.wygenerujPlikButton.UseVisualStyleBackColor = true;
            this.wygenerujPlikButton.Visible = false;
            this.wygenerujPlikButton.Click += new System.EventHandler(this.wygenerujPlikButton_Click);
            // 
            // wybierzLokalizacjeButton
            // 
            this.wybierzLokalizacjeButton.BackColor = System.Drawing.Color.Transparent;
            this.wybierzLokalizacjeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wybierzLokalizacjeButton.BackgroundImage")));
            this.wybierzLokalizacjeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wybierzLokalizacjeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wybierzLokalizacjeButton.FlatAppearance.BorderSize = 0;
            this.wybierzLokalizacjeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wybierzLokalizacjeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wybierzLokalizacjeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wybierzLokalizacjeButton.ForeColor = System.Drawing.Color.Transparent;
            this.wybierzLokalizacjeButton.Location = new System.Drawing.Point(327, 301);
            this.wybierzLokalizacjeButton.Name = "wybierzLokalizacjeButton";
            this.wybierzLokalizacjeButton.Size = new System.Drawing.Size(156, 45);
            this.wybierzLokalizacjeButton.TabIndex = 1;
            this.wybierzLokalizacjeButton.UseVisualStyleBackColor = false;
            this.wybierzLokalizacjeButton.Visible = false;
            this.wybierzLokalizacjeButton.Click += new System.EventHandler(this.wybierzLokalizacjeButton_Click);
            // 
            // wybierzPlikButton
            // 
            this.wybierzPlikButton.BackColor = System.Drawing.Color.Transparent;
            this.wybierzPlikButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wybierzPlikButton.BackgroundImage")));
            this.wybierzPlikButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wybierzPlikButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wybierzPlikButton.FlatAppearance.BorderSize = 0;
            this.wybierzPlikButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wybierzPlikButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wybierzPlikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wybierzPlikButton.ForeColor = System.Drawing.Color.Transparent;
            this.wybierzPlikButton.Location = new System.Drawing.Point(97, 301);
            this.wybierzPlikButton.Name = "wybierzPlikButton";
            this.wybierzPlikButton.Size = new System.Drawing.Size(156, 45);
            this.wybierzPlikButton.TabIndex = 0;
            this.wybierzPlikButton.UseVisualStyleBackColor = false;
            this.wybierzPlikButton.Click += new System.EventHandler(this.wybierzPlikButton_Click);
            // 
            // pomoc1
            // 
            this.pomoc1.BackColor = System.Drawing.Color.White;
            this.pomoc1.Location = new System.Drawing.Point(0, 0);
            this.pomoc1.Name = "pomoc1";
            this.pomoc1.Size = new System.Drawing.Size(744, 375);
            this.pomoc1.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.main);
            this.Controls.Add(this.distanceRight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottomMenu);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(784, 485);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator MD5";
            this.topMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.bottomMenu.ResumeLayout(false);
            this.bottomMenu.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Panel bottomMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel distanceRight;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button pomocButton;
        private System.Windows.Forms.Button minimalizujButton;
        private System.Windows.Forms.Button zamknijButton;
        private System.Windows.Forms.Label stopka2;
        private System.Windows.Forms.Label stopka1;
        private System.Windows.Forms.Button zamknijPomocButton;
        private System.Windows.Forms.Button wygenerujPlikButton;
        private System.Windows.Forms.Button wybierzLokalizacjeButton;
        private System.Windows.Forms.Button wybierzPlikButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label saveStatusLabel;
        private System.Windows.Forms.Label openStatusLabel;
        private System.Windows.Forms.Label assistantLabel2;
        private System.Windows.Forms.Label assistantLabel;
        private Pomoc pomoc1;
    }
}

