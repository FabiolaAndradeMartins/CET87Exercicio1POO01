namespace FormsBalao
{
    public class Balao
    {
        public string Cor { get; set; }
        public string Direcao { get; set; }
        public int Altura { get; set; }
        public int PosicaoForm { get; set; }


        public Balao(string cor, string direcao, int altura)
        {
            Cor = cor;
            Direcao = direcao;
            Altura = altura;
            PosicaoForm = altura;
        }

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

    }
}
