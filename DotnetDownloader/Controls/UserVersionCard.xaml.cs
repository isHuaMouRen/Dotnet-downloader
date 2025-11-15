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
        public string Title { get; set; } = "Title";
        public string Subtitle { get; set; } = "Subtitle";
        public string Date { get; set; } = "1970-1-1";
        public bool IsSafe { get; set; } = true;
        public string RType { get; set; } = "LTS";

        public UserVersionCard()
        {
            InitializeComponent();

            textBlock_Title.Text = Title;
            textBlock_Subtitle.Text = Subtitle;
            textBlock_Date.Text = Date;
            textBlock_Rtype.Text = RType;

            grid_Safe.Visibility = IsSafe ? Visibility.Visible : Visibility.Collapsed;
            grid_unSafe.Visibility = IsSafe ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}
