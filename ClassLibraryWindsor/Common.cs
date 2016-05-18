using ClassLibraryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWindsor
{
    public class Common : ICommon
    {

        public string GetNome()
        {
            return "122";
        }


        public string GetTeste2()
        {
            throw new NotImplementedException();
        }
    }
}
