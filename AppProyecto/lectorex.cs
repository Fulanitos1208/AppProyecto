using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
namespace AppProyecto
{
  public partial class lectorex : Form
  {
    public lectorex()
    {
      InitializeComponent();
    }
    DataTableCollection tableCollection;
    private void button1_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnBrowse_Click(object sender, EventArgs e)
      {
        using (OpenFileDialog openFileDialog = new OpenFileDialog()
        {
          Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx" 
        })
        {
          if (openFileDialog.ShowDialog() == DialogResult.OK)
          {
            txtFilename.Text = openFileDialog.FileName;
            using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
              using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
              {
                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                  ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                });
                tableCollection = result.Tables;
                cboSheet.Items.Clear();
                foreach (DataTable table in tableCollection)
                  cboSheet.Items.Add(table.TableName);
              }
            }
          }
        }
      }
    private void cboSheet_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
      dataGridView1.DataSource = dt;
    }
  }
}

