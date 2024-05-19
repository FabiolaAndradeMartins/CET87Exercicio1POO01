namespace FormsPost
{
    public class Blog
    {
        #region Atributos (Fields)
        private List<Post> _posts = new List<Post>();
        private int _posicao = 0; 
        #endregion

        #region Propriedades
        public List<Post> Posts { get => _posts; set => _posts = value; }
        public int Posicao { get => _posicao; set => _posicao = value; }
        #endregion

        #region Métodos
        public void Proximo()
        {
            var qtd = Posts.Count;

            // Verifica se não chegou na ultima posição
            if (Posicao < qtd - 1) 
            {
                // vai para o proximo post
                Posicao++;
            }
            else
            {
                // vai para o primeiro post
                Posicao = 0;
            }
        }
        public void Anterior()
        {
            var qtd = Posts.Count;

            // Verifica se não chegou na primeira posição
            if (Posicao != 0)
            {
                // vai para o post anterior
                Posicao--;
            }
            else
            {
                // vai para o ultimo post
                Posicao = qtd - 1;
            }
        }
        #endregion
    }
}
