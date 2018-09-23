using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.BLL;
using tcc.DTO;

namespace tcc
{
    public partial class InicioUsuario : Form
    {
        Usuario usuario;

        public InicioUsuario()
        {
            InitializeComponent();
        }

        private void InicioUsuario_Load(object sender, EventArgs e)
        {
            usuario = ((usuarioMDI)MdiParent).usuario;
            txtnome.Text = usuario.nome.ToUpper();
            calculaIMC();
            calculaTaxaBasal(usuario.sexo);
            carregaProfissional();
        }

        private void calculaIMC()
        {
            Decimal muitoAbaixo = 17m;
            Decimal abaixo = 18.49m;
            Decimal pesoNormal = 24.99m;
            Decimal acimaPeso = 29.99m;
            Decimal obesidade = 34.99m;
            Decimal obesidadeSevera = 39.99m;

            Decimal peso = Convert.ToDecimal(usuario.peso);
            Decimal altura = Convert.ToDecimal(usuario.altura);
            Decimal imc = peso / (altura * altura);
            String textoImc = Convert.ToString(imc);

            if (imc < muitoAbaixo) { txtimc.Text = " Muito abaixo do peso"; txtimc.BackColor = Color.LightSalmon; }
            else if (imc > muitoAbaixo && imc < abaixo) { txtimc.Text = " Abaixo do peso"; txtimc.BackColor = Color.LightYellow; }
            else if (imc > abaixo && imc < pesoNormal) { txtimc.Text = " Peso Normal"; txtimc.BackColor = Color.LimeGreen; }
            else if (imc > pesoNormal && imc < acimaPeso) { txtimc.Text = " Acima do peso"; txtimc.BackColor = Color.LightSalmon; }
            else if (imc > acimaPeso && imc < obesidade) { txtimc.Text = " Obesidade"; txtimc.BackColor = Color.LightSalmon; }
            else if (imc > obesidade && imc < obesidadeSevera) { txtimc.Text = " Obesidade Severa"; txtimc.BackColor = Color.Red; }
            else { txtimc.Text = " Obesidade Mórbida"; txtimc.BackColor = Color.Red; }
        }

        private void calculaTaxaBasal(String sexo)
        {
            Decimal taxaBasal;
            Decimal peso = Convert.ToDecimal(usuario.peso);
            Decimal altura = Convert.ToDecimal(usuario.altura)*100;
            DateTime hoje = DateTime.Now;
            DateTime nascimento = usuario.nascimento;
            int idade = hoje.Year - nascimento.Year;
            if (nascimento > hoje.AddYears(-idade)) idade--;

            if (sexo == "M")
            {
                taxaBasal = 66 + (13.7m * peso) + (5m * altura) - (6.8m * idade) * 1.375m;
                txtbasal.Text = Convert.ToString( Math.Round(taxaBasal, 2) );
            }
            else
            {
                taxaBasal = 665 + (9.6m * peso) + (1.8m * altura) - (4.7m * idade) * 1.375m;
                txtbasal.Text = Convert.ToString( Math.Round(taxaBasal, 2) );
            }
        }

        private void carregaProfissional()
        {
            Personal personal = new UsuarioBLL().carregaPersonal(usuario.id_usuario);
            if(personal.id_personal != 0) txtpersonal.Text = personal.nome.ToUpper();
            else txtpersonal.Text = "Não possui um personal";


            Nutricionista nutricionista = new UsuarioBLL().carregaNutricionista(usuario.id_usuario);
            if(nutricionista.id_nutricionista != 0) txtnutricionista.Text = nutricionista.nome.ToUpper();
            else txtnutricionista.Text = "Não possui um nutricionista";
        }
    }
}
