using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSBackground
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //创建一个登录窗口的实例用于管理员登录
            FrmLogin frmLogin = new FrmLogin();
            if(frmLogin.ShowDialog()== DialogResult.Yes)
                Application.Run(new FrmMain());
        }
    }
}
