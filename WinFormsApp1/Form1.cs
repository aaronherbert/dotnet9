namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new OpenFileDialog();
            x.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ASd");
        }
    }
}
