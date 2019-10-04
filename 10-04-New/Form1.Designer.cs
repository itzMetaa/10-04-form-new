namespace _10_04_New
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_main = new System.Windows.Forms.Button();
            this.label_kiir = new System.Windows.Forms.Label();
            this.text_szoveg = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_main
            // 
            this.button_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_main.BackgroundImage")));
            this.button_main.Location = new System.Drawing.Point(78, 88);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(124, 30);
            this.button_main.TabIndex = 1;
            this.button_main.Text = "Gmoob";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_kiir
            // 
            this.label_kiir.AutoSize = true;
            this.label_kiir.BackColor = System.Drawing.Color.SlateBlue;
            this.label_kiir.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kiir.Location = new System.Drawing.Point(12, 121);
            this.label_kiir.Name = "label_kiir";
            this.label_kiir.Size = new System.Drawing.Size(140, 17);
            this.label_kiir.TabIndex = 2;
            this.label_kiir.Text = "Sample txext";
            this.label_kiir.Click += new System.EventHandler(this.rich);
            // 
            // text_szoveg
            // 
            this.text_szoveg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.text_szoveg.Location = new System.Drawing.Point(33, 12);
            this.text_szoveg.Name = "text_szoveg";
            this.text_szoveg.Size = new System.Drawing.Size(100, 86);
            this.text_szoveg.TabIndex = 3;
            this.text_szoveg.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 167);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(445, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(569, 191);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_szoveg);
            this.Controls.Add(this.label_kiir);
            this.Controls.Add(this.button_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Label label_kiir;
        private System.Windows.Forms.RichTextBox text_szoveg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

