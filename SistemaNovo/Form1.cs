using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopyHora_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHora.Text);

        }

        private void lblLucro_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Produto produto = Produto.GetProduto(txtCodigo.Text);
            if (produto == null)
            {
                txtCodigo.Text = "";
                txtData.Text = "";
                txtHora.Text = "";
                txtDuracao.Text = "";
                txtResultado.Text = "";
                txtCusto.Text = "";
                txtPrejuizo.Text = "";
                txtLucro.Text = "";
                lblStatus.Text = "Notificação: Produto Não Encontrado";
            }
            else
            {
                txtCodigo.Text = produto.Codigo;
                txtData.Text = produto.Data.ToString("yyyy-MM-dd");
                txtHora.Text = produto.Hora.ToString("HH:mm:ss");
                txtDuracao.Text = produto.Duracao.ToString();
                txtResultado.Text = produto.Resultado.ToString();
                txtCusto.Text = produto.Valores.custoProducao.ToString("F2");
                txtPrejuizo.Text = produto.Valores.prejuizo.ToString("F2");
                txtLucro.Text = produto.Valores.lucro.ToString("F2");
                lblStatus.Text = "Notificação: Produto Encontrado";

            }
        }
        private void LoadData()
        {
            using (Db dbConnection = new Db())
            {
                try
                {
                    dbConnection.Open();
                    string query = "SELECT * FROM dbo.Produto";
                    using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable; // Atualiza o DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;

                // Converte a data de string para DateTime
                string dataEHora = txtData.Text + " " + txtHora.Text;
                DateTime data;
                if (!DateTime.TryParse(dataEHora, out data))
                {
                    MessageBox.Show(dataEHora + "Data inválida. Por favor, insira uma data válida.");
                    return;
                }

                // Converte a duração de string para int
                int duracao;
                if (!int.TryParse(txtDuracao.Text, out duracao))
                {
                    MessageBox.Show("Duração inválida. Por favor, insira um número inteiro.");
                    return;
                }

                // Converte o resultado de string para EnumResultadoTeste
                EnumResultadoTeste resultado;
                if (!Enum.TryParse<EnumResultadoTeste>(txtResultado.Text, out resultado))
                {
                    lblStatus.Text = "Resultado inválido. Por favor, insira um valor válido para o resultado.";
                    return;
                }

                // Cria uma nova instância do Produto
                Produto novoProduto = new Produto(codigo, data, duracao, resultado);

                // Chama o método para criar o produto no banco de dados
                lblStatus.Text=novoProduto.CreateProduto(novoProduto);

                LoadData(); // Atualiza o DataGridView, se necessário
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto: {ex.Message}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblStatus.Text = Produto.RemoverProduto(txtCodigo.Text);
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCopyCodigo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCodigo.Text);
        }

        private void btnCopyData_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtData.Text);

        }

        private void btnCopyDuracao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDuracao.Text);
        }

        private void btnCopyResultado_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResultado.Text);
        }

        private void btnCopyCusto_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCusto.Text);
        }

        private void btnCopyPrejuizo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPrejuizo.Text);
        }

        private void btnCopyLucro_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLucro.Text);
        }
    }
}
