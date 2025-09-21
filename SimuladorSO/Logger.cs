// Logger.cs - Logger simples para registrar eventos e controlar o relógio da simulação
// Permite logar mensagens e avançar o tempo (tick)

namespace SimuladorSO
{
    // Logger simples com clock
    public class Logger
    {
        public int Relogio { get; private set; } = 0; // Relógio da simulação

        // Avança o relógio em 1 tick
        public void Tick()
        {
            Relogio++;
        }

        // Loga uma mensagem (pode ser adaptado para gravar em arquivo, etc.)
        public void Log(string mensagem)
        {
            // Exibe mensagem no console com o tick atual
            System.Console.WriteLine($"[t={Relogio}] {mensagem}");
        }
    }
}
