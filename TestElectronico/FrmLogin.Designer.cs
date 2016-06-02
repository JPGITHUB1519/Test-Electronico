namespace TestElectronico
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cerrar_user = new System.Windows.Forms.Button();
            this.btn_cancelar_user = new System.Windows.Forms.Button();
            this.btnaceptar_user = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontraseña = new Utilidades.textbox(this.components);
            this.txtusuario = new Utilidades.textbox(this.components);
            this.txtmatricula = new Utilidades.textbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btncerrarstudent = new System.Windows.Forms.Button();
            this.btncancelarstudent = new System.Windows.Forms.Button();
            this.btnaceptarstudent = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(38, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 438);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btncerrarstudent);
            this.tabPage1.Controls.Add(this.btncancelarstudent);
            this.tabPage1.Controls.Add(this.btnaceptarstudent);
            this.tabPage1.Controls.Add(this.txtmatricula);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estudiantes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cerrar_user);
            this.tabPage2.Controls.Add(this.txtcontraseña);
            this.tabPage2.Controls.Add(this.txtusuario);
            this.tabPage2.Controls.Add(this.btn_cancelar_user);
            this.tabPage2.Controls.Add(this.btnaceptar_user);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuario Administrador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar_user
            // 
            this.btn_cerrar_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_user.Image")));
            this.btn_cerrar_user.Location = new System.Drawing.Point(353, 229);
            this.btn_cerrar_user.Name = "btn_cerrar_user";
            this.btn_cerrar_user.Size = new System.Drawing.Size(110, 86);
            this.btn_cerrar_user.TabIndex = 16;
            this.btn_cerrar_user.Text = "Cerrar";
            this.btn_cerrar_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cerrar_user.UseVisualStyleBackColor = true;
            this.btn_cerrar_user.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_cancelar_user
            // 
            this.btn_cancelar_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar_user.Image")));
            this.btn_cancelar_user.Location = new System.Drawing.Point(219, 229);
            this.btn_cancelar_user.Name = "btn_cancelar_user";
            this.btn_cancelar_user.Size = new System.Drawing.Size(110, 86);
            this.btn_cancelar_user.TabIndex = 13;
            this.btn_cancelar_user.Text = "Cancelar";
            this.btn_cancelar_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar_user.UseVisualStyleBackColor = true;
            this.btn_cancelar_user.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnaceptar_user
            // 
            this.btnaceptar_user.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar_user.Image")));
            this.btnaceptar_user.Location = new System.Drawing.Point(85, 229);
            this.btnaceptar_user.Name = "btnaceptar_user";
            this.btnaceptar_user.Size = new System.Drawing.Size(110, 86);
            this.btnaceptar_user.TabIndex = 12;
            this.btnaceptar_user.Text = "Aceptar";
            this.btnaceptar_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnaceptar_user.UseVisualStyleBackColor = true;
            this.btnaceptar_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(275, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Log-In";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(342, 157);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '•';
            this.txtcontraseña.Size = new System.Drawing.Size(176, 20);
            this.txtcontraseña.TabIndex = 15;
            this.txtcontraseña.validar = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(342, 70);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(176, 20);
            this.txtusuario.TabIndex = 14;
            this.txtusuario.validar = false;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(207, 71);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(176, 20);
            this.txtmatricula.TabIndex = 18;
            this.txtmatricula.validar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Matricula";
            // 
            // btncerrarstudent
            // 
            this.btncerrarstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrarstudent.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarstudent.Image")));
            this.btncerrarstudent.Location = new System.Drawing.Point(328, 200);
            this.btncerrarstudent.Name = "btncerrarstudent";
            this.btncerrarstudent.Size = new System.Drawing.Size(110, 86);
            this.btncerrarstudent.TabIndex = 21;
            this.btncerrarstudent.Text = "Cerrar";
            this.btncerrarstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncerrarstudent.UseVisualStyleBackColor = true;
            // 
            // btncancelarstudent
            // 
            this.btncancelarstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelarstudent.Image = ((System.Drawing.Image)(resources.GetObject("btncancelarstudent.Image")));
            this.btncancelarstudent.Location = new System.Drawing.Point(194, 200);
            this.btncancelarstudent.Name = "btncancelarstudent";
            this.btncancelarstudent.Size = new System.Drawing.Size(110, 86);
            this.btncancelarstudent.TabIndex = 20;
            this.btncancelarstudent.Text = "Cancelar";
            this.btncancelarstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncancelarstudent.UseVisualStyleBackColor = true;
            // 
            // btnaceptarstudent
            // 
            this.btnaceptarstudent.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptarstudent.Image")));
            this.btnaceptarstudent.Location = new System.Drawing.Point(60, 200);
            this.btnaceptarstudent.Name = "btnaceptarstudent";
            this.btnaceptarstudent.Size = new System.Drawing.Size(110, 86);
            this.btnaceptarstudent.TabIndex = 19;
            this.btnaceptarstudent.Text = "Aceptar";
            this.btnaceptarstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnaceptarstudent.UseVisualStyleBackColor = true;
            this.btnaceptarstudent.Click += new System.EventHandler(this.btnaceptarstudent_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 574);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_cerrar_user;
        private Utilidades.textbox txtcontraseña;
        private Utilidades.textbox txtusuario;
        private System.Windows.Forms.Button btn_cancelar_user;
        private System.Windows.Forms.Button btnaceptar_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Utilidades.textbox txtmatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncerrarstudent;
        private System.Windows.Forms.Button btncancelarstudent;
        private System.Windows.Forms.Button btnaceptarstudent;
    }
}