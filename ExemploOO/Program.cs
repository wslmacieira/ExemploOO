using System;

namespace ExemploOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Wagner dos Santos",
                new DateTime(1979, 12, 11), "wslmacieira", "123456", "wslmacieira@email.com",
                "12345678910");

            if(cliente.Invalid)
            {
                foreach(var notificacao in cliente.Notifications)
                {
                    Console.WriteLine(notificacao.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
