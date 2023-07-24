using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando___Aula2___Parte_2.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            } catch (Exception error)
            {
                Console.WriteLine(error.Message + "Exceção Tratada. ");
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()   
        {
            Metodo4();
        }
        public void Metodo4()
        {   
            // Console.WriteLine("Uma exceção genérica foi detectada.");
            throw new Exception("Uma exceção genérica foi detectada. ");
        }
        /*Os métodos estão em formato cascata pelo fato de o 'throw' ser um método que joga o erro de exceção de volta para cima,
        e não para baixo, como o código normalmente faz. Ele vai voltando até achar o bloco 'catch', que trata os erros de 
        código*/
    }
}