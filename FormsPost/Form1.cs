namespace FormsPost
{
    public partial class Form1 : Form
    {
        public Blog blog { get; set; }
        public Form1()
        {
            InitializeComponent();
            InicializaBlog();
            AtualizarTela();
        }

        private void llblTitulo_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarTela()
        {
            var post = blog.Posts[blog.Posicao];
            lblTituloPost.Text = post.Titulo;
            lblTexto.Text = post.Texto;
            lblData.Text = post.DataPublicacao.ToShortDateString();
            lblLike.Text = post.Gosto.ToString();
            lblDislike.Text = post.NaoGosto.ToString();
        }
        private void InicializaBlog()
        {
            blog = new Blog();

            blog.Posts.Add(new Post
            {
                Id = 1,
                Titulo = "O BI e o ERP na Gest�o Pedag�gica",
                Texto = @"Pessoas tomam decis�es a todo momento, estas s�o as mais diversas poss�veis, sejam para sanar um problema, responder a um questionamento, tomar uma dire��o; o que se sabe � que essas decis�es geralmente s�o norteadas por cren�as, valores, conhecimentos t�cnicos, experi�ncias e que podem resultar em sucesso ou fracasso de pessoas, empresas e at� de um pa�s inteiro.",
                DataPublicacao = new DateTime(2020, 12, 21)
            });

            blog.Posts.Add(new Post
            {
                Id = 2,
                Titulo = "Reflex�es",
                Texto = @"Pense: Quando no in�cio do ano letivo uma nova turma lhe � atribu�da, quais s�o as suas cren�as em rela��o aos novos alunos? ROCHA, D. 2019. Coaching para professores.Matrix",
                DataPublicacao = new DateTime(2020, 06, 01)
            });

            blog.Posts.Add(new Post
            {
                Id = 3,
                Titulo = "Ensino H�brido - Blended Learning",
                Texto = @"O Ensino H�brido tamb�m conhecido como blended learning, significa algo misturado, combinado, ou seja, � uma modalidade de educa��o que chegou junto com a era digital e que envolve os modos de ensino online � onde o aluno geralmente busca o conhecimento sozinho atrav�s da internet, e offline � no qual este estuda em grupo, com a media��o do professor. ",
                DataPublicacao = new DateTime(2020, 05, 28)
            });
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            blog.Proximo();
            AtualizarTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            blog.Anterior();
            AtualizarTela();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            var post = blog.Posts[blog.Posicao];
            post.Like();
            AtualizarTela();
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            var post = blog.Posts[blog.Posicao];
            post.Dislike();
            AtualizarTela();
        }
    }
}
