namespace Ejercicio3
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
            components = new System.ComponentModel.Container();
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            dgvIntentos = new DataGridView();
            btnRegistrar = new Button();
            btnLogin = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvIntentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 119);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(12, 182);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(86, 20);
            lblClave.TabIndex = 1;
            lblClave.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 142);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(120, 26);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 205);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(120, 26);
            txtClave.TabIndex = 3;
            txtClave.UseSystemPasswordChar = true;
            // 
            // dgvIntentos
            // 
            dgvIntentos.AllowUserToAddRows = false;
            dgvIntentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIntentos.Location = new Point(200, 165);
            dgvIntentos.Name = "dgvIntentos";
            dgvIntentos.ReadOnly = true;
            dgvIntentos.RowHeadersWidth = 49;
            dgvIntentos.Size = new Size(394, 166);
            dgvIntentos.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 267);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(90, 28);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Location = new Point(12, 301);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 30);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(200, 132);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 33);
            label1.Name = "label1";
            label1.Size = new Size(125, 40);
            label1.TabIndex = 8;
            label1.Text = "PORTAL";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 109);
            panel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 357);
            Controls.Add(lblResultado);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistrar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(dgvIntentos);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvIntentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private DataGridView dgvIntentos;
        private Button btnRegistrar;
        private Button btnLogin;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Label label1;
    }
}
