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
            pictureBox3 = new PictureBox();
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
            pnl_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnl_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_2.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Principal
            // 
            pnl_Principal.BackgroundImage = Properties.Resources.pexels_codioful_6985001;
            pnl_Principal.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Principal.Controls.Add(pictureBox3);
            pnl_Principal.Controls.Add(pnl_3);
            pnl_Principal.Controls.Add(pnl_2);
            pnl_Principal.Dock = DockStyle.Fill;
            pnl_Principal.Location = new Point(0, 0);
            pnl_Principal.Name = "pnl_Principal";
            pnl_Principal.Size = new Size(800, 450);
            pnl_Principal.TabIndex = 0;
            pnl_Principal.Paint += pnl_Principal_Paint;
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
            pnl_3.Location = new Point(332, 40);
            pnl_3.Name = "pnl_3";
            pnl_3.Size = new Size(425, 370);
            pnl_3.TabIndex = 19;
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
            pictureBox2.Location = new Point(23, 149);
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
            lbl_Iniciodesesion.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Iniciodesesion.ForeColor = Color.DimGray;
            lbl_Iniciodesesion.Location = new Point(139, 85);
            lbl_Iniciodesesion.Name = "lbl_Iniciodesesion";
            lbl_Iniciodesesion.Size = new Size(163, 23);
            lbl_Iniciodesesion.TabIndex = 25;
            lbl_Iniciodesesion.Text = "Inicio de sesión";
            // 
            // btn_Iniciarsesion
            // 
            btn_Iniciarsesion.BackColor = Color.Pink;
            btn_Iniciarsesion.FlatStyle = FlatStyle.Flat;
            btn_Iniciarsesion.Font = new Font("Century Gothic", 9.75F);
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
            tb_Contraseña.Font = new Font("Century Gothic", 9.75F);
            tb_Contraseña.ForeColor = Color.Gray;
            tb_Contraseña.Location = new Point(55, 200);
            tb_Contraseña.Name = "tb_Contraseña";
            tb_Contraseña.Size = new Size(350, 16);
            tb_Contraseña.TabIndex = 23;
            tb_Contraseña.Text = "Contraseña";
            tb_Contraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_Correo
            // 
            tb_Correo.BorderStyle = BorderStyle.None;
            tb_Correo.Font = new Font("Century Gothic", 9.75F);
            tb_Correo.ForeColor = Color.Gray;
            tb_Correo.Location = new Point(55, 149);
            tb_Correo.Name = "tb_Correo";
            tb_Correo.Size = new Size(350, 16);
            tb_Correo.TabIndex = 22;
            tb_Correo.Text = "Correo";
            tb_Correo.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Olvidarcontraseña
            // 
            lbl_Olvidarcontraseña.AutoSize = true;
            lbl_Olvidarcontraseña.Font = new Font("Century Gothic", 9.75F);
            lbl_Olvidarcontraseña.ForeColor = Color.Black;
            lbl_Olvidarcontraseña.Location = new Point(16, 279);
            lbl_Olvidarcontraseña.Name = "lbl_Olvidarcontraseña";
            lbl_Olvidarcontraseña.Size = new Size(179, 17);
            lbl_Olvidarcontraseña.TabIndex = 21;
            lbl_Olvidarcontraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // pnl_2
            // 
            pnl_2.BackColor = Color.Pink;
            pnl_2.Controls.Add(bt_interfaz);
            pnl_2.Location = new Point(43, 40);
            pnl_2.Name = "pnl_2";
            pnl_2.Size = new Size(283, 370);
            pnl_2.TabIndex = 18;
            // 
            // bt_interfaz
            // 
            bt_interfaz.BackColor = Color.Pink;
            bt_interfaz.FlatStyle = FlatStyle.Flat;
            bt_interfaz.Font = new Font("Century Gothic", 9.75F);
            bt_interfaz.Location = new Point(206, 109);
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
            Controls.Add(pnl_Principal);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += Form1_Load;
            pnl_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnl_3.ResumeLayout(false);
            pnl_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Principal;
        private Panel pnl_2;
        private Button bt_interfaz;
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
        private PictureBox pictureBox3;
    }
}
