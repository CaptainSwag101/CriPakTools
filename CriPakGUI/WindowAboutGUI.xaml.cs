using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CriPakGUI
{
    /// <summary>
    /// WindowAboutGUI.xaml 的交互逻辑
    /// </summary>
    public partial class WindowAboutGUI : Window
    {
        public WindowAboutGUI(double x, double y)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Top = x;
            this.Left = y;
            SetWindowPrefs();
        }
        private void SetWindowPrefs()
        {
            textblock0.Text = @"CriPakTools-GUI

            Github repository:
            https://github.com/jpmac26/CriPakTools

            This tool is based on code by 
            Falo (http://forum.xentax.com/viewtopic.php?f=10&t=10646),
            Nanashi3(http://forums.fuwanovel.org/index.php?/topic/1785-request-for-psp-hackers/page-4),
            esperknight (https://github.com/esperknight/CriPakTools),
            uyjulian(https://github.com/uyjulian/CriPakTools),
            and wmltogether(https://github.com/wmltogether/CriPakTools).

            I forked these repos, fixed some issues, and added better support for large CPK files.";
        }

        private void button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
