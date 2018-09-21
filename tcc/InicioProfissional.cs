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
        profissionalMDI mdi;

        public InicioProfissional(profissionalMDI mdi)
        {
            InitializeComponent();
            this.mdi = mdi;
        }

        private void InicioProfissional_Load(object sender, EventArgs e)
        {
            if( mdi.profissional.GetType() == typeof(Personal) )lbltitulo.Text = "TELA INICIAL DE PERSONAL";
            else lbltitulo.Text = "TELA INICIAL DE NUTRICIONISTA";

            txtnome.Text = mdi.profissional.nome.ToUpper();
        }
    }
}
