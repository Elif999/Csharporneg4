namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int arttir = Convert.ToInt32(textBox1.Text);
            arttir+=1;
            textBox1.Text = arttir.ToString();

            if (arttir >= 1)
            {
                button2.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int azalt = Convert.ToInt32(textBox1.Text);
            azalt -= 1;
            textBox1.Text = azalt.ToString();
            if (azalt == 0)
            {
                button2.Enabled = false;
            }
            
        }
    }
}
/*
