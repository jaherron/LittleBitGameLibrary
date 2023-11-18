namespace LittleBitsGameLibrary
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadGameList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game(GameName.Text, GameDev.Text, GameDesc.Text, GamePicture.ImageLocation, GameGenre.Text);
            var serializer = new YamlDotNet.Serialization.Serializer();
            string yamlGame = serializer.Serialize(game);
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (FileName.Text.EndsWith(".yaml"))
            {
                System.IO.File.WriteAllText($"{documentsFolder}\\LittleBitGameLibrary\\games\\{FileName.Text}", yamlGame);
            }
            else
            {
                System.IO.File.WriteAllText($"{documentsFolder}\\LittleBitGameLibrary\\games\\{FileName.Text}.yaml", yamlGame);
            }
            ReloadGameList();
        }

        private void GamePicture_Click(object sender, EventArgs e)
        {
            ImageSelect imageform = new ImageSelect();
            if (imageform.ShowDialog() == DialogResult.OK)
            {
                GamePicture.ImageLocation = imageform.textBox1.Text;
            }
        }

        private void ReloadGameList()
        {
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            GameSelect.Items.Clear();
            if (Directory.Exists($"{documentsFolder}\\LittleBitGameLibrary\\games"))
            {
                string[] files = System.IO.Directory.GetFiles($"{documentsFolder}\\LittleBitGameLibrary\\games");
                foreach (string file in files)
                {
                    if (file.EndsWith(".yaml"))
                    {
                        string[] splitname = file.Split('\\');
                        string name = splitname[splitname.Length - 1];
                        GameSelect.Items.Add(name);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory($"{documentsFolder}\\LittleBitGameLibrary\\games");
            }
        }

        private void GameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string yamlGame = System.IO.File.ReadAllText($"{documentsFolder}\\LittleBitGameLibrary\\games\\{GameSelect.Text}");
            var deserializer = new YamlDotNet.Serialization.Deserializer();
            Game game = deserializer.Deserialize<Game>(yamlGame);
            GameName.Text = game.name;
            GameDev.Text = game.developer;
            GameDesc.Text = game.description;
            GameGenre.Text = game.genre;
            GamePicture.ImageLocation = game.imagepath;
            FileName.Text = GameSelect.Text;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            ReloadGameList();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameName.Text = "";
            GameDesc.Text = "";
            GameDev.Text = "";
            GameGenre.Text = "";
            GamePicture.ImageLocation = "";
            ReloadGameList();
        }

        private void aboutThisAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void loadGameYAMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gameFileDialog.ShowDialog();
        }

        private void gameFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (gameFileDialog.FileName.EndsWith(".yaml"))
            {
                string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string yamlGame = System.IO.File.ReadAllText(gameFileDialog.FileName);
                var deserializer = new YamlDotNet.Serialization.Deserializer();
                Game game = deserializer.Deserialize<Game>(yamlGame);
                GameName.Text = game.name;
                GameDev.Text = game.developer;
                GameDesc.Text = game.description;
                GameGenre.Text = game.genre;
                GamePicture.ImageLocation = game.imagepath;
                string[] splitname = gameFileDialog.FileName.Split('\\');
                string name = splitname[splitname.Length - 1];
                FileName.Text = name;
            }
        }
    }
}