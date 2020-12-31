using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace ExemploOO
{
    public class Cliente: Notifiable
    {
        public Cliente(string nome,
            DateTime dataDeNascimento, string userName,
            string senha, string email, string cpf)
        {
            Codigo = Guid.NewGuid();
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            UserName = userName;
            Senha = GerarHashDaSenha(senha);
            Email = email;
            Cpf = cpf;
            DataDeCadastro = DateTime.Now;

            AddNotifications(
                new Contract()
                .IsNotNullOrEmpty(Nome, "Nome", "Nome inválido")
                .IsGreaterOrEqualsThan(Nome.Length, 3 , nameof(Nome), "Nome deve ter no minimo 3 caracteres")
                .IsTrue(Cpf.Length != 11, "Cpf", "Cpf inválido")
                );

        }

        public Guid Codigo { get; private set; }
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

        public void Alterar(string nome, string dataDeNascimento,
            string email, string userName, string cpf)
        {

        }

        public void AlterarSenha(string senhaAtual, string novaSenha)
        {

        }
    }
}
