namespace Mission2
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLiaison = new System.Windows.Forms.ListBox();
            this.lbTraversee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbLiaison
            // 
            this.lbLiaison.FormattingEnabled = true;
            this.lbLiaison.ItemHeight = 16;
            this.lbLiaison.Location = new System.Drawing.Point(50, 54);
            this.lbLiaison.Name = "lbLiaison";
            this.lbLiaison.Size = new System.Drawing.Size(775, 340);
            this.lbLiaison.TabIndex = 0;
            // 
            // lbTraversee
            // 
            this.lbTraversee.FormattingEnabled = true;
            this.lbTraversee.ItemHeight = 16;
            this.lbTraversee.Location = new System.Drawing.Point(922, 54);
            this.lbTraversee.Name = "lbTraversee";
            this.lbTraversee.Size = new System.Drawing.Size(556, 340);
            this.lbTraversee.TabIndex = 1;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 516);
            this.Controls.Add(this.lbTraversee);
            this.Controls.Add(this.lbLiaison);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLiaison;
        private System.Windows.Forms.ListBox lbTraversee;
    }
}

