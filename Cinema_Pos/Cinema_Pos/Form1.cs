namespace Cinema_Pos
{
    public partial class MainForm : Form
    {
        public static double total = 0, change;
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nPopcorn Large Menu - 11.50 ��.";
            //������ ��� ���������� total - 7,50
            total = total + 11.50;
            //�������� ��� ����� ���� tbSum ��-�� �� total
            label3.Text = total.ToString("F2") + " ��."; //F2 - result with 2 decimal
        }

        private void btnPCMediumMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nPopcorn Medium Menu - 7.50 ��.";
            //������ ��� ���������� total - 7,50
            total = total + 7.50;
            //�������� ��� ����� ���� tbSum ��-�� �� total
            label3.Text = total.ToString("F2") + " ��.";
        }

        private void btnNachoDuetMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nNachos Duet Menu - 10.50 ��.";
            //������ ��� ���������� total - 7,50
            total = total + 10.50;
            //�������� ��� ����� ���� tbSum ��-�� �� total
            label3.Text = total.ToString("F2") + " ��.";
        }

        private void btnNachoLargeMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nNachos Lerge Menu - 12.50 ��.";
            //������ ��� ���������� total - 7,50
            total = total + 12.50;
            //�������� ��� ����� ���� tbSum ��-�� �� total
            label3.Text = total.ToString("F2") + " ��.";
        }

        private void btnNachoMediumMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nNachos Medium Menu - 8.50 ��.";
            //������ ��� ���������� total - 7,50
            total = total + 8.50;
            //�������� ��� ����� ���� tbSum ��-�� �� total
            label3.Text = total.ToString("F2") + " ��.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear
            richTextBox1.Clear();
            total = 0;
            label3.Text = " ";
                             
        }

        private void btnPCDuetMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nPopcorn Duet Menu - 9.50 ��.";
            //������ ��� ���������� total - 7,50
            total = total + 9.50;
            //�������� ��� ����� ���� tbSum ��-�� �� total
            label3.Text = total.ToString("F2") + " ��.";

        }
    }
}