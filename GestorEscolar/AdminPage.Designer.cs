namespace GestorEscolar
{
    partial class AdminPage
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
            this.btnDirectivos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnProfesores = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEstudiantes = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.btnDirectivos.Click += new System.EventHandler(this.btnDirectivos_Click);
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
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
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
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OldLace;
            this.panelMenu.Controls.Add(this.btnDirectivos);
            this.panelMenu.Controls.Add(this.btnEstudiantes);
            this.panelMenu.Controls.Add(this.btnProfesores);
            this.panelMenu.Location = new System.Drawing.Point(12, 73);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(400, 48);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.panelPrincipal.Location = new System.Drawing.Point(15, 141);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(933, 340);
            this.panelPrincipal.TabIndex = 4;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 493);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de administrador";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnDirectivos;
        private MaterialSkin.Controls.MaterialFlatButton btnProfesores;
        private MaterialSkin.Controls.MaterialFlatButton btnEstudiantes;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}