using Steamworks;
using System.Net;

namespace SteamUtils
{
    public partial class MainForm : Form
    {
        private List<Friend>? _friends;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists($@"{Environment.CurrentDirectory}\steam_api64.dll")) DownloadSteamApi(@"https://drive.google.com/file/d/1wFTqpfST2Sm8XKbvyVts4TOg-Jmk9EPq/view?usp=sharing");

            /*SteamClient.Init(730);

            _friends = SteamFriends.GetFriends().ToList();

            string friends = string.Empty;

            _friends.ToList().ForEach(x => friends += $"\n{x.Name}");

            MessageBox.Show(friends);*/
        }

        private void DownloadSteamApi(string link)
        {
            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += OnDownloadProgressChanged;
                client.DownloadFileAsync(new Uri(link), $@"{Environment.CurrentDirectory}\steam_api64.dll");
            }
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) => progressBarDownload.Value = e.ProgressPercentage;
    }
}