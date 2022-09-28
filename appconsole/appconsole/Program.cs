using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace appconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string nome, cpf;
            int idade, pergunta;






            do
            {


                Console.WriteLine("Olá, escolha o que deseja fazer");
                Console.WriteLine("______________________________");
                Console.WriteLine();
                Console.WriteLine("      1: Calculadora          ");
                Console.WriteLine("      2: Fazer Cadastro       ");
                Console.WriteLine("      3: Sair                 ");
                Console.WriteLine("______________________________");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Digite o numero do que deseja fazer: ");
                numero = double.Parse(Console.ReadLine());




                switch (numero)
                {
                    case 2:
                        Console.Write("Seu nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Seu CPF: ");
                        cpf = Console.ReadLine();
                        Console.Write("Sua Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Suas informações:");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("CPF: " + cpf);
                        Console.WriteLine("Idade: " + idade);
                        break;
                    case 1:
                        calculadora c = new calculadora();
                        Console.Write("Digite o primeiro numero: ");
                        c.num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        c.num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("");
                        c.resultadoS = c.num1 + c.num2;
                        Console.WriteLine("Resultado soma: " + c.resultadoS);
                        c.resultadoSub = c.num1 - c.num2;
                        Console.WriteLine("Resultado subtração: " + c.resultadoSub);
                        c.resultadoM = c.num1 * c.num2;
                        Console.WriteLine("Resultado multiplicação: " + c.resultadoM);
                        c.resultadoD = c.num1 / c.num2;
                        Console.WriteLine("Resultado divisão: " + c.resultadoD);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;



                }

                Console.WriteLine("");
                Console.Write("Digite 1 para voltar: ");
                pergunta = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (pergunta == 1);

        }
    }
}
