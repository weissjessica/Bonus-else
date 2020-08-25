namespace Weiss_Jessica_Bonus1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUmsatz = new System.Windows.Forms.Label();
            this.lblVertreter = new System.Windows.Forms.Label();
            this.txtboxUmsatz = new System.Windows.Forms.TextBox();
            this.txtboxVertreter = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUmsatz
            // 
            this.lblUmsatz.AutoSize = true;
            this.lblUmsatz.Location = new System.Drawing.Point(53, 63);
            this.lblUmsatz.Name = "lblUmsatz";
            this.lblUmsatz.Size = new System.Drawing.Size(68, 20);
            this.lblUmsatz.TabIndex = 0;
            this.lblUmsatz.Text = "Umsatz:";
            // 
            // lblVertreter
            // 
            this.lblVertreter.AutoSize = true;
            this.lblVertreter.Location = new System.Drawing.Point(53, 115);
            this.lblVertreter.Name = "lblVertreter";
            this.lblVertreter.Size = new System.Drawing.Size(76, 20);
            this.lblVertreter.TabIndex = 1;
            this.lblVertreter.Text = "Vertreter:";
            // 
            // txtboxUmsatz
            // 
            this.txtboxUmsatz.Location = new System.Drawing.Point(180, 57);
            this.txtboxUmsatz.Name = "txtboxUmsatz";
            this.txtboxUmsatz.Size = new System.Drawing.Size(145, 26);
            this.txtboxUmsatz.TabIndex = 2;
            // 
            // txtboxVertreter
            // 
            this.txtboxVertreter.Location = new System.Drawing.Point(180, 108);
            this.txtboxVertreter.Name = "txtboxVertreter";
            this.txtboxVertreter.Size = new System.Drawing.Size(145, 26);
            this.txtboxVertreter.TabIndex = 3;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(74, 184);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(192, 35);
            this.btnBerechnen.TabIndex = 4;
            this.btnBerechnen.Text = "Provision berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(57, 283);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(0, 20);
            this.lblErgebnis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtboxVertreter);
            this.Controls.Add(this.txtboxUmsatz);
            this.Controls.Add(this.lblVertreter);
            this.Controls.Add(this.lblUmsatz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUmsatz;
        private System.Windows.Forms.Label lblVertreter;
        private System.Windows.Forms.TextBox txtboxUmsatz;
        private System.Windows.Forms.TextBox txtboxVertreter;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label lblErgebnis;
    }
}

