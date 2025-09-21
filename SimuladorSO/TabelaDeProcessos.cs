// TabelaDeProcessos.cs - Gerencia a lista de processos do simulador
// Permite adicionar, buscar e listar processos

using System;
using System.Collections.Generic;

namespace SimuladorSO
{
    // Tabela de processos simples
    public class TabelaDeProcessos
    {
        private List<Processo> lista = new List<Processo>(); // Lista de processos

        // Adiciona um processo à tabela
        public void Adicionar(Processo p)
        {
            lista.Add(p);
        }

        // Busca processo pelo ID
        public Processo BuscarPorId(int id)
        {
            return lista.Find(p => p.Id == id);
        }

        // Retorna todos os processos
        public List<Processo> Todos()
        {
            return lista;
        }

        // Exibe todos os processos no console
        public void Exibir()
        {
            Console.WriteLine("\n=== Tabela de Processos ===");
            foreach (var p in lista)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("===========================\n");
        }
    }
}
