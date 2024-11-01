using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    { 
        private List<string> Listahistorico;
        private string data;

        public Calculadora(string data)
        {
            Listahistorico = new List<string>();

            this.data = data;
        }
 
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            Listahistorico.Insert(0, "Res: " + res + " - data" + data);
            return res;

            // return val2 + val3;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            Listahistorico.Insert(0, "Res: " + res + " - data" + data);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            Listahistorico.Insert(0, "Res: " + res + " - data" + data);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            Listahistorico.Insert(0, "Res: " + res + " - data" + data);
            return res;
        }

        public List<string> historico()
        {
            Listahistorico.RemoveRange(3, Listahistorico.Count - 3);
            return Listahistorico;
        }
    }
}