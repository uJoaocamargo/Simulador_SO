// ThreadSimulada.cs - Simula uma thread/processo para fins de teste ou extensão
// Pode ser usada para representar execução concorrente no simulador

using System;

namespace SimuladorSO
{
    // Thread simulada (exemplo, pode ser expandida conforme necessidade)
    public class ThreadSimulada
    {
        public int Tid { get; set; } // Identificador da thread
        public Processo Pai { get; set; }
        public EstadoDoProcesso Estado { get; set; }
        public int StackPointer { get; set; } // Ponteiro da pilha da thread

        // Construtor
        public ThreadSimulada(int tid, Processo pai)
        {
            Tid = tid;
            Pai = pai;
            Estado = EstadoDoProcesso.Criado;
            StackPointer = 0;
        }
    }
}
