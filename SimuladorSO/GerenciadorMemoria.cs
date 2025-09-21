// GerenciadorMemoria.cs - Gerencia a alocação e liberação de molduras de memória para processos
// Simula um gerenciador de memória simples baseado em molduras (frames)

using System.Collections.Generic;

namespace SimuladorSO
{
    // Gerenciador de memória muito simples (molduras)
    public class GerenciadorMemoria
    {
        private int totalMolduras; // Total de molduras disponíveis
        private Dictionary<int, int> mapaProcessoParaMoldura = new Dictionary<int, int>(); // Mapeia processo para moldura
        private Queue<int> moldurasLivres = new Queue<int>(); // Molduras livres

        // Construtor: inicializa molduras livres
        public GerenciadorMemoria(int total)
        {
            totalMolduras = total > 0 ? total : 1;
            for (int i = 0; i < totalMolduras; i++) moldurasLivres.Enqueue(i);
        }

        // Tenta alocar uma moldura para o processo
        public bool Alocar(Processo p)
        {
            if (moldurasLivres.Count == 0) return false;
            int moldura = moldurasLivres.Dequeue();
            mapaProcessoParaMoldura[p.Id] = moldura;
            return true;
        }

        // Libera a moldura alocada para o processo
        public void Liberar(Processo p)
        {
            if (mapaProcessoParaMoldura.TryGetValue(p.Id, out int m))
            {
                mapaProcessoParaMoldura.Remove(p.Id);
                moldurasLivres.Enqueue(m);
            }
        }

        // Retorna uma string com o estado da memória
        public override string ToString()
        {
            return $"Memória: {totalMolduras} molduras, livres: {moldurasLivres.Count}";
        }
    }
}
