using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_cadastrais_melhorado
{
    internal class Program
    {
        struct Dadoscadastrais
        {
            public string nome;
            public string Nomedarua;
            public UInt32 numerodacasa;
            public UInt32 numerododocumento;
        }
        static void Main(string[] args)
        {
            List<Dadoscadastrais> Listadecadastro = new List<Dadoscadastrais>();
            string opcao;

            do
            {
                Console.WriteLine("Digite C para cadastrar ou S para fechar o programa.");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    Dadoscadastrais dados;
                    Console.WriteLine("Digite seu nome completo");
                    dados.nome = Console.ReadLine();

                    Console.WriteLine("Digite o nome da sua rua");
                    dados.Nomedarua = Console.ReadLine();

                    Console.WriteLine("Digite o número de sua residência");
                    dados.numerodacasa = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Digite o número do seu documento");
                    dados.numerododocumento = Convert.ToUInt32(Console.ReadLine());

                    Listadecadastro.Add(dados);

                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Encerrando a aplicação");
                    
                }
                else
                {
                    Console.WriteLine("Opção desconhecida!!");
                }
            } while (opcao != "s");

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey(true);
        }
    }
}
