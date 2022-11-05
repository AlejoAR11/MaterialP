namespace GestorEscolar
{
    partial class FiltroEstudiantes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpEstudiantes = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flpEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpEstudiantes
            // 
            this.flpEstudiantes.Controls.Add(this.materialLabel1);
            this.flpEstudiantes.Controls.Add(this.dataGridView1);
            this.flpEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.flpEstudiantes.Name = "flpEstudiantes";
            this.flpEstudiantes.Size = new System.Drawing.Size(933, 350);
            this.flpEstudiantes.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(31, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Est";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FiltroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpEstudiantes);
            this.Name = "FiltroEstudiantes";
            this.Size = new System.Drawing.Size(933, 350);
            this.flpEstudiantes.ResumeLayout(false);
            this.flpEstudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEstudiantes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
