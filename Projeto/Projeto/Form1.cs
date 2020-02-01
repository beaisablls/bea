using Projeto.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class FrmLogin : Form
    {
        Usuario usr;
        Conexao con;

        public FrmLogin()
        {
            InitializeComponent();
            usr = new Usuario();
            con = new Conexao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lerDados();
            String hashSenha = CryopHash.ComputeSha256Hash(usr.senha);
            if (con.OpenConnection())
            {
                MessageBox.Show("Conectou");
            }
            else
            {
                MessageBox.Show("Não conectou");
            }


            String sql = $"select * from tb_usuario where usuario = '{usr.User}' and senha = '{hashSenha}' and status = true";
            //Console.WriteLine(sql);
            MySqlDataReader reader;

            reader = con.executeQuery(sql);

            //Console.WriteLine(qtd);


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(1));
                }
                //Console.WriteLine(tString());
                MessageBox.Show("Logou com sucesso!");
            }
            else
            {
                MessageBox.Show("Não logou");
            }
        }

        private void lerDados()
        {
            usr.User = textBox1.Text.Trim();
            usr.senha = txtbuton.Text.Trim();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}