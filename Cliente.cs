namespace Atividade
{
    public class Cliente{
        public string nome {get; set;}
        public string endereco {get; set;}
        public float valor {get; protected set;}
        public float valorImposto {get; protected set;}
        public float valorTotal {get; protected set;}

        public virtual void pagarImposto(float valorProduto){
            this.valor = valorProduto;
            this.valorImposto = this.valor*10/100;
            this.valorTotal = this.valor + this.valorImposto;

        }
    }
}