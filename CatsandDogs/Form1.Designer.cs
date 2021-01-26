namespace CatsandDogs
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
            this.dogPicture = new System.Windows.Forms.PictureBox();
            this.getDog = new System.Windows.Forms.Button();
            this.catPicture = new System.Windows.Forms.PictureBox();
            this.GettheCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPicture
            // 
            this.dogPicture.Location = new System.Drawing.Point(1070, 140);
            this.dogPicture.Name = "dogPicture";
            this.dogPicture.Size = new System.Drawing.Size(422, 481);
            this.dogPicture.TabIndex = 0;
            this.dogPicture.TabStop = false;
            this.dogPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // getDog
            // 
            this.getDog.Location = new System.Drawing.Point(1252, 661);
            this.getDog.Name = "getDog";
            this.getDog.Size = new System.Drawing.Size(92, 23);
            this.getDog.TabIndex = 1;
            this.getDog.Text = "getDog immage";
            this.getDog.UseVisualStyleBackColor = true;
            this.getDog.Click += new System.EventHandler(this.getDog_Click);
            // 
            // catPicture
            // 
            this.catPicture.Location = new System.Drawing.Point(375, 140);
            this.catPicture.Name = "catPicture";
            this.catPicture.Size = new System.Drawing.Size(420, 481);
            this.catPicture.TabIndex = 2;
            this.catPicture.TabStop = false;
            // 
            // GettheCat
            // 
            this.GettheCat.Location = new System.Drawing.Point(512, 661);
            this.GettheCat.Name = "GettheCat";
            this.GettheCat.Size = new System.Drawing.Size(113, 23);
            this.GettheCat.TabIndex = 3;
            this.GettheCat.Text = "GettheCat";
            this.GettheCat.UseVisualStyleBackColor = true;
            this.GettheCat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 858);
            this.Controls.Add(this.GettheCat);
            this.Controls.Add(this.catPicture);
            this.Controls.Add(this.getDog);
            this.Controls.Add(this.dogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogPicture;
        private System.Windows.Forms.Button getDog;
        private System.Windows.Forms.PictureBox catPicture;
        private System.Windows.Forms.Button GettheCat;
    }
}

