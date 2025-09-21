// Program.cs - Ponto de entrada do simulador de sistema operacional
// Inicializa parâmetros, escalonador, memória, dispositivos e executa a simulação.

using System;

namespace SimuladorSO
{
    public static class Program
    {
        // Método principal: inicializa e executa a simulação
        public static void Main(string[] args)
        {
            // parâmetros padrão
            string escalonador = "FCFS"; // ou "RR"
            int quantum = 4;
            int seed = 42;
            int processosIniciais = 5;
            int memoriaMolduras = 3;

            // parse simples de args
            foreach (var a in args)
            {
                if (a.StartsWith("--escalonador="))
                    escalonador = a.Split('=')[1].ToUpper();
                else if (a.StartsWith("--quantum="))
                    int.TryParse(a.Split('=')[1], out quantum);
                else if (a.StartsWith("--seed="))
                    int.TryParse(a.Split('=')[1], out seed);
                else if (a.StartsWith("--processos="))
                    int.TryParse(a.Split('=')[1], out processosIniciais);
                else if (a.StartsWith("--molduras="))
                    int.TryParse(a.Split('=')[1], out memoriaMolduras);
            }

            Console.WriteLine("Simulador de Sistema Operacional");
            Console.WriteLine($"Escalonador: {escalonador} | Quantum: {quantum} | Seed: {seed} | Molduras: {memoriaMolduras}");
            Console.WriteLine();

            Random rnd = new Random(seed);
            IEscalonador esc;
            if (escalonador == "RR")
                esc = new EscalonadorRR(quantum);
            else
                esc = new EscalonadorFCFS();

            var gerMem = new GerenciadorMemoria(memoriaMolduras);
            var disp = new DispositivoIO();
            var so = new SistemaOperacional(esc, gerMem, disp, rnd, quantum);

            // Cria processos iniciais e coloca em pronto
            for (int i = 0; i < processosIniciais; i++)
            {
                int tempoCpu = rnd.Next(3, 12);
                int pri = rnd.Next(0, 3);
                var p = so.CriarProcesso("P" + (i + 1), tempoCpu, pri);
                so.ColocarEmPronto(p.Id);
            }

            // Executa a simulação principal
            so.ExecutarSimulacao();
        }
    }
}
