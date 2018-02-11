using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace SysTel_Network.View
{
    public partial class Frm_reporte_ventas : MetroForm
    {
        public Frm_reporte_ventas()
        {
            InitializeComponent();
        }

        private void Frm_reporte_ventas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
