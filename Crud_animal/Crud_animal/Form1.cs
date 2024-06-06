namespace Crud_animal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        animal a = new animal();

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                a.setNome(txt_nome.Text);
                a.setSexo(txt_sexo.Text);
                a.setComprimento(txt_compri.Text);
                a.setPeso(txt_peso.Text);
                a.setHabitat(txt_habitat.Text);
                //chamar o metodo inserir
                a.inserir();
            }
            finally
            {
                MessageBox.Show("informações gravadas com sucesso");
            }
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                a.setCodigo(txt_id.Text);
                a.excluir();
                dataGridView1.DataSource = a.Consultar();
            }
            finally
            {
                MessageBox.Show("informações excluídas com sucesso");
            }
        }
    }
}
