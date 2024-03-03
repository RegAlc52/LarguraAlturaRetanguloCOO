using System;

namespace LarguraAlturaRetanguloCOO
{
    class Program
    {
        static void Main()
        {
            double largura, altura;

            Console.WriteLine("Digite a largura do retângulo:");
            while (!double.TryParse(Console.ReadLine(), out largura) || largura <= 0)
            {
                Console.WriteLine("Valor inválido. Digite novamente a largura do retângulo:");
            }

            Console.WriteLine("Digite a altura do retângulo:");
            while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.WriteLine("Valor inválido. Digite novamente a altura do retângulo:");
            }

            Retangulo retangulo = new Retangulo(largura, altura);

            Console.WriteLine($"Área: {retangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {retangulo.CalcularPerimetro()}");
            Console.WriteLine($"Diagonal: {retangulo.CalcularDiagonal()}");
        }
    }

    class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}

//Fazer um programa para ler os valores 
//largura e altura de um retângulo. 
//Mostrar em tela o valor de 
//sua área, perímetro e diagonal.
//A Classe para esta atividade deve 
//conter os atributos Largura e Altura 
//os Métodossing System; using System;
//CalcularArea() : double, 
//CalcularPerimetro: double
//CalcularDiagonal(): double
//Com Orientação a Objetos


//Strings
//largura do retângulo
//altura do retângulo
//Área = double
//Perímetro
//Diagonal

//Variaveis
//largura = double
//altura = double
//retangulo = retangulo