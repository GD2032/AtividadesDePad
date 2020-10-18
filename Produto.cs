using System;

namespace Encapsulamento{
    class Produto{
        private string descricao;
        private float valor;
        private int estoque;

        public Produto(){
            this.descricao = null;
            this.valor = 0f;
            this.estoque = 0;
        }
        public Produto(string d, float v, int e){
            this.descricao = d;
            this.valor = v;
            this.estoque = e;
        }

        // public string GetDescricao(){
        //     return descricao;
        // }
        // public void SetDescricao(string d){
        //     this.descricao = d;
        // }
        // public float GetValor(){
        //     return valor;
        // }
        // public void SetValor(float v){
        //     this.valor = v;
        // }
        // public int GetEstoque(){
        //     return estoque;
        // }
        // public void SetEstoque(int e){
        //     this.estoque = e;
        // }

        public string Descricao{
            get{
                return descricao;
            }
            set{
                this.descricao = value;
            }
        }
        public float Valor{
            get{
                return valor;
            }
            set{
                this.valor = value;
            }
        }
        public int Estoque{
            get{
                return estoque;
            }
            set{
                this.estoque = value;
            }
        }
    }
}
