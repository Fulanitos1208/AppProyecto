namespace AppProyecto
{
  partial class frmXml
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.openFile1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.XmlTextReader = new System.Windows.Forms.RichTextBox();
      this.btnAbrir = new System.Windows.Forms.Button();
      this.btnBorrar = new System.Windows.Forms.Button();
      this.BtnCargar = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // openFile1
      // 
      this.openFile1.FileName = "openFileDialog1";
      // 
      // XmlTextReader
      // 
      this.XmlTextReader.ForeColor = System.Drawing.Color.Black;
      this.XmlTextReader.Location = new System.Drawing.Point(227, 12);
      this.XmlTextReader.Name = "XmlTextReader";
      this.XmlTextReader.Size = new System.Drawing.Size(490, 264);
      this.XmlTextReader.TabIndex = 1;
      this.XmlTextReader.Text = "";
      this.XmlTextReader.Visible = false;
      // 
      // btnAbrir
      // 
      this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAbrir.ForeColor = System.Drawing.Color.White;
      this.btnAbrir.Location = new System.Drawing.Point(723, 4);
      this.btnAbrir.Name = "btnAbrir";
      this.btnAbrir.Size = new System.Drawing.Size(75, 23);
      this.btnAbrir.TabIndex = 2;
      this.btnAbrir.Text = "Abrir";
      this.btnAbrir.UseVisualStyleBackColor = true;
      this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
      // 
      // btnBorrar
      // 
      this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBorrar.ForeColor = System.Drawing.Color.Purple;
      this.btnBorrar.Location = new System.Drawing.Point(723, 52);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(75, 23);
      this.btnBorrar.TabIndex = 3;
      this.btnBorrar.Text = "Borrar";
      this.btnBorrar.UseVisualStyleBackColor = true;
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // BtnCargar
      // 
      this.BtnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCargar.ForeColor = System.Drawing.Color.Purple;
      this.BtnCargar.Location = new System.Drawing.Point(723, 113);
      this.BtnCargar.Name = "BtnCargar";
      this.BtnCargar.Size = new System.Drawing.Size(75, 23);
      this.BtnCargar.TabIndex = 4;
      this.BtnCargar.Text = "Guardar";
      this.BtnCargar.UseVisualStyleBackColor = true;
      this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Red;
      this.button1.Location = new System.Drawing.Point(723, 182);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Cerrar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmXml
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.BtnCargar);
      this.Controls.Add(this.btnBorrar);
      this.Controls.Add(this.btnAbrir);
      this.Controls.Add(this.XmlTextReader);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmXml";
      this.Text = "frmXml";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFile1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.RichTextBox XmlTextReader;
    private System.Windows.Forms.Button btnAbrir;
    private System.Windows.Forms.Button btnBorrar;
    private System.Windows.Forms.Button BtnCargar;
    private System.Windows.Forms.Button button1;
  }
}