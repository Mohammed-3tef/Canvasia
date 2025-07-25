namespace Canvasia.pages.filter_pages.rotate
{
    partial class RotateImagePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotateImagePage));
            this.loadPhotoBtn = new System.Windows.Forms.Button();
            this.applyFilter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.redoBtn = new System.Windows.Forms.Button();
            this.rotate180Degree = new System.Windows.Forms.RadioButton();
            this.rotate90Degree = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rotate270Degree = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadPhotoBtn
            // 
            this.loadPhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadPhotoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPhotoBtn.Location = new System.Drawing.Point(9, 9);
            this.loadPhotoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadPhotoBtn.Name = "loadPhotoBtn";
            this.loadPhotoBtn.Size = new System.Drawing.Size(183, 78);
            this.loadPhotoBtn.TabIndex = 13;
            this.loadPhotoBtn.Text = "Load Image";
            this.loadPhotoBtn.UseVisualStyleBackColor = true;
            this.loadPhotoBtn.Click += new System.EventHandler(this.loadPhotoBtn_Click);
            // 
            // applyFilter
            // 
            this.applyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyFilter.Location = new System.Drawing.Point(200, 9);
            this.applyFilter.Margin = new System.Windows.Forms.Padding(4);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(183, 78);
            this.applyFilter.TabIndex = 14;
            this.applyFilter.Text = "Apply Filter";
            this.applyFilter.UseVisualStyleBackColor = true;
            this.applyFilter.Click += new System.EventHandler(this.applyFilterBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(585, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(565, 429);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 84);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 498);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 49);
            this.label3.TabIndex = 11;
            this.label3.Text = "After:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 49);
            this.label2.TabIndex = 10;
            this.label2.Text = "Before:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.loadPhotoBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.applyFilter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.undoBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.downloadBtn, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.redoBtn, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 650);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1160, 96);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(773, 9);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(183, 78);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.undoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.undoBtn.Location = new System.Drawing.Point(391, 9);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(183, 78);
            this.undoBtn.TabIndex = 15;
            this.undoBtn.Text = "Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.Location = new System.Drawing.Point(964, 9);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(187, 78);
            this.downloadBtn.TabIndex = 18;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.redoBtn.Location = new System.Drawing.Point(582, 9);
            this.redoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(183, 78);
            this.redoBtn.TabIndex = 16;
            this.redoBtn.Text = "Redo";
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // rotate180Degree
            // 
            this.rotate180Degree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotate180Degree.AutoSize = true;
            this.rotate180Degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate180Degree.Location = new System.Drawing.Point(593, 599);
            this.rotate180Degree.Name = "rotate180Degree";
            this.rotate180Degree.Size = new System.Drawing.Size(176, 35);
            this.rotate180Degree.TabIndex = 49;
            this.rotate180Degree.TabStop = true;
            this.rotate180Degree.Text = "180 Degree";
            this.rotate180Degree.UseVisualStyleBackColor = true;
            // 
            // rotate90Degree
            // 
            this.rotate90Degree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotate90Degree.AutoSize = true;
            this.rotate90Degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate90Degree.Location = new System.Drawing.Point(402, 599);
            this.rotate90Degree.Name = "rotate90Degree";
            this.rotate90Degree.Size = new System.Drawing.Size(161, 35);
            this.rotate90Degree.TabIndex = 48;
            this.rotate90Degree.TabStop = true;
            this.rotate90Degree.Text = "90 Degree";
            this.rotate90Degree.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 64);
            this.label4.TabIndex = 47;
            this.label4.Text = "Rotate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1160, 75);
            this.label1.TabIndex = 45;
            this.label1.Text = "Rotate Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotate270Degree
            // 
            this.rotate270Degree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotate270Degree.AutoSize = true;
            this.rotate270Degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate270Degree.Location = new System.Drawing.Point(784, 599);
            this.rotate270Degree.Name = "rotate270Degree";
            this.rotate270Degree.Size = new System.Drawing.Size(176, 35);
            this.rotate270Degree.TabIndex = 50;
            this.rotate270Degree.TabStop = true;
            this.rotate270Degree.Text = "270 Degree";
            this.rotate270Degree.UseVisualStyleBackColor = true;
            // 
            // RotateImagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.rotate270Degree);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.rotate180Degree);
            this.Controls.Add(this.rotate90Degree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "RotateImagePage";
            this.Text = "Canvasia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadPhotoBtn;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.RadioButton rotate180Degree;
        private System.Windows.Forms.RadioButton rotate90Degree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rotate270Degree;
    }
}