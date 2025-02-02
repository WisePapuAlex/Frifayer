namespace Frifayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //  SetRoundedRegion(pnl_2, 30); // Redondea con radio de 30 píxeles
           // SetRoundedRegion(pnl_3, 30); // Redondea con radio de 30 píxeles
                    


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
    }
}
