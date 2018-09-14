using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using tcc.BLL;
using tcc.DTO;

namespace tcc
{
    public partial class Testa : Form
    {
        public Testa()
        {
            InitializeComponent();
        }

        private void Testa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCarregaTodos_Click(object sender, EventArgs e)
        {
            /*
            // ======  INCLUI UMA DIETA   =======
            int id_usuario = 1;
            Dieta dieta = new Dieta{tipo_refeicao = "Cafe da Manha",qtde_porcao = 7};
            incluiDieta(id_usuario, dieta);
             */

            /*
            // ======  EXCLUI UMA DIETA   =======
            int id_usuario = 1; int id_dieta = 2;
            excluiDieta(id_usuario, id_dieta);
            */

            /*
            // ======  ALTERA UMA DIETA   =======
            Dieta dieta = new Dieta{id_dieta = 8,tipo_refeicao = "Café",qtde_porcao = 1};
            alteraDieta(dieta);
             */

            /*
            // Carrega alimentos das dietas do usuario
            int id_usuario = 1;
            carregaAlimentosDieta(id_usuario);
             */

            //buscaDieta(1);

            //todosEXERCICIO();

            //todosALIMENTO();
        }

        private void btnCarregaEspecifico_Click(object sender, EventArgs e)
        {
            /*
            //incluir alimento em dieta
            int id_dieta = 1; int id_alimento = 10;
            incluiAlimentoDieta(id_dieta, id_alimento);
             */

            //carregaAlimentosDieta(2);

            //buscaDieta(2);

            //unicoEXERCICIO();

            //unicoALIMENTO();
        }

        private void btnCarregaLista_Click(object sender, EventArgs e)
        {
            /*
            //excluir alimento em dieta
            int id_dieta = 1; int id_alimento = 10;
            excluiAlimentoDieta(id_dieta, id_alimento);
             */

            //carregaAlimentosDieta(3);

            //buscaDieta(3);

            //listaEspecificaEXERCICIO();

            //listaEspecificaALIMENTO();
        }






        /* ==================  metodos de teste ============================== */

        public void incluiAlimentoDieta(int id_dieta, int id_alimento)
        {
            int result = new AlimentosBLL().incluiAlimentoDieta(id_dieta, id_alimento);
            if (result == 1) MessageBox.Show("Alimento incluído com sucesso!");
            else if (result == -1) MessageBox.Show("Alimento já presente na dieta");
            else MessageBox.Show("Erro ao incluir alimento!");
        }
        public void excluiAlimentoDieta(int id_dieta, int id_alimento)
        {
            int result = new AlimentosBLL().excluiAlimentoDieta(id_dieta, id_alimento);
            if (result == 1) MessageBox.Show("Alimento excluído com sucesso!");
            else if (result == -1) MessageBox.Show("Alimento não encontrado na dieta");
            else MessageBox.Show("Erro ao excluir alimento!");
        }
        public void listaEspecificaALIMENTO()
        {
            IList<Alimento> listaAlimentos = new List<Alimento>();
            ArrayList id_alimentos = new ArrayList { 1, 2, 3, 4 };
            listaAlimentos = new AlimentosBLL().buscaListaDeAlimentosEspecificos(id_alimentos);
            gridTabela.DataSource = listaAlimentos;
        }
        public void unicoALIMENTO()
        {
            Alimento alimento = new Alimento();

            int id_alimento = 2;
            alimento = new AlimentosBLL().buscaUnicoAlimento(id_alimento);

            //cria lista apenas para inserir no grid
            IList<Alimento> alimentoGrid = new List<Alimento>();
            alimentoGrid.Add(alimento);
            gridTabela.DataSource = alimentoGrid;
        }
        public void todosALIMENTO()
        {
            IList<Alimento> listaAlimentos = new List<Alimento>();

            listaAlimentos = new AlimentosBLL().buscaTodosAlimentos();
            gridTabela.DataSource = listaAlimentos;
        }


        public void unicoEXERCICIO()
        {
            Exercicio exercicio = new Exercicio();

            int id_exercicio = 2;
            exercicio = new ExerciciosBLL().buscaExercicioEspecifico(id_exercicio);

            //cria lista apenas para inserir no grid
            IList<Exercicio> exercicioGrid = new List<Exercicio>();
            exercicioGrid.Add(exercicio);
            gridTabela.DataSource = exercicioGrid;
        }
        public void listaEspecificaEXERCICIO()
        {
            IList<Exercicio> listaExercicios = new List<Exercicio>();
            ArrayList id_exercicio = new ArrayList {1, 2, 3};
            listaExercicios = new ExerciciosBLL().buscaListaDeExerciciosEspecificos(id_exercicio);
            gridTabela.DataSource = listaExercicios;
        }
        public void todosEXERCICIO()
        {
            IList<Exercicio> listaExercicios = new List<Exercicio>();

            listaExercicios = new ExerciciosBLL().buscaTodosExercicios();
            gridTabela.DataSource = listaExercicios;
        }


        public void incluiDieta(int id_usuario, Dieta dieta)
        {            
            int result = new DietaBLL().incluirDietaUsuario(id_usuario, dieta);
            if (result == -1)
            {
                MessageBox.Show("Usuario já possui uma dieta deste tipo");
            }
            else if (result > 1)
            {
                MessageBox.Show("Dieta cadastrada com Sucesso");
            }
            else if (result < 0)
            {
                MessageBox.Show("Erro ao cadastrar dieta");
            }
        }
        public void excluiDieta(int id_usuario, int id_dieta)
        {
            int result = new DietaBLL().excluiDietaUnicaUsuario(id_usuario, id_dieta);
            if (result == 1)
            {
                MessageBox.Show("Dieta excluída com Sucesso");
            }
            else if (result == -1)
            {
                MessageBox.Show("Erro no processo de referencia a dieta");
            }
            else
            {
                MessageBox.Show("Dieta não excluída ou não encontrada");
            }
        }
        public void alteraDieta(Dieta dieta)
        {            
            int result = new DietaBLL().alteraDietasDeUsuario(dieta);
            if (result == 1)
            {
                MessageBox.Show("Dieta alterada com Sucesso");
            }
            else
            {
                MessageBox.Show("Dieta não alterada");
            }
        }
        public void buscaDieta( int id)
        {
            gridManha.DataSource = null;
            gridAlmoco.DataSource = null;
            gridTarde.DataSource = null;
            gridJanta.DataSource = null;

            IList<Dieta> dietas = new List<Dieta>();
            dietas = new DietaBLL().carregaDietasDeUsuario(id);
            if (dietas.Count == 0)
            {
                MessageBox.Show("Sem dietas para este usuário!");
            }
            else
            {
                foreach (Dieta dieta in dietas)
                {
                    if(dieta.tipo_refeicao.Equals("Café da Manhã"))
                    {
                        IList<Dieta> exibeDieta = new List<Dieta>();
                        exibeDieta.Add(dieta);
                        gridManha.DataSource = exibeDieta;
                    }
                    else if (dieta.tipo_refeicao.Equals("Almoço"))
                    {
                        IList<Dieta> exibeDieta = new List<Dieta>();
                        exibeDieta.Add(dieta);
                        gridAlmoco.DataSource = exibeDieta;
                    }
                    else if (dieta.tipo_refeicao.Equals("Café da Tarde"))
                    {
                        IList<Dieta> exibeDieta = new List<Dieta>();
                        exibeDieta.Add(dieta);
                        gridTarde.DataSource = exibeDieta;
                    }
                    else if (dieta.tipo_refeicao.Equals("Janta"))
                    {
                        IList<Dieta> exibeDieta = new List<Dieta>();
                        exibeDieta.Add(dieta);
                        gridJanta.DataSource = exibeDieta;
                    }
                }
            }
        }
        public void carregaAlimentosDieta(int id_usuario)
        {
            gridManha.DataSource = null;
            gridAlmoco.DataSource = null;
            gridTarde.DataSource = null;
            gridJanta.DataSource = null;

            /* Carrega as dietas vinculadas ao id do usuario */
            IList<Dieta> dietas = new List<Dieta>();
            dietas = new DietaBLL().carregaDietasDeUsuario(id_usuario);
            if (dietas.Count == 0)
            {
                MessageBox.Show("Sem dietas para este usuário!");
            }
            else
            {
                foreach (Dieta dieta in dietas)
                {
                    /* Carrega lista de alimentos, vinculados ao id de cada dieta do usuario */
                    IList<Alimento> alimetosDieta = new List<Alimento>();
                    alimetosDieta = new AlimentosBLL().carregaAlimentosDieta(dieta.id_dieta);

                    /* Verifica qual o tipo da refeição, e inclui os dados da dieta no grid correto */
                    if (dieta.tipo_refeicao.Equals("Café da Manhã"))
                    {
                        gridManha.DataSource = alimetosDieta;
                    }
                    else if (dieta.tipo_refeicao.Equals("Almoço"))
                    {
                        gridAlmoco.DataSource = alimetosDieta;
                    }
                    else if (dieta.tipo_refeicao.Equals("Café da Tarde"))
                    {
                        gridTarde.DataSource = alimetosDieta;
                    }
                    else if (dieta.tipo_refeicao.Equals("Janta"))
                    {
                        gridJanta.DataSource = alimetosDieta;
                    }
                }
            }
        }
    }
}