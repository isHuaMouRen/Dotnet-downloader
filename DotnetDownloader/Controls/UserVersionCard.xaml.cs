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
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Date { get; set; }
        public bool IsSafe { get; set; }
        public string RType { get; set; }

        public UserVersionCard()
        {
            InitializeComponent();

            Loaded += (s, e) => UpdateUI();
        }

        private void UpdateUI()
        {
            textBlock_Title.Text = Title;
            textBlock_Subtitle.Text = Subtitle;
            textBlock_Date.Text = Date;
            textBlock_Rtype.Text = RType;

            grid_Safe.Visibility = IsSafe ? Visibility.Visible : Visibility.Collapsed;
            grid_unSafe.Visibility = IsSafe ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}
