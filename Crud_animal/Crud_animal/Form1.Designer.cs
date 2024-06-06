namespace Crud_animal
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txt_peso = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_compri = new TextBox();
            label3 = new Label();
            txt_sexo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_nome = new TextBox();
            txt_habitat = new TextBox();
            btn_excluir = new Button();
            btn_consulta = new Button();
            btn_salvar = new Button();
            txt_id = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_peso);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_compri);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_sexo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(txt_habitat);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_consulta);
            groupBox1.Controls.Add(btn_salvar);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastre o seu Lambari(peixe)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 224);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 15;
            label4.Text = "Codigo:";
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(154, 130);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(121, 23);
            txt_peso.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 102);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 13;
            label5.Text = "peso(kg):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 102);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 12;
            label6.Text = "Comprimento(cm):";
            // 
            // txt_compri
            // 
            txt_compri.Location = new Point(25, 130);
            txt_compri.Name = "txt_compri";
            txt_compri.Size = new Size(100, 23);
            txt_compri.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 166);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "habitat";
            // 
            // txt_sexo
            // 
            txt_sexo.Location = new Point(154, 67);
            txt_sexo.Name = "txt_sexo";
            txt_sexo.Size = new Size(121, 23);
            txt_sexo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 39);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "Sexo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(25, 67);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 6;
            // 
            // txt_habitat
            // 
            txt_habitat.Location = new Point(25, 184);
            txt_habitat.Name = "txt_habitat";
            txt_habitat.Size = new Size(246, 23);
            txt_habitat.TabIndex = 5;
            // 
            // btn_excluir
            // 
            btn_excluir.Image = Properties.Resources.lixo;
            btn_excluir.Location = new Point(408, 227);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(121, 51);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "Excluir";
            btn_excluir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_consulta
            // 
            btn_consulta.Image = Properties.Resources.lupa;
            btn_consulta.Location = new Point(281, 227);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(121, 51);
            btn_consulta.TabIndex = 2;
            btn_consulta.Text = "Consultar";
            btn_consulta.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consulta.UseVisualStyleBackColor = true;
            btn_consulta.Click += btn_consulta_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Image = Properties.Resources.disquete;
            btn_salvar.Location = new Point(154, 227);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(121, 51);
            btn_salvar.TabIndex = 1;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(25, 242);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(535, 136);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txt_peso;
        private Label label5;
        private Label label6;
        private TextBox txt_compri;
        private Label label3;
        private TextBox txt_sexo;
        private Label label2;
        private Label label1;
        private TextBox txt_nome;
        private TextBox txt_habitat;
        private Button btn_excluir;
        private Button btn_consulta;
        private Button btn_salvar;
        private TextBox txt_id;
        private DataGridView dataGridView1;
    }
}
