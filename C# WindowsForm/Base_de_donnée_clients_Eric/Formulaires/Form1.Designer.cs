namespace Formulaires
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTB_MDP = new System.Windows.Forms.TextBox();
            this.BT_CONNEXION = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTB_EMAIL = new WindowsFormsControlTextBoxEmail.TextBoxEmail();
            this.LB_WARNING = new System.Windows.Forms.Label();
            this.BT_FERMER = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXTB_EMAIL);
            this.groupBox1.Controls.Add(this.TXTB_MDP);
            this.groupBox1.Controls.Add(this.BT_CONNEXION);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(123, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONNEXION";
            // 
            // TXTB_MDP
            // 
            this.TXTB_MDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_MDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TXTB_MDP.Location = new System.Drawing.Point(269, 67);
            this.TXTB_MDP.Name = "TXTB_MDP";
            this.TXTB_MDP.PasswordChar = '*';
            this.TXTB_MDP.Size = new System.Drawing.Size(150, 23);
            this.TXTB_MDP.TabIndex = 9;
            this.TXTB_MDP.UseSystemPasswordChar = true;
            // 
            // BT_CONNEXION
            // 
            this.BT_CONNEXION.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_CONNEXION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CONNEXION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BT_CONNEXION.Location = new System.Drawing.Point(269, 119);
            this.BT_CONNEXION.Name = "BT_CONNEXION";
            this.BT_CONNEXION.Size = new System.Drawing.Size(150, 27);
            this.BT_CONNEXION.TabIndex = 7;
            this.BT_CONNEXION.Text = "Entrer";
            this.BT_CONNEXION.UseVisualStyleBackColor = true;
            this.BT_CONNEXION.Click += new System.EventHandler(this.BT_CONNEXION_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(170, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // TXTB_EMAIL
            // 
            this.TXTB_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TXTB_EMAIL.ForeColor = System.Drawing.Color.Red;
            this.TXTB_EMAIL.Location = new System.Drawing.Point(270, 19);
            this.TXTB_EMAIL.Name = "TXTB_EMAIL";
            this.TXTB_EMAIL.Size = new System.Drawing.Size(149, 23);
            this.TXTB_EMAIL.TabIndex = 10;
            // 
            // LB_WARNING
            // 
            this.LB_WARNING.AutoSize = true;
            this.LB_WARNING.Location = new System.Drawing.Point(99, 401);
            this.LB_WARNING.Name = "LB_WARNING";
            this.LB_WARNING.Size = new System.Drawing.Size(0, 13);
            this.LB_WARNING.TabIndex = 11;
            // 
            // BT_FERMER
            // 
            this.BT_FERMER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_FERMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_FERMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BT_FERMER.Location = new System.Drawing.Point(402, 393);
            this.BT_FERMER.Name = "BT_FERMER";
            this.BT_FERMER.Size = new System.Drawing.Size(150, 27);
            this.BT_FERMER.TabIndex = 12;
            this.BT_FERMER.Text = "Fermer";
            this.BT_FERMER.UseVisualStyleBackColor = true;
            this.BT_FERMER.Click += new System.EventHandler(this.BT_FERMER_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(120, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "VPC Data Center Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Formulaires.Properties.Resources.vente_par_correspondance_e_commerce_logistique_commerce_en_ligne_e_business_THIMM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(564, 443);
            this.ControlBox = false;
            this.Controls.Add(this.LB_WARNING);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_FERMER);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion VPC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTB_MDP;
        private System.Windows.Forms.Button BT_CONNEXION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlTextBoxEmail.TextBoxEmail TXTB_EMAIL;
        private System.Windows.Forms.Label LB_WARNING;
        private System.Windows.Forms.Button BT_FERMER;
        private System.Windows.Forms.Label label3;
    }
}

