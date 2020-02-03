namespace OrdnerRechteVerwaltung
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtErr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edBasis = new System.Windows.Forms.TextBox();
            this.edMaske = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.lbCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edUser = new System.Windows.Forms.TextBox();
            this.grdPfade = new System.Windows.Forms.DataGridView();
            this.butDel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPfade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtErr
            // 
            this.txtErr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErr.ForeColor = System.Drawing.Color.Red;
            this.txtErr.Location = new System.Drawing.Point(15, 349);
            this.txtErr.Multiline = true;
            this.txtErr.Name = "txtErr";
            this.txtErr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErr.Size = new System.Drawing.Size(655, 39);
            this.txtErr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basis-Pfad";
            // 
            // edBasis
            // 
            this.edBasis.Location = new System.Drawing.Point(90, 6);
            this.edBasis.Name = "edBasis";
            this.edBasis.Size = new System.Drawing.Size(190, 20);
            this.edBasis.TabIndex = 2;
            this.edBasis.Text = "K:\\11 Projekte";
            // 
            // edMaske
            // 
            this.edMaske.Location = new System.Drawing.Point(374, 7);
            this.edMaske.Name = "edMaske";
            this.edMaske.Size = new System.Drawing.Size(130, 20);
            this.edMaske.TabIndex = 3;
            this.edMaske.Text = "Kunde";
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.Location = new System.Drawing.Point(304, 28);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(200, 23);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "Verzeichnisse suchen";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // lbCounter
            // 
            this.lbCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCounter.AutoSize = true;
            this.lbCounter.Location = new System.Drawing.Point(645, 37);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(25, 13);
            this.lbCounter.TabIndex = 5;
            this.lbCounter.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Such-Pfad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User / Gruppe";
            // 
            // edUser
            // 
            this.edUser.Location = new System.Drawing.Point(90, 30);
            this.edUser.Name = "edUser";
            this.edUser.Size = new System.Drawing.Size(190, 20);
            this.edUser.TabIndex = 9;
            this.edUser.Text = "STI\\Einkauf_reduziert";
            // 
            // grdPfade
            // 
            this.grdPfade.AllowUserToAddRows = false;
            this.grdPfade.AllowUserToDeleteRows = false;
            this.grdPfade.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grdPfade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPfade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPfade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPfade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPfade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPfade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPfade.Location = new System.Drawing.Point(15, 60);
            this.grdPfade.Name = "grdPfade";
            this.grdPfade.ReadOnly = true;
            this.grdPfade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPfade.Size = new System.Drawing.Size(655, 287);
            this.grdPfade.TabIndex = 10;
            // 
            // butDel
            // 
            this.butDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.Red;
            this.butDel.Location = new System.Drawing.Point(265, 420);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(405, 23);
            this.butDel.TabIndex = 12;
            this.butDel.Text = "Zugriff auf alle oben aufgeführten Verzeichnisse verweigern";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Zum Ändern von Berechtigungen muss man als Administrtor angemeldet sein!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.grdPfade);
            this.Controls.Add(this.edUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCounter);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.edMaske);
            this.Controls.Add(this.edBasis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtErr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Ordner-Rechte Verwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.grdPfade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtErr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edBasis;
        private System.Windows.Forms.TextBox edMaske;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edUser;
        private System.Windows.Forms.DataGridView grdPfade;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Label label4;
    }
}

