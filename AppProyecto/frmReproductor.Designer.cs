namespace AppProyecto
{
  partial class frmReproductor
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReproductor));
      this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
      this.btnAleatorio = new System.Windows.Forms.Button();
      this.btnSiguiente = new System.Windows.Forms.Button();
      this.btnAbrir = new System.Windows.Forms.Button();
      this.Playlist = new System.Windows.Forms.ListBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnAnterior = new System.Windows.Forms.Button();
      this.btnPausa = new System.Windows.Forms.Button();
      this.lbTotalTime = new System.Windows.Forms.Label();
      this.lbTime = new System.Windows.Forms.Label();
      this.sbVolumen = new System.Windows.Forms.HScrollBar();
      this.sbTiempo = new System.Windows.Forms.HScrollBar();
      this.pbAlbum = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
      this.SuspendLayout();
      // 
      // vlcControl1
      // 
      this.vlcControl1.BackColor = System.Drawing.Color.Black;
      this.vlcControl1.Location = new System.Drawing.Point(12, 0);
      this.vlcControl1.Name = "vlcControl1";
      this.vlcControl1.Size = new System.Drawing.Size(593, 219);
      this.vlcControl1.Spu = -1;
      this.vlcControl1.TabIndex = 0;
      this.vlcControl1.Text = "vlcControl1";
      this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
      this.vlcControl1.VlcMediaplayerOptions = null;
      // 
      // btnAleatorio
      // 
      this.btnAleatorio.BackColor = System.Drawing.Color.Transparent;
      this.btnAleatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnAleatorio.Location = new System.Drawing.Point(423, 225);
      this.btnAleatorio.Name = "btnAleatorio";
      this.btnAleatorio.Size = new System.Drawing.Size(75, 23);
      this.btnAleatorio.TabIndex = 12;
      this.btnAleatorio.Text = "Aleatorio";
      this.btnAleatorio.UseVisualStyleBackColor = false;
      this.btnAleatorio.Visible = false;
      this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click_1);
      // 
      // btnSiguiente
      // 
      this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
      this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSiguiente.ForeColor = System.Drawing.Color.Fuchsia;
      this.btnSiguiente.Location = new System.Drawing.Point(282, 225);
      this.btnSiguiente.Name = "btnSiguiente";
      this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
      this.btnSiguiente.TabIndex = 11;
      this.btnSiguiente.Text = "Siguiente";
      this.btnSiguiente.UseVisualStyleBackColor = false;
      this.btnSiguiente.Visible = false;
      this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
      // 
      // btnAbrir
      // 
      this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
      this.btnAbrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
      this.btnAbrir.Location = new System.Drawing.Point(21, 303);
      this.btnAbrir.Name = "btnAbrir";
      this.btnAbrir.Size = new System.Drawing.Size(105, 95);
      this.btnAbrir.TabIndex = 10;
      this.btnAbrir.Text = "Abrir";
      this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnAbrir.UseVisualStyleBackColor = false;
      this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
      // 
      // Playlist
      // 
      this.Playlist.BackColor = System.Drawing.Color.Black;
      this.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Playlist.ForeColor = System.Drawing.Color.Fuchsia;
      this.Playlist.FormattingEnabled = true;
      this.Playlist.Location = new System.Drawing.Point(611, 0);
      this.Playlist.Name = "Playlist";
      this.Playlist.Size = new System.Drawing.Size(151, 260);
      this.Playlist.TabIndex = 9;
      this.Playlist.Visible = false;
      this.Playlist.SelectedIndexChanged += new System.EventHandler(this.playlist_SelectedIndexChanged);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnAnterior
      // 
      this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAnterior.ForeColor = System.Drawing.Color.Fuchsia;
      this.btnAnterior.Location = new System.Drawing.Point(19, 225);
      this.btnAnterior.Name = "btnAnterior";
      this.btnAnterior.Size = new System.Drawing.Size(90, 23);
      this.btnAnterior.TabIndex = 13;
      this.btnAnterior.Text = "Anterior";
      this.btnAnterior.UseVisualStyleBackColor = true;
      this.btnAnterior.Visible = false;
      this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
      // 
      // btnPausa
      // 
      this.btnPausa.BackColor = System.Drawing.Color.Transparent;
      this.btnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPausa.ForeColor = System.Drawing.Color.Fuchsia;
      this.btnPausa.Location = new System.Drawing.Point(155, 225);
      this.btnPausa.Name = "btnPausa";
      this.btnPausa.Size = new System.Drawing.Size(75, 23);
      this.btnPausa.TabIndex = 14;
      this.btnPausa.Text = "Pausa";
      this.btnPausa.UseVisualStyleBackColor = false;
      this.btnPausa.Visible = false;
      this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
      // 
      // lbTotalTime
      // 
      this.lbTotalTime.AutoSize = true;
      this.lbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTotalTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.lbTotalTime.Location = new System.Drawing.Point(420, 260);
      this.lbTotalTime.Name = "lbTotalTime";
      this.lbTotalTime.Size = new System.Drawing.Size(38, 16);
      this.lbTotalTime.TabIndex = 18;
      this.lbTotalTime.Text = "00:00";
      // 
      // lbTime
      // 
      this.lbTime.AutoSize = true;
      this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.lbTime.Location = new System.Drawing.Point(18, 260);
      this.lbTime.Name = "lbTime";
      this.lbTime.Size = new System.Drawing.Size(38, 16);
      this.lbTime.TabIndex = 17;
      this.lbTime.Text = "00:00";
      // 
      // sbVolumen
      // 
      this.sbVolumen.Location = new System.Drawing.Point(493, 260);
      this.sbVolumen.Maximum = 200;
      this.sbVolumen.Name = "sbVolumen";
      this.sbVolumen.Size = new System.Drawing.Size(114, 20);
      this.sbVolumen.TabIndex = 9;
      this.sbVolumen.Value = 50;
      this.sbVolumen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVolumen_Scroll);
      // 
      // sbTiempo
      // 
      this.sbTiempo.Location = new System.Drawing.Point(59, 260);
      this.sbTiempo.Name = "sbTiempo";
      this.sbTiempo.Size = new System.Drawing.Size(357, 20);
      this.sbTiempo.TabIndex = 8;
      this.sbTiempo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbTiempo_Scroll);
      // 
      // pbAlbum
      // 
      this.pbAlbum.Location = new System.Drawing.Point(496, 283);
      this.pbAlbum.Name = "pbAlbum";
      this.pbAlbum.Size = new System.Drawing.Size(114, 95);
      this.pbAlbum.TabIndex = 19;
      this.pbAlbum.TabStop = false;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Transparent;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Red;
      this.button1.Location = new System.Drawing.Point(910, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(34, 34);
      this.button1.TabIndex = 20;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Visible = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmReproductor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(944, 469);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pbAlbum);
      this.Controls.Add(this.lbTotalTime);
      this.Controls.Add(this.lbTime);
      this.Controls.Add(this.sbVolumen);
      this.Controls.Add(this.sbTiempo);
      this.Controls.Add(this.btnPausa);
      this.Controls.Add(this.btnAnterior);
      this.Controls.Add(this.btnAleatorio);
      this.Controls.Add(this.btnSiguiente);
      this.Controls.Add(this.btnAbrir);
      this.Controls.Add(this.Playlist);
      this.Controls.Add(this.vlcControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmReproductor";
      this.Text = "frmReproductor";
      ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Vlc.DotNet.Forms.VlcControl vlcControl1;
    private System.Windows.Forms.Button btnAleatorio;
    private System.Windows.Forms.Button btnSiguiente;
    private System.Windows.Forms.Button btnAbrir;
    private System.Windows.Forms.ListBox Playlist;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnAnterior;
    private System.Windows.Forms.Button btnPausa;
    private System.Windows.Forms.Label lbTotalTime;
    private System.Windows.Forms.Label lbTime;
    private System.Windows.Forms.HScrollBar sbVolumen;
    private System.Windows.Forms.HScrollBar sbTiempo;
    private System.Windows.Forms.PictureBox pbAlbum;
    private System.Windows.Forms.Button button1;
  }
}