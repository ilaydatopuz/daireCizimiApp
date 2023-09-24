namespace daireÇizimiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            int yaricap = int.Parse(textBox1.Text);

            for (int i = -yaricap; i <= yaricap; i++)
            {
                for (int j = -yaricap; j <= yaricap; j++)
                {
                    if (i * i + j * j <= yaricap * yaricap)
                        richTextBox1.Text += "*";
                    else
                        richTextBox1.Text += " ";
                }
                richTextBox1.Text += "\n";

            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
