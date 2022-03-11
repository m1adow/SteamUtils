using Steamworks;
using System.Net;
using SteamUtils.Models;

namespace SteamUtils
{
    public partial class MainForm : Form
    {
        private User? _user;
        private List<Friend>? _friends;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists($@"{Environment.CurrentDirectory}\steam_api64.dll")) DownloadSteamApi(@"https://github.com/Facepunch/Facepunch.Steamworks/blob/master/Facepunch.Steamworks/steam_api64.dll");

            _user = new User();

            MessageBox.Show("Select game", "Message", MessageBoxButtons.OK);
        }

        private void DownloadSteamApi(string link)
        {
            using (var client = new WebClient()) client.DownloadFileAsync(new Uri(link), $@"{Environment.CurrentDirectory}\steam_api64.dll");
        }

        private void comboBoxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            _user.SetAppId(comboBoxGame.SelectedItem.ToString()); //setting appId

            SteamClient.Init(_user.AppId); //initialization client

            //set data for labels
            labelUserName.Text = SteamClient.Name;
            labelUserState.Text = SteamClient.State.ToString();

            if (labelUserState.Text == "Online") labelUserState.ForeColor = Color.Green; //change color of label

            comboBoxGame.Visible = false;

            _friends = SteamFriends.GetFriends().ToList();
            _friends.ForEach(f => listBoxFriends.Items.Add($"{f.Name}({f.Id}) {f.State}")); //display friends
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxCount.Text.Any(c => !char.IsDigit(c))) MessageBox.Show("Second text box must contains only digits"); //examination for containing letters

            string listBoxSelectedItem = listBoxFriends.SelectedItem.ToString(); //string with selected string
            string name = string.Empty;

            //getting friend name from listBox
            for (int i = 0; i < listBoxSelectedItem.Length; i++)
            {
                if (listBoxSelectedItem[i] != '(') name += listBoxSelectedItem[i];
                else i = listBoxSelectedItem.Length + 1;
            }

            Friend friend = _friends.FirstOrDefault(f => f.Name == name); //getting friend

            for (int i = 0; i < int.Parse(textBoxCount.Text); i++) friend.SendMessage(textBoxMessage.Text); //send messages
        }
    }
}