using ProjectViewerFixer.Exceptions;
using ProjectViewerFixer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            var exceptions = new List<IdNotFoundException>();
            foreach (var item in findedObjects)
            {
                var obj = item.obj;

                string categoryName = null;
                string sizeName = null;
                string packageName = null;
                string brandName = null;

                try
                {
                    categoryName = dbCategory[obj.CategoryId].Name;
                }
                catch(KeyNotFoundException)
                {
                    exceptions.Add(new IdNotFoundException(obj.CategoryId, Path.GetFileName(item.dataFilePath), obj.IdCounter, IdNotFoundException.IdType.Category));
                    continue;
                }

                try
                {
                    sizeName = dbSize[obj.SizeId].Name;
                }
                catch (KeyNotFoundException)
                {
                    exceptions.Add(new IdNotFoundException(obj.SizeId, Path.GetFileName(item.dataFilePath), obj.IdCounter, IdNotFoundException.IdType.Size));
                    continue;
                }

                try
                {
                    packageName = dbPackage[obj.PackageId].Name;
                }
                catch (KeyNotFoundException)
                {
                    exceptions.Add(new IdNotFoundException(obj.PackageId, Path.GetFileName(item.dataFilePath), obj.IdCounter, IdNotFoundException.IdType.Package));
                    continue;
                }

                try
                {
                    brandName = dbBrand[obj.BrandId].Name;
                }
                catch (KeyNotFoundException)
                {
                    exceptions.Add(new IdNotFoundException(obj.BrandId, Path.GetFileName(item.dataFilePath), obj.IdCounter, IdNotFoundException.IdType.Brand));
                    continue;
                }


                dgvContent.Rows.Add(Path.GetFileName(item.dataFilePath), obj.IdCounter, categoryName, sizeName, packageName, brandName, obj.PriceValue);
            }
            if (exceptions.Count > 0)
            {
                var errorsForm = new ErrorFormShow(exceptions);
                errorsForm.ShowDialog();
                errorsForm.Dispose();
            }
        }

        private void FindedShowForm_Resize(object sender, EventArgs e)
        {
            dgvContent.Size = new Size()
            {
                Width = Size.Width - 40,
                Height = Size.Height - 62
            };
        }
    }
}
