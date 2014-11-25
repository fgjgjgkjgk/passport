using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Validation
{
    public class Validations
    {

        private List<String> ClinList = new List<string>();

        public Validations() { 
        
        }

        public List<String> VNotempty(String[] m1)
        {
            List<String> Vres = new List<String>();

            for (int i=0, ii=1; i<m1.Length; i++, ii++ )
            {
                if (m1[i] == "")
                {
                    Vres.Add("Поле");
                    Vres.Add(" №"+ ii +" пустим бути не може!");
                }
                else {
                    Vres.Add(null);
                }
            }

            return Vres;
        }

        public List<String> VLengt(String[] m2, int min, int max)
        {

            List<String> Vres = new List<String>();

            for (int i = 0, ii=1 ; i < m2.Length; i++, ii++ )
            {
                if (m2[i].Length >= max)
                {
                    Vres.Add("Поле");
                    Vres.Add(" №" + ii + "Має занадто багато символів!");
                }
                else {
                    if (m2[i].Length <= min)
                    {
                        Vres.Add("Поле");
                        Vres.Add(" №" + ii + "Має занадто мало символів!");
                    }
                    else {
                        Vres.Add(null);
                    }
                }
            }

            return Vres;
        }

    }
}