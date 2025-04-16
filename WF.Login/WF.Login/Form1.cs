namespace WF.Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar o programa?",
                "Sair",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuário")
                textBox1.Text = string.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                textBox1.Text = "Usuário";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Senha")
                textBox2.Text = string.Empty;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
                textBox2.Text = "Senha";
        }
    }
}
