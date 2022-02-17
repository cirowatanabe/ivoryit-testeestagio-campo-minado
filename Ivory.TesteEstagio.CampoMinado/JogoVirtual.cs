using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ivory.TesteEstagio.CampoMinado
{
    class JogoVirtual
    {
        public static void AtualizarJogo(string[,] Jogo, CampoMinado campoMinado)
        {
            // Esse método é responsável por criar uma matriz idêntica à matriz Jogo da classe CampoMinado. Isso é feito porque a matriz Jogo da classe CampoMinado é private e, portanto, não permite edição pelo Program.cs. No entanto, as minas precisam ser marcadas para que o programa saiba quais elementos são seguros de abrir. Essa marcação é feita na cópia gerada por este método.

            string[] sequence = Regex.Split(campoMinado.Tabuleiro, string.Empty);
            List<string> list = new List<string>();

            foreach (string s in sequence)
            {
                if (s != "\n" && s != "\r" && s != "")
                {
                    list.Add(s);
                }
            }

            for (int a = 0; a < 9; a++)
            {
                Jogo[0, a] = list[a];
            }
            for (int b = 9; b < 18; b++)
            {
                Jogo[1, b - 9] = list[b];
            }
            for (int c = 18; c < 27; c++)
            {
                Jogo[2, c - 18] = list[c];
            }
            for (int d = 27; d < 36; d++)
            {
                Jogo[3, d - 27] = list[d];
            }
            for (int e = 36; e < 45; e++)
            {
                Jogo[4, e - 36] = list[e];
            }
            for (int f = 45; f < 54; f++)
            {
                Jogo[5, f - 45] = list[f];
            }
            for (int g = 54; g < 63; g++)
            {
                Jogo[6, g - 54] = list[g];
            }
            for (int h = 63; h < 72; h++)
            {
                Jogo[7, h - 63] = list[h];
            }
            for (int i = 72; i < 81; i++)
            {
                Jogo[8, i - 72] = list[i];
            }
        }
    }
}
