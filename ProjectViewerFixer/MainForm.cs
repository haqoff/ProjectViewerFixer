using System.IO;
using System.Windows.Forms;

namespace ProjectViewerFixer
{
    public partial class MainForm : Form
    {
        private FolderBrowserDialog folderBrowser;

        public MainForm()
        {
            InitializeComponent();
            folderBrowser = new FolderBrowserDialog();
        }

        private void iOpen_Click(object sender, System.EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (!IsViewerProject(folderBrowser.SelectedPath))
                {
                    MessageBox.Show("Выбранная папка не является проектом Viewer.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }
        }

        /// <summary>
        /// Определяет является ли указанный путь папкой проекта программы Viewer.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Возвращает true, если является, иначе false.</returns>
        private bool IsViewerProject(string path)
        {
            const string dataFolderName = "data";
            const string dbFolderName = "db";
            const string settingsFileName = "settings.json";

            if (!Directory.Exists(path + @"\" + dataFolderName)) return false;
            if (!Directory.Exists(path + @"\" + dbFolderName)) return false;
            if (!File.Exists(path + @"\" + settingsFileName)) return false;

            return true;
        }
    }
}
