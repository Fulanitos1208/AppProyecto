namespace AppProyecto
{
  partial class frmMenuDoc
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDoc));
      this.btnXml = new System.Windows.Forms.Button();
      this.Documentos = new System.Windows.Forms.Label();
      this.LbMenu = new System.Windows.Forms.Label();
      this.btnMenu = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.btnWord = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnXml
      // 
      this.btnXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXml.Image = ((System.Drawing.Image)(resources.GetObject("btnXml.Image")));
      this.btnXml.Location = new System.Drawing.Point(60, 32);
      this.btnXml.Name = "btnXml";
      this.btnXml.Size = new System.Drawing.Size(110, 122);
      this.btnXml.TabIndex = 11;
      this.btnXml.Text = "Xml";
      this.btnXml.UseVisualStyleBackColor = true;
      this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
      // 
      // Documentos
      // 
      this.Documentos.AutoSize = true;
      this.Documentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Documentos.Location = new System.Drawing.Point(12, 1);
      this.Documentos.Name = "Documentos";
      this.Documentos.Size = new System.Drawing.Size(110, 20);
      this.Documentos.TabIndex = 12;
      this.Documentos.Text = "Documentos";
      // 
      // LbMenu
      // 
      this.LbMenu.AutoSize = true;
      this.LbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LbMenu.Location = new System.Drawing.Point(392, 157);
      this.LbMenu.Name = "LbMenu";
      this.LbMenu.Size = new System.Drawing.Size(53, 20);
      this.LbMenu.TabIndex = 14;
      this.LbMenu.Text = "Menu";
      // 
      // btnMenu
      // 
      this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
      this.btnMenu.Location = new System.Drawing.Point(359, 32);
      this.btnMenu.Name = "btnMenu";
      this.btnMenu.Size = new System.Drawing.Size(110, 122);
      this.btnMenu.TabIndex = 8;
      this.btnMenu.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Black;
      this.button1.Location = new System.Drawing.Point(800, 1);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(34, 34);
      this.button1.TabIndex = 17;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnWord
      // 
      this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnWord.Image = ((System.Drawing.Image)(resources.GetObject("btnWord.Image")));
      this.btnWord.Location = new System.Drawing.Point(610, 32);
      this.btnWord.Name = "btnWord";
      this.btnWord.Size = new System.Drawing.Size(110, 122);
      this.btnWord.TabIndex = 18;
      this.btnWord.Text = "Word";
      this.btnWord.UseVisualStyleBackColor = true;
      this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
      // 
      // button2
      // 
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
      this.button2.Location = new System.Drawing.Point(193, 32);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(110, 122);
      this.button2.TabIndex = 19;
      this.button2.Text = "Excel";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // frmMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ClientSize = new System.Drawing.Size(834, 281);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnWord);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.LbMenu);
      this.Controls.Add(this.Documentos);
      this.Controls.Add(this.btnXml);
      this.Controls.Add(this.btnMenu);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmMenu";
      this.Text = "frmMenu";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnXml;
    private System.Windows.Forms.Label Documentos;
    private System.Windows.Forms.Label LbMenu;
    private System.Windows.Forms.Button btnMenu;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnWord;
    private System.Windows.Forms.Button button2;
  }
}