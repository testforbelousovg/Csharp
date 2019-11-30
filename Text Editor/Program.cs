using System;
using System.Windows.Forms;

namespace Text_Editor
{
    static class Program
    {
    

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Editor());
        }
    }
}
