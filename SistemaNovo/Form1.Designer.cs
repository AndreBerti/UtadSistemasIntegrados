
namespace SistemaNovo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnCopyCodigo = new Button();
            btnCopyData = new Button();
            txtData = new TextBox();
            lblData = new Label();
            btnCopyHora = new Button();
            txtHora = new TextBox();
            lblHora = new Label();
            btnCopyDuracao = new Button();
            lblDuracao = new Label();
            btnCopyResultado = new Button();
            txtResultado = new TextBox();
            btnCopyCusto = new Button();
            txtCusto = new TextBox();
            lblCusto = new Label();
            btnCopyPrejuizo = new Button();
            txtPrejuizo = new TextBox();
            lblPrejuizo = new Label();
            btnCopyLucro = new Button();
            txtLucro = new TextBox();
            lblLucro = new Label();
            dataGridView1 = new DataGridView();
            txtDuracao = new TextBox();
            lblResultado = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnBuscar = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AccessibleDescription = "lblCodigo";
            lblCodigo.AccessibleName = "lblCodigo";
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(90, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(152, 27);
            txtCodigo.TabIndex = 1;
            // 
            // btnCopyCodigo
            // 
            btnCopyCodigo.Location = new Point(248, 11);
            btnCopyCodigo.Name = "btnCopyCodigo";
            btnCopyCodigo.Size = new Size(94, 29);
            btnCopyCodigo.TabIndex = 9;
            btnCopyCodigo.Text = "Copiar";
            btnCopyCodigo.UseVisualStyleBackColor = true;
            btnCopyCodigo.Click += btnCopyCodigo_Click;
            // 
            // btnCopyData
            // 
            btnCopyData.Location = new Point(248, 44);
            btnCopyData.Name = "btnCopyData";
            btnCopyData.Size = new Size(94, 29);
            btnCopyData.TabIndex = 10;
            btnCopyData.Text = "Copiar";
            btnCopyData.UseVisualStyleBackColor = true;
            btnCopyData.Click += btnCopyData_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(90, 45);
            txtData.Name = "txtData";
            txtData.Size = new Size(152, 27);
            txtData.TabIndex = 2;
            // 
            // lblData
            // 
            lblData.AccessibleDescription = "lblCodigo";
            lblData.AccessibleName = "lblCodigo";
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 48);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 0;
            lblData.Text = "Data";
            // 
            // btnCopyHora
            // 
            btnCopyHora.Location = new Point(248, 77);
            btnCopyHora.Name = "btnCopyHora";
            btnCopyHora.Size = new Size(94, 29);
            btnCopyHora.TabIndex = 11;
            btnCopyHora.Text = "Copiar";
            btnCopyHora.UseVisualStyleBackColor = true;
            btnCopyHora.Click += btnCopyHora_Click;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(90, 78);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(152, 27);
            txtHora.TabIndex = 3;
            txtHora.TextChanged += textBox1_TextChanged;
            // 
            // lblHora
            // 
            lblHora.AccessibleDescription = "lblCodigo";
            lblHora.AccessibleName = "lblCodigo";
            lblHora.AutoSize = true;
            lblHora.Location = new Point(12, 81);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(42, 20);
            lblHora.TabIndex = 0;
            lblHora.Text = "Hora";
            // 
            // btnCopyDuracao
            // 
            btnCopyDuracao.Location = new Point(248, 112);
            btnCopyDuracao.Name = "btnCopyDuracao";
            btnCopyDuracao.Size = new Size(94, 29);
            btnCopyDuracao.TabIndex = 12;
            btnCopyDuracao.Text = "Copiar";
            btnCopyDuracao.UseVisualStyleBackColor = true;
            btnCopyDuracao.Click += btnCopyDuracao_Click;
            // 
            // lblDuracao
            // 
            lblDuracao.AccessibleDescription = "lblCodigo";
            lblDuracao.AccessibleName = "lblCodigo";
            lblDuracao.AutoSize = true;
            lblDuracao.Location = new Point(12, 116);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(65, 20);
            lblDuracao.TabIndex = 0;
            lblDuracao.Text = "Duração";
            // 
            // btnCopyResultado
            // 
            btnCopyResultado.Location = new Point(248, 148);
            btnCopyResultado.Name = "btnCopyResultado";
            btnCopyResultado.Size = new Size(94, 29);
            btnCopyResultado.TabIndex = 13;
            btnCopyResultado.Text = "Copiar";
            btnCopyResultado.UseVisualStyleBackColor = true;
            btnCopyResultado.Click += btnCopyResultado_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(90, 149);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(152, 27);
            txtResultado.TabIndex = 5;
            // 
            // btnCopyCusto
            // 
            btnCopyCusto.Location = new Point(248, 183);
            btnCopyCusto.Name = "btnCopyCusto";
            btnCopyCusto.Size = new Size(94, 29);
            btnCopyCusto.TabIndex = 14;
            btnCopyCusto.Text = "Copiar";
            btnCopyCusto.UseVisualStyleBackColor = true;
            btnCopyCusto.Click += btnCopyCusto_Click;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(90, 184);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(152, 27);
            txtCusto.TabIndex = 6;
            // 
            // lblCusto
            // 
            lblCusto.AccessibleDescription = "lblCodigo";
            lblCusto.AccessibleName = "lblCodigo";
            lblCusto.AutoSize = true;
            lblCusto.Location = new Point(12, 187);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(46, 20);
            lblCusto.TabIndex = 0;
            lblCusto.Text = "Custo";
            // 
            // btnCopyPrejuizo
            // 
            btnCopyPrejuizo.Location = new Point(248, 216);
            btnCopyPrejuizo.Name = "btnCopyPrejuizo";
            btnCopyPrejuizo.Size = new Size(94, 29);
            btnCopyPrejuizo.TabIndex = 15;
            btnCopyPrejuizo.Text = "Copiar";
            btnCopyPrejuizo.UseVisualStyleBackColor = true;
            btnCopyPrejuizo.Click += btnCopyPrejuizo_Click;
            // 
            // txtPrejuizo
            // 
            txtPrejuizo.Location = new Point(90, 217);
            txtPrejuizo.Name = "txtPrejuizo";
            txtPrejuizo.Size = new Size(152, 27);
            txtPrejuizo.TabIndex = 7;
            // 
            // lblPrejuizo
            // 
            lblPrejuizo.AccessibleDescription = "lblCodigo";
            lblPrejuizo.AccessibleName = "lblCodigo";
            lblPrejuizo.AutoSize = true;
            lblPrejuizo.Location = new Point(12, 220);
            lblPrejuizo.Name = "lblPrejuizo";
            lblPrejuizo.Size = new Size(62, 20);
            lblPrejuizo.TabIndex = 0;
            lblPrejuizo.Text = "Prejuizo";
            // 
            // btnCopyLucro
            // 
            btnCopyLucro.Location = new Point(248, 250);
            btnCopyLucro.Name = "btnCopyLucro";
            btnCopyLucro.Size = new Size(94, 29);
            btnCopyLucro.TabIndex = 16;
            btnCopyLucro.Text = "Copiar";
            btnCopyLucro.UseVisualStyleBackColor = true;
            btnCopyLucro.Click += btnCopyLucro_Click;
            // 
            // txtLucro
            // 
            txtLucro.Location = new Point(90, 251);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(152, 27);
            txtLucro.TabIndex = 8;
            // 
            // lblLucro
            // 
            lblLucro.AccessibleDescription = "lblCodigo";
            lblLucro.AccessibleName = "lblCodigo";
            lblLucro.AutoSize = true;
            lblLucro.Location = new Point(12, 254);
            lblLucro.Name = "lblLucro";
            lblLucro.Size = new Size(45, 20);
            lblLucro.TabIndex = 0;
            lblLucro.Text = "Lucro";
            lblLucro.Click += lblLucro_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(351, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(580, 269);
            dataGridView1.TabIndex = 99;
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(90, 114);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(152, 27);
            txtDuracao.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AccessibleDescription = "lblCodigo";
            lblResultado.AccessibleName = "lblCodigo";
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 152);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 15F);
            btnAdd.ForeColor = Color.Snow;
            btnAdd.Location = new Point(12, 301);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(288, 81);
            btnAdd.TabIndex = 100;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.HotTrack;
            btnRemove.Font = new Font("Arial Rounded MT Bold", 15F);
            btnRemove.ForeColor = Color.Snow;
            btnRemove.Location = new Point(327, 301);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(288, 81);
            btnRemove.TabIndex = 101;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HotTrack;
            btnBuscar.Font = new Font("Arial Rounded MT Bold", 15F);
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(642, 301);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(288, 81);
            btnBuscar.TabIndex = 103;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 395);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 31);
            lblStatus.TabIndex = 104;
            lblStatus.Text = "Notificação:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(954, 446);
            Controls.Add(lblStatus);
            Controls.Add(btnBuscar);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblResultado);
            Controls.Add(txtDuracao);
            Controls.Add(dataGridView1);
            Controls.Add(btnCopyLucro);
            Controls.Add(txtLucro);
            Controls.Add(lblLucro);
            Controls.Add(btnCopyPrejuizo);
            Controls.Add(txtPrejuizo);
            Controls.Add(lblPrejuizo);
            Controls.Add(btnCopyCusto);
            Controls.Add(txtCusto);
            Controls.Add(lblCusto);
            Controls.Add(btnCopyResultado);
            Controls.Add(txtResultado);
            Controls.Add(btnCopyDuracao);
            Controls.Add(lblDuracao);
            Controls.Add(btnCopyHora);
            Controls.Add(txtHora);
            Controls.Add(lblHora);
            Controls.Add(btnCopyData);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(btnCopyCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Button btnCopyCodigo;
        private Button btnCopyData;
        private TextBox txtData;
        private Label lblData;
        private Button btnCopyHora;
        private TextBox txtHora;
        private Label lblHora;
        private Button btnCopyDuracao;
        private Label lblDuracao;
        private Button btnCopyResultado;
        private TextBox txtResultado;
        private Button btnCopyCusto;
        private TextBox txtCusto;
        private Label lblCusto;
        private Button btnCopyPrejuizo;
        private TextBox txtPrejuizo;
        private Label lblPrejuizo;
        private Button btnCopyLucro;
        private TextBox txtLucro;
        private Label lblLucro;
        private DataGridView dataGridView1;
        private EventHandler label1_Click_1;
        private EventHandler textBox1_TextChanged_1;
        private TextBox txtDuracao;
        private Label lblResultado;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnBuscar;
        private Label lblStatus;
    }
}
