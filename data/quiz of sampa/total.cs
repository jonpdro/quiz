using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_of_sampa
{
    class total
    {
        private static int acertos = 0;
        public static int Acertos
        {
            get { return acertos; }
            set { acertos = value; }
        }

        private static int erros = 0;
        public static int Erros
        {
            get { return erros; }
            set { erros = value; }
        }
    }
}
