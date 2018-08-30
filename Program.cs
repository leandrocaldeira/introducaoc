using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão 1 A
            int num;

            num = 1;

            while (num <= 40)
            {
                Console.WriteLine(num);
                num = num + 1;
            }
            Console.ReadKey();
            Console.Clear();


            //Questão 1 b

            for (int i = 1; i <= 40; i++)
            {
                int a = i;
                if (a < 11)
                { Console.WriteLine(i); }

                else if (a >= 11 && a <= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(i);
                }
                else if (a > 20 && a <= 30)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(i);
                }
                else if (a > 30 && a <= 40)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.Clear();

            //Questão 2 
            int x = 2;
            int y = 3;

            Console.WriteLine("x = " + x);
            // resposta: x = 2

            Console.WriteLine("o valor de x + x é " + (x + x));
            // resposta: o valor de x + x é 4
            Console.WriteLine("x =");
            // resposta x =

            Console.WriteLine((x + y) + "=" + (y + x));
            //resposta 5 = 5

            Console.ReadKey();
            Console.Clear();
            // resposta: x = 2

            //Questao 3

            Console.WriteLine("*\n**\n***\n****\n*****");
            // resposta: os asteriscos estão em linhas quebradas
            Console.ReadKey();
            Console.Clear();

            // Questão 4

            Console.WriteLine("*");
            Console.WriteLine("***");
            Console.WriteLine("*****");
            Console.WriteLine("****");
            Console.WriteLine("**");

            // respostas: os asteriscos em cada linha

            Console.ReadKey();
            Console.Clear();

            // Questão 5

            String ra;
            String nome;
            String sobrenome;

            Console.WriteLine("Digite seus dados");
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Digite sua matricula: ");
            ra = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Aluno");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(ra);

            Console.ResetColor();

            Console.WriteLine(" - ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(nome + " " + sobrenome);

            Console.ResetColor();
            Console.WriteLine("\n\n");


            Console.ReadKey();
            Console.Clear(); ;

            //Questão 6
            int numero1, numero2;
            Console.WriteLine("Digite um numero");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo numero");
            numero2 = Int32.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine("{0} + {1} = {2}", numero1, numero2, soma);

            int subtracao = numero1 - numero2;
            Console.WriteLine("{0} - {1} = {2}", numero1, numero2, subtracao);

            int mutiplicacao = numero1 * numero2;
            Console.WriteLine("{0} x {1} = {2}", numero1, numero2, mutiplicacao);

            int divisao = numero1 / numero2;
            Console.WriteLine("{0} ÷ {1} = {2}", numero1, numero2, divisao);


            Console.ReadKey();
            Console.Clear(); ;

            //Questao 7
            double raio;

            Console.Write("\nDigite o valor do raio: ");
            raio = Double.Parse(Console.ReadLine());

            double diametro = 2 * raio;
            Console.WriteLine("O valor do Diametro é: " + diametro);
            double circunferencia = 2 * Math.PI * raio;
            Console.WriteLine("O valor da circuferencia é: " + circunferencia);
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("O valor da area é: " + area);

            Console.ReadKey();
            Console.Clear();

            //Questao 8 

            int numero3, numero4, resto;
            Console.WriteLine("Digite um numeiro inteiro");
            numero3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numeiro inteiro");
            numero4 = Int32.Parse(Console.ReadLine());
            resto = numero3 % numero4;

            if (resto == 0)
            {
                Console.WriteLine(numero3 + " è multiplo de " + numero4);
            }
            else
            {
                Console.WriteLine(numero3 + " não è multiplo de " + numero4);
            }
            Console.ReadKey();
            Console.Clear();


            //Questão 9

            int unidade = 0;
            int dezena = 0;
            int centena = 0;
            int unidadeDeMilhar = 0;
            int dezenaDeMilhar = 0;
            int restoDivisao = 0;
            int quociente = 0;

            const int DECIMAL = 10;

            
            Console.WriteLine("Digite um número inteiro com 5 dígitos :");
            int numeroCincoDigitos = Int32.Parse(Console.ReadLine());

            
            restoDivisao = numeroCincoDigitos % DECIMAL;
            quociente = numeroCincoDigitos / DECIMAL;
            unidade = restoDivisao;

            
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            dezena = restoDivisao;

            
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            centena = restoDivisao;

            
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            unidadeDeMilhar = restoDivisao;

            
            dezenaDeMilhar = quociente;

            Console.WriteLine("Número Espaçado: {0}   {1}   {2}   {3}   {4}", dezenaDeMilhar, unidadeDeMilhar, centena, dezena, unidade);

            Console.ReadKey();
            Console.Clear();

            //questão 10

            int contador = 0;
            int numero = 0;
            double quadrado = 0.0;
            double cubo = 0.0;

            Console.WriteLine("\nNúmero\t\tQuadrado\tCubo");

            while (contador <= 10) 
            {
                numero = contador;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);
                contador = contador + 1;
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}