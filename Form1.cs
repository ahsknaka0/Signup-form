using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Signup_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6EH655J8\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
            con.Open();
            MessageBox.Show(" Sign-up Successfully");
            SqlCommand cm;
            string id = textBox1.Text; 
            int idd = Convert.ToInt32(id); 
            string nm = textBox2.Text;
            string em = textBox3.Text;
            string pw = textBox4.Text;
            String query = "Insert into Employee(ID,Name,Email,Password) values(" + id + ",'" + nm + "' ,'" + em + "' , '" + pw + "')";
            cm = new SqlCommand(query,con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
        }
    }
}