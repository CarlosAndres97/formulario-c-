namespace Fase3CarlosSoriano
{
    partial class IngresoDatos
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
            panel1 = new Panel();
            label11 = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnRegisrar = new Button();
            txtReporteDatos = new TextBox();
            label10 = new Label();
            cmbTipoEstructuraDatos = new ComboBox();
            label9 = new Label();
            dtpFechaIngreso = new DateTimePicker();
            label8 = new Label();
            txtValorCopago = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            rbtnExamenLaboratorio = new RadioButton();
            rbtnMedicinaGeneral = new RadioButton();
            cmbEstrato = new ComboBox();
            label6 = new Label();
            txtEdad = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtNumeroIdentificacion = new TextBox();
            label3 = new Label();
            cmbTipoIdentificacion = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            label13 = new Label();
            tabEstructuras = new TabControl();
            tabPage1 = new TabPage();
            btnEliminarPila = new Button();
            btnReportePila = new Button();
            dgPila = new DataGridView();
            tabPage2 = new TabPage();
            btnEliminarCola = new Button();
            btnReporteCola = new Button();
            dgCola = new DataGridView();
            tabPage3 = new TabPage();
            btnEliminarLista = new Button();
            btnReporteLista = new Button();
            dgLista = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabEstructuras.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPila).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCola).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnRegisrar);
            panel1.Controls.Add(txtReporteDatos);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cmbTipoEstructuraDatos);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dtpFechaIngreso);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtValorCopago);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(cmbEstrato);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNumeroIdentificacion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbTipoIdentificacion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(50, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 304);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(403, 278);
            label11.Name = "label11";
            label11.Size = new Size(258, 15);
            label11.TabIndex = 23;
            label11.Text = "Los campos marcados con (*) son obligatorios.";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(586, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 255, 192);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(484, 235);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegisrar
            // 
            btnRegisrar.BackColor = Color.FromArgb(192, 255, 192);
            btnRegisrar.Cursor = Cursors.Hand;
            btnRegisrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisrar.Location = new Point(377, 235);
            btnRegisrar.Name = "btnRegisrar";
            btnRegisrar.Size = new Size(75, 23);
            btnRegisrar.TabIndex = 20;
            btnRegisrar.Text = "Registrar";
            btnRegisrar.UseVisualStyleBackColor = false;
            btnRegisrar.Click += btnRegisrar_Click;
            // 
            // txtReporteDatos
            // 
            txtReporteDatos.Enabled = false;
            txtReporteDatos.Location = new Point(188, 270);
            txtReporteDatos.Name = "txtReporteDatos";
            txtReporteDatos.Size = new Size(160, 23);
            txtReporteDatos.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(30, 273);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 18;
            label10.Text = "Reporte de datos:";
            // 
            // cmbTipoEstructuraDatos
            // 
            cmbTipoEstructuraDatos.FormattingEnabled = true;
            cmbTipoEstructuraDatos.Items.AddRange(new object[] { "Pila", "Cola", "Lista" });
            cmbTipoEstructuraDatos.Location = new Point(188, 230);
            cmbTipoEstructuraDatos.Name = "cmbTipoEstructuraDatos";
            cmbTipoEstructuraDatos.Size = new Size(160, 23);
            cmbTipoEstructuraDatos.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(30, 233);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 16;
            label9.Text = "* Tipo de estructura:";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(495, 186);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(166, 23);
            dtpFechaIngreso.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(365, 192);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 14;
            label8.Text = "* Fecha de acceso:";
            // 
            // txtValorCopago
            // 
            txtValorCopago.Enabled = false;
            txtValorCopago.Location = new Point(188, 184);
            txtValorCopago.Name = "txtValorCopago";
            txtValorCopago.Size = new Size(160, 23);
            txtValorCopago.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 187);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 12;
            label7.Text = "Valor del copago:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnExamenLaboratorio);
            groupBox1.Controls.Add(rbtnMedicinaGeneral);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(365, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 64);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "* Tipo de atención";
            // 
            // rbtnExamenLaboratorio
            // 
            rbtnExamenLaboratorio.AutoSize = true;
            rbtnExamenLaboratorio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnExamenLaboratorio.Location = new Point(146, 39);
            rbtnExamenLaboratorio.Name = "rbtnExamenLaboratorio";
            rbtnExamenLaboratorio.Size = new Size(144, 19);
            rbtnExamenLaboratorio.TabIndex = 1;
            rbtnExamenLaboratorio.Text = "Examen de laboratorio";
            rbtnExamenLaboratorio.UseVisualStyleBackColor = true;
            // 
            // rbtnMedicinaGeneral
            // 
            rbtnMedicinaGeneral.AutoSize = true;
            rbtnMedicinaGeneral.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnMedicinaGeneral.Location = new Point(6, 39);
            rbtnMedicinaGeneral.Name = "rbtnMedicinaGeneral";
            rbtnMedicinaGeneral.Size = new Size(116, 19);
            rbtnMedicinaGeneral.TabIndex = 0;
            rbtnMedicinaGeneral.Text = "Medicina general";
            rbtnMedicinaGeneral.UseVisualStyleBackColor = true;
            // 
            // cmbEstrato
            // 
            cmbEstrato.FormattingEnabled = true;
            cmbEstrato.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbEstrato.Location = new Point(188, 135);
            cmbEstrato.Name = "cmbEstrato";
            cmbEstrato.Size = new Size(160, 23);
            cmbEstrato.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 138);
            label6.Name = "label6";
            label6.Size = new Size(149, 15);
            label6.TabIndex = 9;
            label6.Text = "* Estrato socioeconómico:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(511, 75);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 23);
            txtEdad.TabIndex = 8;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(365, 78);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 7;
            label5.Text = "* Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(188, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 6;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 78);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 5;
            label4.Text = "* Nombre completo:";
            // 
            // txtNumeroIdentificacion
            // 
            txtNumeroIdentificacion.Location = new Point(511, 33);
            txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            txtNumeroIdentificacion.Size = new Size(150, 23);
            txtNumeroIdentificacion.TabIndex = 4;
            txtNumeroIdentificacion.KeyPress += txtNumeroIdentificacion_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(365, 39);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 3;
            label3.Text = "* N° de identificación:";
            // 
            // cmbTipoIdentificacion
            // 
            cmbTipoIdentificacion.FormattingEnabled = true;
            cmbTipoIdentificacion.Items.AddRange(new object[] { "CC", "CE", "NUIP", "PAS" });
            cmbTipoIdentificacion.Location = new Point(188, 33);
            cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
            cmbTipoIdentificacion.Size = new Size(160, 23);
            cmbTipoIdentificacion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 36);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 1;
            label2.Text = "* Tipo de identificación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos del usuario";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(154, 9);
            label12.Name = "label12";
            label12.Size = new Size(383, 21);
            label12.TabIndex = 2;
            label12.Text = "SISTEMA DE REGISTRO DE USUARIOS EN CENTRO";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(266, 41);
            label13.Name = "label13";
            label13.Size = new Size(126, 17);
            label13.TabIndex = 3;
            label13.Text = "EPS Salvando vidas";
            // 
            // tabEstructuras
            // 
            tabEstructuras.Controls.Add(tabPage1);
            tabEstructuras.Controls.Add(tabPage2);
            tabEstructuras.Controls.Add(tabPage3);
            tabEstructuras.Location = new Point(50, 383);
            tabEstructuras.Name = "tabEstructuras";
            tabEstructuras.SelectedIndex = 0;
            tabEstructuras.Size = new Size(680, 126);
            tabEstructuras.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEliminarPila);
            tabPage1.Controls.Add(btnReportePila);
            tabPage1.Controls.Add(dgPila);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(672, 98);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pila";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPila
            // 
            btnEliminarPila.Location = new Point(591, 43);
            btnEliminarPila.Name = "btnEliminarPila";
            btnEliminarPila.Size = new Size(75, 23);
            btnEliminarPila.TabIndex = 2;
            btnEliminarPila.Text = "Eliminar";
            btnEliminarPila.UseVisualStyleBackColor = true;
            btnEliminarPila.Click += btnEliminarPila_Click;
            // 
            // btnReportePila
            // 
            btnReportePila.Location = new Point(591, 6);
            btnReportePila.Name = "btnReportePila";
            btnReportePila.Size = new Size(75, 23);
            btnReportePila.TabIndex = 1;
            btnReportePila.Text = "Reporte";
            btnReportePila.UseVisualStyleBackColor = true;
            btnReportePila.Click += btnReportePila_Click;
            // 
            // dgPila
            // 
            dgPila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPila.Location = new Point(0, 0);
            dgPila.Name = "dgPila";
            dgPila.RowTemplate.Height = 25;
            dgPila.Size = new Size(585, 98);
            dgPila.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEliminarCola);
            tabPage2.Controls.Add(btnReporteCola);
            tabPage2.Controls.Add(dgCola);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(672, 98);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cola";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCola
            // 
            btnEliminarCola.Location = new Point(594, 43);
            btnEliminarCola.Name = "btnEliminarCola";
            btnEliminarCola.Size = new Size(75, 23);
            btnEliminarCola.TabIndex = 5;
            btnEliminarCola.Text = "Eliminar";
            btnEliminarCola.UseVisualStyleBackColor = true;
            btnEliminarCola.Click += btnEliminarCola_Click;
            // 
            // btnReporteCola
            // 
            btnReporteCola.Location = new Point(594, 6);
            btnReporteCola.Name = "btnReporteCola";
            btnReporteCola.Size = new Size(75, 23);
            btnReporteCola.TabIndex = 4;
            btnReporteCola.Text = "Reporte";
            btnReporteCola.UseVisualStyleBackColor = true;
            btnReporteCola.Click += btnReporteCola_Click;
            // 
            // dgCola
            // 
            dgCola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCola.Location = new Point(3, 0);
            dgCola.Name = "dgCola";
            dgCola.RowTemplate.Height = 25;
            dgCola.Size = new Size(585, 95);
            dgCola.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnEliminarLista);
            tabPage3.Controls.Add(btnReporteLista);
            tabPage3.Controls.Add(dgLista);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(672, 98);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lista";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLista
            // 
            btnEliminarLista.Location = new Point(594, 43);
            btnEliminarLista.Name = "btnEliminarLista";
            btnEliminarLista.Size = new Size(75, 23);
            btnEliminarLista.TabIndex = 5;
            btnEliminarLista.Text = "Eliminar";
            btnEliminarLista.UseVisualStyleBackColor = true;
            btnEliminarLista.Click += btnEliminarLista_Click;
            // 
            // btnReporteLista
            // 
            btnReporteLista.Location = new Point(594, 6);
            btnReporteLista.Name = "btnReporteLista";
            btnReporteLista.Size = new Size(75, 23);
            btnReporteLista.TabIndex = 4;
            btnReporteLista.Text = "Reporte";
            btnReporteLista.UseVisualStyleBackColor = true;
            btnReporteLista.Click += btnReporteLista_Click;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(3, 0);
            dgLista.Name = "dgLista";
            dgLista.RowTemplate.Height = 25;
            dgLista.Size = new Size(585, 98);
            dgLista.TabIndex = 3;
            // 
            // IngresoDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(tabEstructuras);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(panel1);
            Name = "IngresoDatos";
            Text = "EstructurasDatos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabEstructuras.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPila).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCola).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox txtNumeroIdentificacion;
        private Label label3;
        private ComboBox cmbTipoIdentificacion;
        private Label label2;
        private TextBox txtEdad;
        private Label label5;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private ComboBox cmbEstrato;
        private Label label6;
        private Label label7;
        private RadioButton rbtnExamenLaboratorio;
        private RadioButton rbtnMedicinaGeneral;
        private DateTimePicker dtpFechaIngreso;
        private Label label8;
        private TextBox txtValorCopago;
        private Label label10;
        private ComboBox cmbTipoEstructuraDatos;
        private Label label9;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnRegisrar;
        private TextBox txtReporteDatos;
        private Label label11;
        private Label label12;
        private Label label13;
        private TabControl tabEstructuras;
        private TabPage tabPage1;
        private Button btnEliminarPila;
        private Button btnReportePila;
        private DataGridView dgPila;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnEliminarCola;
        private Button btnReporteCola;
        private DataGridView dgCola;
        private Button btnEliminarLista;
        private Button btnReporteLista;
        private DataGridView dgLista;
    }
}