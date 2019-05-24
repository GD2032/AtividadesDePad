using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHerança
{
    class ContaCorrente : Conta
    {
       public ContaCorrente(string nome, float numeroConta) : base(nome, numeroConta)
        {
        }
        public float CobrarTaxa(float Taxa)
        {
            TransformPorcentagem(Taxa);
            return saldo -= Taxa * saldo;
        }
    }
}
