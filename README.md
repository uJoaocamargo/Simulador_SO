# Simulador de Sistema Operacional 
Aluno João Victor Camargo RA: 113803, e Aluno Guilherme Belem RA: 114031


Este projeto é um **simulador simplificado de Sistema Operacional**, desenvolvido em C# como exercício didático. 
O objetivo é reproduzir, de forma básica, alguns dos conceitos principais de Sistemas Operacionais: criação de processos, 
escalonamento, gerenciamento de memória, operações de entrada/saída, coleta de métricas e simulação de execução no tempo.

---

🔹 Funcionalidades implementadas

1. **Processos e PCB**

   * Cada processo possui um **PCB** (Process Control Block) com:

     * ID
     * Nome
     * Tempo de CPU restante
     * Estado (Criado, Pronto, Executando, Esperando, Finalizado)
     * Prioridade
     * Program Counter
     * Registradores simulados (R0, R1, R2)
     * Tabela de arquivos abertos
   * Também são registradas métricas individuais: tempo de espera, início de execução e finalização.

2. **Threads (TCB simplificado)**

   * Estrutura para threads simuladas ligadas a processos.
   * Não há paralelismo real, apenas representação.

3. **Tabela de Processos**

   * Estrutura que mantém todos os processos criados.
   * Permite busca por ID e exibição completa.

4. **Escalonadores**

   * **FCFS (First Come First Served)**: fila simples, executa processos na ordem de chegada.
   * **Round Robin (RR)**: fila circular com quantum configurável.
   * Interface `IEscalonador` permite expandir para outras políticas.

5. **Gerenciador de Memória**

   * Modelo baseado em molduras (frames).
   * Cada processo tenta ocupar uma moldura.
   * Caso não haja moldura disponível, o processo é criado mas marcado como sem alocação (mensagem exibida).

6. **Entrada/Saída (E/S)**

   * Dispositivo com fila de espera.
   * Durante execução, há probabilidade de um processo solicitar E/S.
   * Ao terminar E/S, retorna para o estado **Pronto**.

7. **Logger com Relógio**

   * Cada evento importante gera uma linha de log com o tempo (`[t=...]`).
   * Facilita o rastreamento da execução.

8. **Métricas**

   * Número de trocas de contexto.
   * Total de ticks de CPU utilizados.
   * Tempo de espera por processo.
   * Início e fim de execução de cada processo.

9. **Interface de Linha de Comando (CLI)**

   * Permite configurar parâmetros:

     * `--escalonador=FCFS|RR`
     * `--quantum=N` (para RR)
     * `--seed=N` (semente para geração determinística)
     * `--processos=N` (quantidade de processos iniciais)
     * `--molduras=N` (quantidade de molduras de memória)

🔹 Conclusão

Este simulador não é um SO real, mas cumpre o papel de **mostrar de forma prática como funcionam os conceitos fundamentais de Sistemas Operacionais**. 
Ele pode ser facilmente estendido e serve como base para estudos acadêmicos.
