namespace AppProyecto
{
  partial class lectorex
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
      this.txtFilename = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.cboSheet = new System.Windows.Forms.ComboBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtFilename
      // 
      this.txtFilename.AutoSize = true;
      this.txtFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.txtFilename.Location = new System.Drawing.Point(21, 333);
      this.txtFilename.Name = "txtFilename";
      this.txtFilename.Size = new System.Drawing.Size(48, 24);
      this.txtFilename.TabIndex = 0;
      this.txtFilename.Text = "Ruta";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(146, 23);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(573, 278);
      this.dataGridView1.TabIndex = 1;
      // 
      // btnBrowse
      // 
      this.btnBrowse.Location = new System.Drawing.Point(603, 375);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(46, 23);
      this.btnBrowse.TabIndex = 2;
      this.btnBrowse.Text = "...";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // cboSheet
      // 
      this.cboSheet.FormattingEnabled = true;
      this.cboSheet.Location = new System.Drawing.Point(100, 417);
      this.cboSheet.Name = "cboSheet";
      this.cboSheet.Size = new System.Drawing.Size(211, 21);
      this.cboSheet.TabIndex = 3;
      this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged_1);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(89, 375);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(473, 20);
      this.textBox1.TabIndex = 4;
      // 
      // button1
      // 
      this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Red;
      this.button1.Location = new System.Drawing.Point(761, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(37, 37);
      this.button1.TabIndex = 38;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.UseWaitCursor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // lectorex
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.cboSheet);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.txtFilename);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "lectorex";
      this.Text = "lectorex";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label txtFilename;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.ComboBox cboSheet;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
  }
}