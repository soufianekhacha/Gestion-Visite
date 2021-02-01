namespace GestionVisite
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
			this.btnAfficher = new System.Windows.Forms.Button();
			this.grd = new System.Windows.Forms.DataGridView();
			this.IdLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtX = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.distanceField = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSaisirComm = new System.Windows.Forms.Button();
			this.grdVisite = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdVisite)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAfficher
			// 
			this.btnAfficher.BackColor = System.Drawing.Color.Maroon;
			this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAfficher.ForeColor = System.Drawing.Color.IndianRed;
			this.btnAfficher.Location = new System.Drawing.Point(715, 304);
			this.btnAfficher.Margin = new System.Windows.Forms.Padding(2);
			this.btnAfficher.Name = "btnAfficher";
			this.btnAfficher.Size = new System.Drawing.Size(110, 38);
			this.btnAfficher.TabIndex = 0;
			this.btnAfficher.Text = "Afficher";
			this.btnAfficher.UseVisualStyleBackColor = false;
			this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
			// 
			// grd
			// 
			this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grd.BackgroundColor = System.Drawing.Color.White;
			this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd.Location = new System.Drawing.Point(424, 68);
			this.grd.Margin = new System.Windows.Forms.Padding(2);
			this.grd.Name = "grd";
			this.grd.RowHeadersVisible = false;
			this.grd.RowHeadersWidth = 82;
			this.grd.RowTemplate.Height = 33;
			this.grd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grd.Size = new System.Drawing.Size(401, 232);
			this.grd.TabIndex = 1;
			// 
			// IdLabel
			// 
			this.IdLabel.AutoSize = true;
			this.IdLabel.Location = new System.Drawing.Point(14, 47);
			this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.Size = new System.Drawing.Size(16, 13);
			this.IdLabel.TabIndex = 0;
			this.IdLabel.Text = "Id";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 73);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 98);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Position :  X =                      Y=";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(60, 47);
			this.txtId.Margin = new System.Windows.Forms.Padding(2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(52, 20);
			this.txtId.TabIndex = 1;
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(60, 71);
			this.txtNom.Margin = new System.Windows.Forms.Padding(2);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(52, 20);
			this.txtNom.TabIndex = 1;
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(89, 95);
			this.txtX.Margin = new System.Windows.Forms.Padding(2);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(52, 20);
			this.txtX.TabIndex = 1;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(170, 95);
			this.txtY.Margin = new System.Windows.Forms.Padding(2);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(52, 20);
			this.txtY.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.distanceField);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnSaisirComm);
			this.groupBox1.Controls.Add(this.grdVisite);
			this.groupBox1.Controls.Add(this.txtY);
			this.groupBox1.Controls.Add(this.txtX);
			this.groupBox1.Controls.Add(this.IdLabel);
			this.groupBox1.Controls.Add(this.txtNom);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(11, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(406, 344);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// distanceField
			// 
			this.distanceField.Enabled = false;
			this.distanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanceField.Location = new System.Drawing.Point(178, 308);
			this.distanceField.Margin = new System.Windows.Forms.Padding(2);
			this.distanceField.Name = "distanceField";
			this.distanceField.Size = new System.Drawing.Size(215, 23);
			this.distanceField.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 308);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Distance du chemin :";
			// 
			// btnSaisirComm
			// 
			this.btnSaisirComm.BackColor = System.Drawing.Color.Maroon;
			this.btnSaisirComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaisirComm.ForeColor = System.Drawing.Color.IndianRed;
			this.btnSaisirComm.Location = new System.Drawing.Point(271, 47);
			this.btnSaisirComm.Margin = new System.Windows.Forms.Padding(2);
			this.btnSaisirComm.Name = "btnSaisirComm";
			this.btnSaisirComm.Size = new System.Drawing.Size(109, 43);
			this.btnSaisirComm.TabIndex = 2;
			this.btnSaisirComm.Text = "Calculer";
			this.btnSaisirComm.UseVisualStyleBackColor = false;
			this.btnSaisirComm.Click += new System.EventHandler(this.btnSaisirComm_Click);
			// 
			// grdVisite
			// 
			this.grdVisite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdVisite.BackgroundColor = System.Drawing.Color.White;
			this.grdVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdVisite.Location = new System.Drawing.Point(8, 128);
			this.grdVisite.Margin = new System.Windows.Forms.Padding(2);
			this.grdVisite.Name = "grdVisite";
			this.grdVisite.RowHeadersVisible = false;
			this.grdVisite.RowHeadersWidth = 82;
			this.grdVisite.RowTemplate.Height = 33;
			this.grdVisite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grdVisite.Size = new System.Drawing.Size(385, 161);
			this.grdVisite.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Maroon;
			this.label4.Location = new System.Drawing.Point(532, 35);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(225, 31);
			this.label4.TabIndex = 4;
			this.label4.Text = "Liste des clients";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Maroon;
			this.label5.Location = new System.Drawing.Point(128, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 26);
			this.label5.TabIndex = 5;
			this.label5.Text = "Commercial";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MistyRose;
			this.ClientSize = new System.Drawing.Size(836, 375);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grd);
			this.Controls.Add(this.btnAfficher);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Gestion Visite";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdVisite)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaisirComm;
        private System.Windows.Forms.DataGridView grdVisite;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox distanceField;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

