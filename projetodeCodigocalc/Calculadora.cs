using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetodeCodigocalc
{
     public class Calculadora
    {
        
        private List<string> listahistorioco;
        private string data;

        public Calculadora(string data)
        {
            listahistorioco = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            listahistorioco.Insert(0, "res: " + res + "- data: " + data);
            return res;
            //return val1 + val2;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            listahistorioco.Insert(0, "res: " + res + "- data: " + data);
            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            listahistorioco.Insert(0, "res: " + res + "- data: " + data);
            return res;
        }

        public int dividir(int val1, int val2 )
        {
            int res = val1 / val2;

            listahistorioco.Insert(0, "res: " + res + "- data: " + data);
            return res;
        }

        public List<string> historico()
        {
            listahistorioco.RemoveRange(3, listahistorioco.Count );
            return listahistorioco;
        }
    }
}
