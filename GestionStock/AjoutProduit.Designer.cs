namespace GestionStock
{
    partial class AjoutProduit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTaux = new System.Windows.Forms.ComboBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxEuros = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxQteCrit = new System.Windows.Forms.TextBox();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.labelMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 72);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(472, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 72);
            this.button4.TabIndex = 20;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(546, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 72);
            this.button3.TabIndex = 19;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(3, 22);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(167, 25);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Ajouter produit";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(177, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE STOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taux du jour :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Désignation produit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prix unitaire € :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantité :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Etat produit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "USD :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Qté_critique :";
            // 
            // comboBoxTaux
            // 
            this.comboBoxTaux.FormattingEnabled = true;
            this.comboBoxTaux.Location = new System.Drawing.Point(193, 138);
            this.comboBoxTaux.Name = "comboBoxTaux";
            this.comboBoxTaux.Size = new System.Drawing.Size(123, 28);
            this.comboBoxTaux.TabIndex = 10;
            this.comboBoxTaux.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTaux_KeyPress);
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(193, 195);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(378, 26);
            this.textBoxDesignation.TabIndex = 11;
            // 
            // textBoxEuros
            // 
            this.textBoxEuros.Location = new System.Drawing.Point(193, 249);
            this.textBoxEuros.Name = "textBoxEuros";
            this.textBoxEuros.Size = new System.Drawing.Size(123, 26);
            this.textBoxEuros.TabIndex = 12;
            this.textBoxEuros.TextChanged += new System.EventHandler(this.textBoxEuros_TextChanged);
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(448, 252);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.ReadOnly = true;
            this.textBoxUSD.Size = new System.Drawing.Size(123, 26);
            this.textBoxUSD.TabIndex = 13;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(193, 310);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(123, 26);
            this.textBoxStock.TabIndex = 14;
            this.textBoxStock.TextChanged += new System.EventHandler(this.textBoxStock_TextChanged);
            // 
            // textBoxQteCrit
            // 
            this.textBoxQteCrit.Location = new System.Drawing.Point(448, 313);
            this.textBoxQteCrit.Name = "textBoxQteCrit";
            this.textBoxQteCrit.ReadOnly = true;
            this.textBoxQteCrit.Size = new System.Drawing.Size(123, 26);
            this.textBoxQteCrit.TabIndex = 15;
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Items.AddRange(new object[] {
            "Active",
            "Desactive"});
            this.comboBoxEtat.Location = new System.Drawing.Point(193, 375);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(123, 28);
            this.comboBoxEtat.TabIndex = 16;
            this.comboBoxEtat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEtat_KeyPress);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.BackColor = System.Drawing.Color.Turquoise;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(407, 457);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(164, 52);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Red;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(35, 457);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(164, 52);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // AjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(621, 540);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.comboBoxEtat);
            this.Controls.Add(this.textBoxQteCrit);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.textBoxEuros);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.comboBoxTaux);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "AjoutProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Produit";
            this.Load += new System.EventHandler(this.AjoutProduit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ComboBox comboBoxTaux;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxEuros;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxQteCrit;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
    }
}