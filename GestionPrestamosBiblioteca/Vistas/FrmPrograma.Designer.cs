namespace GestionPrestamosBiblioteca.Vistas
{
    partial class FrmPrograma
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
            this.cmbPrestamoLibros = new System.Windows.Forms.ComboBox();
            this.cmbPrestamoUsuarios = new System.Windows.Forms.ComboBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.btnLimpiarLibro = new System.Windows.Forms.Button();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.btnPrestamoDevolver = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPrestamoFecha = new System.Windows.Forms.DateTimePicker();
            this.btnPrestamoRegistrar = new System.Windows.Forms.Button();
            this.txtIsbnLibro = new System.Windows.Forms.TextBox();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.txtFechaLibro = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombresUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnInsertarLibro = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.cmbPrestamoLibros);
            this.panel1.Controls.Add(this.cmbPrestamoUsuarios);
            this.panel1.Controls.Add(this.lstPrestamos);
            this.panel1.Controls.Add(this.btnLimpiarLibro);
            this.panel1.Controls.Add(this.btnLimpiarUsuario);
            this.panel1.Controls.Add(this.btnPrestamoDevolver);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtpPrestamoFecha);
            this.panel1.Controls.Add(this.btnPrestamoRegistrar);
            this.panel1.Controls.Add(this.txtIsbnLibro);
            this.panel1.Controls.Add(this.txtAutorLibro);
            this.panel1.Controls.Add(this.txtFechaLibro);
            this.panel1.Controls.Add(this.txtTituloLibro);
            this.panel1.Controls.Add(this.btnEliminarUsuario);
            this.panel1.Controls.Add(this.btnInsertarUsuario);
            this.panel1.Controls.Add(this.txtDireccionUsuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNombresUsuario);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminarLibro);
            this.panel1.Controls.Add(this.btnInsertarLibro);
            this.panel1.Controls.Add(this.lstUsuarios);
            this.panel1.Controls.Add(this.lstLibros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 649);
            this.panel1.TabIndex = 0;
            // 
            // cmbPrestamoLibros
            // 
            this.cmbPrestamoLibros.FormattingEnabled = true;
            this.cmbPrestamoLibros.Location = new System.Drawing.Point(775, 394);
            this.cmbPrestamoLibros.Name = "cmbPrestamoLibros";
            this.cmbPrestamoLibros.Size = new System.Drawing.Size(127, 29);
            this.cmbPrestamoLibros.TabIndex = 35;
            // 
            // cmbPrestamoUsuarios
            // 
            this.cmbPrestamoUsuarios.FormattingEnabled = true;
            this.cmbPrestamoUsuarios.Location = new System.Drawing.Point(775, 359);
            this.cmbPrestamoUsuarios.Name = "cmbPrestamoUsuarios";
            this.cmbPrestamoUsuarios.Size = new System.Drawing.Size(127, 29);
            this.cmbPrestamoUsuarios.TabIndex = 34;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.HorizontalScrollbar = true;
            this.lstPrestamos.ItemHeight = 21;
            this.lstPrestamos.Location = new System.Drawing.Point(775, 44);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.ScrollAlwaysVisible = true;
            this.lstPrestamos.Size = new System.Drawing.Size(292, 235);
            this.lstPrestamos.TabIndex = 33;
            // 
            // btnLimpiarLibro
            // 
            this.btnLimpiarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnLimpiarLibro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLibro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarLibro.Location = new System.Drawing.Point(60, 413);
            this.btnLimpiarLibro.Name = "btnLimpiarLibro";
            this.btnLimpiarLibro.Size = new System.Drawing.Size(63, 34);
            this.btnLimpiarLibro.TabIndex = 32;
            this.btnLimpiarLibro.Text = "Limpiar";
            this.btnLimpiarLibro.UseVisualStyleBackColor = false;
            this.btnLimpiarLibro.Click += new System.EventHandler(this.btnLimpiarLibro_Click);
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnLimpiarUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(420, 359);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(63, 34);
            this.btnLimpiarUsuario.TabIndex = 31;
            this.btnLimpiarUsuario.Text = "Limpiar";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = false;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
            // 
            // btnPrestamoDevolver
            // 
            this.btnPrestamoDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnPrestamoDevolver.ForeColor = System.Drawing.Color.White;
            this.btnPrestamoDevolver.Location = new System.Drawing.Point(889, 469);
            this.btnPrestamoDevolver.Name = "btnPrestamoDevolver";
            this.btnPrestamoDevolver.Size = new System.Drawing.Size(108, 37);
            this.btnPrestamoDevolver.TabIndex = 30;
            this.btnPrestamoDevolver.Text = "devolver";
            this.btnPrestamoDevolver.UseVisualStyleBackColor = false;
            this.btnPrestamoDevolver.Click += new System.EventHandler(this.btnPrestamoDevolver_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(771, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Fecha del préstamo";
            // 
            // dtpPrestamoFecha
            // 
            this.dtpPrestamoFecha.Location = new System.Drawing.Point(775, 318);
            this.dtpPrestamoFecha.Name = "dtpPrestamoFecha";
            this.dtpPrestamoFecha.Size = new System.Drawing.Size(292, 28);
            this.dtpPrestamoFecha.TabIndex = 28;
            // 
            // btnPrestamoRegistrar
            // 
            this.btnPrestamoRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnPrestamoRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnPrestamoRegistrar.Location = new System.Drawing.Point(775, 469);
            this.btnPrestamoRegistrar.Name = "btnPrestamoRegistrar";
            this.btnPrestamoRegistrar.Size = new System.Drawing.Size(108, 37);
            this.btnPrestamoRegistrar.TabIndex = 27;
            this.btnPrestamoRegistrar.Text = "Prestar";
            this.btnPrestamoRegistrar.UseVisualStyleBackColor = false;
            this.btnPrestamoRegistrar.Click += new System.EventHandler(this.btnPrestamoRegistrar_Click);
            // 
            // txtIsbnLibro
            // 
            this.txtIsbnLibro.Location = new System.Drawing.Point(142, 386);
            this.txtIsbnLibro.MaxLength = 13;
            this.txtIsbnLibro.Name = "txtIsbnLibro";
            this.txtIsbnLibro.Size = new System.Drawing.Size(210, 28);
            this.txtIsbnLibro.TabIndex = 26;
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(142, 354);
            this.txtAutorLibro.MaxLength = 30;
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(210, 28);
            this.txtAutorLibro.TabIndex = 25;
            // 
            // txtFechaLibro
            // 
            this.txtFechaLibro.Location = new System.Drawing.Point(142, 322);
            this.txtFechaLibro.MaxLength = 6;
            this.txtFechaLibro.Name = "txtFechaLibro";
            this.txtFechaLibro.Size = new System.Drawing.Size(210, 28);
            this.txtFechaLibro.TabIndex = 24;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(142, 290);
            this.txtTituloLibro.MaxLength = 50;
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(210, 28);
            this.txtTituloLibro.TabIndex = 23;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(535, 469);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(108, 37);
            this.btnEliminarUsuario.TabIndex = 22;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnInsertarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnInsertarUsuario.Location = new System.Drawing.Point(421, 469);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(108, 37);
            this.btnInsertarUsuario.TabIndex = 21;
            this.btnInsertarUsuario.Text = "Insertar";
            this.btnInsertarUsuario.UseVisualStyleBackColor = false;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(502, 325);
            this.txtDireccionUsuario.MaxLength = 100;
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(210, 28);
            this.txtDireccionUsuario.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Dirección";
            // 
            // txtNombresUsuario
            // 
            this.txtNombresUsuario.Location = new System.Drawing.Point(502, 291);
            this.txtNombresUsuario.MaxLength = 50;
            this.txtNombresUsuario.Name = "txtNombresUsuario";
            this.txtNombresUsuario.Size = new System.Drawing.Size(210, 28);
            this.txtNombresUsuario.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Historial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Libros disponibles";
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnEliminarLibro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLibro.Location = new System.Drawing.Point(174, 469);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(108, 37);
            this.btnEliminarLibro.TabIndex = 4;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnInsertarLibro
            // 
            this.btnInsertarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnInsertarLibro.ForeColor = System.Drawing.Color.White;
            this.btnInsertarLibro.Location = new System.Drawing.Point(60, 469);
            this.btnInsertarLibro.Name = "btnInsertarLibro";
            this.btnInsertarLibro.Size = new System.Drawing.Size(108, 37);
            this.btnInsertarLibro.TabIndex = 3;
            this.btnInsertarLibro.Text = "Insertar";
            this.btnInsertarLibro.UseVisualStyleBackColor = false;
            this.btnInsertarLibro.Click += new System.EventHandler(this.btnInsertarLibro_Click);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.HorizontalScrollbar = true;
            this.lstUsuarios.ItemHeight = 21;
            this.lstUsuarios.Location = new System.Drawing.Point(420, 44);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.ScrollAlwaysVisible = true;
            this.lstUsuarios.Size = new System.Drawing.Size(292, 235);
            this.lstUsuarios.TabIndex = 1;
            this.lstUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstUsuarios_SelectedIndexChanged);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.HorizontalScrollbar = true;
            this.lstLibros.ItemHeight = 21;
            this.lstLibros.Location = new System.Drawing.Point(60, 44);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.ScrollAlwaysVisible = true;
            this.lstLibros.Size = new System.Drawing.Size(292, 235);
            this.lstLibros.TabIndex = 0;
            this.lstLibros.SelectedIndexChanged += new System.EventHandler(this.lstLibros_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(982, 600);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 37);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(844, 600);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(123, 37);
            this.btnInfo.TabIndex = 37;
            this.btnInfo.Text = "Información";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1120, 649);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración Biblioteca";
            this.Activated += new System.EventHandler(this.FrmPrograma_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnInsertarLibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombresUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.TextBox txtIsbnLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.DateTimePicker dtpPrestamoFecha;
        private System.Windows.Forms.Button btnPrestamoRegistrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrestamoDevolver;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.Button btnLimpiarLibro;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.ComboBox cmbPrestamoLibros;
        private System.Windows.Forms.ComboBox cmbPrestamoUsuarios;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSalir;
    }
}