namespace Frifayer
{
    public partial class inicio_sesion : Form
    {
        public inicio_sesion()
        {
            InitializeComponent();
            redondeaPaneles(pnl_central, 15); // Redondea con radio de 30 píxeles

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

        private void tb_Contraseña_TextChanged(object sender, EventArgs e)
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
            if (pnl_registro.Visible) // Si panel1 está visible, lo oculta y muestra pnl_3
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
            if (!pnl_central.Controls.Contains(pnl_registro)) // Si panel1 no está agregado, lo agrega
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
    }
}
