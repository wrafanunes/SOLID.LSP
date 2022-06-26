using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Manager : Employee
    {

        public override void CalculatePerHourRate(short rank)
        {
            /*essa validação não pode ser feita, porque pré-condições não podem ser fortalecidas, ao fazer isso, quando
             * houver uma tentativa de substituir um objeto do tipo Employee por um objeto do tipo Manager, a aplicação
             * cairá em uma exceção*/
            if(rank < 0 || rank > 100)
            {
                throw new Exception();
            }
            decimal baseAmount = 19.75M;
            Salary = baseAmount + rank * 4;
        }

        public void GeneratePerformanceReview ()
        {
            Console.WriteLine("I'm reviewing a direct's report's performance");
        }
    }
}
