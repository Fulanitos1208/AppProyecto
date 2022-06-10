using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
namespace AppProyecto
{
  public partial class frmImagenes : Form
  {
    public frmImagenes()
    {
      InitializeComponent();
    }
    Image file;
    Boolean opened = false;
    void openImage()
    {
      DialogResult dr = openFileDialog1.ShowDialog();
      if (dr == DialogResult.OK)
      {
        file = Image.FromFile(openFileDialog1.FileName);
        PbVisualizador.Image = file;
        redbar.Visible = true;
        greenbar.Visible = true;
        bluebar.Visible = true;
        bluevalue.Visible = true;
        redvalue.Visible = true;
        greenvalue.Visible = true;
        LbBlue.Visible = true;
        LbGreen.Visible = true;
        LbRed.Visible = true;
        opened = true;
        BtnGuardar.Visible = true;
        btnFiltros.Visible = true;
      }
    }
    void saveImage()
    {
      if (opened)
      {
        SaveFileDialog sfd = new SaveFileDialog(); 
        sfd.Filter = "Images|*.png;*.bmp;*.jpg";
        ImageFormat format = ImageFormat.Png;
        if (sfd.ShowDialog() == DialogResult.OK)
        {
          string ext = Path.GetExtension(sfd.FileName);
          switch (ext)
          {
            case ".jpg":
              format = ImageFormat.Jpeg;
              break;
            case ".bmp":
              format = ImageFormat.Bmp;
              break;
          }
          PbVisualizador.Image.Save(sfd.FileName, format);
        }
      }
      else { MessageBox.Show("No se ha seleccionado ninguna imagen, agregela desde el apartado >editor de imagenes>seleccionar arrchivo"); }
    }
    void grayscale()
    {
      if (!opened)
      {
        MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        Image img = PbVisualizador.Image;            
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  
        ImageAttributes ia = new ImageAttributes();
        ColorMatrix cmPicture = new ColorMatrix(new float[][]
        {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
        });
        ia.SetColorMatrix(cmPicture);          
        Graphics g = Graphics.FromImage(bmpInverted); 
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();                          
        PbVisualizador.Image = bmpInverted;
      }
    }
    void flash()
    {
      if (!opened)
      {
        MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        Image img = PbVisualizador.Image;                           
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  
        ImageAttributes ia = new ImageAttributes();      
        ColorMatrix cmPicture = new ColorMatrix(new float[][]    
        {
                    new float[]{1+0.9f, 0, 0, 0, 0},
            new float[]{0, 1+1.5f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
        });
        ia.SetColorMatrix(cmPicture);         
        Graphics g = Graphics.FromImage(bmpInverted);  
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();                         
        PbVisualizador.Image = bmpInverted;
      }
    }
    void redscale()
    {
      if (!opened)
      {
        MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        Image img = PbVisualizador.Image;                        
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height); 
        ImageAttributes ia = new ImageAttributes();           
        ColorMatrix cmPicture = new ColorMatrix(new float[][]     
        {
            new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
        });
        ia.SetColorMatrix(cmPicture);        
        Graphics g = Graphics.FromImage(bmpInverted);   
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();                           
        PbVisualizador.Image = bmpInverted;
      }
    }
    void filter1()
    {
      if (!opened)
      {
        MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        Image img = PbVisualizador.Image;                        
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
        ImageAttributes ia = new ImageAttributes();             
        ColorMatrix cmPicture = new ColorMatrix(new float[][]    
        {
            new float[]{.393f, .349f, .272f+1.3f, 0, 0},
            new float[]{.769f, .686f+0.5f, .534f, 0, 0},
            new float[]{.189f+2.3f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
        });
        ia.SetColorMatrix(cmPicture);     
        Graphics g = Graphics.FromImage(bmpInverted);  
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();                           
        PbVisualizador.Image = bmpInverted;
      }
    }
    void filter2()
    {
      if (!opened)
      {
        MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        Image img = PbVisualizador.Image;                           
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  
        ImageAttributes ia = new ImageAttributes();         
        ColorMatrix cmPicture = new ColorMatrix(new float[][]  
        {
            new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
        });
        ia.SetColorMatrix(cmPicture);          
        Graphics g = Graphics.FromImage(bmpInverted); 
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();                          
        PbVisualizador.Image = bmpInverted;
      }
    }
    void filter3()
    {
      if (!opened)
      {
        MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        Image img = PbVisualizador.Image;                     
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height); 
        ImageAttributes ia = new ImageAttributes();          
        ColorMatrix cmPicture = new ColorMatrix(new float[][]   
        {
            new float[]{.393f+0.3f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f+0.2f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.9f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
        });
        ia.SetColorMatrix(cmPicture);        
        Graphics g = Graphics.FromImage(bmpInverted);   
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();                          
        PbVisualizador.Image = bmpInverted;
      }
    }
    void Winter()
    {
      if (!opened)
      {
        MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        Image img = PbVisualizador.Image;                      
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  
        ImageAttributes ia = new ImageAttributes();        
        ColorMatrix cmPicture = new ColorMatrix(new float[][]    
        {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
        });
        ia.SetColorMatrix(cmPicture);        
        Graphics g = Graphics.FromImage(bmpInverted);  
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();                            
        PbVisualizador.Image = bmpInverted;
      }
    }
    void reload()
    {
      if (!opened)
      {
        // MessageBox.Show("Open an Image then apply changes");
      }
      else
      {
        if (opened)
        {
          file = Image.FromFile(openFileDialog1.FileName);
          PbVisualizador.Image = file;
          opened = true;
        }
      }
    }
    void hue()
    {
      float changered = redbar.Value * 0.1f;
      float changegreen = greenbar.Value * 0.1f;
      float changeblue = bluebar.Value * 0.1f;
      redvalue.Text = changered.ToString();
      greenvalue.Text = changeblue.ToString();
      bluevalue.Text = changegreen.ToString();
      reload();
      if (!opened)
      { }
      else
      {
        Image img = PbVisualizador.Image;
        Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
        ImageAttributes ia = new ImageAttributes();
        ColorMatrix cmPicture = new ColorMatrix(new float[][]
        {
                    new float[]{1+changered, 0, 0, 0, 0},
                    new float[]{0, 1+changegreen, 0, 0, 0},
                    new float[]{0, 0, 1+changeblue, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
        });
        ia.SetColorMatrix(cmPicture);
        Graphics g = Graphics.FromImage(bmpInverted);
        g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        g.Dispose();
        PbVisualizador.Image = bmpInverted;
      }
    }
    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      saveImage();
    }
    private void redbar_Scroll_1(object sender, EventArgs e)
    {
      hue();
    }
    private void greenbar_Scroll(object sender, EventArgs e)
    {
      hue();
    }
    private void bluebar_Scroll(object sender, EventArgs e)
    {
      hue();
    }
    private void pbReturn_Click(object sender, EventArgs e)
    {
      Form home = new frmMenuDoc();
      home.ShowDialog();
    }
    private void BtnAbri_Click(object sender, EventArgs e)
    {
      openImage();
    }
    private void btnOriginal_Click(object sender, EventArgs e)
    {
      greenbar.Value = 0;
      redbar.Value = 0;
      bluebar.Value = 0;
      greenvalue.Text = "0";
      reload();
    }
    private void btnFiltros_Click(object sender, EventArgs e)
    {
      btnFiltroBn.Visible = true;
      button6.Visible = true;
      button5.Visible = true;
      button4.Visible = true;
      button3.Visible = true;
      button2.Visible = true;
      button1.Visible = true;
      btnOriginal.Visible = true;
    }
    private void btnFiltroBn_Click(object sender, EventArgs e)
    {
      reload();
      grayscale();
    }
    private void button6_Click(object sender, EventArgs e)
    {
      reload();
      redscale();
    }
    private void button5_Click(object sender, EventArgs e)
    {
      reload();
      Winter();
    }
    private void button4_Click(object sender, EventArgs e)
    {
      reload();
      flash();
    }
    private void button3_Click(object sender, EventArgs e)
    {
      reload();
      filter2();
    }
    private void button2_Click(object sender, EventArgs e)
    {
      reload();
      filter3();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      reload();
      filter1();
    }
    private void BtnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
