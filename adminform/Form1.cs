using adminform;

namespace adminform

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Cau_hinh ucCH = new Cau_hinh();
            ucCH.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucCH);


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Quan_ly ucQuanly = new Quan_ly();
            ucQuanly.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucQuanly);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            QT_DL ucqldl = new QT_DL();
            ucqldl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucqldl);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Hoat_dong ucHD = new Hoat_dong();
            ucHD.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucHD);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
