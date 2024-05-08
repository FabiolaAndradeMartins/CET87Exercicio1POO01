namespace FormsBalao
{
    public partial class Form1 : Form
    {
        public Balao balao { get; set; }

        public Form1()
        {
            InitializeComponent();
            InicializaBalao();
            AtualizaDados();
        }

        public void InicializaBalao()
        {
            balao = new Balao("Branco", "Norte", 1000);
        }

        public void AtualizaDados()
        {
            txtCor.Text = balao.Cor;
            txtDirecao.Text = balao.Direcao;
            lblAlturaAtual.Text = balao.Altura.ToString();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            balao.MudaCor(txtCor.Text);
        }

        private void btnDirecao_Click(object sender, EventArgs e)
        {
            balao.MudaDirecao(txtDirecao.Text);            
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            balao.Subir((int)numX.Value);
            AtualizaDados();
        }

        private void btnDescer_Click(object sender, EventArgs e)
        {
            balao.Descer((int)numY.Value);
            AtualizaDados();
        }
    }
}
