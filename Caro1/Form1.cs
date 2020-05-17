using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro1
{
    public partial class Form1 : Form
    {
        #region Properties
        QuanLy BanCo;
        #endregion

        public Form1()
        {
            InitializeComponent();
            BanCo = new QuanLy(pnlBanCo);
            BanCo.VeBanCo();
            //VeBanCo();
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            pnlBanCo.Controls.Clear();
            BanCo.VeBanCo();
        }

        /*private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\cross.jpeg");
        }*/

    }
}
