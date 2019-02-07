namespace Historia
{
    partial class historia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historia));
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnSalirHistoria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Plum;
            this.btnA.Location = new System.Drawing.Point(12, 239);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(180, 60);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A)";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Plum;
            this.btnB.Location = new System.Drawing.Point(198, 239);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(180, 60);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "B)";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Plum;
            this.btnC.Location = new System.Drawing.Point(386, 239);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(180, 60);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C)";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Plum;
            this.btnD.Location = new System.Drawing.Point(572, 239);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(180, 60);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "D)";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(12, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(58, 25);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "texto";
            // 
            // btnSalirHistoria
            // 
            this.btnSalirHistoria.BackColor = System.Drawing.Color.Magenta;
            this.btnSalirHistoria.Location = new System.Drawing.Point(810, 219);
            this.btnSalirHistoria.Name = "btnSalirHistoria";
            this.btnSalirHistoria.Size = new System.Drawing.Size(80, 80);
            this.btnSalirHistoria.TabIndex = 5;
            this.btnSalirHistoria.Text = "SALIR";
            this.btnSalirHistoria.UseVisualStyleBackColor = false;
            this.btnSalirHistoria.Click += new System.EventHandler(this.btnSalirHistoria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 53);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(914, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirHistoria);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(930, 350);
            this.MinimumSize = new System.Drawing.Size(930, 350);
            this.Name = "historia";
            this.Text = "Historia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnSalirHistoria;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}