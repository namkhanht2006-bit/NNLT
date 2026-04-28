namespace teacherform
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
            Thong_Bao_UC ucThongBao = new Thong_Bao_UC();
            ucThongBao.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucThongBao);


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {


            panelContent.Controls.Clear();
            HoSoCaNhanUC ucHoSo = new HoSoCaNhanUC();
            ucHoSo.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucHoSo);
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
            Diemso ucDiem = new Diemso();
            ucDiem.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucDiem);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Bao_cao ucBC = new Bao_cao();
            ucBC.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ucBC);
        }

        private void panelContent_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
