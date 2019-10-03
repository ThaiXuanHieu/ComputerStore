namespace GUI
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.Slideshow = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Slideshow)).BeginInit();
            this.SuspendLayout();
            // 
            // Slideshow
            // 
            this.Slideshow.Image = ((System.Drawing.Image)(resources.GetObject("Slideshow.Image")));
            this.Slideshow.Location = new System.Drawing.Point(20, 134);
            this.Slideshow.Name = "Slideshow";
            this.Slideshow.Size = new System.Drawing.Size(980, 410);
            this.Slideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slideshow.TabIndex = 0;
            this.Slideshow.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Slideshow);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slideshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Slideshow;
        private System.Windows.Forms.Timer Timer;
    }
}
