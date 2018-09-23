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
        }

        private void InicioProfissional_Load(object sender, EventArgs e)
        {
            profissional = ((profissionalMDI)MdiParent).profissional;

            if (profissional.GetType() == typeof(Personal))
            {
                lbltitulo.Text = "TELA INICIAL DE PERSONAL";
                lblcrn_crea.Text = "CREA :";
                txtcrn_crea.Text = ((Personal)profissional).crea;
            }
            else
            {
                lbltitulo.Text = "TELA INICIAL DE NUTRICIONISTA";
                lblcrn_crea.Text = "CRN :";
                txtcrn_crea.Text = ((Nutricionista)profissional).crn;
            }

            txtnome.Text = profissional.nome.ToUpper();
        }
    }
}
