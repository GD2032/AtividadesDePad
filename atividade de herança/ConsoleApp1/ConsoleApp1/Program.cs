using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupança conta1 = new ContaPoupança("Maria Fernanda", 1234);
            ContaCorrente conta2 = new ContaCorrente("Paulo Ricardo", 1235);
            //exercicio 7 creditar 100 reais na conta do Paulo
            conta2.Creditar(100);
            //exercicio 8 creditar 250 reais na conta da Maria
            conta1.Creditar(250);
            //exercicio 9 efetue um rendimento de 5% na conta da Maria
            conta1.AdcionarRendimento(5);
            //exercicio 10 efetue uma taxa de 1% na conta do Paulo
            conta2.CobrarTaxa(1);
        }
    }
}
