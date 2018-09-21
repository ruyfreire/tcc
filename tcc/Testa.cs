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
            Usuario usuario = new Usuario { id_usuario = 1, id_gym_personal = 0, id_nutricionista = 0 };

            /*
            Personal personal = new UsuarioBLL().carregaPersonal(usuario);
            if (personal.id_personal == 0) MessageBox.Show("Usuario não possui Personal");
            else
            {
                MessageBox.Show("Nome: "+personal.nome+
                    "\ne-mail: "+personal.email+
                    "\nnascimento: "+personal.nascimento.ToShortDateString()+
                    "\ncrn: "+personal.crea+
                    "\nendereço: "+personal.endereco+
                    "\ncpf/cnpj: "+personal.cpf_cnpj);
            }

            Nutricionista nutricionista = new UsuarioBLL().carregaNutricionista(usuario);
            if (nutricionista.id_nutricionista == 0) MessageBox.Show("Usuario não possui Nutricionista");
            else
            {
                MessageBox.Show("Nome: " + nutricionista.nome +
                    "\ne-mail: " + nutricionista.email +
                    "\nnascimento: " + nutricionista.nascimento.ToShortDateString() +
                    "\ncrn: " + nutricionista.crn +
                    "\nendereço: " + nutricionista.endereco +
                    "\ncpf/cnpj: " + nutricionista.cpf_cnpj);
            }
             */


            /*
            // ======  INCLUI UM TREINO   =======
            int id_usuario = 1;
            Treino treino = new Treino { diaSemana = "quarta", serie = 7, duracao = 20 };
            incluiTreino(id_usuario, treino);
             */



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
            // ======  EXCLUI UM TREINO   =======
            int id_treino = 4;
            int id_usuario = 1;
            excluiTreino(id_usuario, id_treino);
            

            /*
            //incluir alimento em dieta
            int id_dieta = 1; int id_alimento = 10;
            incluiAlimentoDieta(id_dieta, id_alimento);
             */

            /*
            //incluir exercicio em treino
            int id_treino = 1; int id_exercicio = 2;
            incluiExercicioTreino(id_treino, id_exercicio);
             */


            //carregaAlimentosDieta(2);

            //buscaDieta(2);

            //unicoEXERCICIO();

            //unicoALIMENTO();
        }

        private void btnCarregaLista_Click(object sender, EventArgs e)
        {
            carregaExercicioTreino(1);

            /*
            //excluir alimento em dieta
            int id_dieta = 1; int id_alimento = 10;
            excluiAlimentoDieta(id_dieta, id_alimento);
             */

            /*
            //excluir exercicio em treino
            int id_treino = 1; int id_exercicio = 2;
            excluiExercicioTreino(id_treino, id_exercicio);
             */


            //carregaAlimentosDieta(3);

            //buscaDieta(3);

            //listaEspecificaEXERCICIO();

            //listaEspecificaALIMENTO();
        }






        /* ==================  metodos de teste ============================== */

        public void incluiTreino(int id_usuario, Treino treino)
        {
            int result = new TreinoBLL().incluirTreinoUsuario(id_usuario, treino);
            if (result == 0)
            {
                MessageBox.Show("Usuario já possui um treino neste dia");
            }
            else if (result > 0)
            {
                MessageBox.Show("Treino cadastrado com Sucesso");
            }
            else if (result < 0)
            {
                MessageBox.Show("Erro ao cadastrar treino");
            }
        }
        public void excluiTreino(int id_usuario, int id_treino)
        {
            int result = new TreinoBLL().excluiTreinoUnicoUsuario(id_usuario, id_treino);
            if (result == 1)
            {
                MessageBox.Show("Treino excluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Treino não excluído ou não encontrado");
            }
        }
        public void alteraTreino(Treino treino, int id_usuario)
        {
            int result = new TreinoBLL().alteraTreinoDeUsuario(treino, id_usuario);
            if (result == 1)
            {
                MessageBox.Show("Treino alterado com Sucesso");
            }
            else
            {
                MessageBox.Show("Treino não alterado");
            }
        }
        public void carregaExercicioTreino(int id_usuario)
        {
            gridManha.DataSource = null;
            gridAlmoco.DataSource = null;
            gridTarde.DataSource = null;
            gridJanta.DataSource = null;

            /* Carrega os treinos vinculadas ao id do usuario */
            IList<Treino> treinos = new TreinoBLL().carregaTreinosDeUsuario(id_usuario);
            if (treinos.Count == 0)
            {
                MessageBox.Show("Sem treinos para este usuário!");
            }
            else
            {
                foreach (Treino treino in treinos)
                {
                    /* Carrega lista de exercicios, vinculados ao id de cada treino do usuario */
                    IList<Exercicio> exerciciosTreino = new ExerciciosBLL().carregaExerciciosTreino(treino.id_treino);

                    /* Verifica qual o dia da semana do treino, e inclui os dados do treino no grid correto */
                    if (treino.diaSemana.Equals("segunda"))
                    {
                        gridManha.DataSource = exerciciosTreino;
                    }
                    else if (treino.diaSemana.Equals("terça"))
                    {
                        gridAlmoco.DataSource = exerciciosTreino;
                    }
                    else if (treino.diaSemana.Equals("quarta"))
                    {
                        gridTarde.DataSource = exerciciosTreino;
                    }
                    else
                    {
                        gridJanta.DataSource = exerciciosTreino;
                    }
                }
            }
        }

        public void incluiExercicioTreino(int id_treino, int id_exercicio)
        {
            int result = new ExerciciosBLL().incluiExercicioTreino(id_treino, id_exercicio);
            if (result == 1) MessageBox.Show("Exercicio incluído com sucesso!");
            else if (result == -1) MessageBox.Show("Exercicio já presente no treino");
            else MessageBox.Show("Erro ao incluir exercicio!");
        }
        public void excluiExercicioTreino(int id_treino, int id_exercicio)
        {
            int result = new ExerciciosBLL().excluiExercicioTreino(id_treino, id_exercicio);
            if (result == 1) MessageBox.Show("Exercicio excluído com sucesso!");
            else if (result == -1) MessageBox.Show("Exercicio não encontrado no treino");
            else MessageBox.Show("Erro ao excluir exercicio!");
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
            if (result == 0)
            {
                MessageBox.Show("Usuario já possui uma dieta deste tipo");
            }
            else if (result > 0)
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
            else
            {
                MessageBox.Show("Dieta não excluída ou não encontrada");
            }
        }
        public void alteraDieta(Dieta dieta, int id_usuario)
        {            
            int result = new DietaBLL().alteraDietasDeUsuario(dieta, id_usuario);
            if (result == 1)
            {
                MessageBox.Show("Dieta alterada com Sucesso");
            }
            else
            {
                MessageBox.Show("Dieta não alterada");
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


        public void tirarSelecao()
        {
            gridManha.ClearSelection();
            gridAlmoco.ClearSelection();
            gridTarde.ClearSelection();
            gridJanta.ClearSelection();
        }
    }
}