﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome, calculadora, resposta;        
            string cpf;
          

            


            //Cadastro
            Console.Write("Diga o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Qual seu CPF: ");
            cpf = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Olá " + nome + ", seja bem vindo ao nosso Quiz!!");
            Console.WriteLine("Seu CPF é: " + cpf);
            //fim do cadastro

            //primeira pergunta
            Console.WriteLine("\n");
            Console.WriteLine("(Se precisar de ajuda recorra a nossa calculadora)");
            Console.WriteLine("Vamos para as perguntas\n");
            Console.WriteLine("Quanto é 50,1 - 25,2?");
            Console.WriteLine("");
            Console.Write("Calculadora? (sim ou nao): ");
            calculadora = Console.ReadLine();


            if (calculadora == "sim")
            {
                program();
                Console.WriteLine("Sua respota é: ");
                resposta = Console.ReadLine();
                if (resposta == "24,9")
                {
                    
                    pontos p = new pontos();
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns você acertou e ganhou mais pontos!" + p);

                }
                else if (resposta != "24,9")
                {
                    Console.WriteLine("Você errou e não recebeu pontos!");
                }

            }
            else if (calculadora == "nao")
            {
                Console.WriteLine("Sua respota é: ");
                resposta = Console.ReadLine();
                if (resposta == "24,9")
                {
                    pontos p = new pontos();
                    p.pontos2();
                   
                }
                else if (resposta != "24,9")
                {
                    Console.WriteLine("Você errou e não recebeu pontos!");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            //fim da primira pergunta

            Console.WriteLine("Quanto é 27,8-17,2?");
            Console.Write("Calculadora? (sim ou nao): ");
            calculadora = Console.ReadLine();
            if (calculadora == "sim")
            {
                program();
                Console.WriteLine("Sua respota é: ");
                resposta = Console.ReadLine();
                if (resposta == "10,6")
              {
                    
                    pontos p = new pontos();
                    p.pontos2();

                }
                else if (resposta != "10,6")
                {
                    Console.WriteLine("Você errou e não recebeu pontos!");
                }

            }
            else if (calculadora == "nao")
            {
                Console.WriteLine("Sua respota é: ");
                resposta = Console.ReadLine();
                if (resposta == "10,6")
                {
                    pontos p = new pontos();
                    p.pontos2();

                }
                else if (resposta != "10,6")
                {
                    Console.WriteLine("Você errou e não recebeu pontos!");
                }

            }

        }

        




        static void program()
        {
            double resultado, num1, num2;
            Console.WriteLine("Digite o 1° numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° numero");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 - num2;

            Console.WriteLine("A resposta é: " + resultado);


        }
    }
}