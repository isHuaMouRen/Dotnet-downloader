using DotnetDownloader.Utils;
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
using static DotnetDownloader.Class.AppLogger;

namespace DotnetDownloader.Pages
{
    /// <summary>
    /// PageSdk.xaml 的交互逻辑
    /// </summary>
    public partial class PageSdk : ModernWpf.Controls.Page
    {
        #region Initialize
        //构造时初始化
        public void Initialize() { }
        //每次加载初始化
        public void InitializeLoaded()
        {
            try
            {
                logger.Info($"{this.Name} 开始初始化");



                logger.Info($"{this.Name} 结束初始化");
            }
            catch (Exception ex)
            {
                ErrorReportDialog.Show("发生错误", $"初始化 {this.Name} 发生错误", ex);
            }
        }
        #endregion

        public PageSdk()
        {
            InitializeComponent();
            Initialize();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) { InitializeLoaded(); }
    }
}
