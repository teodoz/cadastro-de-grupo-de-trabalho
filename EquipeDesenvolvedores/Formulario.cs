using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipeDesenvolvedores
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saulo Teodoz\source\repos\EquipeDesenvolvedores\EquipeDesenvolvedores\database\equipe.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue700, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        public void mostrarDados()
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from devs";
            command.ExecuteNonQuery();
            DataTable tabela = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(command);
            adaptador.Fill(tabela);
            lista.DataSource = tabela;
            ra.Enabled = true;
            inserir.Visible = true;
            atualizar.Visible = false;
            excluir.Visible = false;
            cancelar.Visible = false;
            nome.Focus();

            connection.Close();

        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow item = this.lista.Rows[e.RowIndex];
                ra.Text = item.Cells["ra"].Value.ToString();
                nome.Text = item.Cells["nome"].Value.ToString();
                funcao.Text = item.Cells["funcao"].Value.ToString();
                email.Text = item.Cells["email"].Value.ToString();
                ra.Enabled = false;
                inserir.Visible = false;
                atualizar.Visible = true;
                excluir.Visible = true;
                cancelar.Visible = true;

            }
        }

        private void inserir_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            if (string.IsNullOrWhiteSpace(nome.Text) || string.IsNullOrWhiteSpace(ra.Text) || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(funcao.Text))
            {
                connection.Close();
                MessageBox.Show("Todos os campos devem ser preenchidos!", "ERRO");
            }
            else
            {
                try
                {
                
                command.CommandText = "insert into devs values('" + ra.Text + "', '" + nome.Text + "', '" + funcao.Text + "', '" + email.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                nome.Text = "";
                ra.Text = "";
                funcao.Text = "";
                email.Text = "";
                mostrarDados();
                MessageBox.Show("Membro cadastrado com sucesso!", "AVISO");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        connection.Close();
                        MessageBox.Show("RA já cadastrado!", "ERRO");
                        ra.Text = "";
                        ra.Focus();
                    }
                    else if (ex.Number == 8114)
                    {
                        connection.Close();
                        MessageBox.Show("O RA somente pode conter números!", "ERRO");
                        ra.Text = "";
                        ra.Focus();
                    }
                    else throw;
                }

            }

        }

        private void excluir_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            var confirmarExclusao = MessageBox.Show("Tem certeza que deseja excluir este membro?", "Excluir Membro",
                                     MessageBoxButtons.YesNo);
            if (confirmarExclusao == DialogResult.Yes)
            {

            command.CommandText = "delete from devs where ra='" + ra.Text + "'";
            command.ExecuteNonQuery();
            connection.Close();
            nome.Text = "";
            ra.Text = "";
            funcao.Text = "";
            email.Text = "";
            mostrarDados();
            inserir.Visible = true;
            MessageBox.Show("Membro excluído com sucesso!", "AVISO");
            }
            else
            {
                connection.Close();
            }

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            if (string.IsNullOrWhiteSpace(nome.Text) || string.IsNullOrWhiteSpace(ra.Text) || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(funcao.Text))
            {
                connection.Close();
                MessageBox.Show("Todos os campos devem ser preenchidos!", "AVISO");
            }
            else
            {
                command.CommandText = "update devs set nome='" + nome.Text + "', funcao='" + funcao.Text + "', email='" + email.Text + "' where ra='" + ra.Text + "'";
                command.ExecuteNonQuery();
                connection.Close();
                nome.Text = "";
                ra.Text = "";
                funcao.Text = "";
                email.Text = "";
                mostrarDados();
                inserir.Visible = true;
                MessageBox.Show("Membro atualizado com sucesso!", "AVISO");
            }

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            if (string.IsNullOrWhiteSpace(campoBusca.Text))
            {
                connection.Close();
                MessageBox.Show("Por favor, preencha o RA para busca", "AVISO");
                campoBusca.Focus();
            }
            else
            {
                try
                {
                    command.CommandText = "select * from devs where ra = '" + campoBusca.Text + "'";
                    command.ExecuteNonQuery();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(command);
                    adaptador.Fill(tabela);
                    lista.DataSource = tabela;

                    connection.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 8114)
                    {
                        connection.Close();
                        MessageBox.Show("O RA somente pode conter números!", "ERRO");
                        campoBusca.Text = "";
                        campoBusca.Focus();
                    }
                }
            }

        }

        private void listarTodos_Click(object sender, EventArgs e)
        {
            mostrarDados();
            nome.Text = "";
            ra.Text = "";
            funcao.Text = "";
            email.Text = "";
            campoBusca.Text = "";

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            mostrarDados();
            nome.Text = "";
            ra.Text = "";
            funcao.Text = "";
            email.Text = "";
            campoBusca.Text = "";

        }
    }
}
