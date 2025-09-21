// EscalonadorRR.cs - Implementa o algoritmo de escalonamento Round Robin (RR)
// Mantém uma fila de processos prontos e executa cada um por um quantum definido.

using System.Collections.Generic;

namespace SimuladorSO
{
    // Round Robin simples: escalonador que executa processos por fatias de tempo (quantum)
    public class EscalonadorRR : IEscalonador
    {
        private Queue<Processo> fila = new Queue<Processo>(); // fila de processos prontos
        private int quantum; // quantum de execução
        public string Nome => $"RR(q={quantum})";

        // Construtor: define o quantum
        public EscalonadorRR(int q)
        {
            quantum = q > 0 ? q : 1;
        }

        // Adiciona um processo à fila de prontos, evitando duplicatas
        public void AdicionarPronto(Processo p)
        {
            if (!fila.Contains(p))
                fila.Enqueue(p);
        }

        // Retorna o próximo processo a ser executado (primeiro da fila)
        public Processo ProximoProcesso()
        {
            return fila.Count > 0 ? fila.Dequeue() : null;
        }

        // Tick não é usado diretamente, quantum é gerido pelo SO
        public void Tick() { /* lógica do quantum é gerida pelo SO principal */ }
    }
}
