using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*Manager herda de Employee porque além de conter o comportamento de BaseEmployee, possui um comportamento comum
     * com a classe Employee, o método AssingManager, já que um Manager pode ser subordinado a outro Manager*/
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(short rank)
        {
            /*essa validação não pode ser feita, porque pré-condições não podem ser fortalecidas, ao fazer isso, quando
             * houver uma tentativa de substituir um objeto do tipo Employee por um objeto do tipo Manager, a aplicação
             * cairá em uma exceção*/
            //if(rank < 0 || rank > 100)
            //{
            //    throw new Exception();
            //}
            decimal baseAmount = 19.75M;
            Salary = baseAmount + rank * 4;
        }

        public void GeneratePerformanceReview ()
        {
            Console.WriteLine("I'm reviewing a direct's report's performance");
        }
    }
}
