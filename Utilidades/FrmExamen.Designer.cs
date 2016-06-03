namespace Utilidades
{
    partial class FrmExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamen));
            this.label1 = new System.Windows.Forms.Label();
            this.lblpregunta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbresp4 = new System.Windows.Forms.RadioButton();
            this.rbresp3 = new System.Windows.Forms.RadioButton();
            this.rbresp2 = new System.Windows.Forms.RadioButton();
            this.rbresp1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblprueba = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Examen";
            // 
            // lblpregunta
            // 
            this.lblpregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregunta.Location = new System.Drawing.Point(12, 93);
            this.lblpregunta.Name = "lblpregunta";
            this.lblpregunta.Size = new System.Drawing.Size(735, 187);
            this.lblpregunta.TabIndex = 20;
            this.lblpregunta.Text = resources.GetString("lblpregunta.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pregunta #";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbresp4);
            this.groupBox1.Controls.Add(this.rbresp3);
            this.groupBox1.Controls.Add(this.rbresp2);
            this.groupBox1.Controls.Add(this.rbresp1);
            this.groupBox1.Location = new System.Drawing.Point(31, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 243);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respuestas";
            // 
            // rbresp4
            // 
            this.rbresp4.AutoSize = true;
            this.rbresp4.Location = new System.Drawing.Point(17, 195);
            this.rbresp4.Name = "rbresp4";
            this.rbresp4.Size = new System.Drawing.Size(403, 17);
            this.rbresp4.TabIndex = 3;
            this.rbresp4.TabStop = true;
            this.rbresp4.Text = "Donec eget aliquam augue. Nullam suscipit quam ante, at fringilla nulla mollis ac" +
                ".";
            this.rbresp4.UseVisualStyleBackColor = true;
            this.rbresp4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbresp3
            // 
            this.rbresp3.AutoSize = true;
            this.rbresp3.Location = new System.Drawing.Point(17, 143);
            this.rbresp3.Name = "rbresp3";
            this.rbresp3.Size = new System.Drawing.Size(403, 17);
            this.rbresp3.TabIndex = 2;
            this.rbresp3.TabStop = true;
            this.rbresp3.Text = "Donec eget aliquam augue. Nullam suscipit quam ante, at fringilla nulla mollis ac" +
                ".";
            this.rbresp3.UseVisualStyleBackColor = true;
            // 
            // rbresp2
            // 
            this.rbresp2.AutoSize = true;
            this.rbresp2.Location = new System.Drawing.Point(17, 97);
            this.rbresp2.Name = "rbresp2";
            this.rbresp2.Size = new System.Drawing.Size(403, 17);
            this.rbresp2.TabIndex = 1;
            this.rbresp2.TabStop = true;
            this.rbresp2.Text = "Donec eget aliquam augue. Nullam suscipit quam ante, at fringilla nulla mollis ac" +
                ".";
            this.rbresp2.UseVisualStyleBackColor = true;
            // 
            // rbresp1
            // 
            this.rbresp1.AutoSize = true;
            this.rbresp1.Location = new System.Drawing.Point(17, 48);
            this.rbresp1.Name = "rbresp1";
            this.rbresp1.Size = new System.Drawing.Size(403, 17);
            this.rbresp1.TabIndex = 0;
            this.rbresp1.TabStop = true;
            this.rbresp1.Text = "Donec eget aliquam augue. Nullam suscipit quam ante, at fringilla nulla mollis ac" +
                ".";
            this.rbresp1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(105, 557);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 108);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.Location = new System.Drawing.Point(65, 25);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(50, 13);
            this.lblprueba.TabIndex = 24;
            this.lblprueba.Text = "lblprueba";
            // 
            // FrmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 718);
            this.Controls.Add(this.lblprueba);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpregunta);
            this.Controls.Add(this.label1);
            this.Name = "FrmExamen";
            this.Text = "FrmExamen";
            this.Load += new System.EventHandler(this.FrmExamen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbresp4;
        private System.Windows.Forms.RadioButton rbresp3;
        private System.Windows.Forms.RadioButton rbresp2;
        private System.Windows.Forms.RadioButton rbresp1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblprueba;
    }
}