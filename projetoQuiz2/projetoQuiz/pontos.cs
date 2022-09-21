using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoQuiz
{
    public class pontos
    {
        public int pontuacao, total;
        public void pontos2()
        {
           
            pontuacao = pontuacao + 10;
            Console.WriteLine("");
            Console.WriteLine("Parabéns você acertou e ganhou mais "+pontuacao+" pontos!!");
        }


       
    }
}
