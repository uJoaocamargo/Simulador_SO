// Processo.cs - Define o PCB (Process Control Block) simplificado para o simulador
// Representa um processo, seus estados e métricas.

using System;
using System.Collections.Generic;

namespace SimuladorSO
{
    // Estados possíveis de um processo
    public enum EstadoDoProcesso
    {
        Criado,
        Pronto,
        Executando,
        Esperando,
        Finalizado
    }

    // Processo: PCB simplificado
    public class Processo
    {
        public int Id { get; set; } // Identificador único
        public string Nome { get; set; } // Nome do processo
        public int TempoRestanteCpu { get; set; } // Ticks restantes de CPU
        public EstadoDoProcesso Estado { get; set; } // Estado atual

        // Campos adicionais do PCB
        public int Prioridade { get; set; } // Prioridade do processo
        public int ProgramCounter { get; set; } // Contador de instruções
        public Dictionary<string, int> Registradores { get; set; } // Registradores simulados
        public List<string> ArquivosAbertos { get; set; } // Arquivos abertos pelo processo

        // Métricas por processo
        public int TempoEspera { get; set; } // Tempo total em espera
        public int InicioExecucaoTick { get; set; } = -1; // Tick de início
        public int FinalizacaoTick { get; set; } = -1; // Tick de finalização

        // Construtor: inicializa campos do processo
        public Processo(int id, string nome, int tempoCpu, int prioridade = 0)
        {
            Id = id;
            Nome = nome;
            TempoRestanteCpu = tempoCpu;
            Estado = EstadoDoProcesso.Criado;
            Prioridade = prioridade;
            ProgramCounter = 0;
            Registradores = new Dictionary<string, int> { { "R0", 0 }, { "R1", 0 }, { "R2", 0 } };
            ArquivosAbertos = new List<string>();
            TempoEspera = 0;
        }

        // Retorna uma string resumida do processo
        public override string ToString()
        {
            return $"ID:{Id} Nome:{Nome} CPU:{TempoRestanteCpu} Estado:{Estado} Pri:{Prioridade} PC:{ProgramCounter}";
        }
    }
}
