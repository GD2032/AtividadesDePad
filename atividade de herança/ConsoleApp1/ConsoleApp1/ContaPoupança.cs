using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHerança
{
    class ContaPoupança : Conta
    {
        public ContaPoupança(string nome, float numeroConta) : base(nome, numeroConta)
        {
        }
        public float AdcionarRendimento(float juros)
        {
            TransformPorcentagem(juros);
            return saldo += juros * saldo;
        }
    }
}
