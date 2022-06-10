using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AppProyecto
{
  public partial class frmMen : Form
  {
    public frmMen()
    {
      InitializeComponent();
      this.Opacity = 0;
      this.ShowInTaskbar = false;
      frmInicioSesion f = new frmInicioSesion(this);
      f.WindowState = FormWindowState.Maximized;
      f.ShowDialog();
    }
    private void btnclose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnMusica_Click(object sender, EventArgs e)
    {
      frmReproductor rep = new frmReproductor();
      rep.Show(); 
    }
    private void btneditorimagen_Click(object sender, EventArgs e)
    {
      frmImagenes img = new frmImagenes();
      img.Show();
    }
    private void btnvideo_Click(object sender, EventArgs e)
    {
      frmReproductor r = new frmReproductor();
      r.Show();
    }
    private void btntexto_Click(object sender, EventArgs e)
    {
      frmMenuDoc m = new frmMenuDoc();
      m.Show();
    }
    private void btnminimizar_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }
    private void btnGaleria_Click(object sender, EventArgs e)
    {
      frmOrdenadorArchivos oa = new frmOrdenadorArchivos();
      oa.Show();
    }
    private void LbEditorImg_Click(object sender, EventArgs e)
    {
      frmImagenes img = new frmImagenes();
      img.Show();
    }
    private void LbOrdenador_Click(object sender, EventArgs e)
    {
      frmOrdenadorArchivos oa = new frmOrdenadorArchivos();
      oa.Show();
    }
    private void LbDocumentos_Click(object sender, EventArgs e)
    {
      frmMenuDoc Md = new frmMenuDoc();
      Md.Show();  
    }
    private void LbReproductorV_Click(object sender, EventArgs e)
    {
      frmReproductor Rv = new frmReproductor();
      Rv.Show();
    }
  }
}
