using System;
using System.Collections.Generic;
using Projeto_Figuras.Entities;
using Projeto_Figuras.Entities.Enums;

namespace Projeto_Figuras
{
    class Program
    {
        static List<Figura> lista = new List<Figura>();
        
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Escolha o tipo de figura que deseja adicionar:");
                Console.WriteLine("1 - Triangulo\n2 - Circulo\n3 - Retangulo\n4 - Quadrado\n5 - Soma total das areas\n6 - Sair");
                int.TryParse(Console.ReadLine(), out int opcSel);

                if (opcSel > 0 && opcSel < 7)
                {
                    Menu escolha = (Menu)opcSel;
                    switch (escolha)
                    {
                        case Menu.Triangulo:
                            AdicionarTriangulo();
                            break;
                        case Menu.Circulo:
                            AdicionarCirculo();
                            break;
                        case Menu.Retangulo:
                            AdicionarRetangulo();
                            break;
                        case Menu.Quadrado:
                            AdicionarQuadrado();
                            break;
                        case Menu.SomaTotal:
                            SomaTotal();
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                Console.Clear();
            }

            static void AdicionarTriangulo()
            {
                Console.WriteLine("Digite os lados do Triangulo:");
                Console.Write("Lado A: ");
                double ladoA = double.Parse(Console.ReadLine());
                Console.Write("Lado B: ");
                double ladoB = double.Parse(Console.ReadLine());
                Console.Write("Lado C: ");
                double ladoC = double.Parse(Console.ReadLine());
                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
                lista.Add(triangulo);
                Console.WriteLine("Concluido. Pressione ENTER para voltar");
                Console.ReadLine();
            }
            static void AdicionarCirculo()
            {
                Console.WriteLine("Digite o raio do Circulo com duas casas decimais: ");
                double raio = double.Parse(Console.ReadLine());
                Circulo circulo = new Circulo(raio);
                lista.Add(circulo);
                Console.WriteLine("Concluido. Pressione ENTER para voltar");
                Console.ReadLine();
            }
            static void AdicionarRetangulo()
            {
                Console.WriteLine("Digite os lados do Retangulo:");
                Console.Write("Lado A: ");
                double ladoA = double.Parse(Console.ReadLine());
                Console.Write("Lado B: ");
                double ladoB = double.Parse(Console.ReadLine());

                Retangulo retangulo = new Retangulo(ladoA, ladoB);
                lista.Add(retangulo);
                Console.WriteLine("Concluido. Pressione ENTER para voltar");
                Console.ReadLine();
            }
            static void AdicionarQuadrado()
            {
                Console.WriteLine("Digite a base do Quadrado:");
                double ladoA = double.Parse(Console.ReadLine());                

                Quadrado quadrado1 = new Quadrado(ladoA);
                lista.Add(quadrado1);
                Console.WriteLine("Concluido. Pressione ENTER para voltar");
                Console.ReadLine();
            }
            static void SomaTotal()
            {
                double total = 0;

                foreach (Figura figuras in lista)
                {
                    total += figuras.Area();
                }
                Console.WriteLine("Area total: " + total.ToString("F4"));
                Console.WriteLine("Concluido. Pressione ENTER para voltar");
                Console.ReadLine();
            }
        }
    }
}