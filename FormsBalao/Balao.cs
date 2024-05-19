namespace FormsBalao
{
    public class Balao
    {
        #region Atributos
        private string _cor;
        private string _direcao;
        private int _altura;
        private int _posicaoForm;
        #endregion


        #region Propriedades
        //public string Cor { get; set; }
        //public string Direcao { get; set; }
        //public int Altura { get; set; }
        // public int PosicaoForm { get; set; }
        public string Cor { get => _cor; set => _cor = value; }
        public string Direcao { get => _direcao; set => _direcao = value; }
        public int Altura { get => _altura; set => _altura = value; }
        public int PosicaoForm { get => _posicaoForm; set => _posicaoForm = value; }
        #endregion

        #region Metodos Construtores

        public Balao()
        {
            _cor = "Red";
            _direcao = "Norte";
            _altura = _posicaoForm = 1000;
        }

        public Balao(string cor, string direcao, int altura)
        {
            _cor = cor;
            _direcao = direcao;
            _altura = altura;
            _posicaoForm = altura;
        }
        #endregion


        #region Métodos
        public void MudaCor(string novaCor) => Cor = novaCor;

        public void MudaDirecao(string novaDirecao) => Direcao = novaDirecao;

        public void Subir(int x)
        {
            Altura += x;
            PosicaoForm -= x;
        }

        public void Descer(int y)
        {
            if (Altura - y < 0)
            {
                Altura = 0;
            }
            else
            {
                Altura -= y;
                PosicaoForm += y;
            }
        }
        #endregion

    }
}
