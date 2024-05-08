using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPost
{
    public class Blog
    {
        public List<Post> Posts { get; set; } = new List<Post>();

        public  int Posicao { get; set; } = 0;

        public void Proximo()
        {
            var qtd = Posts.Count;
            if (Posicao < qtd - 1) 
            {
                Posicao++;
            }
            else
            {
                Posicao = 0;
            }
        }
        public void Anterior()
        {
            var qtd = Posts.Count;
            if (Posicao != 0)
            {
                Posicao--;
            }
            else
            {
                Posicao = qtd - 1;
            }
        }
    }
}
