namespace OyunProjesi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ButtonTas;
        private System.Windows.Forms.Button ButtonKagit;
        private System.Windows.Forms.Button ButtonMakas;
        private System.Windows.Forms.Label labelOyuncuSkor;
        private System.Windows.Forms.Label labelBilgisayarSkor;
        private System.Windows.Forms.PictureBox pictureBoxOyuncu;
        private System.Windows.Forms.PictureBox pictureBoxBilgisayar;

        private void InitializeComponent()
        {
            this.ButtonTas = new System.Windows.Forms.Button();
            this.ButtonKagit = new System.Windows.Forms.Button();
            this.ButtonMakas = new System.Windows.Forms.Button();
            this.labelOyuncuSkor = new System.Windows.Forms.Label();
            this.labelBilgisayarSkor = new System.Windows.Forms.Label();
            this.pictureBoxOyuncu = new System.Windows.Forms.PictureBox();
            this.pictureBoxBilgisayar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBilgisayar)).BeginInit();
            this.SuspendLayout();

            this.ButtonTas.Location = new System.Drawing.Point(12, 12);
            this.ButtonTas.Name = "ButtonTas";
            this.ButtonTas.Size = new System.Drawing.Size(100, 30);
            this.ButtonTas.TabIndex = 0;
            this.ButtonTas.Text = "Taş";
            this.ButtonTas.UseVisualStyleBackColor = true;
            this.ButtonTas.Click += new System.EventHandler(this.ButtonTas_Click);

            this.ButtonKagit.Location = new System.Drawing.Point(120, 12);
            this.ButtonKagit.Name = "ButtonKagit";
            this.ButtonKagit.Size = new System.Drawing.Size(100, 30);
            this.ButtonKagit.TabIndex = 1;
            this.ButtonKagit.Text = "Kağıt";
            this.ButtonKagit.UseVisualStyleBackColor = true;
            this.ButtonKagit.Click += new System.EventHandler(this.ButtonKagit_Click);

            this.ButtonMakas.Location = new System.Drawing.Point(230, 12);
            this.ButtonMakas.Name = "ButtonMakas";
            this.ButtonMakas.Size = new System.Drawing.Size(100, 30);
            this.ButtonMakas.TabIndex = 2;
            this.ButtonMakas.Text = "Makas";
            this.ButtonMakas.UseVisualStyleBackColor = true;
            this.ButtonMakas.Click += new System.EventHandler(this.ButtonMakas_Click);

            this.labelOyuncuSkor.AutoSize = true;
            this.labelOyuncuSkor.Location = new System.Drawing.Point(12, 198);
            this.labelOyuncuSkor.Name = "labelOyuncuSkor";
            this.labelOyuncuSkor.Size = new System.Drawing.Size(96, 16);
            this.labelOyuncuSkor.TabIndex = 3;
            this.labelOyuncuSkor.Text = "Oyuncu Skor: 0";

            this.labelBilgisayarSkor.AutoSize = true;
            this.labelBilgisayarSkor.Location = new System.Drawing.Point(261, 198);
            this.labelBilgisayarSkor.Name = "labelBilgisayarSkor";
            this.labelBilgisayarSkor.Size = new System.Drawing.Size(111, 16);
            this.labelBilgisayarSkor.TabIndex = 4;
            this.labelBilgisayarSkor.Text = "Bilgisayar Skor: 0";

            this.pictureBoxOyuncu.Location = new System.Drawing.Point(12, 80);
            this.pictureBoxOyuncu.Name = "pictureBoxOyuncu";
            this.pictureBoxOyuncu.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxOyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOyuncu.TabIndex = 5;
            this.pictureBoxOyuncu.TabStop = false;

            this.pictureBoxBilgisayar.Location = new System.Drawing.Point(272, 80);
            this.pictureBoxBilgisayar.Name = "pictureBoxBilgisayar";
            this.pictureBoxBilgisayar.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBilgisayar.TabIndex = 6;
            this.pictureBoxBilgisayar.TabStop = false;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senin Seçimin";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bilgisayarın Seçimi";

            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonTas);
            this.Controls.Add(this.ButtonKagit);
            this.Controls.Add(this.ButtonMakas);
            this.Controls.Add(this.labelOyuncuSkor);
            this.Controls.Add(this.labelBilgisayarSkor);
            this.Controls.Add(this.pictureBoxOyuncu);
            this.Controls.Add(this.pictureBoxBilgisayar);
            this.Name = "Form1";
            this.Text = "Taş Kağıt Makas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBilgisayar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
