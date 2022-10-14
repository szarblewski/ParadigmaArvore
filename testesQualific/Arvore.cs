using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesQualific
{
    internal class CriaArvore
    {
        public No raiz = null;
        private int contador = 0;
        string imp = "";


        public Dictionary<string, string> Erros = new Dictionary<string, string>()
        {
            {"E1",  "Mais de 2 filhos"},
            {"E2",  "Ciclo presente"},
            {"E3",  "Raízes múltiplas"},
            {"E4",  "Qualquer outro erro" }

        };

        //public CriaArvore(string[,] dic)
        //{
        //    raiz = null;
        //    contador = 0;
        //    //dic1.OrderBy(x => x.Key)
        //    //for (int i = 0; i < dados.Length / 2; i++)
        //    //{
        //    //    insere(dados[i, 0], dados[i, 1]);
        //    //}

        //    MontaArvore(dic);
        //}

        public CriaArvore(List<List<char>> dados)
        {
            imp = MontaArvore(dados);
        }

        private string MontaArvore(List<List<char>> dados)
        {
            try
            {
                List<No> nos = new List<No>();

                if(!dados.Any())
                {
                    Console.WriteLine("Nenhum dado informado");
                    Console.WriteLine(Erros["E4"]);
                    return "";
                }

                raiz = null;
                foreach (List<char> value in dados)
                {
                    if (!value.Any())
                        Console.WriteLine("Valores informados em branco!");
                    else if (value.Count() > 2)
                        Console.WriteLine("Informado valores a mais na lista limitada a 2");

                    No chave = new No(value[0]);
                    No dep = new No(value[1]);

                    if (raiz != null && raiz.BuscaChave(dep) != null)
                        Console.WriteLine(Erros["E3"]);

                    if (nos.Any())
                    {
                        List<No> rem = new List<No>();
                        foreach (var item in nos)
                        {
                            if (dep.Compara(item))
                            {
                                dep.Adiciona(item.Esquerda);
                                dep.Adiciona(item.Direita);
                            }
                        }

                        if (rem.Any())
                        {
                            foreach (var item in rem)
                            {
                                nos.Remove(item);
                            }
                        }
                    }

                    if(raiz != null)
                    {
                        if (raiz.Compara(dep))
                        {
                            chave.Esquerda = raiz;
                            raiz = chave;
                            continue;
                        }
                        else
                        {
                            var n = raiz.BuscaNo(chave.Chave);
                            if(n != null)
                            {
                                n.Adiciona(dep);
                                continue;
                            }
                            else
                            {
                                chave.Esquerda = dep;
                                nos.Add(chave);
                                continue;
                            }
                        }
                    }
                    else
                    {
                        chave.Esquerda = dep;
                        raiz = chave;
                        continue;
                    }    
                }

                return raiz.MontaImpressao();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(Erros["E4"]);
                return "";
            }
        }





        

        public void imprime()
        {
            try
            {
               Console.WriteLine(imp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de impressao " + ex.Message);
                
            }
        }

       
    }
}
