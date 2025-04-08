using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaTools
{
    public partial class FrmSearch: Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yn = MessageBox.Show("查询时间会比较长，需要耐心等候，是否执行查询？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yn == DialogResult.Yes)
            {
                string searchValue = textBox1.Text.Trim();
                if (string.IsNullOrEmpty(searchValue))
                {
                    MessageBox.Show("请输入查询条件。");
                    return;
                }   
                SearchStringInDatabase search = new SearchStringInDatabase();
                if (radioButton2.Checked)
                {
                    search.SearchEqual(Properties.Settings.Default.K3C90ConnectionString, searchValue, this.dsK3Cloud);
                }
                else
                    search.SearchLike(Properties.Settings.Default.K3C90ConnectionString, searchValue, this.dsK3Cloud);

            }
            MessageBox.Show("查询完成。");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var drv = this.t_SearchBindingSource.Current as DataRowView;
            if (drv != null)
            {
                string sql = drv["SqlString"].ToString();
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.K3C90ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {               
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }


            }
        }
    }
}
