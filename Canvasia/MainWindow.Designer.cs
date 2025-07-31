namespace Canvasia
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.cropBtn = new System.Windows.Forms.Button();
            this.skewBtn = new System.Windows.Forms.Button();
            this.addingFrameBtn = new System.Windows.Forms.Button();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.flipBtn = new System.Windows.Forms.Button();
            this.blurBtn = new System.Windows.Forms.Button();
            this.lightenDarkenBtn = new System.Windows.Forms.Button();
            this.grayscaleBtn = new System.Windows.Forms.Button();
            this.blackAndWhiteBtn = new System.Windows.Forms.Button();
            this.detectEdgesBtn = new System.Windows.Forms.Button();
            this.sunlightBtn = new System.Windows.Forms.Button();
            this.purpleBtn = new System.Windows.Forms.Button();
            this.infraredBtn = new System.Windows.Forms.Button();
            this.invertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(296, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1323, 929);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mergeBtn);
            this.panel1.Controls.Add(this.resizeBtn);
            this.panel1.Controls.Add(this.cropBtn);
            this.panel1.Controls.Add(this.skewBtn);
            this.panel1.Controls.Add(this.addingFrameBtn);
            this.panel1.Controls.Add(this.rotateBtn);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.flipBtn);
            this.panel1.Controls.Add(this.blurBtn);
            this.panel1.Controls.Add(this.lightenDarkenBtn);
            this.panel1.Controls.Add(this.grayscaleBtn);
            this.panel1.Controls.Add(this.blackAndWhiteBtn);
            this.panel1.Controls.Add(this.detectEdgesBtn);
            this.panel1.Controls.Add(this.sunlightBtn);
            this.panel1.Controls.Add(this.purpleBtn);
            this.panel1.Controls.Add(this.infraredBtn);
            this.panel1.Controls.Add(this.invertBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 929);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mergeBtn
            // 
            this.mergeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mergeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mergeBtn.FlatAppearance.BorderSize = 0;
            this.mergeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mergeBtn.ForeColor = System.Drawing.Color.White;
            this.mergeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mergeBtn.Location = new System.Drawing.Point(0, 630);
            this.mergeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.mergeBtn.Size = new System.Drawing.Size(281, 45);
            this.mergeBtn.TabIndex = 12;
            this.mergeBtn.Text = "Merge Images";
            this.mergeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizeBtn.FlatAppearance.BorderSize = 0;
            this.resizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.resizeBtn.ForeColor = System.Drawing.Color.White;
            this.resizeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resizeBtn.Location = new System.Drawing.Point(0, 728);
            this.resizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.resizeBtn.Size = new System.Drawing.Size(281, 45);
            this.resizeBtn.TabIndex = 14;
            this.resizeBtn.Text = "Resize Image";
            this.resizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // cropBtn
            // 
            this.cropBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cropBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cropBtn.FlatAppearance.BorderSize = 0;
            this.cropBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cropBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cropBtn.ForeColor = System.Drawing.Color.White;
            this.cropBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cropBtn.Location = new System.Drawing.Point(0, 238);
            this.cropBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cropBtn.Name = "cropBtn";
            this.cropBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.cropBtn.Size = new System.Drawing.Size(281, 45);
            this.cropBtn.TabIndex = 4;
            this.cropBtn.Text = "Crop Image";
            this.cropBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cropBtn.UseVisualStyleBackColor = true;
            this.cropBtn.Click += new System.EventHandler(this.cropBtn_Click);
            // 
            // skewBtn
            // 
            this.skewBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skewBtn.FlatAppearance.BorderSize = 0;
            this.skewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.skewBtn.ForeColor = System.Drawing.Color.White;
            this.skewBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.skewBtn.Location = new System.Drawing.Point(0, 826);
            this.skewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skewBtn.Name = "skewBtn";
            this.skewBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.skewBtn.Size = new System.Drawing.Size(281, 45);
            this.skewBtn.TabIndex = 16;
            this.skewBtn.Text = "Skew Image";
            this.skewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skewBtn.UseVisualStyleBackColor = true;
            this.skewBtn.Click += new System.EventHandler(this.skewBtn_Click);
            // 
            // addingFrameBtn
            // 
            this.addingFrameBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addingFrameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addingFrameBtn.FlatAppearance.BorderSize = 0;
            this.addingFrameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addingFrameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addingFrameBtn.ForeColor = System.Drawing.Color.White;
            this.addingFrameBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addingFrameBtn.Location = new System.Drawing.Point(0, 91);
            this.addingFrameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addingFrameBtn.Name = "addingFrameBtn";
            this.addingFrameBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.addingFrameBtn.Size = new System.Drawing.Size(281, 45);
            this.addingFrameBtn.TabIndex = 1;
            this.addingFrameBtn.Text = "Adding a Frame";
            this.addingFrameBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addingFrameBtn.UseVisualStyleBackColor = true;
            this.addingFrameBtn.Click += new System.EventHandler(this.addingFrameBtn_Click);
            // 
            // rotateBtn
            // 
            this.rotateBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rotateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotateBtn.FlatAppearance.BorderSize = 0;
            this.rotateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rotateBtn.ForeColor = System.Drawing.Color.White;
            this.rotateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rotateBtn.Location = new System.Drawing.Point(0, 777);
            this.rotateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rotateBtn.Size = new System.Drawing.Size(281, 45);
            this.rotateBtn.TabIndex = 15;
            this.rotateBtn.Text = "Rotate Image";
            this.rotateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutBtn.BackgroundImage")));
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.aboutBtn.Location = new System.Drawing.Point(3, 892);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(35, 35);
            this.aboutBtn.TabIndex = 17;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // flipBtn
            // 
            this.flipBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flipBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flipBtn.FlatAppearance.BorderSize = 0;
            this.flipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.flipBtn.ForeColor = System.Drawing.Color.White;
            this.flipBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flipBtn.Location = new System.Drawing.Point(0, 336);
            this.flipBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flipBtn.Name = "flipBtn";
            this.flipBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.flipBtn.Size = new System.Drawing.Size(281, 45);
            this.flipBtn.TabIndex = 6;
            this.flipBtn.Text = "Flip Filter";
            this.flipBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flipBtn.UseVisualStyleBackColor = true;
            this.flipBtn.Click += new System.EventHandler(this.flipBtn_Click);
            // 
            // blurBtn
            // 
            this.blurBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.blurBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blurBtn.FlatAppearance.BorderSize = 0;
            this.blurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.blurBtn.ForeColor = System.Drawing.Color.White;
            this.blurBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.blurBtn.Location = new System.Drawing.Point(0, 189);
            this.blurBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blurBtn.Name = "blurBtn";
            this.blurBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.blurBtn.Size = new System.Drawing.Size(281, 45);
            this.blurBtn.TabIndex = 3;
            this.blurBtn.Text = "Blur Filter";
            this.blurBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blurBtn.UseVisualStyleBackColor = true;
            this.blurBtn.Click += new System.EventHandler(this.blurBtn_Click);
            // 
            // lightenDarkenBtn
            // 
            this.lightenDarkenBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lightenDarkenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightenDarkenBtn.FlatAppearance.BorderSize = 0;
            this.lightenDarkenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightenDarkenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lightenDarkenBtn.ForeColor = System.Drawing.Color.White;
            this.lightenDarkenBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lightenDarkenBtn.Location = new System.Drawing.Point(0, 532);
            this.lightenDarkenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lightenDarkenBtn.Name = "lightenDarkenBtn";
            this.lightenDarkenBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.lightenDarkenBtn.Size = new System.Drawing.Size(281, 45);
            this.lightenDarkenBtn.TabIndex = 10;
            this.lightenDarkenBtn.Text = "Lighten-Darken Filter";
            this.lightenDarkenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lightenDarkenBtn.UseVisualStyleBackColor = true;
            this.lightenDarkenBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // grayscaleBtn
            // 
            this.grayscaleBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grayscaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayscaleBtn.FlatAppearance.BorderSize = 0;
            this.grayscaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayscaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grayscaleBtn.ForeColor = System.Drawing.Color.White;
            this.grayscaleBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grayscaleBtn.Location = new System.Drawing.Point(0, 385);
            this.grayscaleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grayscaleBtn.Name = "grayscaleBtn";
            this.grayscaleBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.grayscaleBtn.Size = new System.Drawing.Size(281, 45);
            this.grayscaleBtn.TabIndex = 7;
            this.grayscaleBtn.Text = "Grayscale Filter";
            this.grayscaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grayscaleBtn.UseVisualStyleBackColor = true;
            this.grayscaleBtn.Click += new System.EventHandler(this.grayscaleBtn_Click);
            // 
            // blackAndWhiteBtn
            // 
            this.blackAndWhiteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.blackAndWhiteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackAndWhiteBtn.FlatAppearance.BorderSize = 0;
            this.blackAndWhiteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackAndWhiteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.blackAndWhiteBtn.ForeColor = System.Drawing.Color.White;
            this.blackAndWhiteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.blackAndWhiteBtn.Location = new System.Drawing.Point(0, 140);
            this.blackAndWhiteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blackAndWhiteBtn.Name = "blackAndWhiteBtn";
            this.blackAndWhiteBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.blackAndWhiteBtn.Size = new System.Drawing.Size(281, 45);
            this.blackAndWhiteBtn.TabIndex = 2;
            this.blackAndWhiteBtn.Text = "Black and White Filter";
            this.blackAndWhiteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blackAndWhiteBtn.UseVisualStyleBackColor = true;
            this.blackAndWhiteBtn.Click += new System.EventHandler(this.blackAndWhiteBtn_Click);
            // 
            // detectEdgesBtn
            // 
            this.detectEdgesBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.detectEdgesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detectEdgesBtn.FlatAppearance.BorderSize = 0;
            this.detectEdgesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectEdgesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.detectEdgesBtn.ForeColor = System.Drawing.Color.White;
            this.detectEdgesBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.detectEdgesBtn.Location = new System.Drawing.Point(0, 287);
            this.detectEdgesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detectEdgesBtn.Name = "detectEdgesBtn";
            this.detectEdgesBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.detectEdgesBtn.Size = new System.Drawing.Size(281, 45);
            this.detectEdgesBtn.TabIndex = 5;
            this.detectEdgesBtn.Text = "Detect Edges Filter";
            this.detectEdgesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detectEdgesBtn.UseVisualStyleBackColor = true;
            this.detectEdgesBtn.Click += new System.EventHandler(this.detectEdgesBtn_Click);
            // 
            // sunlightBtn
            // 
            this.sunlightBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sunlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sunlightBtn.FlatAppearance.BorderSize = 0;
            this.sunlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sunlightBtn.ForeColor = System.Drawing.Color.White;
            this.sunlightBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sunlightBtn.Location = new System.Drawing.Point(0, 679);
            this.sunlightBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sunlightBtn.Name = "sunlightBtn";
            this.sunlightBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.sunlightBtn.Size = new System.Drawing.Size(281, 45);
            this.sunlightBtn.TabIndex = 13;
            this.sunlightBtn.Text = "Natural Sunlight Filter";
            this.sunlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunlightBtn.UseVisualStyleBackColor = true;
            this.sunlightBtn.Click += new System.EventHandler(this.sunlightBtn_Click);
            // 
            // purpleBtn
            // 
            this.purpleBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.purpleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purpleBtn.FlatAppearance.BorderSize = 0;
            this.purpleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.purpleBtn.ForeColor = System.Drawing.Color.White;
            this.purpleBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.purpleBtn.Location = new System.Drawing.Point(0, 581);
            this.purpleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purpleBtn.Name = "purpleBtn";
            this.purpleBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.purpleBtn.Size = new System.Drawing.Size(281, 45);
            this.purpleBtn.TabIndex = 11;
            this.purpleBtn.Text = "Look Purple Filter";
            this.purpleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purpleBtn.UseVisualStyleBackColor = true;
            this.purpleBtn.Click += new System.EventHandler(this.purpleBtn_Click);
            // 
            // infraredBtn
            // 
            this.infraredBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.infraredBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infraredBtn.FlatAppearance.BorderSize = 0;
            this.infraredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infraredBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.infraredBtn.ForeColor = System.Drawing.Color.White;
            this.infraredBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.infraredBtn.Location = new System.Drawing.Point(0, 434);
            this.infraredBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infraredBtn.Name = "infraredBtn";
            this.infraredBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.infraredBtn.Size = new System.Drawing.Size(281, 45);
            this.infraredBtn.TabIndex = 8;
            this.infraredBtn.Text = "Infrared Filter";
            this.infraredBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infraredBtn.UseVisualStyleBackColor = true;
            this.infraredBtn.Click += new System.EventHandler(this.infraredBtn_Click);
            // 
            // invertBtn
            // 
            this.invertBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.invertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invertBtn.FlatAppearance.BorderSize = 0;
            this.invertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.invertBtn.ForeColor = System.Drawing.Color.White;
            this.invertBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invertBtn.Location = new System.Drawing.Point(0, 483);
            this.invertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invertBtn.Name = "invertBtn";
            this.invertBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.invertBtn.Size = new System.Drawing.Size(281, 45);
            this.invertBtn.TabIndex = 9;
            this.invertBtn.Text = "Invert Filter";
            this.invertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invertBtn.UseVisualStyleBackColor = true;
            this.invertBtn.Click += new System.EventHandler(this.invertBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canvasia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1632, 953);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1650, 1000);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canvasia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button invertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button infraredBtn;
        private System.Windows.Forms.Button purpleBtn;
        private System.Windows.Forms.Button detectEdgesBtn;
        private System.Windows.Forms.Button sunlightBtn;
        private System.Windows.Forms.Button blackAndWhiteBtn;
        private System.Windows.Forms.Button grayscaleBtn;
        private System.Windows.Forms.Button lightenDarkenBtn;
        private System.Windows.Forms.Button blurBtn;
        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.Button addingFrameBtn;
        private System.Windows.Forms.Button flipBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button skewBtn;
        private System.Windows.Forms.Button cropBtn;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Button mergeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

