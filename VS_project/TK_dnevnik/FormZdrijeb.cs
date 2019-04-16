using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TK_dnevnik
{
    public partial class FormZdrijeb : Form
    {
        public FormZdrijeb()
        {
            InitializeComponent();
        }

        //textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //if (textBox1.Text.Length >= 3)
        //{
        //    textBox1.AutoCompleteCustomSource = GetCustomerInfo(textBox1.Text);
        //}
        //else
        //{
        //    textBox1.AutoCompleteCustomSource = null;
        //}

        //public List<string> GetCustomerInfo(string custName)
        //{
        //    List<string> result = new List<string>();
        //    string sql = "Select Name from Customers Where Name like @partName";
        //    using (SqlConnection con = GetConnection())
        //    using (SqlCommand cmd = new SqlCommand(sql, con))
        //    {
        //        con.Open();
        //        cmd.Parameters.AddWithValue("@partName", custName + "%");
        //        using (SqlDataReader r = cmd.ExecuteReader())
        //        {
        //            while (r.Read())
        //            {
        //                if (!r.IsDbNull(0))
        //                {
        //                    result.Add(r.GetString(0));
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
