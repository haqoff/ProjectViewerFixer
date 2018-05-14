using ProjectViewerFixer.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViewerFixer
{
    public partial class ErrorFormShow : Form
    {
        private List<IdNotFoundException> exceptions;
        public ErrorFormShow(List<IdNotFoundException> exceptions)
        {
            InitializeComponent();
            this.exceptions = exceptions;
        }

        private void ErrorFormShow_Load(object sender, EventArgs e)
        {
            dgvErrors.Columns.Add("Имя файла", "Имя файла");
            dgvErrors.Columns.Add("IdCounter", "IdCounter");
            dgvErrors.Columns.Add("Сообщение ошибки", "Сообщение ошибки");

            dgvErrors.ReadOnly = true;

            dgvErrors.RowHeadersWidth = 50;

            ShowAllErrors();
        }

        private void ShowAllErrors()
        {
            dgvErrors.Rows.Clear();

            dgvErrors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;

            for (int i = 0; i < exceptions.Count; i++)
            {
                var ex = exceptions[i];
                dgvErrors.Rows.Add(ex.FileName, ex.IdCounter, ex.Message);
                dgvErrors.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void ShowOnlyDistinctFiles()
        {
            dgvErrors.Rows.Clear();
            dgvErrors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            var distinctFiles = exceptions.Select(s => s.FileName).Distinct().ToList();

            for (int i = 0; i < distinctFiles.Count; i++)
            {
                var ex = distinctFiles[i];
                dgvErrors.Rows.Add(ex);
                dgvErrors.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void cbShowOnlyFiles_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowOnlyFiles.Checked)
            {
                ShowOnlyDistinctFiles();
            }
            else
            {
                ShowAllErrors();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
