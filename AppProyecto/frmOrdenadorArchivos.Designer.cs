namespace AppProyecto
{
  partial class frmOrdenadorArchivos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenadorArchivos));
      this.label1 = new System.Windows.Forms.Label();
      this.btnSiguiente = new System.Windows.Forms.Button();
      this.btnAnterior = new System.Windows.Forms.Button();
      this.PbVisualizadorImg = new System.Windows.Forms.PictureBox();
      this.RtbVisualizadorTex = new System.Windows.Forms.RichTextBox();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.BtnRuta = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.LbCopiar = new System.Windows.Forms.Label();
      this.lbMover = new System.Windows.Forms.Label();
      this.pbMover = new System.Windows.Forms.PictureBox();
      this.pbCopiar = new System.Windows.Forms.PictureBox();
      this.btnFrmEditor = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PbVisualizadorImg)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbMover)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCopiar)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, -13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(13, 13);
      this.label1.TabIndex = 27;
      this.label1.Text = "0";
      // 
      // btnSiguiente
      // 
      this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSiguiente.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSiguiente.ForeColor = System.Drawing.Color.Purple;
      this.btnSiguiente.Location = new System.Drawing.Point(723, 217);
      this.btnSiguiente.Name = "btnSiguiente";
      this.btnSiguiente.Size = new System.Drawing.Size(69, 62);
      this.btnSiguiente.TabIndex = 25;
      this.btnSiguiente.Text = ">";
      this.btnSiguiente.UseVisualStyleBackColor = true;
      this.btnSiguiente.UseWaitCursor = true;
      this.btnSiguiente.Visible = false;
      // 
      // btnAnterior
      // 
      this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAnterior.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAnterior.ForeColor = System.Drawing.Color.Purple;
      this.btnAnterior.Location = new System.Drawing.Point(647, 217);
      this.btnAnterior.Name = "btnAnterior";
      this.btnAnterior.Size = new System.Drawing.Size(70, 62);
      this.btnAnterior.TabIndex = 24;
      this.btnAnterior.Text = "<";
      this.btnAnterior.UseVisualStyleBackColor = true;
      this.btnAnterior.UseWaitCursor = true;
      this.btnAnterior.Visible = false;
      // 
      // PbVisualizadorImg
      // 
      this.PbVisualizadorImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PbVisualizadorImg.Location = new System.Drawing.Point(597, 49);
      this.PbVisualizadorImg.Name = "PbVisualizadorImg";
      this.PbVisualizadorImg.Size = new System.Drawing.Size(238, 162);
      this.PbVisualizadorImg.TabIndex = 23;
      this.PbVisualizadorImg.TabStop = false;
      this.PbVisualizadorImg.Click += new System.EventHandler(this.PbVisualizadorImg_Click);
      this.PbVisualizadorImg.DoubleClick += new System.EventHandler(this.PbVisualizadorImg_DoubleClick);
      // 
      // RtbVisualizadorTex
      // 
      this.RtbVisualizadorTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.RtbVisualizadorTex.BackColor = System.Drawing.Color.Black;
      this.RtbVisualizadorTex.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.RtbVisualizadorTex.ForeColor = System.Drawing.Color.White;
      this.RtbVisualizadorTex.Location = new System.Drawing.Point(384, 49);
      this.RtbVisualizadorTex.Name = "RtbVisualizadorTex";
      this.RtbVisualizadorTex.Size = new System.Drawing.Size(451, 274);
      this.RtbVisualizadorTex.TabIndex = 22;
      this.RtbVisualizadorTex.Text = "";
      // 
      // treeView1
      // 
      this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.treeView1.BackColor = System.Drawing.Color.Black;
      this.treeView1.ForeColor = System.Drawing.Color.IndianRed;
      this.treeView1.Location = new System.Drawing.Point(1, 48);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(130, 416);
      this.treeView1.TabIndex = 21;
      // 
      // BtnRuta
      // 
      this.BtnRuta.BackColor = System.Drawing.Color.IndianRed;
      this.BtnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnRuta.ForeColor = System.Drawing.Color.Black;
      this.BtnRuta.Location = new System.Drawing.Point(9, 23);
      this.BtnRuta.Name = "BtnRuta";
      this.BtnRuta.Size = new System.Drawing.Size(106, 22);
      this.BtnRuta.TabIndex = 20;
      this.BtnRuta.Text = "Seleccionar ruta";
      this.BtnRuta.UseVisualStyleBackColor = false;
      this.BtnRuta.Click += new System.EventHandler(this.BtnRuta_Click);
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.ForeColor = System.Drawing.Color.Purple;
      this.textBox1.Location = new System.Drawing.Point(128, 28);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(672, 13);
      this.textBox1.TabIndex = 19;
      // 
      // LbCopiar
      // 
      this.LbCopiar.AutoSize = true;
      this.LbCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LbCopiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.LbCopiar.Location = new System.Drawing.Point(449, 421);
      this.LbCopiar.Name = "LbCopiar";
      this.LbCopiar.Size = new System.Drawing.Size(135, 20);
      this.LbCopiar.TabIndex = 34;
      this.LbCopiar.Text = "Organizar (copiar)";
      this.LbCopiar.Visible = false;
      // 
      // lbMover
      // 
      this.lbMover.AutoSize = true;
      this.lbMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbMover.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.lbMover.Location = new System.Drawing.Point(665, 421);
      this.lbMover.Name = "lbMover";
      this.lbMover.Size = new System.Drawing.Size(135, 20);
      this.lbMover.TabIndex = 33;
      this.lbMover.Text = "Organizar (mover)";
      this.lbMover.Visible = false;
      // 
      // pbMover
      // 
      this.pbMover.Image = ((System.Drawing.Image)(resources.GetObject("pbMover.Image")));
      this.pbMover.Location = new System.Drawing.Point(740, 372);
      this.pbMover.Name = "pbMover";
      this.pbMover.Size = new System.Drawing.Size(48, 46);
      this.pbMover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbMover.TabIndex = 32;
      this.pbMover.TabStop = false;
      this.pbMover.Visible = false;
      this.pbMover.Click += new System.EventHandler(this.pbMover_Click);
      // 
      // pbCopiar
      // 
      this.pbCopiar.Image = ((System.Drawing.Image)(resources.GetObject("pbCopiar.Image")));
      this.pbCopiar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCopiar.InitialImage")));
      this.pbCopiar.Location = new System.Drawing.Point(505, 372);
      this.pbCopiar.Name = "pbCopiar";
      this.pbCopiar.Size = new System.Drawing.Size(48, 46);
      this.pbCopiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbCopiar.TabIndex = 31;
      this.pbCopiar.TabStop = false;
      this.pbCopiar.Visible = false;
      this.pbCopiar.Click += new System.EventHandler(this.pbCopiar_Click);
      // 
      // btnFrmEditor
      // 
      this.btnFrmEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnFrmEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnFrmEditor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFrmEditor.ForeColor = System.Drawing.Color.Purple;
      this.btnFrmEditor.Location = new System.Drawing.Point(622, 285);
      this.btnFrmEditor.Name = "btnFrmEditor";
      this.btnFrmEditor.Size = new System.Drawing.Size(202, 38);
      this.btnFrmEditor.TabIndex = 36;
      this.btnFrmEditor.Text = "Abrir editor de imagenes";
      this.btnFrmEditor.UseVisualStyleBackColor = true;
      this.btnFrmEditor.UseWaitCursor = true;
      this.btnFrmEditor.Visible = false;
      this.btnFrmEditor.Click += new System.EventHandler(this.btnFrmEditor_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCerrar.ForeColor = System.Drawing.Color.Red;
      this.btnCerrar.Location = new System.Drawing.Point(798, -1);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(37, 37);
      this.btnCerrar.TabIndex = 37;
      this.btnCerrar.Text = "X";
      this.btnCerrar.UseVisualStyleBackColor = true;
      this.btnCerrar.UseWaitCursor = true;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // frmOrdenadorArchivos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(836, 450);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.btnFrmEditor);
      this.Controls.Add(this.LbCopiar);
      this.Controls.Add(this.lbMover);
      this.Controls.Add(this.pbMover);
      this.Controls.Add(this.pbCopiar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSiguiente);
      this.Controls.Add(this.btnAnterior);
      this.Controls.Add(this.PbVisualizadorImg);
      this.Controls.Add(this.RtbVisualizadorTex);
      this.Controls.Add(this.treeView1);
      this.Controls.Add(this.BtnRuta);
      this.Controls.Add(this.textBox1);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmOrdenadorArchivos";
      this.Text = "frmOrdenadorArchivos";
      ((System.ComponentModel.ISupportInitialize)(this.PbVisualizadorImg)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbMover)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCopiar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSiguiente;
    private System.Windows.Forms.Button btnAnterior;
    private System.Windows.Forms.PictureBox PbVisualizadorImg;
    private System.Windows.Forms.RichTextBox RtbVisualizadorTex;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Button BtnRuta;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label LbCopiar;
    private System.Windows.Forms.Label lbMover;
    private System.Windows.Forms.PictureBox pbMover;
    private System.Windows.Forms.PictureBox pbCopiar;
    private System.Windows.Forms.Button btnFrmEditor;
    private System.Windows.Forms.Button btnCerrar;
  }
}