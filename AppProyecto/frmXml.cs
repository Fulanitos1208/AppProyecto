using System;
using System.Xml;
using System.Windows.Forms;
namespace AppProyecto
{
  public partial class frmXml : Form
  {
    SaveFileDialog saveFile1 = new SaveFileDialog();
    public frmXml()
    {
      InitializeComponent();
    }
    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      openFile1.DefaultExt = "*.xml";
      openFile1.Filter = "XML Files|*.xml";
      if (openFile1.ShowDialog() == DialogResult.OK &&
         openFile1.FileName.Length > 0)
      {
        XmlTextReader xmlTextReader = new XmlTextReader(openFile1.FileName);
        string ultimaEtiqueta = "";
        while (xmlTextReader.Read())
        {
          if (xmlTextReader.NodeType == XmlNodeType.Element)
          {
            XmlTextReader.Text += (new string(' ', xmlTextReader.Depth * 3) + "<" + xmlTextReader.Name + ">");
            ultimaEtiqueta = xmlTextReader.Name;
            continue;
          }
          if (xmlTextReader.NodeType == XmlNodeType.Text)
          {
            XmlTextReader.Text += xmlTextReader.ReadContentAsString() + "</" + ultimaEtiqueta + ">";
          }
          else
            XmlTextReader.Text += "\r";
        }
      }
    }
    private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      frmXml frm = new frmXml();
      frm.Show();
    }
    private void btnBorrar_Click(object sender, EventArgs e)
    {
      if (btnAbrir != null)
      {
        XmlTextReader.Clear();
      }
    }
    private void btnAbrir_Click(object sender, EventArgs e)
      {
      openFile1.DefaultExt = "*.xml";
      openFile1.Filter = "XML Files|*.xml";
        if (openFile1.ShowDialog() == DialogResult.OK &&
           openFile1.FileName.Length > 0)
        {
          XmlTextReader xmlTextReader = new XmlTextReader(openFile1.FileName);
          string ultimaEtiqueta = "";
        XmlTextReader.Visible = true;
          while (xmlTextReader.Read())
          {
            if (xmlTextReader.NodeType == XmlNodeType.Element)
            {
              XmlTextReader.Text += (new string(' ', xmlTextReader.Depth * 3) + "<" + xmlTextReader.Name + ">");
              ultimaEtiqueta = xmlTextReader.Name;
              continue;
            }
            if (xmlTextReader.NodeType == XmlNodeType.Text)
            {
              XmlTextReader.Text += xmlTextReader.ReadContentAsString() + "</" + ultimaEtiqueta + ">";
            }
            else
              XmlTextReader.Text += "\r";
          }
        }
      }
    private void BtnGuardar_Click(object sender, EventArgs e)
    {
        saveFile1.DefaultExt = "*.xml";
        saveFile1.Filter = "XML Files|*.xml";
        if (saveFile1.ShowDialog() == DialogResult.OK &&
          saveFile1.FileName.Length > 0)
        {
          XmlTextReader.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
        }
    }
    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
