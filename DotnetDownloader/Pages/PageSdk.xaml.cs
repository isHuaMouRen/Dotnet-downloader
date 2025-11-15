using DotnetDownloader.Class;
using DotnetDownloader.Class.JsonConfig;
using DotnetDownloader.Utils;
using HuaZi.Library.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using DotnetDownloader.Controls;

namespace DotnetDownloader.Pages
{
    /// <summary>
    /// PageSdk.xaml 的交互逻辑
    /// </summary>
    public partial class PageSdk : ModernWpf.Controls.Page
    {
        private JsonIndex.Index jsonIndex;
        private List<JsonRelease.Index> jsonRelease = new List<JsonRelease.Index>();
        private List<JsonSupportOs.Index> jsonSupportOs = new List<JsonSupportOs.Index>();

        #region Initialize
        //构造时初始化
        public void Initialize() { }
        //每次加载初始化
        public async void InitializeLoaded()
        {
            try
            {
                logger.Info($"{this.Name} 开始初始化");

                using (var client = new HttpClient()) 
                {
                    logger.Info("获取元数据...");
                    jsonIndex = Json.ReadJson<JsonIndex.Index>(await client.GetStringAsync(AppInfo.DotnetIndexUrl));

                    //获得所有版本的发行信息、支持系统信息
                    for (int i = 0; i < jsonIndex.ReleasesIndex.Length; i++)
                    {
                        if (jsonIndex.ReleasesIndex[i].Product == ".NET")
                        {
                            jsonRelease.Add(Json.ReadJson<JsonRelease.Index>(await client.GetStringAsync(jsonIndex.ReleasesIndex[i].ReleasesJson)));
                            if (!string.IsNullOrEmpty(jsonIndex.ReleasesIndex[i].SupportedOsJson))
                                jsonSupportOs.Add(Json.ReadJson<JsonSupportOs.Index>(await client.GetStringAsync(jsonIndex.ReleasesIndex[i].SupportedOsJson)));
                        }
                    }
                    logger.Info("所有数据获取完毕");

                    //加入列表
                    foreach (var release in jsonRelease)
                    {
                        for (int i = 0; i < release.Releases.Length; i++)
                        {
                            var card = new UserVersionCard
                            {
                                Title = $"{release.Releases[i].ReleaseVersion}",
                                Subtitle = $"{release.ChannelVersion}",
                                Date = $"{release.Releases[i].ReleaseDate}",
                                IsSafe = release.Releases[i].Security,
                                RType = $"{release.ReleaseType.ToUpper()}"
                            };
                            listBox.Items.Add(card);
                        }
                    }
                }

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
