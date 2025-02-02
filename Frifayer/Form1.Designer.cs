namespace Frifayer
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
            lbl_Olvidarcontraseña = new Label();
            tb_Correo = new TextBox();
            tb_Contraseña = new TextBox();
            btn_Iniciarsesion = new Button();
            lbl_Iniciodesesion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            bt_interfaz = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Olvidarcontraseña
            // 
            lbl_Olvidarcontraseña.AutoSize = true;
            lbl_Olvidarcontraseña.Font = new Font("Century Gothic", 9.75F);
            lbl_Olvidarcontraseña.Location = new Point(349, 219);
            lbl_Olvidarcontraseña.Name = "lbl_Olvidarcontraseña";
            lbl_Olvidarcontraseña.Size = new Size(179, 17);
            lbl_Olvidarcontraseña.TabIndex = 0;
            lbl_Olvidarcontraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // tb_Correo
            // 
            tb_Correo.BorderStyle = BorderStyle.None;
            tb_Correo.Font = new Font("Century Gothic", 9.75F);
            tb_Correo.ForeColor = Color.Gray;
            tb_Correo.Location = new Point(388, 89);
            tb_Correo.Name = "tb_Correo";
            tb_Correo.Size = new Size(350, 16);
            tb_Correo.TabIndex = 1;
            tb_Correo.Text = "Correo";
            tb_Correo.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_Contraseña
            // 
            tb_Contraseña.BorderStyle = BorderStyle.None;
            tb_Contraseña.Font = new Font("Century Gothic", 9.75F);
            tb_Contraseña.ForeColor = Color.Gray;
            tb_Contraseña.Location = new Point(388, 140);
            tb_Contraseña.Name = "tb_Contraseña";
            tb_Contraseña.Size = new Size(350, 16);
            tb_Contraseña.TabIndex = 2;
            tb_Contraseña.Text = "Contraseña";
            tb_Contraseña.TextAlign = HorizontalAlignment.Center;
            tb_Contraseña.TextChanged += tb_Contraseña_TextChanged;
            // 
            // btn_Iniciarsesion
            // 
            btn_Iniciarsesion.BackColor = Color.Pink;
            btn_Iniciarsesion.FlatStyle = FlatStyle.Flat;
            btn_Iniciarsesion.Font = new Font("Century Gothic", 9.75F);
            btn_Iniciarsesion.Location = new Point(567, 213);
            btn_Iniciarsesion.Name = "btn_Iniciarsesion";
            btn_Iniciarsesion.Size = new Size(171, 28);
            btn_Iniciarsesion.TabIndex = 3;
            btn_Iniciarsesion.Text = "Iniciar sesión";
            btn_Iniciarsesion.UseVisualStyleBackColor = false;
            // 
            // lbl_Iniciodesesion
            // 
            lbl_Iniciodesesion.AutoSize = true;
            lbl_Iniciodesesion.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Iniciodesesion.Location = new Point(473, 9);
            lbl_Iniciodesesion.Name = "lbl_Iniciodesesion";
            lbl_Iniciodesesion.Size = new Size(163, 23);
            lbl_Iniciodesesion.TabIndex = 5;
            lbl_Iniciodesesion.Text = "Inicio de sesión";
            lbl_Iniciodesesion.Click += lbl_Iniciodesesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.icone_de_cadenas_de_securite_gris;
            pictureBox1.Location = new Point(356, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(356, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(bt_interfaz);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 450);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(349, 106);
            label1.Name = "label1";
            label1.Size = new Size(392, 15);
            label1.TabIndex = 9;
            label1.Text = "_____________________________________________________________________________";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(349, 157);
            label2.Name = "label2";
            label2.Size = new Size(392, 15);
            label2.TabIndex = 10;
            label2.Text = "_____________________________________________________________________________";
            // 
            // bt_interfaz
            // 
            bt_interfaz.BackColor = Color.Pink;
            bt_interfaz.FlatStyle = FlatStyle.Flat;
            bt_interfaz.Font = new Font("Century Gothic", 9.75F);
            bt_interfaz.Location = new Point(209, 128);
            bt_interfaz.Name = "bt_interfaz";
            bt_interfaz.Size = new Size(74, 28);
            bt_interfaz.TabIndex = 11;
            bt_interfaz.Text = "Login";
            bt_interfaz.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Iniciodesesion);
            Controls.Add(btn_Iniciarsesion);
            Controls.Add(tb_Contraseña);
            Controls.Add(tb_Correo);
            Controls.Add(lbl_Olvidarcontraseña);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Olvidarcontraseña;
        private TextBox tb_Correo;
        private TextBox tb_Contraseña;
        private Button btn_Iniciarsesion;
        private Label lbl_Iniciodesesion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button bt_interfaz;
    }
}
