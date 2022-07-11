using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio2
{
    public static class MaquinaDinheiro
    {
        public static void CalculaCedulas(int valorSaque, ref List<Nota> lstCedulas)
        {
            // Obtém padrão de notas
            var listaNotas = new List<Nota>()
            {
                new Nota(){Valor = 10},
                new Nota(){Valor = 20},
                new Nota(){Valor = 50},
                new Nota(){Valor = 100}
            };

            // Calcula maior nota
            Nota maiorNota = listaNotas.FirstOrDefault();
            foreach (Nota nota in listaNotas)
                if (valorSaque >= nota.Valor)
                    maiorNota = nota;

            // Adiciona notas na lista de retorno conforme divisão da maior nota
            for (int i = 0; i < valorSaque / maiorNota.Valor; i++)
                lstCedulas.Add(maiorNota);

            // Varifica se sobrou valor e chama o método novamente de forma recursiva
            var valorRestante = valorSaque % maiorNota.Valor;
            if ((valorRestante != 0) && (valorRestante >= 10))
                CalculaCedulas(valorRestante, ref lstCedulas);
        }

        public static void Sacar(List<Nota> notas)
        {
            // REALIZA O SAQUE DAS NOTAS 
            foreach (Nota nota in notas)
                Console.WriteLine($"SACANDO NOTA {nota.Valor}");
        }
    }
}
