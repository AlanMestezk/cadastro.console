
namespace Static {
    class Program {

         static void Main(string[] args) {

            

            Console.WriteLine("CADASTRO DE NOVO COLABORADOR: ");
            Console.WriteLine();
            Console.Write("VOCÊ QUER CADASTRAR UM NOVO COLABORADOR?");
            Console.Write("Sim ou Não?: ");
            string resposta = Console.ReadLine();

            

            if (resposta == "Sim") {

                Console.WriteLine();
                Console.WriteLine("Vamos lá, preencha os campos");
                Console.WriteLine();
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Digite o cargo: ");
                string cargo = Console.ReadLine();
                Console.Write("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());
                Produto pessoa = new Produto(nome, cargo, idade, salario);
                Console.WriteLine("");
                Console.WriteLine(pessoa);
                

            }
            else {
                Console.WriteLine();
                Console.WriteLine("APERTE A TECLA ENTER PARA ENCERRAR O PROGRAMA");
            }
            
        }

    }
}
