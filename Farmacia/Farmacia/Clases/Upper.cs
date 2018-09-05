using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farmacia
{
   abstract class Upper
    {
        public  Upper()
        {

        }
        
        public static string ConvertFirtsCharToUpperString(string Palabra)
        {
            char[] letra = Palabra.ToCharArray();
            string NuevaPalabra = String.Empty;

            for (int I = 0; I < letra.Length; I++)
            {
                if (I==0)
                {
                    NuevaPalabra += Convert.ToString(letra[I]).ToUpper();
                }
                else
                {
                    NuevaPalabra += Convert.ToString(letra[I]).ToLower();
                }
            }

            return NuevaPalabra;
        }
    }
}
