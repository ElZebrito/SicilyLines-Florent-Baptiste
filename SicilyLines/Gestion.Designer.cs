namespace SicilyLines
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTraversee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbLiaison
            // 
            this.lbLiaison.FormattingEnabled = true;
            this.lbLiaison.ItemHeight = 16;
            this.lbLiaison.Location = new System.Drawing.Point(31, 50);
            this.lbLiaison.Margin = new System.Windows.Forms.Padding(4);
            this.lbLiaison.Name = "lbLiaison";
            this.lbLiaison.Size = new System.Drawing.Size(748, 292);
            this.lbLiaison.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(354, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Liaisons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(939, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liste des Traversées par Liaison";
            // 
            // lbTraversee
            // 
            this.lbTraversee.FormattingEnabled = true;
            this.lbTraversee.ItemHeight = 16;
            this.lbTraversee.Location = new System.Drawing.Point(808, 50);
            this.lbTraversee.Margin = new System.Windows.Forms.Padding(4);
            this.lbTraversee.Name = "lbTraversee";
            this.lbTraversee.Size = new System.Drawing.Size(451, 292);
            this.lbTraversee.TabIndex = 4;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 554);
            this.Controls.Add(this.lbTraversee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLiaison);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLiaison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTraversee;
    }
}

