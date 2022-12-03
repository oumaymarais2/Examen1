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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'exameDataSet.EX' table. You can move, or remove it, as needed.
			this.eXTableAdapter.Fill(this.exameDataSet.EX);
			// TODO: This line of code loads data into the 'examenDataSet.EXM' table. You can move, or remove it, as needed.
			this.eXMTableAdapter.Fill(this.examenDataSet.EXM);

        }

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-64KR7SG\\SQLEXPRESS;Initial Catalog=Examen;Integrated Security=True");
			con.Open();
			SqlCommand cmd = new SqlCommand("insert into EXM values('" + int.(textBox1.Text )+ "', '" +int.Parse( textBox2.Text )+ "', '" + textBox3.Text + "', '" + textBox4.Text+ "', '" + textBox5.Text + "')", con);

			MessageBox.Show(cmd.CommandText);
			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("seccesfully insert");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();

		}
	}
}
