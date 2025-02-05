namespace Frifayer
{
    public partial class inicio_sesion : Form
    {
        public inicio_sesion()
        {
            InitializeComponent();
            redondeaPaneles(pnl_central, 15); // Redondea con radio de 30 p�xeles

            //para seleccionar el primer item de los combobox
            cb_Rol.SelectedIndex = 0;
            cb_EstadoDeCuenta.SelectedIndex = 0;


        }
        private void redondeaPaneles(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int width = control.Width;
            int height = control.Height;

            // Agrega arcos para cada esquina
            path.AddArc(0, 0, radius, radius, 180, 90); // Esquina superior izquierda
            path.AddArc(width - radius, 0, radius, radius, 270, 90); // Esquina superior derecha
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, height - radius, radius, radius, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void tb_Contrase�a_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Iniciodesesion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_interfaz_Click(object sender, EventArgs e)
        {
            if (pnl_registro.Visible) // Si panel1 est� visible, lo oculta y muestra pnl_3
            {
                pnl_registro.Visible = false;
                pnl_iniciosesion.Visible = true;
            }

        }

        private void bt_sign_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (!pnl_central.Controls.Contains(pnl_registro)) // Si panel1 no est� agregado, lo agrega
            {
                pnl_central.Controls.Add(pnl_registro);
                pnl_registro.Location = pnl_iniciosesion.Location;
            }

            // Oculta pnl_3 y muestra panel1
            pnl_iniciosesion.Visible = false;
            pnl_registro.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tb_Correo_Enter(object sender, EventArgs e)
        {
            if (tb_Correo.Text == "Correo")
            {
                tb_Correo.Text = "";
            }
        }

        private void tb_Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Correo_Leave(object sender, EventArgs e)
        {
            if (tb_Correo.Text == "")
            {
                tb_Correo.Text = "Correo";
            }
        }

        private void tb_Contrase�a_Enter(object sender, EventArgs e)
        {
            if (tb_Contrase�a.Text == "Contrase�a")
            {
                tb_Contrase�a.Text = "";
            }
        }

        private void tb_Contrase�a_Leave(object sender, EventArgs e)
        {
            if (tb_Contrase�a.Text == "")
            {
                tb_Contrase�a.Text = "Contrase�a";
            }
        }

        private void tb_Contrase�a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_Iniciarsesion.Focus();
            }
        }

        private void tb_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                tb_Contrase�a.Focus();
            }
        }

        private void tb_NombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                tb_Usuario.Focus();
            }
        }

        private void tb_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                tb_Contrase�aRegistro.Focus();
            }
        }

        private void tb_Contrase�aRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cb_Rol_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void tb_NombreCompleto_Enter(object sender, EventArgs e)
        {
            if (tb_NombreCompleto.Text == "Nombre completo")
            {
                tb_NombreCompleto.Text = "";
            }
        }

        private void tb_Usuario_Enter(object sender, EventArgs e)
        {
            if (tb_Usuario.Text == "Usuario")
            {
                tb_Usuario.Text = "";
            }
        }

        private void tb_Contrase�aRegistro_Enter(object sender, EventArgs e)
        {
            if (tb_Contrase�aRegistro.Text == "Contrase�a")
            {
                tb_Contrase�aRegistro.Text = "";
            }
        }

        private void tb_NombreCompleto_Leave(object sender, EventArgs e)
        {
            if (tb_NombreCompleto.Text == "")
            {
                tb_NombreCompleto.Text = "Nombre completo";
            }
        }

        private void tb_Usuario_Leave(object sender, EventArgs e)
        {
            if (tb_Usuario.Text == "")
            {
                tb_Usuario.Text = "Usuario";
            }
        }

        private void tb_Contrase�aRegistro_Leave(object sender, EventArgs e)
        {
            if (tb_Contrase�aRegistro.Text == "")
            {
                tb_Contrase�aRegistro.Text = "Contrase�a";
            }
        }

        private void cb_Rol_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down) // Flecha Abajo
            {
                if (cb_Rol.SelectedIndex < cb_Rol.Items.Count - 1)
                {
                    cb_Rol.SelectedIndex++;
                }
            }
            else if (e.KeyCode == Keys.Up) // Flecha Arriba
            {
                if (cb_Rol.SelectedIndex > 0)
                {
                    cb_Rol.SelectedIndex--;
                }
            }
        }

        private void lbl_crearcuenta_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
}

