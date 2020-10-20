namespace BilboMetropolikoKutxa
{
    partial class Hasiera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasiera));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zureIzena = new System.Windows.Forms.TextBox();
            this.maileguEskaintza = new System.Windows.Forms.Button();
            this.Irten = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilbo Metropoliko Kutxa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zure izena:";
            // 
            // zureIzena
            // 
            this.zureIzena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zureIzena.Location = new System.Drawing.Point(369, 173);
            this.zureIzena.Name = "zureIzena";
            this.zureIzena.Size = new System.Drawing.Size(149, 26);
            this.zureIzena.TabIndex = 3;
            this.zureIzena.Text = "\r\n";
            this.zureIzena.TextChanged += new System.EventHandler(this.zureIzena_TextChanged);
            // 
            // maileguEskaintza
            // 
            this.maileguEskaintza.BackColor = System.Drawing.Color.Black;
            this.maileguEskaintza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maileguEskaintza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maileguEskaintza.Location = new System.Drawing.Point(306, 228);
            this.maileguEskaintza.Name = "maileguEskaintza";
            this.maileguEskaintza.Size = new System.Drawing.Size(155, 51);
            this.maileguEskaintza.TabIndex = 4;
            this.maileguEskaintza.Text = "Mailegu Eskaintza";
            this.maileguEskaintza.UseVisualStyleBackColor = false;
            this.maileguEskaintza.Click += new System.EventHandler(this.maileguEskaintza_Click_1);
            // 
            // Irten
            // 
            this.Irten.BackColor = System.Drawing.Color.Red;
            this.Irten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Irten.ForeColor = System.Drawing.Color.Black;
            this.Irten.Location = new System.Drawing.Point(666, 380);
            this.Irten.Name = "Irten";
            this.Irten.Size = new System.Drawing.Size(91, 47);
            this.Irten.TabIndex = 5;
            this.Irten.Text = "Irten";
            this.Irten.UseVisualStyleBackColor = false;
            this.Irten.Click += new System.EventHandler(this.Irten_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Hasiera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.Irten);
            this.Controls.Add(this.maileguEskaintza);
            this.Controls.Add(this.zureIzena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hasiera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilbo Metropoliko Kutxa";
            this.Load += new System.EventHandler(this.Hasiera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zureIzena;
        private System.Windows.Forms.Button maileguEskaintza;
        private System.Windows.Forms.Button Irten;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

