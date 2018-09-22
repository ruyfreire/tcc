using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc
{
    public class Validacoes
    {
        public Boolean validaCampos(String tipo, String campo)
        {
            switch (tipo)
            {
                //valida nome com expressao regular, minimo de 1 sobrenome e maximo de 5
                case "nome":
                    Regex testaNome = new Regex(@"^[a-zA-Z]+\s{1}[a-zA-Z]+?(\s{1}[a-zA-Z]+){0,4}$", RegexOptions.IgnoreCase);
                    if (!testaNome.IsMatch(campo))
                    {
                        MessageBox.Show("Nome inválido, (apenas letras, mínimo 1 sobrenome, e máximo 5, sem espaço no começo ou final)", "Nome");
                        return false;
                    }
                    if ((campo.Equals("")))
                    {
                        MessageBox.Show("Campo nome vazio!", "Nome");
                        return false;
                    }
                    if (campo.Length < 3)
                    {
                        MessageBox.Show("Nome menor que 3 letras", "Nome");
                        return false;
                    }
                break;
                //valida e-mail com expressao regular para carecteres paermitidos
                case "email":
                    Regex testaEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                    if (!testaEmail.IsMatch(campo))
                    {
                        MessageBox.Show("E-mail inválido", "E-mail");
                        return false;
                    }
                    break;
                case "login":
                    if(campo.Length > 15) { MessageBox.Show("Máximo de 15 caracteres", "Login"); return false; }
                    Regex testaLogin = new Regex(@"^[a-z]+$", RegexOptions.IgnoreCase);
                    if (!testaLogin.IsMatch(campo))
                    {
                        MessageBox.Show("Apenas letras para o login", "Login");
                        return false;
                    }
                    if ((campo.Equals("")))
                    {
                        MessageBox.Show("Campo login vazio!", "Login");
                        return false;
                    }
                    if (campo.Length < 3)
                    {
                        MessageBox.Show("Login menor que 3 letras", "Login");
                        return false;
                    }
                break;
                case "senha":
                    //valda senha entre 6 e 8
                    if (campo.Length < 6 || campo.Length > 8)
                    {
                        MessageBox.Show("A senha deve conter de 6 a 8 caracteres", "Senha");
                        return false;
                    }
                    break;
                case "cpf_cnpj":
                    campo = campo.Trim();
                    if(campo.Replace(".", "").Replace("-", "").Length == 11) return validaCPF(campo);
                    else if(campo.Replace(".", "").Replace("-", "").Replace("/", "").Length == 14) return validaCNPJ(campo);
                    else
                    {
                        Console.WriteLine(campo);
                        MessageBox.Show("Tamanho de campo inválido", "CPF / CNPJ");
                        return false;
                    }
                case "crn":
                    campo = campo.Trim();
                    Regex testaCRN = new Regex(@"^[0-9]{1,2}/[0-9]{3}?([0-9]){0,4}$");

                    if (!testaCRN.IsMatch(campo))
                    {
                        MessageBox.Show("Formato inválido, entre com um CRN válido ( ex: 0/000 )", "CRN");
                        return false;
                    }
                    else
                    {
                        string[] digitos = campo.Split('/');
                        if(Convert.ToInt32( digitos[0] ) < 1 || Convert.ToInt32( digitos[0] ) > 10 )
                        {
                            MessageBox.Show("Valor antes da barra inválido, permitido de 1 a 10", "CRN");
                            return false;
                        }
                        if(Convert.ToInt32(digitos[1]) < 100 || Convert.ToInt32(digitos[1]) > 9999999)
                        {
                            MessageBox.Show("Valor depois da barra inválido, permitido de 100 a 9999999", "CRN");
                            return false;
                        }
                    }
                    break;
                case "crea":
                    campo = campo.Trim();
                    if (campo.Equals("0000000000"))
                    {
                        MessageBox.Show("CREA inválido", "CREA");
                        return false;
                    }
                    Regex testaCREA = new Regex(@"^[0-9]{10}$");

                    if (!testaCREA.IsMatch(campo))
                    {
                        MessageBox.Show("CREA inválido, digite apenas numeros, e com 10 digitos", "CREA");
                        return false;
                    }
                    break;
                case "nascimento":
                    String nascimento = campo.Replace("/", "");
                    nascimento = nascimento.Replace(" ", "");
                    if (nascimento == "")
                    {
                        MessageBox.Show("Preencha a data de nascimento!", "Data de Nascimento");
                        return false;
                    }
                    break;
                case "idade":
                    DateTime hoje = DateTime.Now;
                    DateTime nascimentoDigitada = Convert.ToDateTime( campo );
                    int idade = hoje.Year - nascimentoDigitada.Year;
                    if (nascimentoDigitada > hoje.AddYears(-idade)) idade--;

                    if (idade < 5 || idade > 100)
                    {
                        MessageBox.Show("Idade permitida entre 5 e 100 anos", "Data de Nascimento");
                        return false;
                    }
                    break;
                case "sexo":
                    if (campo == "")
                    {
                        MessageBox.Show("Selecione um sexo", "Sexo");
                        return false;
                    }
                    break;
                //valida peso entre 30 e 200
                case "peso":
                    Regex testaPeso = new Regex(@"^[0-9]{0,3},?([0-9]){0,2}$");

                    if (!testaPeso.IsMatch(campo))
                    {
                        MessageBox.Show("Formato inválido, entre com o peso correto (30kg a 200kg)", "Peso");
                        return false;
                    }
                    else
                    {
                        Decimal peso = Convert.ToDecimal(campo);
                        Decimal peso_menor = 30m;
                        Decimal peso_maior = 200m;
                        if (Decimal.Compare(peso, peso_menor) < 0 || Decimal.Compare(peso, peso_maior) > 0)
                        {
                            MessageBox.Show("Valor permitido de 30kg a 200kg", "Peso");
                            return false;
                        }
                    }
                    break;
                //valida altura entre 0,50 e 2,50
                case "altura":
                    Regex testaAltura = new Regex(@"^[0-9],?([0-9]){0,2}$");

                    if (!testaAltura.IsMatch(campo))
                    {
                        MessageBox.Show("Formato inválido, entre com a altura correta (0,5m a 2,59m)", "Altura");
                        return false;
                    }
                    else
                    {
                        Decimal altura = Convert.ToDecimal(campo);
                        Decimal altura_menor = 0.5m;
                        Decimal altura_maior = 2.5m;
                        if ((Decimal.Compare(altura, altura_menor) < 0) || (Decimal.Compare(altura, altura_maior) > 0))
                        {
                            MessageBox.Show("Valor permitido de 0,5m a 2,59m", "Altura");
                            return false;
                        }
                    }
                    break;
                case "objetivo":
                    if (campo == "")
                    {
                        MessageBox.Show("Selecione um objetivo", "Objetivo");
                        return false;
                    }
                    break;

                case "serie":
                    Regex testaSerie = new Regex(@"^[0-9]{1,2}$");
                    if (!testaSerie.IsMatch(campo))
                    {
                        MessageBox.Show("Digite números inteiros entre 1 e 20", "Serie");
                        return false;
                    }
                    else
                    {
                        int serie = Convert.ToInt32(campo);
                        if (serie <= 0 || serie > 20)
                        {
                            MessageBox.Show("Número permitido entre 1 e 20", "Serie");
                            return false;
                        }
                    }
                    break;

                case "duracao":
                    Regex testaDuracao = new Regex(@"^[0-9]{1,3}$");
                    if (!testaDuracao.IsMatch(campo))
                    {
                        MessageBox.Show("Digite números inteiros entre 1 e 500", "Duração");
                        return false;
                    }
                    else
                    {
                        int duracao = Convert.ToInt32(campo);
                        if (duracao <= 0 || duracao > 500)
                        {
                            MessageBox.Show("Número permitido entre 1 e 500", "Duração");
                            return false;
                        }
                    }
                    break;

                case "porcao_alimento":
                    Regex testaPorcao = new Regex(@"^[0-9]+,?([0-9]){0,2}$");
                    if (!testaPorcao.IsMatch(campo))
                    {
                        MessageBox.Show("Use valor entre 1 e 5000 e virgula para decimal com duas casas", "Porção de alimento");
                        return false;
                    }
                    else
                    {
                        Decimal porcao = Convert.ToDecimal(campo);
                        if(porcao < 0 || porcao > 5000)
                        {
                            MessageBox.Show("Entre com um valor entre 1 e 5000 gramas", "Porção de alimento");
                            return false;
                        }
                    }
                    break;
            }

            //retorna true se a validação passar direto sem encontrar erro
            return true;
        }

        private Boolean validaCPF(String cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            string[] verificador = cpf.Split('-');
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                MessageBox.Show("Tamanho de CPF inválido", "CPF");
                return false;
            }
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            if (!verificador[1].Equals(digito))
            {
                MessageBox.Show("CPF inválido", "CPF");
                return false;
            }
            return true;
        }

        private Boolean validaCNPJ(String cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            string[] verificador = cnpj.Split('-');
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            if (!verificador[1].Equals(digito))
            {
                MessageBox.Show("CNPJ inválido", "CNPJ");
                return false;
            }
            return true;
        }
    }
}
