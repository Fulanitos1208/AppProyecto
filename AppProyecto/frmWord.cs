using System;
using System.Windows.Forms;
using System.IO;
using Aspose.Words;
namespace AppProyecto
{
  public partial class frmWord : Form
  {
    public frmWord()
    {
      InitializeComponent();
    }
    private void btnAbrir_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog exploradorArchivo = new OpenFileDialog() { Filter = "Word Document|*.Docx| Word 97-2003 Document|*.doc" })
      {
        if (exploradorArchivo.ShowDialog() == DialogResult.OK)
        {
          try
          {
            object readOnly = true;
            object visible = true;
            object save = false;
            object fileName = exploradorArchivo.FileName;
            object missing = Type.Missing;
            object newTemplate = false;
            object docType = 0;
            RtWord.Visible = true;
            Microsoft.Office.Interop.Word._Document documento = null;
            Microsoft.Office.Interop.Word._Application aplicacionWord = new Microsoft.Office.Interop.Word.Application()
            { 
              Visible = false 
            };

            documento = aplicacionWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref visible,
                ref missing, ref missing, ref missing, ref missing);

            documento.ActiveWindow.Selection.WholeStory();
            documento.ActiveWindow.Selection.Copy();
            IDataObject contenidoWord = Clipboard.GetDataObject();
            RtWord.Rtf = contenidoWord.GetData(DataFormats.Rtf).ToString();
            aplicacionWord.Quit(ref missing, ref missing, ref missing);
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
          }
        }
      }
    }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      SaveFileDialog guardar = new SaveFileDialog();
      guardar.Filter = "Documento de texto |*.docx";
      guardar.Title = "Guardar RtWord";
      if(guardar.ShowDialog() == DialogResult.OK)
      {
        StreamWriter escribir = new StreamWriter(guardar.FileName);

        foreach (object line in RtWord.Lines)
        {
          escribir.WriteLine(line);
        }
        }
      }
    private void btnCambios_Click(object sender, EventArgs e)
    {
      //abre los folders
      OpenFileDialog abrir = new OpenFileDialog();
      abrir.Filter = "Documento de texto |*.docx";
      abrir.Title = "Abrir RichTextWord";
      abrir.FileName = "Sin titulo 1";
      var resultado = abrir.ShowDialog();
      if (resultado == DialogResult.OK)
      {
        StreamReader leer = new StreamReader(abrir.FileName);
        RtWord.Text = leer.ReadToEnd();
        leer.Close();
      }
    }
    private void BtnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
