using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca de conexão do SQL
using MySql.Data;
using MySql.Data.MySqlClient;

//adicionar a biblioteca para visualizar os dados na DataGridView
using System.Data;

namespace Crud_animal
{
    internal class animal : Conexao
    {
        private string nome;
        private string sexo;
        private string habitat;
        private string comprimento;
        private string peso;
        private string codigo;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return this.sexo;
        }
        public void setHabitat(string habitat)
        {
            this.habitat = habitat;
        }
        public string getHabitat()
        {
            return this.habitat;
        }
        public void setComprimento(string comprimento)
        {
            this.comprimento = comprimento;
        }
        public string getComprimento()
        {
            return this.comprimento;
        }
        public void setPeso(string peso)
        {
            this.peso = peso;
        }
        public string getPeso()
        {
            return this.peso;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }
        //criação do metodo iserir()
        public void inserir()
        {
            string query = "insert into peixe_lambari (nome , sexo , habitat, comprimento, peso)values('" + getNome() + "','" + getSexo() + "','" + getHabitat() + "','" + getComprimento() + "','" + getPeso() +"')";
            //abrir conexão, enviar ao banco de dados e fechar conexão
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
        public void excluir()
        {
            string query = "delete from peixe_lambari where codigo_lambari = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from peixe_lambari";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            //visualizar os dados partir da select
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
