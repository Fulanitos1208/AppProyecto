using System;
using System.Windows.Forms;
namespace AppProyecto
{
  public partial class frmMenuDoc : Form
  {
    public frmMenuDoc()
    {
      InitializeComponent();
    }
    private void btnRepM_Click(object sender, EventArgs e)
    {
      Form rep = new frmReproductor();
      rep.Show();
    }
    private void btnImg_Click(object sender, EventArgs e)
    {
      Form img = new frmImagenes();
      img.Show();
    }
    private void btnOrg_Click(object sender, EventArgs e)
    {
      Form org = new frmOrdenadorArchivos();
      org.Show(); 
    }
    private void btnXml_Click(object sender, EventArgs e)
    {
      Form Xml = new frmXml();
      Xml.Show(); 
    }
    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnWord_Click(object sender, EventArgs e)
    {
      Form Word = new frmWord();
      Word.Show();
    }
    private void button2_Click(object sender, EventArgs e)
    {
      lectorex le = new lectorex();
      le.Show();
    }
  }
}
