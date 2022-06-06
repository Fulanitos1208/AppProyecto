using System;
using System.Windows.Forms;
namespace AppProyecto
{
  public partial class frmMenu : Form
  {
    public frmMenu()
    {
      InitializeComponent();
      this.Opacity = 0;
      this.ShowInTaskbar = false;
      frmInicioSesion f = new frmInicioSesion(this);
      f.WindowState = FormWindowState.Maximized;
      f.ShowDialog();
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
  }
}
