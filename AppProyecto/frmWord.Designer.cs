namespace AppProyecto
{
  partial class frmWord
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
      this.btnAbrir = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.RtWord = new System.Windows.Forms.RichTextBox();
      this.BtnCerrar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnAbrir
      // 
      this.btnAbrir.BackColor = System.Drawing.Color.IndianRed;
      this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAbrir.Location = new System.Drawing.Point(725, 57);
      this.btnAbrir.Name = "btnAbrir";
      this.btnAbrir.Size = new System.Drawing.Size(75, 23);
      this.btnAbrir.TabIndex = 0;
      this.btnAbrir.Text = "Abrir";
      this.btnAbrir.UseVisualStyleBackColor = false;
      this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.BackColor = System.Drawing.Color.Black;
      this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuardar.ForeColor = System.Drawing.Color.White;
      this.btnGuardar.Location = new System.Drawing.Point(725, 86);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(75, 23);
      this.btnGuardar.TabIndex = 1;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // RtWord
      // 
      this.RtWord.Location = new System.Drawing.Point(12, 12);
      this.RtWord.Name = "RtWord";
      this.RtWord.Size = new System.Drawing.Size(707, 383);
      this.RtWord.TabIndex = 3;
      this.RtWord.Text = "";
      this.RtWord.Visible = false;
      // 
      // BtnCerrar
      // 
      this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnCerrar.ForeColor = System.Drawing.Color.Red;
      this.BtnCerrar.Location = new System.Drawing.Point(765, -1);
      this.BtnCerrar.Name = "BtnCerrar";
      this.BtnCerrar.Size = new System.Drawing.Size(35, 35);
      this.BtnCerrar.TabIndex = 4;
      this.BtnCerrar.Text = "X";
      this.BtnCerrar.UseVisualStyleBackColor = true;
      this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
      // 
      // frmWord
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnCerrar);
      this.Controls.Add(this.RtWord);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.btnAbrir);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmWord";
      this.Text = "frmWord";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAbrir;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.RichTextBox RtWord;
    private System.Windows.Forms.Button BtnCerrar;
  }
}