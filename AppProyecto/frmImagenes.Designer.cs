namespace AppProyecto
{
  partial class frmImagenes
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
      this.LbBlue = new System.Windows.Forms.Label();
      this.LbGreen = new System.Windows.Forms.Label();
      this.LbRed = new System.Windows.Forms.Label();
      this.bluevalue = new System.Windows.Forms.Label();
      this.greenvalue = new System.Windows.Forms.Label();
      this.redvalue = new System.Windows.Forms.Label();
      this.bluebar = new System.Windows.Forms.TrackBar();
      this.greenbar = new System.Windows.Forms.TrackBar();
      this.redbar = new System.Windows.Forms.TrackBar();
      this.BtnGuardar = new System.Windows.Forms.Button();
      this.PbVisualizador = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.sweufeefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmFiltros = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmOriginal = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmBN = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmSepia = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmFiltro1 = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmFiltro2 = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmFiltro3 = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmFiltro4 = new System.Windows.Forms.ToolStripMenuItem();
      this.TsmFiltro5 = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.BtnAbri = new System.Windows.Forms.Button();
      this.BtnCerrar = new System.Windows.Forms.Button();
      this.btnFiltros = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.btnOriginal = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PbVisualizador)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // LbBlue
      // 
      this.LbBlue.AutoSize = true;
      this.LbBlue.BackColor = System.Drawing.Color.Black;
      this.LbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LbBlue.ForeColor = System.Drawing.Color.White;
      this.LbBlue.Location = new System.Drawing.Point(665, 408);
      this.LbBlue.Name = "LbBlue";
      this.LbBlue.Size = new System.Drawing.Size(52, 24);
      this.LbBlue.TabIndex = 45;
      this.LbBlue.Text = "Blue";
      this.LbBlue.Visible = false;
      // 
      // LbGreen
      // 
      this.LbGreen.AutoSize = true;
      this.LbGreen.BackColor = System.Drawing.Color.Black;
      this.LbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LbGreen.ForeColor = System.Drawing.Color.White;
      this.LbGreen.Location = new System.Drawing.Point(665, 368);
      this.LbGreen.Name = "LbGreen";
      this.LbGreen.Size = new System.Drawing.Size(68, 24);
      this.LbGreen.TabIndex = 44;
      this.LbGreen.Text = "Green";
      this.LbGreen.Visible = false;
      // 
      // LbRed
      // 
      this.LbRed.AutoSize = true;
      this.LbRed.BackColor = System.Drawing.Color.Black;
      this.LbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LbRed.ForeColor = System.Drawing.Color.White;
      this.LbRed.Location = new System.Drawing.Point(665, 333);
      this.LbRed.Name = "LbRed";
      this.LbRed.Size = new System.Drawing.Size(48, 24);
      this.LbRed.TabIndex = 43;
      this.LbRed.Text = "Red";
      this.LbRed.Visible = false;
      // 
      // bluevalue
      // 
      this.bluevalue.AutoSize = true;
      this.bluevalue.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bluevalue.ForeColor = System.Drawing.Color.MediumTurquoise;
      this.bluevalue.Location = new System.Drawing.Point(-5, 377);
      this.bluevalue.Name = "bluevalue";
      this.bluevalue.Size = new System.Drawing.Size(35, 26);
      this.bluevalue.TabIndex = 42;
      this.bluevalue.Text = "0.0";
      this.bluevalue.Visible = false;
      // 
      // greenvalue
      // 
      this.greenvalue.AutoSize = true;
      this.greenvalue.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.greenvalue.ForeColor = System.Drawing.Color.MediumTurquoise;
      this.greenvalue.Location = new System.Drawing.Point(-4, 415);
      this.greenvalue.Name = "greenvalue";
      this.greenvalue.Size = new System.Drawing.Size(35, 26);
      this.greenvalue.TabIndex = 41;
      this.greenvalue.Text = "0.0";
      this.greenvalue.Visible = false;
      // 
      // redvalue
      // 
      this.redvalue.AutoSize = true;
      this.redvalue.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redvalue.ForeColor = System.Drawing.Color.MediumTurquoise;
      this.redvalue.Location = new System.Drawing.Point(-4, 331);
      this.redvalue.Name = "redvalue";
      this.redvalue.Size = new System.Drawing.Size(35, 26);
      this.redvalue.TabIndex = 40;
      this.redvalue.Text = "0.0";
      this.redvalue.Visible = false;
      // 
      // bluebar
      // 
      this.bluebar.Location = new System.Drawing.Point(25, 414);
      this.bluebar.Margin = new System.Windows.Forms.Padding(1);
      this.bluebar.Maximum = 50;
      this.bluebar.Name = "bluebar";
      this.bluebar.Size = new System.Drawing.Size(636, 45);
      this.bluebar.TabIndex = 37;
      this.bluebar.Visible = false;
      this.bluebar.Scroll += new System.EventHandler(this.bluebar_Scroll);
      // 
      // greenbar
      // 
      this.greenbar.LargeChange = 50;
      this.greenbar.Location = new System.Drawing.Point(25, 377);
      this.greenbar.Margin = new System.Windows.Forms.Padding(1);
      this.greenbar.Maximum = 50;
      this.greenbar.Name = "greenbar";
      this.greenbar.Size = new System.Drawing.Size(636, 45);
      this.greenbar.TabIndex = 38;
      this.greenbar.Visible = false;
      this.greenbar.Scroll += new System.EventHandler(this.greenbar_Scroll);
      // 
      // redbar
      // 
      this.redbar.Location = new System.Drawing.Point(26, 331);
      this.redbar.Margin = new System.Windows.Forms.Padding(1);
      this.redbar.Maximum = 50;
      this.redbar.Name = "redbar";
      this.redbar.Size = new System.Drawing.Size(635, 45);
      this.redbar.TabIndex = 39;
      this.redbar.Visible = false;
      this.redbar.Scroll += new System.EventHandler(this.redbar_Scroll_1);
      // 
      // BtnGuardar
      // 
      this.BtnGuardar.BackColor = System.Drawing.Color.Black;
      this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.BtnGuardar.Location = new System.Drawing.Point(745, 74);
      this.BtnGuardar.Name = "BtnGuardar";
      this.BtnGuardar.Size = new System.Drawing.Size(55, 42);
      this.BtnGuardar.TabIndex = 35;
      this.BtnGuardar.Text = "Guardar archivo";
      this.BtnGuardar.UseVisualStyleBackColor = false;
      this.BtnGuardar.Visible = false;
      this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // PbVisualizador
      // 
      this.PbVisualizador.Location = new System.Drawing.Point(202, 16);
      this.PbVisualizador.Name = "PbVisualizador";
      this.PbVisualizador.Size = new System.Drawing.Size(457, 341);
      this.PbVisualizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.PbVisualizador.TabIndex = 34;
      this.PbVisualizador.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sweufeefToolStripMenuItem,
            this.TsmFiltros});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 36;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // sweufeefToolStripMenuItem
      // 
      this.sweufeefToolStripMenuItem.Name = "sweufeefToolStripMenuItem";
      this.sweufeefToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.sweufeefToolStripMenuItem.Text = "sweufeef";
      // 
      // TsmFiltros
      // 
      this.TsmFiltros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmOriginal,
            this.TsmBN,
            this.TsmSepia,
            this.TsmFiltro1,
            this.TsmFiltro2,
            this.TsmFiltro3,
            this.TsmFiltro4,
            this.TsmFiltro5});
      this.TsmFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.TsmFiltros.Name = "TsmFiltros";
      this.TsmFiltros.Size = new System.Drawing.Size(51, 20);
      this.TsmFiltros.Text = "Filtros";
      this.TsmFiltros.Visible = false;
      // 
      // TsmOriginal
      // 
      this.TsmOriginal.Name = "TsmOriginal";
      this.TsmOriginal.Size = new System.Drawing.Size(67, 22);
      // 
      // TsmBN
      // 
      this.TsmBN.Name = "TsmBN";
      this.TsmBN.Size = new System.Drawing.Size(67, 22);
      // 
      // TsmSepia
      // 
      this.TsmSepia.Name = "TsmSepia";
      this.TsmSepia.Size = new System.Drawing.Size(67, 22);
      // 
      // TsmFiltro1
      // 
      this.TsmFiltro1.Name = "TsmFiltro1";
      this.TsmFiltro1.Size = new System.Drawing.Size(67, 22);
      // 
      // TsmFiltro2
      // 
      this.TsmFiltro2.Name = "TsmFiltro2";
      this.TsmFiltro2.Size = new System.Drawing.Size(67, 22);
      // 
      // TsmFiltro3
      // 
      this.TsmFiltro3.Name = "TsmFiltro3";
      this.TsmFiltro3.Size = new System.Drawing.Size(67, 22);
      // 
      // TsmFiltro4
      // 
      this.TsmFiltro4.Name = "TsmFiltro4";
      this.TsmFiltro4.Size = new System.Drawing.Size(67, 22);
      // 
      // TsmFiltro5
      // 
      this.TsmFiltro5.Name = "TsmFiltro5";
      this.TsmFiltro5.Size = new System.Drawing.Size(67, 22);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
      // 
      // BtnAbri
      // 
      this.BtnAbri.BackColor = System.Drawing.Color.Black;
      this.BtnAbri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnAbri.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.BtnAbri.Location = new System.Drawing.Point(753, 29);
      this.BtnAbri.Name = "BtnAbri";
      this.BtnAbri.Size = new System.Drawing.Size(47, 24);
      this.BtnAbri.TabIndex = 51;
      this.BtnAbri.Text = "Abrir";
      this.BtnAbri.UseVisualStyleBackColor = false;
      this.BtnAbri.Click += new System.EventHandler(this.BtnAbri_Click);
      // 
      // BtnCerrar
      // 
      this.BtnCerrar.BackColor = System.Drawing.Color.Black;
      this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnCerrar.ForeColor = System.Drawing.Color.Red;
      this.BtnCerrar.Location = new System.Drawing.Point(765, -6);
      this.BtnCerrar.Name = "BtnCerrar";
      this.BtnCerrar.Size = new System.Drawing.Size(35, 29);
      this.BtnCerrar.TabIndex = 52;
      this.BtnCerrar.Text = "X";
      this.BtnCerrar.UseVisualStyleBackColor = false;
      this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
      // 
      // btnFiltros
      // 
      this.btnFiltros.BackColor = System.Drawing.Color.Black;
      this.btnFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnFiltros.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnFiltros.Location = new System.Drawing.Point(0, 32);
      this.btnFiltros.Name = "btnFiltros";
      this.btnFiltros.Size = new System.Drawing.Size(47, 24);
      this.btnFiltros.TabIndex = 53;
      this.btnFiltros.Text = "Filtros";
      this.btnFiltros.UseVisualStyleBackColor = false;
      this.btnFiltros.Visible = false;
      this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.button1.Location = new System.Drawing.Point(1, 242);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(47, 24);
      this.button1.TabIndex = 54;
      this.button1.Text = "5";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Visible = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Black;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.button2.Location = new System.Drawing.Point(0, 212);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(47, 24);
      this.button2.TabIndex = 55;
      this.button2.Text = "4";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Visible = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Black;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.button3.Location = new System.Drawing.Point(1, 182);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(47, 24);
      this.button3.TabIndex = 56;
      this.button3.Text = "3";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Visible = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.Black;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.button4.Location = new System.Drawing.Point(0, 152);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(47, 24);
      this.button4.TabIndex = 57;
      this.button4.Text = "2";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Visible = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.Black;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.button5.Location = new System.Drawing.Point(1, 122);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(47, 24);
      this.button5.TabIndex = 58;
      this.button5.Text = "1";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Visible = false;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.Black;
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.button6.Location = new System.Drawing.Point(1, 92);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(47, 24);
      this.button6.TabIndex = 59;
      this.button6.Text = "Sepia";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Visible = false;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.Black;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.button7.Location = new System.Drawing.Point(1, 62);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(47, 24);
      this.button7.TabIndex = 60;
      this.button7.Text = "B/N";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Visible = false;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // btnOriginal
      // 
      this.btnOriginal.BackColor = System.Drawing.Color.Black;
      this.btnOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOriginal.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnOriginal.Location = new System.Drawing.Point(1, 272);
      this.btnOriginal.Name = "btnOriginal";
      this.btnOriginal.Size = new System.Drawing.Size(112, 25);
      this.btnOriginal.TabIndex = 61;
      this.btnOriginal.Text = "Eliminar filtros";
      this.btnOriginal.UseVisualStyleBackColor = false;
      this.btnOriginal.Visible = false;
      this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
      // 
      // frmImagenes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnOriginal);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnFiltros);
      this.Controls.Add(this.BtnCerrar);
      this.Controls.Add(this.BtnAbri);
      this.Controls.Add(this.LbBlue);
      this.Controls.Add(this.LbGreen);
      this.Controls.Add(this.LbRed);
      this.Controls.Add(this.bluevalue);
      this.Controls.Add(this.greenvalue);
      this.Controls.Add(this.redvalue);
      this.Controls.Add(this.bluebar);
      this.Controls.Add(this.greenbar);
      this.Controls.Add(this.redbar);
      this.Controls.Add(this.BtnGuardar);
      this.Controls.Add(this.PbVisualizador);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmImagenes";
      this.Text = "frmImagenes";
      ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PbVisualizador)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LbBlue;
    private System.Windows.Forms.Label LbGreen;
    private System.Windows.Forms.Label LbRed;
    private System.Windows.Forms.Label bluevalue;
    private System.Windows.Forms.Label greenvalue;
    private System.Windows.Forms.Label redvalue;
    private System.Windows.Forms.TrackBar bluebar;
    private System.Windows.Forms.TrackBar greenbar;
    private System.Windows.Forms.TrackBar redbar;
    private System.Windows.Forms.Button BtnGuardar;
    private System.Windows.Forms.PictureBox PbVisualizador;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem TsmFiltros;
    private System.Windows.Forms.ToolStripMenuItem TsmOriginal;
    private System.Windows.Forms.ToolStripMenuItem TsmBN;
    private System.Windows.Forms.ToolStripMenuItem TsmSepia;
    private System.Windows.Forms.ToolStripMenuItem TsmFiltro1;
    private System.Windows.Forms.ToolStripMenuItem TsmFiltro2;
    private System.Windows.Forms.ToolStripMenuItem TsmFiltro3;
    private System.Windows.Forms.ToolStripMenuItem TsmFiltro4;
    private System.Windows.Forms.ToolStripMenuItem TsmFiltro5;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button BtnAbri;
    private System.Windows.Forms.Button BtnCerrar;
    private System.Windows.Forms.ToolStripMenuItem sweufeefToolStripMenuItem;
    private System.Windows.Forms.Button btnFiltros;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button btnOriginal;
  }
}