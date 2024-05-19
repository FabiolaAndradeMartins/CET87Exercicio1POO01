namespace FormsPost
{
    public class Post
    {
        #region Propriedades
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int Gosto { get; set; } = 0;
        public int NaoGosto { get; set; } = 0;
        #endregion

        #region Métodos

        // Método para incrementar Gosto usando operador lambda
        public void Like() => Gosto++;

        public void Dislike() => NaoGosto++;
        #endregion
    }
}
