namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White; textBox2.BackColor = Color.White;

            if (!Checking()) MessageBox.Show("Все поля должны быть заполнены!");

            /*Проверка на роль*/




        }

        bool Checking()
        {           
            if (textBox1.Text == "") textBox1.BackColor = Color.Red;
            if (textBox2.Text == "") textBox2.BackColor = Color.Red;
            if (textBox1.Text == "" || textBox2.Text == "") return false;
            return true;
        }
    }
}