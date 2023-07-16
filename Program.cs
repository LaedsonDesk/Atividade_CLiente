using System;
namespace Atividade 
{
    class program{
        static void Main(String[] Args){
            
            float valPgamento;
            Console.WriteLine("Digite seu nome:");
            string varNome = Console.ReadLine();
            Console.WriteLine("Informe seu endereço:");
            string varEndereco = Console.ReadLine();
            Console.WriteLine("Qual o seu cadastro:");
            Console.WriteLine("CPF - clique [f]");
            Console.WriteLine("CNPJ - clique [j]");
            string varTipoCadastro = Console.ReadLine();
            
            if(varTipoCadastro == "f"){
                pessoaFisica pf = new pessoaFisica();
                pf.nome = varNome;
                pf.endereco = varEndereco;
                Console.WriteLine("Informe o CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra");
                valPgamento = float.Parse(Console.ReadLine());
                pf.pagarImposto(valPgamento);

                Console.WriteLine("-----Pessoa Física-----");
                Console.WriteLine("Nome............: "+ pf.nome);
                Console.WriteLine("CPF.............: "+ pf.cpf);
                Console.WriteLine("Endereço........: "+ pf.endereco);
                Console.WriteLine("RG..............: "+ pf.rg);
                Console.WriteLine("Valor da compra.: "+ pf.valor.ToString("C"));
                Console.WriteLine("Imposto.........: "+ pf.valorImposto.ToString("C"));
                Console.WriteLine("Valor da total..: "+ pf.valorTotal.ToString("C"));

            } 
            else if (varTipoCadastro == "j"){
                pessoaJuridica pj = new pessoaJuridica();
                pj.nome = varNome;
                pj.endereco = varEndereco;
                Console.WriteLine("Informe o CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe a Inscrição Estadual:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra");
                valPgamento = float.Parse(Console.ReadLine());
                pj.pagarImposto(valPgamento);

                Console.WriteLine("-----Pessoa Física-----");
                Console.WriteLine("Nome............: "+ pj.nome);
                Console.WriteLine("CPF.............: "+ pj.cnpj);
                Console.WriteLine("Endereço........: "+ pj.endereco);
                Console.WriteLine("RG..............: "+ pj.ie);
                Console.WriteLine("Valor da compra.: "+ pj.valor.ToString("C"));
                Console.WriteLine("Imposto.........: "+ pj.valorImposto.ToString("C"));
                Console.WriteLine("Valor da total..: "+ pj.valorTotal.ToString("C"));

            }


        }
    }
}