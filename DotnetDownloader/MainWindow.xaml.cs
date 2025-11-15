using DotnetDownloader.Utils;
using System.Text;
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
using DotnetDownloader.Pages;
using ModernWpf.Controls;
using ModernWpf.Media.Animation;

namespace DotnetDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Obj
        private Dictionary<string, Type> PageMap = new Dictionary<string, Type>();//预加载Page
        private DrillInNavigationTransitionInfo FrameAnimation = new DrillInNavigationTransitionInfo();//Frame动画
        #endregion

        #region Utils
        public void Initialize()
        {
            try
            {
                logger.Info($"{this.Name} 开始初始化");

                //预加载Pages
                void AddType(Type t)
                {
                    PageMap.Add(t.Name, t);
                    logger.Info($"添加 {t.Name} 至预加载Pages");
                }
                AddType(typeof(PageSdk));

                //选择默认项
                navView.SelectedItem = navViewItem_SDK;

                logger.Info($"{this.Name} 结束初始化");
            }
            catch (Exception ex)
            {
                ErrorReportDialog.Show("发生错误", $"初始化 {this.Name} 时发生错误", ex);
            }
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void navView_SelectionChanged(ModernWpf.Controls.NavigationView sender, ModernWpf.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            try
            {
                if (navView.SelectedItem is NavigationViewItem item)
                {
                    logger.Info($"用户选择 {item.Tag} 页");
                    //切换页面
                    frame.Navigate(PageMap[$"Page{item.Tag}"], null, FrameAnimation);
                }
                else
                    throw new Exception("未知的值");
            }
            catch (Exception ex)
            {
                ErrorReportDialog.Show("发生错误", $"处理选择事件发生错误", ex);
            }
        }
    }
}