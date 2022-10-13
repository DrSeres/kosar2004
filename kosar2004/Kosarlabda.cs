using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kosar2004
{
    class Kosarlabda
    {
        private string hazai;

        public string Hazai
        {
            get { return hazai; }
            set { hazai = value; }
        }
        private string idegen;

        public string Idegen
        {
            get { return idegen; }
            set { idegen = value; }
        }
        private int hazai_pont;

        public int Hazai_pont
        {
            get { return hazai_pont; }
            set { hazai_pont = value; }
        }

        private int idegen_pont;

        public int Idegen_pont
        {
            get { return idegen_pont; }
            set { idegen_pont = value; }
        }
        private string helyszín;

        public string Helyszín
        {
            get { return helyszín; }
            set { helyszín = value; }
        }

        private DateTime idopont;  

        public DateTime Idopont
        {
            get { return idopont; }
            set { idopont = value; }
        }

        public Kosarlabda(string hazai, string idegen, int hazai_pont, int idegen_pont, string helyszín, DateTime idopont)
        {
            Hazai = hazai;
            Idegen = idegen;
            Hazai_pont = hazai_pont;
            Idegen_pont = idegen_pont;
            Helyszín = helyszín;
            Idopont = idopont;
        }
    }
}
