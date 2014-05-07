namespace Google_Maps
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
            this.btnstaticmap = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.btnstreetview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstaticmap
            // 
            this.btnstaticmap.Location = new System.Drawing.Point(13, 54);
            this.btnstaticmap.Name = "btnstaticmap";
            this.btnstaticmap.Size = new System.Drawing.Size(75, 23);
            this.btnstaticmap.TabIndex = 0;
            this.btnstaticmap.Text = "Static Map";
            this.btnstaticmap.UseVisualStyleBackColor = true;
            this.btnstaticmap.Click += new System.EventHandler(this.btnstaticmap_Click);
            // 
            // textbox1
            // 
            this.textbox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox1.Location = new System.Drawing.Point(13, 28);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(193, 20);
            this.textbox1.TabIndex = 1;
            this.textbox1.TabStop = false;
            this.textbox1.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 226);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(328, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 226);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textbox2
            // 
            this.textbox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox2.Location = new System.Drawing.Point(230, 27);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(188, 20);
            this.textbox2.TabIndex = 6;
            // 
            // btnstreetview
            // 
            this.btnstreetview.Location = new System.Drawing.Point(94, 54);
            this.btnstreetview.Name = "btnstreetview";
            this.btnstreetview.Size = new System.Drawing.Size(75, 23);
            this.btnstreetview.TabIndex = 7;
            this.btnstreetview.Text = "Street View";
            this.btnstreetview.UseVisualStyleBackColor = true;
            this.btnstreetview.Visible = false;
            this.btnstreetview.Click += new System.EventHandler(this.btnstreetview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Street Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "City/State";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(274, 83);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 13;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 225);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 13;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(606, 336);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstreetview);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.btnstaticmap);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstaticmap;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Button btnstreetview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

