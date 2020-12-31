using System;

namespace ExemploOO
{
    public class Cliente
    {
        public Cliente(int codigo, string nome,
            DateTime dataDeNascimento, string userName,
            string senha, string email, string cpf)
        {
            Codigo = codigo;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            UserName = userName;
            Senha = GerarHashDaSenha(senha);
            Email = email;
            Cpf = cpf;
            DataDeCadastro = DateTime.Now;

            if (Codigo == 0)
            {
                throw new ApplicationException("Código inválido");
            }

            if (string.IsNullOrEmpty(Nome) || Nome.Length < 3)
            {
                throw new ApplicationException("Nome inválido");
            }

            if (Cpf.Length != 11)
            {
                throw new ApplicationException("Cpf inválido");
            }
        }

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public string UserName { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataDeCadastro { get; private set; }

        private string GerarHashDaSenha(string senha)
        {
            return senha;
        }
    }
}
