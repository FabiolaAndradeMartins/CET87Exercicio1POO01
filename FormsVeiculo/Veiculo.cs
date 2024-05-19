namespace FormsVeiculo
{
    public class Veiculo
    {
        #region Costantes
        // Quantidade de Litros da Reserva do Tanque
        const int Reserva = 10;
        // Consumo médio veículo l/ 100 Km
        const decimal ConsumoMedio = 6.5M;
        #endregion

        #region Propriedades
        public string Matricula { get; set; }
        public decimal Quilometragem { get; set; }
        public decimal CapacidadeTanque { get; set; }
        public decimal LitrosNoTanque { get; set; }
        public int ContadorViagens { get; set; }
        #endregion

        #region Construtores        
        public Veiculo(string matricula, int quilometragem, int capacidade, int litrosNoTanque, int contadorViagens)
        {
            Matricula = matricula;
            Quilometragem = quilometragem;
            CapacidadeTanque = capacidade;
            LitrosNoTanque = litrosNoTanque;
            ContadorViagens = contadorViagens;
        }
        #endregion

        #region Metodos
        // Determinar quantos quilómetros é possível percorrer com o
        // combustível que está no depósito
        public decimal Autonomia()
        {
            return LitrosNoTanque / ConsumoMedio * 100;
        }

        // Registar uma viagem de K quilómetros e atualizar os dados do veículo;
        public void RegistrarViagem(int quilometrosPercorridos)
        {
            Quilometragem += quilometrosPercorridos;

            // Converter o consumo para litros por quilômetro
            decimal consumoDeCombustivelPorKm = ConsumoMedio / 100;

            // Calcular os litros consumidos
            decimal litrosConsumidos = consumoDeCombustivelPorKm * quilometrosPercorridos;

            LitrosNoTanque -= (int)litrosConsumidos;
            ContadorViagens++;
        }

        // Determinar se o veículo já entrou na reserva;
        public bool SeEntrouReserva() => LitrosNoTanque <= Reserva;        

        // Dado um valor médio de custo por litro, calcular o
        // valor total gasto em combustível;
        public decimal CalcularTotalGasto(decimal custoMedioPorLitro, decimal litros) => litros * custoMedioPorLitro;
        
        // Dado um valor médio de custo por litro, calcular o
        // custo médio por quilómetro;
        public decimal ValorMedioPorKm(decimal custoMedioPorLitro)
        {
            decimal consumoDeCombustivelPorKm = ConsumoMedio / 100M;
            return custoMedioPorLitro * consumoDeCombustivelPorKm;
        }

        // Meter L litros de combustível, ou o máximo possível inferior a L, sem transbordar.
        public void Abastecer(decimal litros)
        {
            // Usando operadores ternários
            LitrosNoTanque = LitrosNoTanque + litros > CapacidadeTanque
                ? CapacidadeTanque
                : LitrosNoTanque + litros;
        }

        #endregion

        // Sobrescrever método ToString retornando as informações do 
        // objeto do tipo Veiculo
        public override string ToString()
        {
            return $"Matricula carro...........: {Matricula}\n"
                + $"Quilometragem.............: {Quilometragem:n2} km\n"
                + $"Capacidade do Tanque......: {CapacidadeTanque:n2} litros\n"
                + $"Litros no tanque..........: {LitrosNoTanque:n2} litros\n"
                + $"Autonomia.................: {Autonomia():n2} km\n"
                + $"Consumo Medio.............: {ConsumoMedio:n2} l/100km\n"
                + $"Reserva...................: {SeEntrouReserva()}\n"
                + $"Contador de Viagens.......: {ContadorViagens}\n"
                ;
        }
    }
}
