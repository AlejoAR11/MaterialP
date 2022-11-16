namespace GestorEscolar
{
    partial class EstudiantePage
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
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.ColumnN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnN3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnN4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.gbNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(898, 81);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnN1,
            this.ColumnN2,
            this.ColumnN3,
            this.ColumnN4,
            this.ColumnProm});
            this.dgvNotas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvNotas.Location = new System.Drawing.Point(343, 32);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.Size = new System.Drawing.Size(546, 280);
            this.dgvNotas.TabIndex = 13;
            this.dgvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_CellContentClick);
            // 
            // gbNotas
            // 
            this.gbNotas.Controls.Add(this.materialLabel1);
            this.gbNotas.Controls.Add(this.dgvNotas);
            this.gbNotas.Location = new System.Drawing.Point(12, 116);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Size = new System.Drawing.Size(935, 365);
            this.gbNotas.TabIndex = 14;
            this.gbNotas.TabStop = false;
            // 
            // ColumnN1
            // 
            this.ColumnN1.HeaderText = "Nota 1";
            this.ColumnN1.Name = "ColumnN1";
            this.ColumnN1.ReadOnly = true;
            // 
            // ColumnN2
            // 
            this.ColumnN2.HeaderText = "Nota 2";
            this.ColumnN2.Name = "ColumnN2";
            this.ColumnN2.ReadOnly = true;
            // 
            // ColumnN3
            // 
            this.ColumnN3.HeaderText = "Nota 3";
            this.ColumnN3.Name = "ColumnN3";
            this.ColumnN3.ReadOnly = true;
            // 
            // ColumnN4
            // 
            this.ColumnN4.HeaderText = "Nota 4";
            this.ColumnN4.Name = "ColumnN4";
            this.ColumnN4.ReadOnly = true;
            // 
            // ColumnProm
            // 
            this.ColumnProm.HeaderText = "Promedio";
            this.ColumnProm.Name = "ColumnProm";
            this.ColumnProm.ReadOnly = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Matemáticas";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(8, 94);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(19, 19);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "\"\"";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // EstudiantePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 493);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbNotas);
            this.Controls.Add(this.btnSalir);
            this.Name = "EstudiantePage";
            this.Text = "Vista de estudiante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.gbNotas.ResumeLayout(false);
            this.gbNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProm;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblName;
    }
}