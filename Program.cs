using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int valorSaque = 0;
                while (valorSaque == 0)
                {
                    Console.Write("Digite um valor para saque: ");
                    string valor = Console.ReadLine();
                    if (int.TryParse(valor, out valorSaque))
                    {
                        List<Nota> lstCedulas = new List<Nota>();
                        MaquinaDinheiro.CalculaCedulas(valorSaque, ref lstCedulas);
                        MaquinaDinheiro.Sacar(lstCedulas);
                    }
                    else
                        throw new ArgumentException("Valor inválido");
                }
            }
            catch(ArgumentException aex) {
                Console.WriteLine(aex.Message);
            }
            catch (Exception){
                Console.WriteLine("Ocorreu um erro ao sacar cédulas");
            }

            Console.ReadKey();
        }
    }
}
