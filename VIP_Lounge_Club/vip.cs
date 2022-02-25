using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VIP_Lounge_Club
{
    class vip
    {
        public int Cpf { get; set; }
        public string nome { get; set; }
        public string nascimento { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string cidade { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\CRUD_PLayer\\DbVip.mdf;Integrated Security=True");

        public List<Vip> listavip()
        {
            List<Vip> li = new List<Vip>();
            string sql = "SELECT * FROM ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Vip v = new Vip();
                v.Id = (int)dr["Id"];
                v.nome = dr["nome"].ToString();
                v.cidade = dr["cidade"].ToString();
                v.email = dr["email"].ToString();
                v.celular = dr["celular"].ToString();
                li.Add(v);
            }
            return li;
        }

        public void Inserir(string nome, int nascimento, string celular, string email, string cidade)
        {
            string sql = "INSERT INTO Vip(nome,cidade,email,celular) VALUES ('" + nome + "','" + nascimento + "','" + email + "','" + celular + "','" + cidade + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localiza(int Cpf)
        {
            string sql = "SELECT * FROM Vip WHERE Cpf = '" + Cpf + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                nascimento = dr["nascimento"].ToString();
                email = dr["email"].ToString();
                celular = dr["celular"].ToString();
                cidade = dr["cidade"].ToString();
            }
        }

        public void Atualizar(int Cpf, string nome, string nascimento, string email, string celular, string celular)
        {
            string sql = "UPDATE Vip SET nome='" + nome + "',nascimento='" + nascimento + "',email='" + email + "',celular='" + celular + "',cidade='" + cidade + "'  WHERE Cpf='" + Cpf + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Exclui(int Cpf)
        {
            string sql = "DELETE FROM Vip WHERE Cpf='" + Cpf + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
