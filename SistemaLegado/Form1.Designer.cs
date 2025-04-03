namespace SistemaLegado
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
            lblCodigoPeca = new Label();
            boxTextCodigoPeca = new TextBox();
            btnCopiarData = new Button();
            boxTextData = new TextBox();
            lblData = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblCodigoPeca
            // 
            lblCodigoPeca.AutoSize = true;
            lblCodigoPeca.Location = new Point(0, 19);
            lblCodigoPeca.Name = "lblCodigoPeca";
            lblCodigoPeca.Size = new Size(92, 20);
            lblCodigoPeca.TabIndex = 0;
            lblCodigoPeca.Text = "Codigo Peça";
            // 
            // boxTextCodigoPeca
            // 
            boxTextCodigoPeca.Location = new Point(98, 16);
            boxTextCodigoPeca.Name = "boxTextCodigoPeca";
            boxTextCodigoPeca.Size = new Size(319, 27);
            boxTextCodigoPeca.TabIndex = 1;
            // 
            // btnCopiarData
            // 
            btnCopiarData.Location = new Point(423, 15);
            btnCopiarData.Name = "btnCopiarData";
            btnCopiarData.Size = new Size(94, 29);
            btnCopiarData.TabIndex = 2;
            btnCopiarData.Text = "Copiar";
            btnCopiarData.UseVisualStyleBackColor = true;
            // 
            // boxTextData
            // 
            boxTextData.Location = new Point(98, 51);
            boxTextData.Name = "boxTextData";
            boxTextData.Size = new Size(319, 27);
            boxTextData.TabIndex = 4;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(0, 54);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 3;
            lblData.Text = "Data";
            // 
            // button2
            // 
            button2.Location = new Point(423, 50);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Copiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 328);
            Controls.Add(button2);
            Controls.Add(boxTextData);
            Controls.Add(lblData);
            Controls.Add(btnCopiarData);
            Controls.Add(boxTextCodigoPeca);
            Controls.Add(lblCodigoPeca);
            Name = "Form1";
            Text = "Sistema Legado";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoPeca;
        private TextBox boxTextCodigoPeca;
        private Button btnCopiarData;
        private Button button1;
        private TextBox boxTextData;
        private Label lblData;
        private Button button2;
    }
}
