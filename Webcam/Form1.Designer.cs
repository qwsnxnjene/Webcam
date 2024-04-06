namespace Webcam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_cameralist = new ComboBox();
            btn_start = new Button();
            btn_capture = new Button();
            btn_save = new Button();
            btn_close = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox_cameralist
            // 
            comboBox_cameralist.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_cameralist.FormattingEnabled = true;
            comboBox_cameralist.Location = new Point(12, 12);
            comboBox_cameralist.Name = "comboBox_cameralist";
            comboBox_cameralist.Size = new Size(121, 23);
            comboBox_cameralist.TabIndex = 0;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(148, 11);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 23);
            btn_start.TabIndex = 1;
            btn_start.Text = "Начать";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_capture
            // 
            btn_capture.Location = new Point(229, 11);
            btn_capture.Name = "btn_capture";
            btn_capture.Size = new Size(75, 23);
            btn_capture.TabIndex = 2;
            btn_capture.Text = "Захват";
            btn_capture.UseVisualStyleBackColor = true;
            btn_capture.Click += btn_capture_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(310, 11);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(155, 23);
            btn_save.TabIndex = 3;
            btn_save.Text = "Сохранить изображение";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(713, 11);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(75, 23);
            btn_close.TabIndex = 4;
            btn_close.Text = "Закрыть";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(763, 397);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(384, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(376, 391);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_close);
            Controls.Add(btn_save);
            Controls.Add(btn_capture);
            Controls.Add(btn_start);
            Controls.Add(comboBox_cameralist);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_cameralist;
        private Button btn_start;
        private Button btn_capture;
        private Button btn_save;
        private Button btn_close;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
