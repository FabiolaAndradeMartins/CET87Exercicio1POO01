using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FormsBalao
{
    public partial class Form1 : Form
    {
        public Balao balao { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void InicializaBalao()
        {
            balao = new Balao("Red", "Norte", 1000);
        }

        public void AtualizaDados()
        {

            txtDirecao.Text = balao.Direcao;
            lblAlturaAtual.Text = balao.Altura.ToString();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Muda a cor da PictureBox
                MudarCorPictureBox(picBalao);
            }
        }

        private void btnDirecao_Click(object sender, EventArgs e)
        {
            balao.MudaDirecao(txtDirecao.Text);

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            balao.Subir((int)numX.Value);
            AtualizaDados();
            PosicionaBalao();
            MudarCorPictureBox(picBalao);
        }

        private void PosicionaBalao()
        {
            picBalao.Top = balao.PosicaoForm / 100 + 200;
            DesenharBalao(picBalao, colorDialog.Color);
        }

        private void btnDescer_Click(object sender, EventArgs e)
        {
            balao.Descer((int)numY.Value);
            AtualizaDados();
            PosicionaBalao();
        }

        private void MudarCorPictureBox(PictureBox pictureBox)
        {
            // Muda a cor do Objeto
            balao.MudaCor(colorDialog.Color.ToString());

            // Muda a cor do Label
            lblCorSelecionada.Text = balao.Cor;
            
            DesenharBalao(pictureBox, colorDialog.Color);
        }

        private void DesenharBalao(PictureBox picBox, Color color)
        {
            // Tamanho do balão
            int width = 50;
            int height = 70;

            // Posição inicial do balão
            // Centro dao PictureBox
            int x = (picBox.Width - width) / 2;
            int y = (picBox.Height - height) / 2;

            // Criar um objeto Graphics a partir da PictureBox
            Graphics g = picBox.CreateGraphics();

            // Criar um pincel para desenhar a forma
            using (SolidBrush brush = new SolidBrush(color))
            {
                // Desenhar a elipse (corpo do balão)
                g.FillEllipse(brush, x, y, width, height);
                
            }

            // Liberar o objeto Graphics
            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            InicializaBalao();
            AtualizaDados();
            PosicionaBalao();
            MudarCorPictureBox(picBalao);
            MudarCorPictureBox(picBalao);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MudarCorPictureBox(picBalao);
            btnCor.Enabled = btnDirecao.Enabled = btnSubir.Enabled = btnDescer.Enabled = true;
        }
    }
}
