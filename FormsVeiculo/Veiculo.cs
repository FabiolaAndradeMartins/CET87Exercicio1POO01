using Microsoft.VisualBasic.Devices;
using System.Drawing;

namespace FormsVeiculo
{
    public class Veiculo
    {
        public string Matricula { get; set; }
        public int Quilometragem { get; set; }
        public int Capacidade { get; set; }
        public int LitrosNoTanque { get; set; }
        public int ContadorViagens { get; set; }

        // Determinar quantos quilómetros é possível percorrer com o combustível que está no depósito
        public int Autonomia()
        {
            return 0;
        }

        // Registar uma viagem de K quilómetros e atualizar os dados do veículo;
        public void RegistrarViagem(int k)
        {

        }

        // Determinar se o veículo já entrou na reserva;
        public bool SeEntrouReserva()
        {
            return false;
        }

        // Dado um valor médio de custo por litro, calcular o valor total gasto em combustível;
        public int CalcularTotalGasto(int valorMedio)
        {
            return 0;
        }
        // Dado um valor médio de custo por litro, calcular o custo médio por quilómetro;

        // Meter L litros de combustível, ou o máximo possível inferior a L, sem transbordar.
    }
}
