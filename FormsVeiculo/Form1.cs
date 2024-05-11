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
            AtualizaStatus();
        }

        private void btnValorMedioPorKm_Click(object sender, EventArgs e)
        {
            var valor = veiculo.ValorMedioPorKm(decimal.Parse(txtValorMedioPorKm.Text));
            lblValorMedioPorKm.Text = $"Valor = {valor:n2}€/Km";
        }
    }
}
