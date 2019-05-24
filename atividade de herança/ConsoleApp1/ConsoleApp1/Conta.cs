using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHerança
{
    class Conta
    {
        protected string nomeCliente;
        protected float numeroConta;
        protected float saldo;
        public float Debitar(float debito)
        {
            return this.saldo -= debito;
        }
        public float Creditar(float credito)
        {
            return this.saldo += credito;
        }

        public float NomeCliente { get; set; }
        public float NumeroConta { get; set; }
        public float Saldo { get; set; }

        public Conta(string nome, float numeroConta)
        {
            this.nomeCliente = nome;
            this.numeroConta = numeroConta;
        }
        protected float TransformPorcentagem(float valor)
        {
            return valor *= 0.01f * 100f;
        }
    }
}
