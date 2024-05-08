using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsBalao
{
    public class Balao
    {
        public string Cor { get; set; }
        public string Direcao { get; set; }
        public int Altura { get; set; }

        public Balao(string cor, string direcao, int altura)
        {
            Cor = cor;
            Direcao = direcao;
            Altura = altura;
        }

        public void MudaCor(string novaCor) => Cor = novaCor; 

        public void MudaDirecao(string novaDirecao) => Direcao = novaDirecao;

        public void Subir(int x) => Altura += x;

        public void Descer(int y) => Altura = Altura - y < 0 ? 0 : Altura - y;

    }
}
