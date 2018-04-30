using ProjectViewerFixer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjectViewerFixer
{
    public partial class FindedShowForm : Form
    {
        private Dictionary<string, DBDictionary> dbCategory;
        private Dictionary<string, DBDictionary> dbSize;
        private Dictionary<string, DBDictionary> dbPackage;
        private Dictionary<string, DBDictionary> dbBrand;
        private IEnumerable<FindedObject> findedObjects;
        public FindedShowForm(Dictionary<string, DBDictionary> dbCategory, Dictionary<string, DBDictionary> dbSize, Dictionary<string, DBDictionary> dbPackage
            , Dictionary<string, DBDictionary> dbBrand, IEnumerable<FindedObject> findedObjects)
        {
            this.dbCategory = dbCategory;
            this.dbSize = dbSize;
            this.dbPackage = dbPackage;
            this.dbBrand = dbBrand;
            this.findedObjects = findedObjects;
            InitializeComponent();
        }

        private void FindedShowForm_Load(object sender, System.EventArgs e)
        {
            dgvContent.Columns.Add("Файл", "Файл");
            dgvContent.Columns.Add("IdCounter", "IdCounter");
            dgvContent.Columns.Add("Category", "Category");
            dgvContent.Columns.Add("Size", "Size");
            dgvContent.Columns.Add("Package", "Package");
            dgvContent.Columns.Add("Brand", "Brand");
            dgvContent.Columns.Add("Price", "Price");

            dgvContent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            int countExceptions = 0;
            int counter = 0;
            foreach (var item in findedObjects)
            {
                var obj = item.obj;
                try
                {
                    dgvContent.Rows.Add(Path.GetFileName(item.dataFilePath), item.obj.IdCounter, dbCategory[obj.CategoryId].Name,
                        dbSize[obj.SizeId].Name, dbPackage[obj.PackageId].Name, dbBrand[obj.BrandId].Name, obj.PriceValue);
                    dgvContent.Rows[counter].HeaderCell.Value = (counter + 1).ToString();
                    counter++;
                }
                catch (KeyNotFoundException)
                {
                    if (countExceptions == 5) MessageBox.Show("Найдено уже 5 ошибок, дальнейшие ошибки показываться не будут!");
                    else if (countExceptions < 5)
                    {
                        MessageBox.Show(string.Format("Не был найден один из ID category/size/package/brand в сопосталвенном словаре.\nИмя файла: {0}\nObjectIdCounter: {1}",
                            Path.GetFileName(item.dataFilePath), obj.IdCounter));
                    }
                    countExceptions++;

                }

            }
        }
    }
}
