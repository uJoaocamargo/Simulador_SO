// DispositivoIO.cs - Simula um dispositivo de entrada/saída (I/O) simples
// Gerencia processos que solicitam operações de I/O e libera um por tick

using System.Collections.Generic;

namespace SimuladorSO
{
    // Dispositivo de E/S simples com fila de processos esperando I/O
    public class DispositivoIO
    {
        private Queue<Processo> fila = new Queue<Processo>(); // fila de processos esperando I/O

        // Adiciona processo à fila de E/S
        public void SolicitarIO(Processo p)
        {
            fila.Enqueue(p);
        }

        // Executa um passo de E/S (libera 1 processo por tick)
        public Processo Tick()
        {
            return fila.Count > 0 ? fila.Dequeue() : null;
        }

        // Retorna o tamanho da fila de espera
        public int TamanhoFila()
        {
            return fila.Count;
        }
    }
}
