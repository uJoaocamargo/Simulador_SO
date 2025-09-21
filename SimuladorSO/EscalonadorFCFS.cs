// EscalonadorFCFS.cs - Implementa o algoritmo de escalonamento First-Come, First-Served (FCFS)
// Mantém uma fila de processos prontos e executa o primeiro que chegou.

using System.Collections.Generic;

namespace SimuladorSO
{
    // FCFS simples: escalonador que executa processos na ordem de chegada
    public class EscalonadorFCFS : IEscalonador
    {
        private Queue<Processo> fila = new Queue<Processo>(); // fila de processos prontos
        public string Nome => "FCFS";

        // Adiciona um processo à fila de prontos
        public void AdicionarPronto(Processo p) => fila.Enqueue(p);

        // Retorna o próximo processo a ser executado (primeiro da fila)
        public Processo ProximoProcesso() => fila.Count > 0 ? fila.Dequeue() : null;

        // Tick não é usado no FCFS
        public void Tick() { /* não usado */ }
    }
}
