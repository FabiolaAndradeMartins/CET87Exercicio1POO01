using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FormsBalao
{
    public partial class Form1 : Form
    {
        private Balao _balao;
        #region Método Construtor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        public void InicializaBalao()
        {
            _balao = new Balao("Red", "Norte", 1000);
        }

        public void AtualizaDados()
        {

            txtDirecao.Text = _balao.Direcao;
            lblAlturaAtual.Text = _balao.Altura.ToString();
        }

        private void PosicionaBalao()
        {
            picBalao.Top = _balao.PosicaoForm / 100 + 200;
            DesenharBalao(picBalao, colorDialog.Color);
        }
        private void MudarCorPictureBox(PictureBox pictureBox)
        {
            // Muda a cor do Objeto
            _balao.MudaCor(colorDialog.Color.ToString());

            // Muda a cor do Label
            lblCorSelecionada.Text = _balao.Cor;

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

        #endregion


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
            _balao.MudaDirecao(txtDirecao.Text);

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            _balao.Subir((int)numX.Value);
            AtualizaDados();
            PosicionaBalao();
            MudarCorPictureBox(picBalao);
        }


        private void btnDescer_Click(object sender, EventArgs e)
        {
            _balao.Descer((int)numY.Value);
            AtualizaDados();
            PosicionaBalao();
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
