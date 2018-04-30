using Newtonsoft.Json;
using ProjectViewerFixer.Model;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjectViewerFixer
{
    public partial class MainForm : Form
    {
        private bool projectOpened;

        private const string dataFolderName = "data";
        private const string dbFolderName = "db";
        private const string settingsFileName = "settings.json";

        private Dictionary<Data, string> datas;
        private Dictionary<string, DBDictionary> dbCategory;
        private Dictionary<string, DBDictionary> dbSize;
        private Dictionary<string, DBDictionary> dbPackage;
        private Dictionary<string, DBDictionary> dbBrand;



        private FolderBrowserDialog folderBrowser;

        private delegate void ObjectFindedHandler(string dataFilePath, Data data, Model.Object obj);

        public MainForm()
        {
            InitializeComponent();
            datas = new Dictionary<Data, string>();
            folderBrowser = new FolderBrowserDialog();
            projectOpened = false;
        }

        private void miOpen_Click(object sender, System.EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (!IsViewerProject(folderBrowser.SelectedPath))
                {
                    MessageBox.Show("Выбранная папка не является проектом Viewer.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (projectOpened) CloseProject();

                datas = DeserializeJsonFilesInFolder<Data>(folderBrowser.SelectedPath + @"\" + dataFolderName);

                var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(folderBrowser.SelectedPath + @"\" + settingsFileName));

                lblProjectName.Text = "Имя проекта: " + settings.ProjectName;
                lblCountData.Text = "Количество файлов данных: " + datas.Count;

                dbBrand = JsonConvert.DeserializeObject<Dictionary<string, DBDictionary>>(File.ReadAllText(folderBrowser.SelectedPath + @"\" + dbFolderName + @"\" + settings.BrandDb));
                dbCategory = JsonConvert.DeserializeObject<Dictionary<string, DBDictionary>>(File.ReadAllText(folderBrowser.SelectedPath + @"\" + dbFolderName + @"\" + settings.CategoryDb));
                dbPackage = JsonConvert.DeserializeObject<Dictionary<string, DBDictionary>>(File.ReadAllText(folderBrowser.SelectedPath + @"\" + dbFolderName + @"\" + settings.PackageDb));
                dbSize = JsonConvert.DeserializeObject<Dictionary<string, DBDictionary>>(File.ReadAllText(folderBrowser.SelectedPath + @"\" + dbFolderName + @"\" + settings.SizeDb));

                LoadDbToCombobox(cbFindCategory, cbReplaceCategory, dbCategory);
                LoadDbToCombobox(cbFindSize, cbReplaceSize, dbSize);
                LoadDbToCombobox(cbFindPackage, cbReplacePackage, dbPackage);
                LoadDbToCombobox(cbFindBrand, cbReplaceBrand, dbBrand);

                projectOpened = true;
                miClose.Enabled = true;
                pMain.Enabled = true;
            }
        }

        private void miClose_Click(object sender, System.EventArgs e) => CloseProject();


        private void CloseProject()
        {
            lblProjectName.Text = "Имя проекта:";
            lblCountData.Text = "Количество файлов данных:";

            cbFindCategory.Items.Clear();
            cbFindSize.Items.Clear();
            cbFindPackage.Items.Clear();
            cbFindBrand.Items.Clear();
            tbFindPrice.Clear();

            cbReplaceCategory.Items.Clear();
            cbReplaceSize.Items.Clear();
            cbReplacePackage.Items.Clear();
            cbReplaceBrand.Items.Clear();
            tbReplacePrice.Clear();

            pMain.Enabled = false;
            miClose.Enabled = false;
            projectOpened = false;
        }

        private void LoadDbToCombobox(ComboBox cbFind, ComboBox cbReplace, Dictionary<string, DBDictionary> dict)
        {
            cbFind.Items.Clear();
            cbReplace.Items.Clear();

            cbFind.Items.Add("Не важно");
            cbReplace.Items.Add("Оставить прежнее");
            foreach (var item in dict.Values)
            {
                cbFind.Items.Add(item);
                cbReplace.Items.Add(item);
            }
            cbFind.SelectedIndex = 0;
            cbReplace.SelectedIndex = 0;
        }

        /// <summary>
        /// Десериализует все json файлы в папке.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        private Dictionary<T, string> DeserializeJsonFilesInFolder<T>(string folderPath)
        {
            var files = Directory.GetFiles(folderPath, "*.json");
            Dictionary<T, string> result = new Dictionary<T, string>();

            for (int i = 0; i < files.Length; i++)
            {
                result.Add(JsonConvert.DeserializeObject<T>(File.ReadAllText(files[i])), files[i]);
            }

            return result;
        }

        /// <summary>
        /// Определяет является ли указанный путь папкой проекта программы Viewer.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Возвращает true, если является, иначе false.</returns>
        private bool IsViewerProject(string path)
        {
            if (!Directory.Exists(path + @"\" + dataFolderName)) return false;
            if (!Directory.Exists(path + @"\" + dbFolderName)) return false;
            if (!File.Exists(path + @"\" + settingsFileName)) return false;

            return true;
        }

        private void btnFindAndReplace_Click(object sender, System.EventArgs e)
        {
            int countReplacedObjects = 0;

            var finded = Find();

            var replaceCategory = cbReplaceCategory.SelectedItem as DBDictionary;
            var replaceSize = cbReplaceSize.SelectedItem as DBDictionary;
            var replacePackage = cbReplacePackage.SelectedItem as DBDictionary;
            var replaceBrand = cbReplaceBrand.SelectedItem as DBDictionary;
            string replacePrice = tbReplacePrice.Text;

            foreach (var item in finded)
            {
                var obj = item.obj;

                if (replaceCategory != null) obj.CategoryId = replaceCategory.Id;
                if (replaceSize != null) obj.SizeId = replaceSize.Id;
                if (replacePackage != null) obj.PackageId = replacePackage.Id;
                if (replaceBrand != null) obj.BrandId = replaceBrand.Id;
                if (!string.IsNullOrEmpty(replacePrice)) obj.PriceValue = replacePrice;

                countReplacedObjects++;
            }

            SerializeAndWriteAllData(datas);

            MessageBox.Show("Успешно заменено обьектов: " + countReplacedObjects, "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<FindedObject> Find()
        {
            var findBrand = cbFindBrand.SelectedItem as DBDictionary;
            var findCategory = cbFindCategory.SelectedItem as DBDictionary;
            var findSize = cbFindSize.SelectedItem as DBDictionary;
            var findPackage = cbFindPackage.SelectedItem as DBDictionary;
            string findPrice = tbFindPrice.Text;

            var result = new List<FindedObject>();

            foreach (var data in datas.Keys)
            {
                foreach (var obj in data.Objects)
                {
                    if ((findCategory == null || findCategory.Id == obj.CategoryId)
                        && (findSize == null || findSize.Id == obj.SizeId)
                        && (findPackage == null || findPackage.Id == obj.PackageId)
                        && (findBrand == null || findBrand.Id == obj.BrandId)
                        && (string.IsNullOrEmpty(findPrice) || findPrice == obj.PriceValue))
                    {
                        var f = new FindedObject();
                        f.data = data;
                        f.dataFilePath = datas[data];
                        f.obj = obj;

                        result.Add(f);
                    }

                }
            }
            return result;
        }

        private void SerializeAndWriteAllData(Dictionary<Data, string> dict)
        {
            foreach (var item in dict.Keys)
            {

                using (var sw = new StreamWriter(dict[item], false))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(item, Formatting.Indented));
                }
            }
        }

        private void btnFindAndShow_Click(object sender, System.EventArgs e)
        {
            var showForm = new FindedShowForm(dbCategory, dbSize, dbPackage, dbBrand, Find());
            showForm.ShowDialog();
        }
    }

    public struct FindedObject
    {
        public string dataFilePath;
        public Data data;
        public Model.Object obj;
    }
}
