namespace Practico_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRut = new Label();
            txtNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            textRut = new TextBox();
            textNombre = new TextBox();
            textTlf = new TextBox();
            textDir = new TextBox();
            textFecha = new TextBox();
            textCantF = new TextBox();
            textNumeroUF = new TextBox();
            textMontoUF = new TextBox();
            cmbEmpresa = new ComboBox();
            dataGCliente = new DataGridView();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label8 = new Label();
            btnFactura = new Button();
            btnGuardarF = new Button();
            btnSalir = new Button();
            luf = new Label();
            ldr = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGCliente).BeginInit();
            SuspendLayout();
            // 
            // txtRut
            // 
            txtRut.AutoSize = true;
            txtRut.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRut.Location = new Point(27, 58);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(39, 26);
            txtRut.TabIndex = 0;
            txtRut.Text = "Rut";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(27, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(72, 26);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 116);
            label2.Name = "label2";
            label2.Size = new Size(94, 26);
            label2.TabIndex = 0;
            label2.Text = "EsEmpresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 147);
            label3.Name = "label3";
            label3.Size = new Size(74, 26);
            label3.TabIndex = 0;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 175);
            label4.Name = "label4";
            label4.Size = new Size(82, 26);
            label4.TabIndex = 0;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 202);
            label5.Name = "label5";
            label5.Size = new Size(116, 26);
            label5.TabIndex = 0;
            label5.Text = "FechaRegistro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 231);
            label6.Name = "label6";
            label6.Size = new Size(129, 23);
            label6.TabIndex = 0;
            label6.Text = "CantidadFacturas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 260);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "NumeroUltFactura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 288);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 0;
            label7.Text = "MontoUltimaFactura";
            // 
            // textRut
            // 
            textRut.Location = new Point(176, 58);
            textRut.Name = "textRut";
            textRut.Size = new Size(147, 23);
            textRut.TabIndex = 1;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(176, 87);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(147, 23);
            textNombre.TabIndex = 1;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // textTlf
            // 
            textTlf.Location = new Point(176, 147);
            textTlf.Name = "textTlf";
            textTlf.Size = new Size(147, 23);
            textTlf.TabIndex = 1;
            textTlf.KeyPress += textTlf_KeyPress;
            // 
            // textDir
            // 
            textDir.Location = new Point(176, 175);
            textDir.Name = "textDir";
            textDir.Size = new Size(147, 23);
            textDir.TabIndex = 1;
            // 
            // textFecha
            // 
            textFecha.Location = new Point(176, 202);
            textFecha.Name = "textFecha";
            textFecha.Size = new Size(147, 23);
            textFecha.TabIndex = 1;
            // 
            // textCantF
            // 
            textCantF.Location = new Point(176, 231);
            textCantF.Name = "textCantF";
            textCantF.Size = new Size(147, 23);
            textCantF.TabIndex = 1;
            textCantF.KeyPress += textCantF_KeyPress;
            // 
            // textNumeroUF
            // 
            textNumeroUF.Location = new Point(176, 260);
            textNumeroUF.Name = "textNumeroUF";
            textNumeroUF.Size = new Size(147, 23);
            textNumeroUF.TabIndex = 1;
            textNumeroUF.KeyPress += textNumeroUF_KeyPress;
            // 
            // textMontoUF
            // 
            textMontoUF.Location = new Point(176, 288);
            textMontoUF.Name = "textMontoUF";
            textMontoUF.Size = new Size(147, 23);
            textMontoUF.TabIndex = 1;
            textMontoUF.KeyPress += textMontoUF_KeyPress;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.IntegralHeight = false;
            cmbEmpresa.Items.AddRange(new object[] { "SI", "NO" });
            cmbEmpresa.Location = new Point(176, 116);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(147, 23);
            cmbEmpresa.TabIndex = 2;
            cmbEmpresa.Text = "Seleccione una opción";
            // 
            // dataGCliente
            // 
            dataGCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGCliente.Location = new Point(349, 41);
            dataGCliente.Name = "dataGCliente";
            dataGCliente.RowTemplate.Height = 25;
            dataGCliente.Size = new Size(439, 279);
            dataGCliente.TabIndex = 3;
            dataGCliente.SelectionChanged += dataGCliente_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Highlight;
            btnAgregar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(322, 326);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(608, 326);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 29);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.Highlight;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(408, 326);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 29);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(509, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Highlight;
            label8.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(27, 7);
            label8.Name = "label8";
            label8.Size = new Size(134, 33);
            label8.TabIndex = 5;
            label8.Text = "CLIENTES";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnFactura
            // 
            btnFactura.Enabled = false;
            btnFactura.Location = new Point(425, 371);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(99, 27);
            btnFactura.TabIndex = 6;
            btnFactura.Text = "Ingreso Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnGuardarF
            // 
            btnGuardarF.Enabled = false;
            btnGuardarF.Location = new Point(557, 371);
            btnGuardarF.Name = "btnGuardarF";
            btnGuardarF.Size = new Size(110, 27);
            btnGuardarF.TabIndex = 7;
            btnGuardarF.Text = "Guardar Factura";
            btnGuardarF.UseVisualStyleBackColor = true;
            btnGuardarF.Click += btnGuardarF_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Highlight;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(699, 326);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // luf
            // 
            luf.AutoSize = true;
            luf.Location = new Point(406, 13);
            luf.Name = "luf";
            luf.Size = new Size(0, 15);
            luf.TabIndex = 9;
            // 
            // ldr
            // 
            ldr.AutoSize = true;
            ldr.Location = new Point(571, 13);
            ldr.Name = "ldr";
            ldr.Size = new Size(0, 15);
            ldr.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(322, 8);
            label9.Name = "label9";
            label9.Size = new Size(78, 21);
            label9.TabIndex = 11;
            label9.Text = "Valor UF:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(487, 7);
            label10.Name = "label10";
            label10.Size = new Size(67, 21);
            label10.TabIndex = 11;
            label10.Text = "Valor $:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(ldr);
            Controls.Add(luf);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardarF);
            Controls.Add(btnFactura);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGCliente);
            Controls.Add(cmbEmpresa);
            Controls.Add(textMontoUF);
            Controls.Add(textNumeroUF);
            Controls.Add(textCantF);
            Controls.Add(textFecha);
            Controls.Add(textDir);
            Controls.Add(textTlf);
            Controls.Add(textNombre);
            Controls.Add(textRut);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtRut;
        private Label txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label7;
        private TextBox textRut;
        private TextBox textNombre;
        private TextBox textTlf;
        private TextBox textDir;
        private TextBox textFecha;
        private TextBox textCantF;
        private TextBox textNumeroUF;
        private TextBox textMontoUF;
        private ComboBox cmbEmpresa;
        private DataGridView dataGCliente;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label8;
        private Button btnFactura;
        private Button btnGuardarF;
        private Button btnSalir;
        private Label luf;
        private Label ldr;
        private Label label9;
        private Label label10;
    }
}