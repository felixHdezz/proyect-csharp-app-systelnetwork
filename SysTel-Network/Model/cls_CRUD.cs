using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    public abstract class cls_CRUD
    {
        public abstract bool _met_insert(object ob);
        public abstract bool _met_update(object ob);
        public abstract bool _met_delete(object ob);
        public virtual SqlDataAdapter _met_select() {
            return null;
        }
        public virtual DataSet _met_select(object ob) {
            return null;
        }
        public virtual DataTable _met_select_cmb() {
            return null;
        }
    }
}
