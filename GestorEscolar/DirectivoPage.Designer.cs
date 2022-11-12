namespace GestorEscolar
{
    partial class DirectivoPage
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDirectivos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEstudiantes = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnProfesores = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.panelPrincipal.Location = new System.Drawing.Point(15, 141);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(933, 340);
            this.panelPrincipal.TabIndex = 6;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OldLace;
            this.panelMenu.Controls.Add(this.btnDirectivos);
            this.panelMenu.Controls.Add(this.btnEstudiantes);
            this.panelMenu.Controls.Add(this.btnProfesores);
            this.panelMenu.Location = new System.Drawing.Point(12, 73);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(323, 48);
            this.panelMenu.TabIndex = 5;
            // 
            // btnDirectivos
            // 
            this.btnDirectivos.AutoSize = true;
            this.btnDirectivos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDirectivos.Depth = 0;
            this.btnDirectivos.Location = new System.Drawing.Point(4, 6);
            this.btnDirectivos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDirectivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDirectivos.Name = "btnDirectivos";
            this.btnDirectivos.Primary = false;
            this.btnDirectivos.Size = new System.Drawing.Size(89, 36);
            this.btnDirectivos.TabIndex = 0;
            this.btnDirectivos.Text = "Directivos";
            this.btnDirectivos.UseVisualStyleBackColor = true;
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.AutoSize = true;
            this.btnEstudiantes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEstudiantes.Depth = 0;
            this.btnEstudiantes.Location = new System.Drawing.Point(220, 6);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEstudiantes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Primary = false;
            this.btnEstudiantes.Size = new System.Drawing.Size(101, 36);
            this.btnEstudiantes.TabIndex = 2;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            // 
            // btnProfesores
            // 
            this.btnProfesores.AutoSize = true;
            this.btnProfesores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProfesores.Depth = 0;
            this.btnProfesores.Location = new System.Drawing.Point(112, 6);
            this.btnProfesores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProfesores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Primary = false;
            this.btnProfesores.Size = new System.Drawing.Size(96, 36);
            this.btnProfesores.TabIndex = 1;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            // 
            // DirectivoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 493);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Name = "DirectivoPage";
            this.Text = "Gestión directivo";
            this.Load += new System.EventHandler(this.DirectivoPage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelMenu;
        private MaterialSkin.Controls.MaterialFlatButton btnDirectivos;
        private MaterialSkin.Controls.MaterialFlatButton btnEstudiantes;
        private MaterialSkin.Controls.MaterialFlatButton btnProfesores;
    }
}