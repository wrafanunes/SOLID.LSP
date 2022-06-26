using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*agora CEO herda de Basemployee, uma classe que possui um comportamento genérico compartilhado com todas suas 
     * sub classes, CEO também implementa IManager, uma interface que possui a assinatura do método 
     * GeneratePerformanceReview, que é usado apenas pelas classes CEO e Manager*/
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate (short rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
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
