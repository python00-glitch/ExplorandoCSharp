using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando___Aula2___Parte_2.Models
{
    public class LeituraArquivo
    {
        // Usando tuplas em um método
        // public void LerArquivo(string caminho)
        public (bool Sucesso /* Representa o booleano*/, string[] Linhas /* Representa o array*/, int QuantLinhas /*Representa o inteiro*/) LerArquivo(string caminho)
        //      ^ Agora, o retorno é uma tupla, e não um void
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
                //      ^ Representa a booleana 'Sucesso' (bool sempre representa 'true');
                //             ^ Representa o array Linha;
                //                    ^ Representa o intereiro com o Count;
            }
            catch (Exception)
            {
                return (false /* Representa o booleano*/, new string[0] /* Representa o array*/, 0 /*Representa o inteiro*/);
                //      ^ Representa a booleana 'Sucesso';
                //                                         ^ Representa o array Linha;
                //                                                                               ^ Representa o intereiro com o Count;
            }
        }
    }
}