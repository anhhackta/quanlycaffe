using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlquancaffe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void khuvuctoolstripMenu_Click(object sender, EventArgs e)
        {
            //if (this.MdiChildren.Length > 0)
            //{
            //    return;
            //}
            quanlikhuvuc ql = new quanlikhuvuc();
            ql.MdiParent = this;
            ql.Show();
        }
    }
}
