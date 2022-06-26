using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /* O princípio de substituição de Liskov prega que se S é um subtipo de T, objetos do tipo T podem ser substituidos
 * por objetos do tipo S sem que a aplicação quebre e sem que seja necessário alterar as propriedades desse programa.
 * No momento essa aplicação viola o LSP, já que ao tentar substituir um objeto do tipo Employee para o tipo CEO,
 * a aplicação cai em uma InvalidOperationException, já que o CEO não tem um Manager*/
    public class CEO : Employee
    {
        public override void CalculatePerHourRate (short rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }

        public override void AssingManager (Employee manager)
        {
            //inserir novas exceções em métodos sobrescritos viola o LSP
            throw new InvalidOperationException("The CEO has no manager.");
        }

        public void GeneratePerformanceReview ()
        {
            Console.WriteLine("I'm reviewing a direct's report's performance");
        }

        public void FireSomeone ()
        {
            Console.WriteLine("You're fired!");
        }
    }
}
