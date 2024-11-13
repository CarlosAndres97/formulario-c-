namespace Fase3CarlosSoriano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            txtClave = new TextBox();
            menuStrip1 = new MenuStrip();
            itemMenuIniciarSesion = new ToolStripMenuItem();
            itemMenuAcercaDe = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(399, 62);
            label1.Name = "label1";
            label1.Size = new Size(358, 21);
            label1.TabIndex = 1;
            label1.Text = "SISTEMA DE REGISTRO USUARIOS EN CENTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(502, 171);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "EPS Salvando Vidas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(461, 262);
            label3.Name = "label3";
            label3.Size = new Size(200, 15);
            label3.TabIndex = 3;
            label3.Text = "Digita la contraseña para el ingreso";
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Enabled = false;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(461, 336);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(577, 336);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtClave
            // 
            txtClave.Enabled = false;
            txtClave.Location = new Point(461, 284);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(191, 23);
            txtClave.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemMenuIniciarSesion, itemMenuAcercaDe });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemMenuIniciarSesion
            // 
            itemMenuIniciarSesion.Name = "itemMenuIniciarSesion";
            itemMenuIniciarSesion.Size = new Size(88, 20);
            itemMenuIniciarSesion.Text = "Iniciar Sesion";
            itemMenuIniciarSesion.Click += itemMenuIniciarSesion_Click;
            // 
            // itemMenuAcercaDe
            // 
            itemMenuAcercaDe.Name = "itemMenuAcercaDe";
            itemMenuAcercaDe.Size = new Size(71, 20);
            itemMenuAcercaDe.Text = "Acerca de";
            itemMenuAcercaDe.Click += itemMenuAcercaDe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtClave);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private Button btnSalir;
        private TextBox txtClave;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemMenuIniciarSesion;
        private ToolStripMenuItem itemMenuAcercaDe;
    }
}
