using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysTel_Network.Model
{
    public abstract class cls_Iterador
    {
        public abstract DataSet _met_FirstPage();
        public abstract DataSet _met_PreviousPage();
        public abstract DataSet _met_NextPage();
        public abstract DataSet _met_LastPage();
        public abstract DataSet _met_LoadData();
        public abstract int _met_countRow();
        public abstract int _met_numPag();
        public abstract int _met_lastpage();
    }
}
 