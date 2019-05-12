namespace MainPaint
{
    partial class FormA2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA2));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cut = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circl = new System.Windows.Forms.Button();
            this.linne = new System.Windows.Forms.Button();
            this.trian = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(482, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 16;
            this.button4.Text = "open";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = global::MainPaint.Properties.Resources.grey_780x400;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(420, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Width:";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.Silver;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Image = global::MainPaint.Properties.Resources.Brush_icon;
            this.checkBox2.Location = new System.Drawing.Point(634, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 65);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.Silver;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Image = global::MainPaint.Properties.Resources.Pencil_icon;
            this.checkBox1.Location = new System.Drawing.Point(559, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 65);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // cut
            // 
            this.cut.BackColor = System.Drawing.Color.Silver;
            this.cut.FlatAppearance.BorderSize = 0;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.Image = global::MainPaint.Properties.Resources.cut_icon;
            this.cut.Location = new System.Drawing.Point(804, 5);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(75, 66);
            this.cut.TabIndex = 12;
            this.cut.UseVisualStyleBackColor = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // crop
            // 
            this.crop.BackColor = System.Drawing.Color.Silver;
            this.crop.FlatAppearance.BorderSize = 0;
            this.crop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crop.Image = global::MainPaint.Properties.Resources.Very_Basic_Copy_Filled_icon;
            this.crop.Location = new System.Drawing.Point(885, 5);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(75, 66);
            this.crop.TabIndex = 11;
            this.crop.UseVisualStyleBackColor = false;
            this.crop.Click += new System.EventHandler(this.crop_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::MainPaint.Properties.Resources.bin_black_full_icon;
            this.button2.Location = new System.Drawing.Point(12, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 65);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MainPaint.Properties.Resources.Color_Meter_icon;
            this.button1.Location = new System.Drawing.Point(707, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 65);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(262, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 271);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(597, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(104, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 413);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // circl
            // 
            this.circl.BackColor = System.Drawing.Color.Silver;
            this.circl.FlatAppearance.BorderSize = 0;
            this.circl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circl.Image = global::MainPaint.Properties.Resources.Arrow_Circle_icon;
            this.circl.Location = new System.Drawing.Point(267, 5);
            this.circl.Name = "circl";
            this.circl.Size = new System.Drawing.Size(65, 65);
            this.circl.TabIndex = 4;
            this.circl.UseVisualStyleBackColor = false;
            this.circl.Click += new System.EventHandler(this.circl_Click);
            // 
            // linne
            // 
            this.linne.BackColor = System.Drawing.Color.Silver;
            this.linne.FlatAppearance.BorderSize = 0;
            this.linne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linne.Image = global::MainPaint.Properties.Resources.Editing_Line_icon;
            this.linne.Location = new System.Drawing.Point(338, 5);
            this.linne.Name = "linne";
            this.linne.Size = new System.Drawing.Size(67, 65);
            this.linne.TabIndex = 3;
            this.linne.UseVisualStyleBackColor = false;
            this.linne.Click += new System.EventHandler(this.linne_Click);
            // 
            // trian
            // 
            this.trian.BackColor = System.Drawing.Color.Silver;
            this.trian.FlatAppearance.BorderSize = 0;
            this.trian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trian.Image = global::MainPaint.Properties.Resources.Editing_Triangle_Stroked_icon;
            this.trian.Location = new System.Drawing.Point(191, 5);
            this.trian.Name = "trian";
            this.trian.Size = new System.Drawing.Size(70, 65);
            this.trian.TabIndex = 1;
            this.trian.UseVisualStyleBackColor = false;
            this.trian.Click += new System.EventHandler(this.trian_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.Silver;
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Image = global::MainPaint.Properties.Resources.Editing_Rectangle_icon;
            this.rectangle.Location = new System.Drawing.Point(106, 5);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(79, 65);
            this.rectangle.TabIndex = 0;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(423, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 33);
            this.button5.TabIndex = 18;
            this.button5.Text = "Option Story";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(-6, 239);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // FormA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::MainPaint.Properties.Resources.grey_780x400;
            this.ClientSize = new System.Drawing.Size(1042, 544);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.crop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.circl);
            this.Controls.Add(this.linne);
            this.Controls.Add(this.trian);
            this.Controls.Add(this.rectangle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormA2";
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormA2_FormClosing);
            this.Load += new System.EventHandler(this.FormA2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button trian;
        private System.Windows.Forms.Button linne;
        private System.Windows.Forms.Button circl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}