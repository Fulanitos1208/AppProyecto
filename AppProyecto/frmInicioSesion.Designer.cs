namespace AppProyecto
{
  partial class frmInicioSesion
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
      this.btnInicioSesion = new System.Windows.Forms.Button();
      this.txtContraseña = new System.Windows.Forms.TextBox();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.lbContraseña = new System.Windows.Forms.Label();
      this.lbUsuario = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnCerrar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnInicioSesion
      // 
      this.btnInicioSesion.BackColor = System.Drawing.Color.Transparent;
      this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnInicioSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.btnInicioSesion.Location = new System.Drawing.Point(336, 231);
      this.btnInicioSesion.Name = "btnInicioSesion";
      this.btnInicioSesion.Size = new System.Drawing.Size(209, 30);
      this.btnInicioSesion.TabIndex = 11;
      this.btnInicioSesion.Text = "Iniciar Sesión";
      this.btnInicioSesion.UseVisualStyleBackColor = false;
      this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click_1);
      // 
      // txtContraseña
      // 
      this.txtContraseña.BackColor = System.Drawing.Color.Black;
      this.txtContraseña.ForeColor = System.Drawing.Color.White;
      this.txtContraseña.Location = new System.Drawing.Point(420, 196);
      this.txtContraseña.Name = "txtContraseña";
      this.txtContraseña.PasswordChar = '*';
      this.txtContraseña.Size = new System.Drawing.Size(125, 20);
      this.txtContraseña.TabIndex = 10;
      // 
      // txtUsuario
      // 
      this.txtUsuario.BackColor = System.Drawing.Color.Black;
      this.txtUsuario.ForeColor = System.Drawing.Color.White;
      this.txtUsuario.Location = new System.Drawing.Point(420, 170);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(125, 20);
      this.txtUsuario.TabIndex = 9;
      // 
      // lbContraseña
      // 
      this.lbContraseña.AutoSize = true;
      this.lbContraseña.ForeColor = System.Drawing.Color.Purple;
      this.lbContraseña.Location = new System.Drawing.Point(333, 203);
      this.lbContraseña.Name = "lbContraseña";
      this.lbContraseña.Size = new System.Drawing.Size(61, 13);
      this.lbContraseña.TabIndex = 8;
      this.lbContraseña.Text = "Contraseña";
      // 
      // lbUsuario
      // 
      this.lbUsuario.AutoSize = true;
      this.lbUsuario.ForeColor = System.Drawing.Color.Purple;
      this.lbUsuario.Location = new System.Drawing.Point(333, 173);
      this.lbUsuario.Name = "lbUsuario";
      this.lbUsuario.Size = new System.Drawing.Size(43, 13);
      this.lbUsuario.TabIndex = 7;
      this.lbUsuario.Text = "Usuario";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(402, 69);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 83);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 12;
      this.pictureBox1.TabStop = false;
      // 
      // btnCerrar
      // 
      this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
      this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCerrar.ForeColor = System.Drawing.Color.Red;
      this.btnCerrar.Location = new System.Drawing.Point(628, 27);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(34, 34);
      this.btnCerrar.TabIndex = 21;
      this.btnCerrar.Text = "X";
      this.btnCerrar.UseVisualStyleBackColor = false;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // frmInicioSesion
      // 
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(899, 469);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.btnInicioSesion);
      this.Controls.Add(this.txtContraseña);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.lbContraseña);
      this.Controls.Add(this.lbUsuario);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmInicioSesion";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnInicioSesion;
    private System.Windows.Forms.TextBox txtContraseña;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label lbContraseña;
    private System.Windows.Forms.Label lbUsuario;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnCerrar;
  }
}

