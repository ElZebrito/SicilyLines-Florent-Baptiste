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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbHeure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDateTraversee = new System.Windows.Forms.TextBox();
            this.tbIdBateau = new System.Windows.Forms.TextBox();
            this.tbIdTraversee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLiaison
            // 
            this.lbLiaison.FormattingEnabled = true;
            this.lbLiaison.ItemHeight = 16;
            this.lbLiaison.Location = new System.Drawing.Point(13, 47);
            this.lbLiaison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLiaison.Name = "lbLiaison";
            this.lbLiaison.Size = new System.Drawing.Size(631, 148);
            this.lbLiaison.TabIndex = 0;
            this.lbLiaison.SelectedIndexChanged += new System.EventHandler(this.lbLiaison_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(275, 9);
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
            this.label2.Location = new System.Drawing.Point(243, 230);
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
            this.lbTraversee.Location = new System.Drawing.Point(13, 265);
            this.lbTraversee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbTraversee.Name = "lbTraversee";
            this.lbTraversee.Size = new System.Drawing.Size(631, 276);
            this.lbTraversee.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbHeure);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbDateTraversee);
            this.groupBox3.Controls.Add(this.tbIdBateau);
            this.groupBox3.Controls.Add(this.tbIdTraversee);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.insertButton);
            this.groupBox3.Location = new System.Drawing.Point(683, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(523, 226);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertion";
            // 
            // tbHeure
            // 
            this.tbHeure.Location = new System.Drawing.Point(207, 108);
            this.tbHeure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHeure.Name = "tbHeure";
            this.tbHeure.Size = new System.Drawing.Size(132, 22);
            this.tbHeure.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Heure de la Traversée :";
            // 
            // tbDateTraversee
            // 
            this.tbDateTraversee.Location = new System.Drawing.Point(324, 59);
            this.tbDateTraversee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDateTraversee.Name = "tbDateTraversee";
            this.tbDateTraversee.Size = new System.Drawing.Size(132, 22);
            this.tbDateTraversee.TabIndex = 8;
            // 
            // tbIdBateau
            // 
            this.tbIdBateau.Location = new System.Drawing.Point(131, 68);
            this.tbIdBateau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIdBateau.Name = "tbIdBateau";
            this.tbIdBateau.Size = new System.Drawing.Size(132, 22);
            this.tbIdBateau.TabIndex = 7;
            // 
            // tbIdTraversee
            // 
            this.tbIdTraversee.Location = new System.Drawing.Point(149, 36);
            this.tbIdTraversee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIdTraversee.Name = "tbIdTraversee";
            this.tbIdTraversee.Size = new System.Drawing.Size(132, 22);
            this.tbIdTraversee.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date de la Traversée :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id du Bateau :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id de Traversée :";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(172, 154);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(187, 68);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Insérer une nouvelle traversée";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(889, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(316, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppression";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(64, 39);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(187, 68);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Supprimer la traversée sélectionnée";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Location = new System.Drawing.Point(889, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(316, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mise à jour";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(64, 38);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(187, 68);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Mettre à jour la traversée sélectionnée";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbTraversee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLiaison);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLiaison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTraversee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDateTraversee;
        private System.Windows.Forms.TextBox tbIdBateau;
        private System.Windows.Forms.TextBox tbIdTraversee;
        private System.Windows.Forms.TextBox tbHeure;
        private System.Windows.Forms.Label label6;
    }
}

