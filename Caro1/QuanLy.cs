using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro1
{
    public class QuanLy
    {
        #region Properties
        private Panel BanCo;


        private List<Player> player;

        private int nguoiChoiHienTai;

        private List<List<Button>> matrix;
        #endregion

        #region Initialize
        public QuanLy(Panel banCo)
        {
            this.BanCo = banCo;
            this.Player = new List<Player>()
            {
                new Player("PLayer1", Image.FromFile(Application.StartupPath + "\\Resources\\cross.jpeg")),
                new Player("Player2", Image.FromFile(Application.StartupPath + "\\Resources\\blue.png"))
            };
            NguoiChoiHienTai = 0;
        }

        public Panel BanCo1 { get => BanCo; set => BanCo = value; }
        
        public List<Player> Player { get => player; set => player = value; }
        public int NguoiChoiHienTai { get => nguoiChoiHienTai; set => nguoiChoiHienTai = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        #endregion

        #region Methods
        public void VeBanCo()
        {
            Matrix = new List<List<Button>>();

            Button oldButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };

            for (int i = 0; i < Cons.chieuRongBanCo; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.chieuCaoBanCo; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.coRong,
                        Height = Cons.coCao,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += btn_Click;

                    BanCo.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.coCao);
                oldButton.Width = 0;
                oldButton.Height = 0;

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            
            //btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\cross.jpeg");
            
            btn.BackgroundImage = Player[NguoiChoiHienTai].Mark;
            NguoiChoiHienTai = NguoiChoiHienTai == 1 ? 0 : 1;

            if(kiemTraThangThua(btn))
            {
                KetThuc();
            }

        }

        /*private void btn_Restart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackgroundImage != null)
            {
                
            }
        }*/

        private void KetThuc()
        {
            MessageBox.Show("Kết thúc");
        }

        private bool kiemTraThangThua(Button btn)
        {
            return kiemTraThangThuaHangNgang(btn) || kiemTraThangThuaHangDoc(btn) || kiemTraThangThuaDuongCheoChinh(btn) || kiemTraThangThuaDuongCheoPhu(btn);
        }

        private Point LayToaDo(Button btn)
        {
            

            int chieuDoc = Convert.ToInt32(btn.Tag);
            int chieuNgang = Matrix[chieuDoc].IndexOf(btn);

            Point point = new Point(chieuNgang, chieuDoc);

            return point;
        }

        private bool kiemTraThangThuaHangNgang(Button btn)
        {
            Point point = LayToaDo(btn);
            int demBenTrai = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTrai++;
                }
                else
                    break;
            }

            int demBenPhai = 0;
            for (int i = point.X+1; i < Cons.chieuRongBanCo; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenPhai++;
                }
                else
                    break;
            }

            return demBenTrai + demBenPhai == 5;
        }

        private bool kiemTraThangThuaHangDoc(Button btn)
        {
            Point point = LayToaDo(btn);

            int demBenTren = 0;

            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTren++;
                }
                else
                    break;
            }

            int demBenDuoi = 0;

            for (int i = point.Y + 1; i < Cons.chieuCaoBanCo; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    demBenDuoi++;
                }
                else
                    break;
            }

            return demBenTren + demBenDuoi == 5;
        }

        private bool kiemTraThangThuaDuongCheoChinh(Button btn)
        {
            Point point = LayToaDo(btn);

            int demBenTren = 0;

            for (int i = 0; i <= point.X; i++)
            {
                if(point.X - i < 0 || point.Y - i < 0)
                {
                    break;
                }

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTren++;
                }
                else
                    break;
            }

            int demBenDuoi = 0;

            for (int i = 1; i <= Cons.chieuRongBanCo - point.X; i++)
            {
                if(point.Y + i > Cons.chieuCaoBanCo || point.X + i >= Cons.chieuRongBanCo)
                {
                    break;
                }

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTren++;
                }
                else
                    break;
            }

            return demBenTren + demBenDuoi == 5;
        }

        private bool kiemTraThangThuaDuongCheoPhu(Button btn)
        {
            Point point = LayToaDo(btn);

            int demBenTren = 0;

            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.chieuRongBanCo || point.Y - i < 0)
                {
                    break;
                }

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTren++;
                }
                else
                    break;
            }

            int demBenDuoi = 0;

            for (int i = 1; i <= Cons.chieuRongBanCo - point.X; i++)
            {
                if (point.Y + i > Cons.chieuCaoBanCo || point.X - i < 0 )
                {
                    break;
                }

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTren++;
                }
                else
                    break;
            }

            return demBenTren + demBenDuoi == 5;
        }
        #endregion
    }
}
