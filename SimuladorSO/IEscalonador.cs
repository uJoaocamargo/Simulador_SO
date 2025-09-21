// IEscalonador.cs - Interface para escalonadores de processos
// Define métodos obrigatórios para qualquer algoritmo de escalonamento

using SimuladorSO;

namespace SimuladorSO
{
    // Interface do escalonador
    public interface IEscalonador
    {
        // Adiciona um processo à lista de prontos
        void AdicionarPronto(Processo p);
        // Retorna o próximo processo a ser executado
        Processo ProximoProcesso();
        // Atualiza o estado do escalonador (se necessário)
        void Tick();
        // Nome do escalonador
        string Nome { get; }
    }
}
