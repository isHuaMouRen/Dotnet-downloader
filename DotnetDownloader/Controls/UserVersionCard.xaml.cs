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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DotnetDownloader.Controls
{
    /// <summary>
    /// UserVersionCard.xaml 的交互逻辑
    /// </summary>
    public partial class UserVersionCard : UserControl
    {
        public string Title = "Title";
        public string Subtitle = "Subtitle";
        public string Date = "1970-1-1";
        public bool isSafe = true;
        public string Rtype = "LTS";


        public UserVersionCard()
        {
            InitializeComponent();

            textBlock_Title.Text = Title;
            textBlock_Subtitle.Text = Subtitle;
            textBlock_Date.Text = Date;
            textBlock_Rtype.Text = Rtype;

            grid_Safe.Visibility = Visibility.Hidden;
            grid_unSafe.Visibility = Visibility.Hidden;

            if (isSafe)
                grid_Safe.Visibility = Visibility.Visible;
            else
                grid_unSafe.Visibility = Visibility.Visible;
        }
    }
}
