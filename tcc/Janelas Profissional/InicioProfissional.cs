using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.DTO;

namespace tcc
{
    public partial class InicioProfissional : Form
    {
        Profissional profissional;

        public InicioProfissional()
        {
            InitializeComponent();
            profissional = ((profissionalMDI)MdiParent).profissional;
        }

        private void InicioProfissional_Load(object sender, EventArgs e)
        {
            if( profissional.GetType() == typeof(Personal) )lbltitulo.Text = "TELA INICIAL DE PERSONAL";
            else lbltitulo.Text = "TELA INICIAL DE NUTRICIONISTA";

            txtnome.Text = profissional.nome.ToUpper();
        }
    }
}
