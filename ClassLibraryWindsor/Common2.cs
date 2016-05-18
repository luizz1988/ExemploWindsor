using ClassLibraryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWindsor
{
    public class Common2 : ICommon
    {
        public string GetTeste()
        {
            return "MEu Cú";
        }


        public string GetTeste2()
        {
            throw new NotImplementedException();
        }
    }
}
