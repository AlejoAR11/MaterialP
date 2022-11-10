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
            this.components = new System.ComponentModel.Container();
            this.flpEstudiantes = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProviderValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDirectivos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMod = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContacto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidar)).BeginInit();
            this.gbDirectivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // flpEstudiantes
            // 
            this.flpEstudiantes.Controls.Add(this.materialLabel1);
            this.flpEstudiantes.Controls.Add(this.gbDirectivos);
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
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Estudiantes";
            // 
            // errorProviderValidar
            // 
            this.errorProviderValidar.ContainerControl = this;
            // 
            // gbDirectivos
            // 
            this.gbDirectivos.Controls.Add(this.btnEliminar);
            this.gbDirectivos.Controls.Add(this.btnGuardar);
            this.gbDirectivos.Controls.Add(this.btnMod);
            this.gbDirectivos.Controls.Add(this.btnAdd);
            this.gbDirectivos.Controls.Add(this.materialLabel5);
            this.gbDirectivos.Controls.Add(this.materialLabel4);
            this.gbDirectivos.Controls.Add(this.materialLabel3);
            this.gbDirectivos.Controls.Add(this.materialLabel2);
            this.gbDirectivos.Controls.Add(this.txtContacto);
            this.gbDirectivos.Controls.Add(this.txtPass);
            this.gbDirectivos.Controls.Add(this.txtDoc);
            this.gbDirectivos.Controls.Add(this.txtNomb);
            this.gbDirectivos.Controls.Add(this.dgvEstudiantes);
            this.gbDirectivos.Location = new System.Drawing.Point(97, 3);
            this.gbDirectivos.Name = "gbDirectivos";
            this.gbDirectivos.Size = new System.Drawing.Size(825, 325);
            this.gbDirectivos.TabIndex = 4;
            this.gbDirectivos.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(652, 227);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(569, 227);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(75, 36);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.AutoSize = true;
            this.btnMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMod.Depth = 0;
            this.btnMod.Enabled = false;
            this.btnMod.Location = new System.Drawing.Point(372, 227);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMod.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMod.Name = "btnMod";
            this.btnMod.Primary = false;
            this.btnMod.Size = new System.Drawing.Size(84, 36);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Depth = 0;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(290, 227);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(74, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 195);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Contacto";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 140);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(86, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Contraseña";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 79);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(87, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Documento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 19);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Nombre";
            // 
            // txtContacto
            // 
            this.txtContacto.Depth = 0;
            this.txtContacto.Hint = "";
            this.txtContacto.Location = new System.Drawing.Point(125, 195);
            this.txtContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.PasswordChar = '\0';
            this.txtContacto.SelectedText = "";
            this.txtContacto.SelectionLength = 0;
            this.txtContacto.SelectionStart = 0;
            this.txtContacto.Size = new System.Drawing.Size(149, 23);
            this.txtContacto.TabIndex = 4;
            this.txtContacto.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "";
            this.txtPass.Location = new System.Drawing.Point(125, 140);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(149, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtDoc
            // 
            this.txtDoc.Depth = 0;
            this.txtDoc.Hint = "";
            this.txtDoc.Location = new System.Drawing.Point(125, 79);
            this.txtDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.PasswordChar = '\0';
            this.txtDoc.SelectedText = "";
            this.txtDoc.SelectionLength = 0;
            this.txtDoc.SelectionStart = 0;
            this.txtDoc.Size = new System.Drawing.Size(149, 23);
            this.txtDoc.TabIndex = 2;
            this.txtDoc.UseSystemPasswordChar = false;
            // 
            // txtNomb
            // 
            this.txtNomb.Depth = 0;
            this.txtNomb.Hint = "";
            this.txtNomb.Location = new System.Drawing.Point(125, 19);
            this.txtNomb.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.PasswordChar = '\0';
            this.txtNomb.SelectedText = "";
            this.txtNomb.SelectionLength = 0;
            this.txtNomb.SelectionStart = 0;
            this.txtNomb.Size = new System.Drawing.Size(149, 23);
            this.txtNomb.TabIndex = 1;
            this.txtNomb.UseSystemPasswordChar = false;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnId,
            this.ColumnPass,
            this.ColumnContacto});
            this.dgvEstudiantes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEstudiantes.Location = new System.Drawing.Point(290, 19);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.Size = new System.Drawing.Size(447, 199);
            this.dgvEstudiantes.TabIndex = 9;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nombre";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Documento";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnPass
            // 
            this.ColumnPass.HeaderText = "Contraseña";
            this.ColumnPass.Name = "ColumnPass";
            this.ColumnPass.ReadOnly = true;
            // 
            // ColumnContacto
            // 
            this.ColumnContacto.HeaderText = "Contacto";
            this.ColumnContacto.Name = "ColumnContacto";
            this.ColumnContacto.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidar)).EndInit();
            this.gbDirectivos.ResumeLayout(false);
            this.gbDirectivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEstudiantes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ErrorProvider errorProviderValidar;
        private System.Windows.Forms.GroupBox gbDirectivos;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnMod;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContacto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDoc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomb;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContacto;
    }
}
