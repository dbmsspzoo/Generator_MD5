namespace Generator_MD5
{
    partial class oProgramie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oProgramie));
            this.oProgramieTitle = new System.Windows.Forms.Label();
            this.oProgramieText = new System.Windows.Forms.Label();
            this.oProgramieLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // oProgramieTitle
            // 
            this.oProgramieTitle.AutoSize = true;
            this.oProgramieTitle.BackColor = System.Drawing.Color.Transparent;
            this.oProgramieTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.oProgramieTitle.Location = new System.Drawing.Point(28, 23);
            this.oProgramieTitle.Name = "oProgramieTitle";
            this.oProgramieTitle.Size = new System.Drawing.Size(103, 19);
            this.oProgramieTitle.TabIndex = 0;
            this.oProgramieTitle.Text = "O programie";
            // 
            // oProgramieText
            // 
            this.oProgramieText.AutoSize = true;
            this.oProgramieText.Font = new System.Drawing.Font("Arial", 8.25F);
            this.oProgramieText.Location = new System.Drawing.Point(29, 57);
            this.oProgramieText.Name = "oProgramieText";
            this.oProgramieText.Size = new System.Drawing.Size(497, 84);
            this.oProgramieText.TabIndex = 1;
            this.oProgramieText.Text = resources.GetString("oProgramieText.Text");
            // 
            // oProgramieLink
            // 
            this.oProgramieLink.AutoSize = true;
            this.oProgramieLink.Font = new System.Drawing.Font("Arial", 8.25F);
            this.oProgramieLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oProgramieLink.Location = new System.Drawing.Point(29, 141);
            this.oProgramieLink.Name = "oProgramieLink";
            this.oProgramieLink.Size = new System.Drawing.Size(117, 14);
            this.oProgramieLink.TabIndex = 2;
            this.oProgramieLink.TabStop = true;
            this.oProgramieLink.Text = "Dowiedz się więcej >>";
            this.oProgramieLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.oProgramieLink_LinkClicked);
            // 
            // oProgramie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.oProgramieLink);
            this.Controls.Add(this.oProgramieText);
            this.Controls.Add(this.oProgramieTitle);
            this.Name = "oProgramie";
            this.Size = new System.Drawing.Size(598, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oProgramieTitle;
        private System.Windows.Forms.Label oProgramieText;
        private System.Windows.Forms.LinkLabel oProgramieLink;
    }
}
