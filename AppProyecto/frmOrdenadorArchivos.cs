using System;
using System.IO;
using WindowsInput;
using System.Drawing;
using System.Collections;
using WindowsInput.Native;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
namespace AppProyecto
{
  public partial class frmOrdenadorArchivos : Form
  {
    int cont = 0;
    public frmOrdenadorArchivos()
    {
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      Borrar();
      ChooseFolder();
      btnAnterior.Visible = true;
      btnSiguiente.Visible = true;
    }
    DirectoryInfo folderInfo;
    public void ChooseFolder()
    {
      FolderBrowserDialog dialogo = new FolderBrowserDialog();
      if (dialogo.ShowDialog() == DialogResult.OK)
      {
        textBox1.Text = dialogo.SelectedPath;
        pbCopiar.Visible = true;
        pbMover.Visible = true;
        label2.Visible = true;
        lbMover.Visible = true;
        DirectoryInfo di = new DirectoryInfo(dialogo.SelectedPath);
        treeView1.AfterSelect += TreeView1_AfterSelect;
        LlenarArbol(di, treeView1.Nodes);
      }
    }
    ArrayList archivos = new ArrayList();
    private void LlenarArbol(DirectoryInfo di, TreeNodeCollection tnc)
    {
      TreeNode nodo = tnc.Add(di.Name);
      foreach (FileInfo archivo in di.GetFiles())
      {
          nodo.Nodes.Add(archivo.FullName, archivo.Name);
        archivos.Add(archivo);
      }
      foreach (DirectoryInfo sdi in di.GetDirectories())
      {
        LlenarArbol(sdi, nodo.Nodes);
      }
    }
    private void Borrar()
    {
      textBox1.Clear();
      richTextBox1.Clear();
      treeView1.Nodes.Clear();
      pictureBox1.Image = null;
    }
    private void OrganizarMover()
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      MessageBox.Show("Selecciona donde se creara la nueva carpeta organizada");
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\Carpeta Organizada");
        DirectoryInfo carpetaOrganizadaInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
        MoverArchivos(carpetaOrganizadaInfo);
      }
    }
    private void OrganizarCopiar()
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      MessageBox.Show("Selecciona donde se creara la nueva carpeta organizada");
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\Carpeta Organizada");
        DirectoryInfo carpetaOrganizadaInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
        CopiarArchivos(carpetaOrganizadaInfo);
      }
    }
    private void MoverArchivos(DirectoryInfo di)
    {
      foreach (FileInfo file in archivos)
      {
        {
          if (file.Extension ==".jpg"|| file.Extension==".jpeg"|| file.Extension==".png")
          {
            try
            {
             FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\ Imagenes" + file, UIOption.AllDialogs);
            }
            catch (Exception ex)  { }
          }
          else if (file.Extension==".mp3"|| file.Extension==".m4a")
          {
            try
            {
               FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Audio\\" + file, UIOption.AllDialogs); 
            }
            catch (Exception) {}
          }
          else if (file.Extension==".mp4"|| file.Extension==".mov")
          {
            try
            {
              FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Video\\" + file, UIOption.AllDialogs);
            }
            catch (Exception) {}
          }
          else if (file.Extension == ".cs" || file.Extension == ".txt" || file.Extension == ".docx" || file.Extension == ".pptx" || file.Extension == ".pdf" || file.Extension == ".PDF" || file.Extension == ".xlsx")
          {
            try
            { FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Documentos\\" + file, UIOption.AllDialogs); }
            catch (Exception ex) { }
          }
          else
          {
            try
            {
              FileSystem.MoveFile(file.FullName, di+ "\\Carpeta Organizada\\Archivos\\" + file, UIOption.AllDialogs);
            }
            catch (Exception)
            {

              throw;
            }
          }
        }
      }
    }
    private void CopiarArchivos(DirectoryInfo di)
    {
      foreach (FileInfo file in archivos)
      {

        if (file.Extension == ".jpg" || file.Extension == ".jpeg" || file.Extension == ".png")
        {
          try
          { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Imagenes\\" + file, UIOption.AllDialogs); }
          catch (Exception ex) { }
        }
        else if (file.Extension == ".mp3" || file.Extension == ".wav" || file.Extension == ".m4a" || file.Extension == ".flac")
        {
          try
          { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Audio\\" + file, UIOption.AllDialogs); }
          catch (Exception ex) { }
        }
        else if (file.Extension == ".mp4" || file.Extension == ".mov")
        {
          try
          { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Video\\" + file, UIOption.AllDialogs); }
          catch (Exception ex) { }
        }
        else if (file.Extension == ".cs" || file.Extension == ".txt" || file.Extension == ".docx" || file.Extension == ".pptx" || file.Extension == ".pdf" || file.Extension == ".xlsx")
        {
          try
          { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Documentos\\" + file, UIOption.AllDialogs); }
          catch (Exception ex) { }
        }
        else
        {
          try
          { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Archivos\\" + file, UIOption.AllDialogs); }
          catch (Exception ex) { }
        }
      }
    }
    public void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (e.Node.Name.EndsWith("txt") || e.Node.Name.EndsWith("cs") || e.Node.Name.EndsWith("pdf") || e.Node.Name.EndsWith("exe"))

      {
        richTextBox1.Clear();
        StreamReader lector = new StreamReader(e.Node.Name);
        richTextBox1.Text = lector.ReadToEnd();
        lector.Close();
        pictureBox1.Visible = false;
        richTextBox1.Visible = true;
        btnAnterior.Visible = false;
        btnSiguiente.Visible = false;
        btnFrmEditor.Visible = false;
        button2.Visible = false;
        pictureBox1.BorderStyle = BorderStyle.None;
        MenuStrip1.Visible = true;
      }
      if (e.Node.Name.EndsWith("jpg") || e.Node.Name.EndsWith("png") || e.Node.Name.EndsWith("gif" +
      ""))
      {
        Image image = Image.FromFile(e.Node.Name);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.Image = image;
        pictureBox1.Visible = true;
        richTextBox1.Visible = false;
        btnAnterior.Visible = true;
        btnSiguiente.Visible = true;
        btnFrmEditor.Visible = true;
        button2.Visible = true;
        richTextBox1.BorderStyle = BorderStyle.None;
        MenuStrip1.Visible = true;
      }
    }
    private void pictureBox1_DoubleClick(object sender, EventArgs e)
    {
      pictureBox1.Dock = DockStyle.Fill;
      FormBorderStyle = FormBorderStyle.None;
      WindowState = FormWindowState.Maximized;
      btnAnterior.Visible = false;
      btnSiguiente.Visible = false;
    }
    private void pictureBox1_Click(object sender, EventArgs e)
    {
      pictureBox1.Dock = DockStyle.None;
      FormBorderStyle = FormBorderStyle.None;
      WindowState = FormWindowState.Normal;
      btnAnterior.Visible = true;
      btnSiguiente.Visible = true;
    }
    InputSimulator sim = new InputSimulator();
    private void btnAnterior_Click(object sender, EventArgs e)
    {
      treeView1.Focus();
      sim.Keyboard.KeyPress(VirtualKeyCode.UP);
    }
    private void btnSiguiente_Click(object sender, EventArgs e)
    {
      treeView1.Focus();
      sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
    }
    private void button2_Click(object sender, EventArgs e)
    {
      //inicializar();
      timer1.Start();
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
      cont += 1;
      label1.Text = "" + cont;
    }
    private void BtnRuta_Click(object sender, EventArgs e)
    {
      ChooseFolder();
    }
    private void pbCopiar_Click(object sender, EventArgs e)
    {
      OrganizarCopiar();
    }
    private void pbMover_Click(object sender, EventArgs e)
    {
      OrganizarMover();
    }
    private void pbReturn_Click(object sender, EventArgs e)
    {
      Form home = new frmMenu();
      home.ShowDialog();
    }
    private void btnFrmEditor_Click(object sender, EventArgs e)
    {
      Form edit = new frmImagenes();
      edit.ShowDialog();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
