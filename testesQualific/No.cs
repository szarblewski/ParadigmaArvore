using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesQualific
{
    //define no da arvore
    public class No
    {
        public char Chave { get; set; }
        public No Esquerda, Direita;

        
        public No (char chave)
        {
            Chave = chave;
            
        }

        public bool Compara(No value)
        {
            return this.Chave == value.Chave;
        }

        public void Adiciona(No value)
        {
            try
            {
                if (value == null)
                    return;

                if (this.Esquerda == null)
                    this.Esquerda = value;
                else if (this.Direita == null)
                    if (value.Chave.CompareTo(this.Esquerda.Chave) > 0)
                    {
                        this.Direita = this.Esquerda;
                        this.Esquerda = value;
                    }
                    else { this.Direita = value; }
                else
                    Console.WriteLine("E1");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro Adiciona No :" + ex.Message);
                Console.WriteLine("E4");
                
            }
            
        }

        public No BuscaChave(No value)
        {
            try
            {
                No nf = null;
                if(this.Esquerda != null)
                {
                    if (this.Esquerda.Chave == value.Chave)
                        return this;
                    else
                        nf = this.Esquerda.BuscaChave(value);
                }

                if(nf != null)
                    return nf;

                if(this.Direita != null)
                {
                    if (this.Direita.Chave == value.Chave)
                        return this;
                    else
                        nf = this.Direita.BuscaChave(value);
                }

                if (nf != null)
                    return nf;
                else
                    return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro BuscaChave :" + ex.Message);
                return null;    
            }
        }
        

        public No BuscaNo(char value)
        {
            try
            {
                No n = null;
                if (this.Chave == value)
                    return this;

                if(this.Esquerda != null)
                    n = this.Esquerda.BuscaNo(value);

                if(n != null)
                    return n;

                if(this.Direita != null)
                    n = this.Direita.BuscaNo(value);

                return n;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro BuscaNo :" + ex.Message);
                return null;
            }
        }


        public string MontaImpressao()
        {
            var retorno = $"[{this.Chave}";

            if (this.Esquerda != null)
            {
                retorno += $"{this.Esquerda.MontaImpressao()}";
            }
            if (this.Direita != null)
            {
                retorno += $"{this.Direita.MontaImpressao()}";
            }
            retorno += $"]";


            return retorno;
        }



    }
}
