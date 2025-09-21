// Metricas.cs - Armazena métricas simples da simulação
// Conta trocas de contexto e ticks de CPU utilizados

namespace SimuladorSO
{
    // Métricas simples
    public class Metricas
    {
        public int TrocasDeContexto { get; private set; } = 0; // Número de trocas de contexto
        public int TicksCpuUtilizados { get; private set; } = 0; // Ticks de CPU usados

        // Incrementa trocas de contexto
        public void RegistrarTroca() => TrocasDeContexto++;
        // Incrementa ticks de CPU
        public void RegistrarCpuTick() => TicksCpuUtilizados++;

        // Retorna uma string com as métricas
        public override string ToString()
        {
            return $"Trocas de contexto: {TrocasDeContexto} | Ticks CPU usados: {TicksCpuUtilizados}";
        }
    }
}
