namespace SistemaLegado
{
    public partial class Form1 : Form
    {
        private static string[] linhas; // Variável estática para armazenar as linhas do CSV
        private static int indiceAtual = -1; // Índice da linha atual

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLerCSV_Click(object sender, EventArgs e)
        {

            string caminhoArquivo = @"C:\Users\andre\Desktop\Trabalho UTAD\pecas_financas.csv";


            try
            {
                // Ler o arquivo CSV e armazenar as linhas na variável estática
                linhas = File.ReadAllLines(caminhoArquivo);
                indiceAtual = -1; // Reiniciar o índice para o início do arquivo
                MessageBox.Show("Arquivo carregado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
