namespace teacherform
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button9 = new Button();
            imageList1 = new ImageList(components);
            button8 = new Button();
            Thong_bao = new Button();
            button5 = new Button();
            panelContent = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 108);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(198, 108);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1001, 487);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(444, 47);
            label4.Name = "label4";
            label4.Size = new Size(371, 26);
            label4.TabIndex = 6;
            label4.Text = "Xin chào giảng viên, mừng bạn trở lại!";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(646, 38);
            label1.TabIndex = 4;
            label1.Text = "HỆ THỐNG QUẢN LÝ ĐIỂM HỌC VIÊN";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 128);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(171, 17);
            label3.TabIndex = 5;
            label3.Text = "Chất lượng tạo nên giá trị";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 36);
            label2.Name = "label2";
            label2.Size = new Size(93, 26);
            label2.TabIndex = 4;
            label2.Text = "MTAedu";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lucid_origin_A_modern_minimalist_circular_logo_for_a_military_technical_academy__Dark_green_o_0;
            pictureBox1.Location = new Point(-16, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(Thong_bao);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 468);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint_1;
            // 
            // button9
            // 
            button9.BackColor = Color.LightYellow;
            button9.FlatAppearance.MouseDownBackColor = Color.Gold;
            button9.FlatAppearance.MouseOverBackColor = Color.Khaki;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(0, 64, 0);
            button9.ImageAlign = ContentAlignment.MiddleRight;
            button9.ImageIndex = 1;
            button9.ImageList = imageList1;
            button9.Location = new Point(0, 56);
            button9.Name = "button9";
            button9.Size = new Size(201, 57);
            button9.TabIndex = 13;
            button9.Text = "Hồ sơ cá nhân";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "download.png");
            imageList1.Images.SetKeyName(1, "Adobe Express - file.png");
            imageList1.Images.SetKeyName(2, "scoreboard.png");
            imageList1.Images.SetKeyName(3, "report.png");
            imageList1.Images.SetKeyName(4, "mail.png");
            imageList1.Images.SetKeyName(5, "edit.png");
            // 
            // button8
            // 
            button8.BackColor = Color.LightYellow;
            button8.FlatAppearance.MouseDownBackColor = Color.Gold;
            button8.FlatAppearance.MouseOverBackColor = Color.Khaki;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.2F);
            button8.ForeColor = Color.FromArgb(0, 64, 0);
            button8.ImageAlign = ContentAlignment.MiddleRight;
            button8.ImageIndex = 3;
            button8.ImageList = imageList1;
            button8.Location = new Point(0, 376);
            button8.Name = "button8";
            button8.Size = new Size(201, 57);
            button8.TabIndex = 12;
            button8.Text = "Báo cáo";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Thong_bao
            // 
            Thong_bao.BackColor = Color.LightYellow;
            Thong_bao.FlatAppearance.MouseDownBackColor = Color.Gold;
            Thong_bao.FlatAppearance.MouseOverBackColor = Color.Khaki;
            Thong_bao.FlatStyle = FlatStyle.Flat;
            Thong_bao.Font = new Font("Segoe UI", 10.2F);
            Thong_bao.ForeColor = Color.FromArgb(0, 64, 0);
            Thong_bao.ImageAlign = ContentAlignment.MiddleRight;
            Thong_bao.ImageIndex = 4;
            Thong_bao.ImageList = imageList1;
            Thong_bao.Location = new Point(0, 269);
            Thong_bao.Name = "Thong_bao";
            Thong_bao.Size = new Size(201, 57);
            Thong_bao.TabIndex = 11;
            Thong_bao.Text = "Thông báo";
            Thong_bao.TextAlign = ContentAlignment.MiddleLeft;
            Thong_bao.UseVisualStyleBackColor = false;
            Thong_bao.Click += button7_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightYellow;
            button5.FlatAppearance.MouseDownBackColor = Color.Gold;
            button5.FlatAppearance.MouseOverBackColor = Color.Khaki;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(0, 64, 0);
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.ImageIndex = 2;
            button5.ImageList = imageList1;
            button5.Location = new Point(0, 164);
            button5.Name = "button5";
            button5.Size = new Size(201, 57);
            button5.TabIndex = 9;
            button5.Text = "Điểm số";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.AutoSize = true;
            panelContent.BackColor = Color.LightYellow;
            panelContent.Location = new Point(201, 108);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(924, 468);
            panelContent.TabIndex = 3;
            panelContent.Paint += panelContent_Paint_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1125, 576);
            Controls.Add(panelContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private ImageList imageList1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button5;
        private Button Thong_bao;
        private Button button8;
        private Button button9;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelContent;
    }
}
