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
            pnl_registro = new Panel();
            bt_interfaz = new Button();
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
            pnl_iniciosesion = new Panel();
            lbl_crearcuenta = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Iniciodesesion = new Label();
            btn_Iniciarsesion = new Button();
            tb_Contraseña = new TextBox();
            tb_Correo = new TextBox();
            lbl_Olvidarcontraseña = new Label();
            pnl_imagen = new Panel();
            pictureBox3 = new PictureBox();
            pnl_Principal.SuspendLayout();
            pnl_registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnl_central.SuspendLayout();
            pnl_iniciosesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pnl_Principal
            // 
            pnl_Principal.BackgroundImage = Properties.Resources.pexels_codioful_6985001;
            pnl_Principal.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Principal.Controls.Add(pnl_registro);
            pnl_Principal.Controls.Add(pnl_central);
            pnl_Principal.Controls.Add(pictureBox3);
            pnl_Principal.Dock = DockStyle.Fill;
            pnl_Principal.Location = new Point(0, 0);
            pnl_Principal.Name = "pnl_Principal";
            pnl_Principal.Size = new Size(800, 450);
            pnl_Principal.TabIndex = 0;
            pnl_Principal.Paint += pnl_Principal_Paint;
            // 
            // pnl_registro
            // 
            pnl_registro.BackColor = Color.White;
            pnl_registro.Controls.Add(bt_interfaz);
            pnl_registro.Controls.Add(pictureBox6);
            pnl_registro.Controls.Add(pictureBox5);
            pnl_registro.Controls.Add(pictureBox4);
            pnl_registro.Controls.Add(cb_EstadoDeCuenta);
            pnl_registro.Controls.Add(label8);
            pnl_registro.Controls.Add(label6);
            pnl_registro.Controls.Add(cb_Rol);
            pnl_registro.Controls.Add(label7);
            pnl_registro.Controls.Add(tb_Usuario);
            pnl_registro.Controls.Add(label3);
            pnl_registro.Controls.Add(label4);
            pnl_registro.Controls.Add(label5);
            pnl_registro.Controls.Add(btn_Registrarse);
            pnl_registro.Controls.Add(tb_ContraseñaRegistro);
            pnl_registro.Controls.Add(tb_NombreCompleto);
            pnl_registro.Location = new Point(12, 68);
            pnl_registro.Name = "pnl_registro";
            pnl_registro.Size = new Size(425, 370);
            pnl_registro.TabIndex = 30;
            pnl_registro.Visible = false;
            // 
            // bt_interfaz
            // 
            bt_interfaz.BackColor = Color.Pink;
            bt_interfaz.FlatStyle = FlatStyle.Flat;
            bt_interfaz.Font = new Font("Microsoft Sans Serif", 9.75F);
            bt_interfaz.Location = new Point(5, 9);
            bt_interfaz.Name = "bt_interfaz";
            bt_interfaz.Size = new Size(40, 28);
            bt_interfaz.TabIndex = 11;
            bt_interfaz.Text = "Login";
            bt_interfaz.UseVisualStyleBackColor = false;
            bt_interfaz.Click += bt_interfaz_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.my_password;
            pictureBox6.Location = new Point(23, 186);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 32);
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
            pictureBox4.Location = new Point(23, 71);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // cb_EstadoDeCuenta
            // 
            cb_EstadoDeCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_EstadoDeCuenta.FormattingEnabled = true;
            cb_EstadoDeCuenta.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cb_EstadoDeCuenta.Location = new Point(278, 276);
            cb_EstadoDeCuenta.Name = "cb_EstadoDeCuenta";
            cb_EstadoDeCuenta.Size = new Size(134, 23);
            cb_EstadoDeCuenta.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(287, 247);
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
            label6.Location = new Point(75, 247);
            label6.Name = "label6";
            label6.Size = new Size(28, 16);
            label6.TabIndex = 33;
            label6.Text = "Rol";
            label6.Click += label6_Click;
            // 
            // cb_Rol
            // 
            cb_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Rol.DropDownWidth = 134;
            cb_Rol.FormattingEnabled = true;
            cb_Rol.Items.AddRange(new object[] { "ADMINISTRADOR", "EMPLEADO" });
            cb_Rol.Location = new Point(26, 276);
            cb_Rol.Name = "cb_Rol";
            cb_Rol.Size = new Size(134, 23);
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
            tb_Usuario.Location = new Point(66, 143);
            tb_Usuario.Name = "tb_Usuario";
            tb_Usuario.Size = new Size(327, 15);
            tb_Usuario.TabIndex = 30;
            tb_Usuario.Text = "Usuario";
            tb_Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(23, 216);
            label3.Name = "label3";
            label3.Size = new Size(392, 15);
            label3.TabIndex = 29;
            label3.Text = "_____________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(23, 108);
            label4.Name = "label4";
            label4.Size = new Size(392, 15);
            label4.TabIndex = 28;
            label4.Text = "_____________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(287, 12);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 25;
            label5.Text = "Registrarse";
            // 
            // btn_Registrarse
            // 
            btn_Registrarse.BackColor = Color.Pink;
            btn_Registrarse.FlatStyle = FlatStyle.Flat;
            btn_Registrarse.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_Registrarse.ForeColor = Color.Black;
            btn_Registrarse.Location = new Point(137, 323);
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
            tb_ContraseñaRegistro.Location = new Point(60, 196);
            tb_ContraseñaRegistro.Name = "tb_ContraseñaRegistro";
            tb_ContraseñaRegistro.Size = new Size(339, 15);
            tb_ContraseñaRegistro.TabIndex = 23;
            tb_ContraseñaRegistro.Text = "Contraseña";
            tb_ContraseñaRegistro.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_NombreCompleto
            // 
            tb_NombreCompleto.BorderStyle = BorderStyle.None;
            tb_NombreCompleto.Font = new Font("Microsoft Sans Serif", 9.75F);
            tb_NombreCompleto.ForeColor = Color.Gray;
            tb_NombreCompleto.Location = new Point(60, 88);
            tb_NombreCompleto.Name = "tb_NombreCompleto";
            tb_NombreCompleto.Size = new Size(333, 15);
            tb_NombreCompleto.TabIndex = 22;
            tb_NombreCompleto.Text = "Nombre completo";
            tb_NombreCompleto.TextAlign = HorizontalAlignment.Center;
            // 
            // pnl_central
            // 
            pnl_central.BackColor = Color.White;
            pnl_central.Controls.Add(pnl_imagen);
            pnl_central.Controls.Add(pnl_iniciosesion);
            pnl_central.Location = new Point(43, 40);
            pnl_central.Name = "pnl_central";
            pnl_central.Size = new Size(708, 370);
            pnl_central.TabIndex = 30;
            // 
            // pnl_iniciosesion
            // 
            pnl_iniciosesion.BackColor = Color.White;
            pnl_iniciosesion.Controls.Add(lbl_crearcuenta);
            pnl_iniciosesion.Controls.Add(label2);
            pnl_iniciosesion.Controls.Add(label1);
            pnl_iniciosesion.Controls.Add(pictureBox2);
            pnl_iniciosesion.Controls.Add(pictureBox1);
            pnl_iniciosesion.Controls.Add(lbl_Iniciodesesion);
            pnl_iniciosesion.Controls.Add(btn_Iniciarsesion);
            pnl_iniciosesion.Controls.Add(tb_Contraseña);
            pnl_iniciosesion.Controls.Add(tb_Correo);
            pnl_iniciosesion.Controls.Add(lbl_Olvidarcontraseña);
            pnl_iniciosesion.Location = new Point(283, 0);
            pnl_iniciosesion.Name = "pnl_iniciosesion";
            pnl_iniciosesion.Size = new Size(425, 370);
            pnl_iniciosesion.TabIndex = 21;
            // 
            // lbl_crearcuenta
            // 
            lbl_crearcuenta.AutoSize = true;
            lbl_crearcuenta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_crearcuenta.ForeColor = Color.Black;
            lbl_crearcuenta.Location = new Point(181, 336);
            lbl_crearcuenta.Name = "lbl_crearcuenta";
            lbl_crearcuenta.Size = new Size(83, 16);
            lbl_crearcuenta.TabIndex = 30;
            lbl_crearcuenta.Text = "Crear cuenta";
            lbl_crearcuenta.Click += label9_Click;
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
            lbl_Iniciodesesion.Location = new Point(145, 98);
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
            btn_Iniciarsesion.Location = new Point(265, 272);
            btn_Iniciarsesion.Name = "btn_Iniciarsesion";
            btn_Iniciarsesion.Size = new Size(140, 28);
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
            tb_Contraseña.Size = new Size(334, 15);
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
            tb_Correo.Size = new Size(334, 15);
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
            // pnl_imagen
            // 
            pnl_imagen.BackColor = Color.PaleGreen;
            pnl_imagen.Dock = DockStyle.Left;
            pnl_imagen.Location = new Point(0, 0);
            pnl_imagen.Name = "pnl_imagen";
            pnl_imagen.Size = new Size(283, 370);
            pnl_imagen.TabIndex = 20;
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
            pnl_registro.ResumeLayout(false);
            pnl_registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnl_central.ResumeLayout(false);
            pnl_iniciosesion.ResumeLayout(false);
            pnl_iniciosesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Principal;
        private PictureBox pictureBox3;
        private Panel pnl_central;
        private Panel pnl_iniciosesion;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_Iniciodesesion;
        private Button btn_Iniciarsesion;
        private TextBox tb_Contraseña;
        private TextBox tb_Correo;
        private Label lbl_Olvidarcontraseña;
        private Panel pnl_imagen;
        private Label lbl_crearcuenta;
        private Panel pnl_registro;
        private Button bt_interfaz;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private ComboBox cb_EstadoDeCuenta;
        private Label label8;
        private Label label6;
        private ComboBox cb_Rol;
        private Label label7;
        private TextBox tb_Usuario;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Registrarse;
        private TextBox tb_ContraseñaRegistro;
        private TextBox tb_NombreCompleto;
    }
}
