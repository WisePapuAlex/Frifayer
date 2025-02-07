using Frifayer.forms_paneles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frifayer
{
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuprincipal_Load(object sender, EventArgs e)
        {
            // Crear una instancia del formulario barra_lateral
            barra_lateral formBarraLateral = new barra_lateral();

            // Configurarlo para poder ser contenido en un panel:
            formBarraLateral.TopLevel = false;                        // No es un formulario de primer nivel
           // formBarraLateral.FormBorderStyle = FormBorderStyle.None;  // Sin borde para integrarse en el panel
            formBarraLateral.Dock = DockStyle.Fill;                   // Se ajusta para ocupar todo el panel

            // Opcional: Limpiar controles previos en el panel (en caso de que ya tenga alguno)
            pnl_desplegable.Controls.Clear();

            // Agregar el formulario barra_lateral al panel pnl_desplegable
            pnl_desplegable.Controls.Add(formBarraLateral);

            // Mostrar el formulario
            formBarraLateral.Show();
        }
    }
}
