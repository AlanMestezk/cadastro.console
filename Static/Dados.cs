using System.Globalization;

namespace Static {
    internal class Produto {

        public string Nome;
        public string Cargo;
        public int Idade;
        public double Salario;


 
        public Produto() {
            Idade = 0;
        }

        public Produto(string nome, string cargo, double salario):this() {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public Produto(string nome, string cargo,int idade ,double salario):this(nome, cargo, salario) { 
            Idade = idade;
        }
        
        override public string ToString() {
            return $"O novo funcionário se chama {Nome}, tem {Idade} anos..." +
                $" Irá ocupar o cargo de {Cargo}" +
                $" com o salário de {Salario.ToString("f2", CultureInfo.InvariantCulture)}R$ reais";
        }


    }
}