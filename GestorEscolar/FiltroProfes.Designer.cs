namespace GestorEscolar
{
    partial class FiltroProfes
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
            this.flpProfesores = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.flpProfesores.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProfesores
            // 
            this.flpProfesores.Controls.Add(this.materialLabel1);
            this.flpProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProfesores.Location = new System.Drawing.Point(0, 0);
            this.flpProfesores.Name = "flpProfesores";
            this.flpProfesores.Size = new System.Drawing.Size(933, 350);
            this.flpProfesores.TabIndex = 0;
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
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "prof";
            // 
            // FiltroProfes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpProfesores);
            this.Name = "FiltroProfes";
            this.Size = new System.Drawing.Size(933, 350);
            this.flpProfesores.ResumeLayout(false);
            this.flpProfesores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProfesores;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
