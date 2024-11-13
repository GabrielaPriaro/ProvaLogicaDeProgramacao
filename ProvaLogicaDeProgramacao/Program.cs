using System.Globalization;

namespace ProvaLogicaDeProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EstruturaSequencialExercicio1_1();
            //EstruturaSequencialExercicio1_2();
            //EstruturaCondicionalExercicio1_1();
            //EstruturaCondicionalExercicio2_2();
            //EstruturaRepetitivasExercicio3_1();
            //EstruturaRepetitivasExercicio3_2();
        }

        static void EstruturaSequencialExercicio1_1()
        {
            int n;
            double valorTotalCompra = 0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos produtos serao digitados: ");
            n = int.Parse(Console.ReadLine());

            int[] codProduto = new int[n];
            int[] quantProduto = new int[n];
            double[] valorUnitProduto = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nDigite o código do {i + 1}º produto: ");
                codProduto[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite a quantidade do {i + 1}º produto: ");
                quantProduto[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite o valor do {i + 1}º produto: ");
                valorUnitProduto[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < n; i++)
            {
                valorTotalCompra += quantProduto[i] * valorUnitProduto[i];
            }

            Console.WriteLine($"\nVALOR A PAGAR: R$ {valorTotalCompra.ToString("F2", CI)}");
        }

        static void EstruturaSequencialExercicio1_2()
        {
            double raio, area;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CI);

            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"\nArea do circulo = {area.ToString("F4", CI)}");
        }

        static void EstruturaCondicionalExercicio1_1()
        {
            int codigoProduto, quantProduto;
            double totalConsumido = 0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Código do Produto: ");
            codigoProduto = int.Parse(Console.ReadLine());

            if (codigoProduto < 1 || codigoProduto > 5)
            {
                Console.WriteLine("CODIGO INVALIDO");
            }
            else
            {

                Console.Write("Quantidade do Produto: ");
                quantProduto = int.Parse(Console.ReadLine());

                switch (codigoProduto)
                {
                    case 1:
                        totalConsumido = quantProduto * 4.00;
                        break;

                    case 2:
                        totalConsumido = quantProduto * 4.50;
                        break;

                    case 3:
                        totalConsumido = quantProduto * 5.00;
                        break;

                    case 4:
                        totalConsumido = quantProduto * 2.00;
                        break;

                    case 5:
                        totalConsumido = quantProduto * 1.50;
                        break;
                }

                Console.Write($"\nVALOR TOTAL CONSUMIDO: R$ {totalConsumido.ToString("F2", CI)}");
            }
        }

        static void EstruturaCondicionalExercicio2_2()
        {
            double coeficienteA, coeficienteB, coeficienteC, delta, raizDelta, x1, x2;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor do Coeficiente A: ");
            coeficienteA = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o valor do Coeficiente B: ");
            coeficienteB = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o valor do Coeficiente C: ");
            coeficienteC = double.Parse(Console.ReadLine(), CI);

            if (coeficienteA == 0)
            {
                Console.WriteLine("\nIMPOSSIVEL CALCULAR, O VALOR DE 'A' NAO PODE SER ZERO.");
            }

            else
            {
                delta = ((coeficienteB * coeficienteB) - (4 * coeficienteA * coeficienteC));

                if (delta < 0)
                {
                    Console.WriteLine("\nIMPOSSIVEL CALCULAR, DELTA NAO PODE SER NEGATIVO");
                }

                else
                {
                    raizDelta = Math.Sqrt(delta);
                    x1 = (-coeficienteB + raizDelta) / (2 * coeficienteA);
                    x2 = (-coeficienteB - raizDelta) / (2 * coeficienteA);

                    Console.WriteLine($"\nX1 = {x1.ToString("F5", CI)}");
                    Console.WriteLine($"X1 = {x2.ToString("F5", CI)}");
                }
            }
        }

        static void EstruturaRepetitivasExercicio3_1()
        {
            string senha;

            Console.Write("DIGITE A SENHA NUMERICA DE QUATRO DIGITOS: ");
            senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.Write("\nSENHA INVALIDA, DIGITE NOVAMENTE: ");
                senha = Console.ReadLine();
            }

            Console.WriteLine("\nSENHA CORRETA, ACESSO PERMITIDO.");
        }

        static void EstruturaRepetitivasExercicio3_2()
        {
            int n, contIn = 0, contOut = 0;

            Console.Write("Quantos numeros serao digitados? ");
            n = int.Parse(Console.ReadLine());

            int[] numero = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nDigite o {i + 1}º numero: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (numero[i] >= 10 && numero[i] <= 20)
                {
                    contIn++;
                }

                else
                {
                    contOut++;
                }
            }

            Console.WriteLine($"\n{contIn} In");
            Console.WriteLine($"{contOut} Out");
        }
    }
}