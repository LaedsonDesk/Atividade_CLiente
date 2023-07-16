namespace Atividade
{

    public class pessoaJuridica : Cliente
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void pagarImposto(float valorProduto){
            this.valor = valorProduto;
            this.valorImposto = this.valor*20/100;
            this.valorTotal = this.valor + this.valorImposto;
        }
    }
}