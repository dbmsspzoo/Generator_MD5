namespace Generator_MD5
{
    partial class kontakt
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kontakt));
            this.oWydawcyTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uruchomChatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oWydawcyTitle
            // 
            this.oWydawcyTitle.AutoSize = true;
            this.oWydawcyTitle.BackColor = System.Drawing.Color.Transparent;
            this.oWydawcyTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.oWydawcyTitle.Location = new System.Drawing.Point(28, 23);
            this.oWydawcyTitle.Name = "oWydawcyTitle";
            this.oWydawcyTitle.Size = new System.Drawing.Size(236, 19);
            this.oWydawcyTitle.TabIndex = 17;
            this.oWydawcyTitle.Text = "Kontakt z pomocą techniczną";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 56);
            this.label2.TabIndex = 19;
            this.label2.Text = "Specjalnie dla naszych użytkowników przygotowaliśmy wiele form wsparcia związanyc" +
    "h z pytaniami\r\ndotyczącymi obsługi programu i jego nowymi wersjami.\r\n\r\nPotrzebuj" +
    "esz wsparcia? Odezwij się.";
            // 
            // uruchomChatButton
            // 
            this.uruchomChatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uruchomChatButton.BackgroundImage")));
            this.uruchomChatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uruchomChatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uruchomChatButton.FlatAppearance.BorderSize = 0;
            this.uruchomChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uruchomChatButton.ForeColor = System.Drawing.Color.Transparent;
            this.uruchomChatButton.Location = new System.Drawing.Point(27, 117);
            this.uruchomChatButton.Name = "uruchomChatButton";
            this.uruchomChatButton.Size = new System.Drawing.Size(150, 42);
            this.uruchomChatButton.TabIndex = 20;
            this.uruchomChatButton.UseVisualStyleBackColor = true;
            this.uruchomChatButton.Click += new System.EventHandler(this.uruchomChatButton_Click);
            // 
            // kontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.uruchomChatButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oWydawcyTitle);
            this.Name = "kontakt";
            this.Size = new System.Drawing.Size(598, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oWydawcyTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uruchomChatButton;
    }
}
