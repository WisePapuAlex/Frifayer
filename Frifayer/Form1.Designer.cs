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
            pnl_Principal = new Panel();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            cb_EstadoDeCuenta = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            cb_Rol = new ComboBox();
            label7 = new Label();
            tb_Usuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Registrarse = new Button();
            tb_ContraseñaRegistro = new TextBox();
            tb_NombreCompleto = new TextBox();
            pnl_central = new Panel();
            pnl_3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Iniciodesesion = new Label();
            btn_Iniciarsesion = new Button();
            tb_Contraseña = new TextBox();
            tb_Correo = new TextBox();
            lbl_Olvidarcontraseña = new Label();
            pnl_2 = new Panel();
            bt_interfaz = new Button();
            pictureBox3 = new PictureBox();
            pnl_Principal.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnl_central.SuspendLayout();
            pnl_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pnl_Principal
            // 
            pnl_Principal.BackgroundImage = Properties.Resources.pexels_codioful_6985001;
            pnl_Principal.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Principal.Controls.Add(panel1);
            pnl_Principal.Controls.Add(pnl_central);
            pnl_Principal.Controls.Add(pictureBox3);
            pnl_Principal.Dock = DockStyle.Fill;
            pnl_Principal.Location = new Point(0, 0);
            pnl_Principal.Name = "pnl_Principal";
            pnl_Principal.Size = new Size(800, 450);
            pnl_Principal.TabIndex = 0;
            pnl_Principal.Paint += pnl_Principal_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(cb_EstadoDeCuenta);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cb_Rol);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tb_Usuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_Registrarse);
            panel1.Controls.Add(tb_ContraseñaRegistro);
            panel1.Controls.Add(tb_NombreCompleto);
            panel1.Location = new Point(775, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 370);
            panel1.TabIndex = 30;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.my_password;
            pictureBox6.Location = new Point(23, 185);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.fi_cnluxx_user_circle_solid;
            pictureBox5.Location = new Point(23, 135);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 37;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.OIP;
            pictureBox4.Location = new Point(16, 72);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // cb_EstadoDeCuenta
            // 
            cb_EstadoDeCuenta.FormattingEnabled = true;
            cb_EstadoDeCuenta.Location = new Point(237, 275);
            cb_EstadoDeCuenta.Name = "cb_EstadoDeCuenta";
            cb_EstadoDeCuenta.Size = new Size(134, 23);
            cb_EstadoDeCuenta.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(247, 243);
            label8.Name = "label8";
            label8.Size = new Size(112, 16);
            label8.TabIndex = 34;
            label8.Text = "Estado de cuenta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(74, 243);
            label6.Name = "label6";
            label6.Size = new Size(28, 16);
            label6.TabIndex = 33;
            label6.Text = "Rol";
            // 
            // cb_Rol
            // 
            cb_Rol.FormattingEnabled = true;
            cb_Rol.Location = new Point(33, 276);
            cb_Rol.Name = "cb_Rol";
            cb_Rol.Size = new Size(121, 23);
            cb_Rol.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(23, 160);
            label7.Name = "label7";
            label7.Size = new Size(392, 15);
            label7.TabIndex = 31;
            label7.Text = "_____________________________________________________________________________";
            // 
            // tb_Usuario
            // 
            tb_Usuario.BorderStyle = BorderStyle.None;
            tb_Usuario.Font = new Font("Microsoft Sans Serif", 9.75F);
            tb_Usuario.ForeColor = Color.Gray;
            tb_Usuario.Location = new Point(43, 142);
            tb_Usuario.Name = "tb_Usuario";
            tb_Usuario.Size = new Size(350, 15);
            tb_Usuario.TabIndex = 30;
            tb_Usuario.Text = "Usuario";
            tb_Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(16, 214);
            label3.Name = "label3";
            label3.Size = new Size(392, 15);
            label3.TabIndex = 29;
            label3.Text = "_____________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(16, 106);
            label4.Name = "label4";
            label4.Size = new Size(392, 15);
            label4.TabIndex = 28;
            label4.Text = "_____________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(150, 23);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 25;
            label5.Text = "Registrarse";
            // 
            // btn_Registrarse
            // 
            btn_Registrarse.BackColor = Color.Pink;
            btn_Registrarse.FlatStyle = FlatStyle.Flat;
            btn_Registrarse.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_Registrarse.ForeColor = Color.Black;
            btn_Registrarse.Location = new Point(121, 325);
            btn_Registrarse.Name = "btn_Registrarse";
            btn_Registrarse.Size = new Size(171, 28);
            btn_Registrarse.TabIndex = 24;
            btn_Registrarse.Text = "Registrarse";
            btn_Registrarse.UseVisualStyleBackColor = false;
            // 
            // tb_ContraseñaRegistro
            // 
            tb_ContraseñaRegistro.BorderStyle = BorderStyle.None;
            tb_ContraseñaRegistro.Font = new Font("Microsoft Sans Serif", 9.75F);
            tb_ContraseñaRegistro.ForeColor = Color.Gray;
            tb_ContraseñaRegistro.Location = new Point(43, 196);
            tb_ContraseñaRegistro.Name = "tb_ContraseñaRegistro";
            tb_ContraseñaRegistro.Size = new Size(350, 15);
            tb_ContraseñaRegistro.TabIndex = 23;
            tb_ContraseñaRegistro.Text = "Contraseña";
            tb_ContraseñaRegistro.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_NombreCompleto
            // 
            tb_NombreCompleto.BorderStyle = BorderStyle.None;
            tb_NombreCompleto.Font = new Font("Microsoft Sans Serif", 9.75F);
            tb_NombreCompleto.ForeColor = Color.Gray;
            tb_NombreCompleto.Location = new Point(43, 88);
            tb_NombreCompleto.Name = "tb_NombreCompleto";
            tb_NombreCompleto.Size = new Size(350, 15);
            tb_NombreCompleto.TabIndex = 22;
            tb_NombreCompleto.Text = "Nombre completo";
            tb_NombreCompleto.TextAlign = HorizontalAlignment.Center;
            // 
            // pnl_central
            // 
            pnl_central.BackColor = Color.White;
            pnl_central.Controls.Add(pnl_3);
            pnl_central.Controls.Add(pnl_2);
            pnl_central.Location = new Point(43, 40);
            pnl_central.Name = "pnl_central";
            pnl_central.Size = new Size(708, 370);
            pnl_central.TabIndex = 30;
            // 
            // pnl_3
            // 
            pnl_3.BackColor = Color.White;
            pnl_3.Controls.Add(label2);
            pnl_3.Controls.Add(label1);
            pnl_3.Controls.Add(pictureBox2);
            pnl_3.Controls.Add(pictureBox1);
            pnl_3.Controls.Add(lbl_Iniciodesesion);
            pnl_3.Controls.Add(btn_Iniciarsesion);
            pnl_3.Controls.Add(tb_Contraseña);
            pnl_3.Controls.Add(tb_Correo);
            pnl_3.Controls.Add(lbl_Olvidarcontraseña);
            pnl_3.Location = new Point(283, 0);
            pnl_3.Name = "pnl_3";
            pnl_3.Size = new Size(425, 370);
            pnl_3.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(16, 217);
            label2.Name = "label2";
            label2.Size = new Size(392, 15);
            label2.TabIndex = 29;
            label2.Text = "_____________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(16, 166);
            label1.Name = "label1";
            label1.Size = new Size(392, 15);
            label1.TabIndex = 28;
            label1.Text = "_____________________________________________________________________________";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 142);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.icone_de_cadenas_de_securite_gris;
            pictureBox1.Location = new Point(23, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // lbl_Iniciodesesion
            // 
            lbl_Iniciodesesion.AutoSize = true;
            lbl_Iniciodesesion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Iniciodesesion.ForeColor = Color.DimGray;
            lbl_Iniciodesesion.Location = new Point(139, 85);
            lbl_Iniciodesesion.Name = "lbl_Iniciodesesion";
            lbl_Iniciodesesion.Size = new Size(157, 24);
            lbl_Iniciodesesion.TabIndex = 25;
            lbl_Iniciodesesion.Text = "Inicio de sesión";
            // 
            // btn_Iniciarsesion
            // 
            btn_Iniciarsesion.BackColor = Color.Pink;
            btn_Iniciarsesion.FlatStyle = FlatStyle.Flat;
            btn_Iniciarsesion.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_Iniciarsesion.ForeColor = Color.Black;
            btn_Iniciarsesion.Location = new Point(234, 273);
            btn_Iniciarsesion.Name = "btn_Iniciarsesion";
            btn_Iniciarsesion.Size = new Size(171, 28);
            btn_Iniciarsesion.TabIndex = 24;
            btn_Iniciarsesion.Text = "Iniciar sesión";
            btn_Iniciarsesion.UseVisualStyleBackColor = false;
            // 
            // tb_Contraseña
            // 
            tb_Contraseña.BorderStyle = BorderStyle.None;
            tb_Contraseña.Font = new Font("Microsoft Sans Serif", 9.75F);
            tb_Contraseña.ForeColor = Color.Gray;
            tb_Contraseña.Location = new Point(55, 200);
            tb_Contraseña.Name = "tb_Contraseña";
            tb_Contraseña.Size = new Size(350, 15);
            tb_Contraseña.TabIndex = 23;
            tb_Contraseña.Text = "Contraseña";
            tb_Contraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_Correo
            // 
            tb_Correo.BorderStyle = BorderStyle.None;
            tb_Correo.Font = new Font("Microsoft Sans Serif", 9.75F);
            tb_Correo.ForeColor = Color.Gray;
            tb_Correo.Location = new Point(55, 149);
            tb_Correo.Name = "tb_Correo";
            tb_Correo.Size = new Size(350, 15);
            tb_Correo.TabIndex = 22;
            tb_Correo.Text = "Correo";
            tb_Correo.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Olvidarcontraseña
            // 
            lbl_Olvidarcontraseña.AutoSize = true;
            lbl_Olvidarcontraseña.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbl_Olvidarcontraseña.ForeColor = Color.Black;
            lbl_Olvidarcontraseña.Location = new Point(16, 279);
            lbl_Olvidarcontraseña.Name = "lbl_Olvidarcontraseña";
            lbl_Olvidarcontraseña.Size = new Size(161, 16);
            lbl_Olvidarcontraseña.TabIndex = 21;
            lbl_Olvidarcontraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // pnl_2
            // 
            pnl_2.BackColor = Color.PaleGreen;
            pnl_2.Controls.Add(bt_interfaz);
            pnl_2.Dock = DockStyle.Left;
            pnl_2.Location = new Point(0, 0);
            pnl_2.Name = "pnl_2";
            pnl_2.Size = new Size(283, 370);
            pnl_2.TabIndex = 20;
            // 
            // bt_interfaz
            // 
            bt_interfaz.BackColor = Color.Pink;
            bt_interfaz.FlatStyle = FlatStyle.Flat;
            bt_interfaz.Font = new Font("Microsoft Sans Serif", 9.75F);
            bt_interfaz.Location = new Point(206, 109);
            bt_interfaz.Name = "bt_interfaz";
            bt_interfaz.Size = new Size(74, 28);
            bt_interfaz.TabIndex = 11;
            bt_interfaz.Text = "Login";
            bt_interfaz.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(775, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Principal);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += Form1_Load;
            pnl_Principal.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnl_central.ResumeLayout(false);
            pnl_3.ResumeLayout(false);
            pnl_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Principal;
        private PictureBox pictureBox3;
        private Panel pnl_central;
        private Panel pnl_3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_Iniciodesesion;
        private Button btn_Iniciarsesion;
        private TextBox tb_Contraseña;
        private TextBox tb_Correo;
        private Label lbl_Olvidarcontraseña;
        private Panel pnl_2;
        private Button bt_interfaz;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Registrarse;
        private TextBox tb_ContraseñaRegistro;
        private TextBox tb_NombreCompleto;
        private Label label8;
        private Label label6;
        private ComboBox cb_Rol;
        private Label label7;
        private TextBox tb_Usuario;
        private ComboBox cb_EstadoDeCuenta;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}
