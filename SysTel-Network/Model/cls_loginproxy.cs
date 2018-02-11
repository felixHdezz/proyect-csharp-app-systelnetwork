using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_loginproxy : cls_log
    {
        private cls_dav_loginReal _cls_login_real;
        public override bool _met_RealizaLogin(object _object)
        {
            if (_cls_login_real == null) {
                _cls_login_real = cls_dav_loginReal._Instance;
                _cls_login_real._met_RealizaLogin(_object);
            }
            return _cls_login_real._action;
        }
    }
}
