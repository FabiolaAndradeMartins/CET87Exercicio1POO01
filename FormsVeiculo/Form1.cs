namespace FormsVeiculo
{
    public partial class Form1 : Form
    {
        public Veiculo veiculo { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veiculo = new Veiculo("11-RR-44", 112000, 45, 20, 145);
            AtualizaStatus();
        }

        private void AtualizaStatus()
        {
            lblStatusVeiculo.Text = veiculo.ToString();
        }

        private void btnRegistaViagem_Click(object sender, EventArgs e)
        {
            veiculo.RegistrarViagem((int)numQuilometros.Value);
            AtualizaStatus();
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            veiculo.Abastecer(numLitros.Value);
            decimal valorLitro = decimal.Parse(txtValorLitro.Text);

            var valorTotal = veiculo.CalcularTotalGasto(valorLitro, numLitros.Value);
            var custoMedioKm = veiculo.ValorMedioPorKm(valorLitro);
            lblAbastecer.Text = $"Valor total abastecido...:{valorTotal:n2}€\n" +
                                $"Valor medio/km...........:{custoMedioKm:n2}€";

            AtualizaStatus();
        }
    }
}
