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
                Titulo = "O BI e o ERP na Gestão Pedagógica",
                Texto = @"Pessoas tomam decisões a todo momento, estas são as mais diversas possíveis, sejam para sanar um problema, responder a um questionamento, tomar uma direção; o que se sabe é que essas decisões geralmente são norteadas por crenças, valores, conhecimentos técnicos, experiências e que podem resultar em sucesso ou fracasso de pessoas, empresas e até de um país inteiro.",
                DataPublicacao = new DateTime(2020, 12, 21)
            });

            blog.Posts.Add(new Post
            {
                Id = 2,
                Titulo = "Reflexões",
                Texto = @"Pense: Quando no início do ano letivo uma nova turma lhe é atribuída, quais são as suas crenças em relação aos novos alunos? ROCHA, D. 2019. Coaching para professores.Matrix",
                DataPublicacao = new DateTime(2020, 06, 01)
            });

            blog.Posts.Add(new Post
            {
                Id = 3,
                Titulo = "Ensino Híbrido - Blended Learning",
                Texto = @"O Ensino Híbrido também conhecido como blended learning, significa algo misturado, combinado, ou seja, é uma modalidade de educação que chegou junto com a era digital e que envolve os modos de ensino online – onde o aluno geralmente busca o conhecimento sozinho através da internet, e offline – no qual este estuda em grupo, com a mediação do professor. ",
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
