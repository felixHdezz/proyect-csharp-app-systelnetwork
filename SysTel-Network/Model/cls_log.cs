using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    public abstract class cls_log
    {
        public abstract bool _met_RealizaLogin(object _object);
        public virtual bool _met_CompruebaLogin(object _object) {
            return false;
        }
    }
}
