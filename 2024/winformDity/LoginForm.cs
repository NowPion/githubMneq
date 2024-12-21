using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformDity
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private Point mouseOff; //抓取窗体Form中的鼠标的坐标,需要设置一个参数
        private bool leftFlag;  //标签，用来标记鼠标的左键的状态
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)  //鼠标左键按下后触发的MouseDown事件
        {
            if (e.Button == MouseButtons.Left)   //判断鼠标左键是否被按下
            {
                mouseOff = new Point(e.X, e.Y); //通过结构，将鼠标在窗体中的坐标（e.X,e.Y）赋值给mouseOff参数
                leftFlag = true;    //标记鼠标左键的状态
            }
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)  //鼠标移动触发的MouseMove事件
        {
            if (leftFlag)    //判断，鼠标左键是否被按下
            {
                Point mouseSet = Control.MousePosition; //抓取屏幕中鼠标光标所在的位置
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);  //两个坐标相减，得到窗体左上角相对于屏幕的坐标
                Location = mouseSet;    //将上面得到的坐标赋值给窗体Form的Location属性
            }
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)    //鼠标释放按键后触发的MouseUp事件
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)    //拖动窗体时，按下a键,测试与MouseUp事件一样。（窗体的KeyPress属性设置为True）
        {                                                                   //这里只是将FrmMain_KeyPress方法与窗体Form的KeyPress事件绑定，但是窗体上的Panel也响应该事件。（Panel上没有KeyPress事件）           
            if (e.KeyChar == 'a')                                           //因为Form的KeyPreview属性，设置为True后，会向窗体注册窗体控件的键盘事件,所以鼠标拖动Panel，按下键值，其实是响应的Form的keypress事件。
            {
                leftFlag = false;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string pwss = pwssBox.Text;

          
            if(new LoginDao().GetLoginDao(user, pwss))
            {
                MessageBox.Show("登录成功");
                this.Close();
               

                Thread th = new Thread(delegate () { new MainForm(user).ShowDialog(); });
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();


            }
            else
            {
                MessageBox.Show("登录失败");
            }

        }
    }
}
