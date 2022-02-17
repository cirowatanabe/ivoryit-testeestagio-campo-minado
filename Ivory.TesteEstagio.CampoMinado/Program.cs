using System;
using System.Collections.Generic;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            // Primeiro, eu preciso acessar a matriz do jogo. Como a classe Jogo é private, eu a recrio a partir da string Tabuleiro.

            string[,] Jogo = new string[9, 9];

            JogoVirtual.AtualizarJogo(Jogo, campoMinado);

            while (true)
            {
                JogoVirtual.AtualizarJogo(Jogo, campoMinado);
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        string sup = "";
                        string inf = "";
                        string esq = "";
                        string dir = "";
                        string supEsq = "";
                        string supDir = "";
                        string infEsq = "";
                        string infDir = "";
                        List<string> entorno = new List<string>();

                        if (x > 0)
                        {
                            sup = Jogo[x - 1, y];
                        }
                        if (y > 0)
                        {
                            esq = Jogo[x, y - 1];
                        }
                        if (y < 8)
                        {
                            dir = Jogo[x, y + 1];
                        }
                        if (x > 0 && y > 0)
                        {
                            supEsq = Jogo[x - 1, y - 1];
                        }
                        if (x > 0 && y < 8)
                        {
                            supDir = Jogo[x - 1, y + 1];
                        }
                        if (x < 8)
                        {
                            inf = Jogo[x + 1, y];
                        }
                        if (x < 8 && y > 0)
                        {
                            infEsq = Jogo[x + 1, y - 1];
                        }
                        if (x < 8 && y < 8)
                        {
                            infDir = Jogo[x + 1, y + 1];
                        }

                        if (Jogo[x, y] != "-" && Jogo[x, y] != "0" && Jogo[x, y] != "M")
                        {
                            int counter = 0;
                            int counterMines = 0;

                            // 0
                            entorno.Add(sup);
                            // 1
                            entorno.Add(inf);
                            // 2
                            entorno.Add(esq);
                            // 3
                            entorno.Add(dir);
                            // 4
                            entorno.Add(supEsq);
                            // 5
                            entorno.Add(supDir);
                            // 6
                            entorno.Add(infEsq);
                            // 7
                            entorno.Add(infDir);

                            foreach (string item in entorno)
                            {
                                if (item == "-")
                                {
                                    counter++;
                                }
                                else if (item == "M")
                                {
                                    counterMines++;
                                }
                            }

                            // Marcação das minas

                            if (int.Parse(Jogo[x, y]) - counterMines == counter)
                            {
                                List<int> posicoesMinas = new List<int>();
                                for (int i = 0; i < entorno.Count; i++)
                                {
                                    if (entorno[i] == "-")
                                    {
                                        posicoesMinas.Add(i);
                                        counterMines++;
                                    }
                                }

                                // E.g.: se "-" estiver na posição 0 da lista 'entorno', então a mina estará em cima (sup) do número analisado

                                foreach (int pos in posicoesMinas)
                                {
                                    if (pos == 0)
                                    {
                                        Jogo[x - 1, y] = "M";
                                    }
                                    else if (pos == 1)
                                    {
                                        Jogo[x + 1, y] = "M";
                                    }
                                    else if (pos == 2)
                                    {
                                        Jogo[x, y - 1] = "M";
                                    }
                                    else if (pos == 3)
                                    {
                                        Jogo[x, y + 1] = "M";
                                    }
                                    else if (pos == 4)
                                    {
                                        Jogo[x - 1, y - 1] = "M";
                                    }
                                    else if (pos == 5)
                                    {
                                        Jogo[x - 1, y + 1] = "M";
                                    }
                                    else if (pos == 6)
                                    {
                                        Jogo[x + 1, y - 1] = "M";
                                    }
                                    else if (pos == 7)
                                    {
                                        Jogo[x + 1, y + 1] = "M";
                                    }
                                }
                            }
                        }
                    }
                }

                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        string sup = "";
                        string inf = "";
                        string esq = "";
                        string dir = "";
                        string supEsq = "";
                        string supDir = "";
                        string infEsq = "";
                        string infDir = "";
                        List<string> entorno = new List<string>();
                        if (x > 0)
                        {
                            sup = Jogo[x - 1, y];
                        }
                        if (y > 0)
                        {
                            esq = Jogo[x, y - 1];
                        }
                        if (y < 8)
                        {
                            dir = Jogo[x, y + 1];
                        }
                        if (x > 0 && y > 0)
                        {
                            supEsq = Jogo[x - 1, y - 1];
                        }
                        if (x > 0 && y < 8)
                        {
                            supDir = Jogo[x - 1, y + 1];
                        }
                        if (x < 8)
                        {
                            inf = Jogo[x + 1, y];
                        }
                        if (x < 8 && y > 0)
                        {
                            infEsq = Jogo[x + 1, y - 1];
                        }
                        if (x < 8 && y < 8)
                        {
                            infDir = Jogo[x + 1, y + 1];
                        }

                        if (Jogo[x, y] != "-" && Jogo[x, y] != "0" && Jogo[x, y] != "M")
                        {
                            int counter = 0;
                            int counterMines = 0;

                            // 0
                            entorno.Add(sup);
                            // 1
                            entorno.Add(inf);
                            // 2
                            entorno.Add(esq);
                            // 3
                            entorno.Add(dir);
                            // 4
                            entorno.Add(supEsq);
                            // 5
                            entorno.Add(supDir);
                            // 6
                            entorno.Add(infEsq);
                            // 7
                            entorno.Add(infDir);

                            foreach (string item in entorno)
                            {
                                if (item == "-")
                                {
                                    counter++;
                                }
                                else if (item == "M")
                                {
                                    counterMines++;
                                }
                            }

                            // Caso o número de minas seja igual ao número analisado e ainda houver "-" no entorno do número:

                            if (counterMines == int.Parse(Jogo[x, y]) && counter != 0)
                            {
                                List<int> posicoesRiscos = new List<int>();
                                for (int i = 0; i < entorno.Count; i++)
                                {
                                    if (entorno[i] == "-")
                                    {
                                        posicoesRiscos.Add(i);
                                    }
                                }
                                foreach (int pos in posicoesRiscos)
                                {
                                    if (pos == 0)
                                    {
                                        campoMinado.Abrir(x, y + 1);
                                    }
                                    if (pos == 1)
                                    {
                                        campoMinado.Abrir(x + 2, y + 1);
                                    }
                                    if (pos == 2)
                                    {
                                        campoMinado.Abrir(x + 1, y);
                                    }
                                    if (pos == 3)
                                    {
                                        campoMinado.Abrir(x + 1, y + 2);
                                    }
                                    if (pos == 4)
                                    {
                                        campoMinado.Abrir(x, y);
                                    }
                                    if (pos == 5)
                                    {
                                        campoMinado.Abrir(x, y + 2);
                                    }
                                    if (pos == 6)
                                    {
                                        campoMinado.Abrir(x + 2, y);
                                    }
                                    if (pos == 7)
                                    {
                                        campoMinado.Abrir(x + 2, y + 2);
                                    }
                                }
                            }
                        }
                    }
                }
                if (campoMinado.JogoStatus != 0)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=========");
            Console.WriteLine();
            Console.WriteLine(campoMinado.Tabuleiro);
            Console.WriteLine();
            Console.WriteLine($"STATUS DO JOGO: {campoMinado.JogoStatus}");
        }
    }
}
