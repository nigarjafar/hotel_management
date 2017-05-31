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

namespace HotelManagement
{
    class Database
    {
        public SqlConnection con;

        public Database()
        {
            try {
                String str = "server=DESKTOP-EHOD9B9\\SQLEXPRESS;database=hotel_management;UID=sa;password=Lenovo";
                SqlConnection con = new SqlConnection(str);
                this.con = con;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public DataTable Read(string query)
        {
            DataTable dt=new DataTable();
            using (this.con)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    try
                    {
                      
                        dt.Load(cmd.ExecuteReader());
                        return dt;
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                        return null;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        public void Insert(string table, Dictionary<string, string> data )
        {
            StringBuilder query = new StringBuilder();
            StringBuilder columns = new StringBuilder();
            StringBuilder values = new StringBuilder();

            foreach (var column in data.Keys)
            {
                columns.Append(column);
                values.Append('@' + column);

                if (!column.Equals(data.Last().Key))
                {
                    columns.Append(',');
                    values.Append(',');
                }
            }

            query.Append(String.Format("INSERT INTO {0} ({1}) VALUES ({2})", table, columns, values));
            
            using (con)

            {
                using (SqlCommand command = new SqlCommand(query.ToString(),con))
                {
                    
                    foreach (var datum in data)
                    {
                        command.Parameters.AddWithValue("@" + datum.Key, datum.Value);
                    }
             
                    try
                    {
                       con.Open();
                       int recordsAffected = command.ExecuteNonQuery();
                       MessageBox.Show("ok data is saved");
                    }
                    catch (SqlException es)
                    {
                        MessageBox.Show(es.Message);
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }

        }

        public void Delete(string table,int id)
        {
            string query = "DELETE FROM " + table + " WHERE id=" + id;
            using (this.con)
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void Update(string table, Dictionary<string, string> data,Dictionary<string, string> where)
        {
            StringBuilder query = new StringBuilder();
            StringBuilder values = new StringBuilder();
            StringBuilder wherePart = new StringBuilder();

            foreach (var column in data.Keys)
            {
            
                values.Append(column+"=@"+column);

                if (!column.Equals(data.Last().Key))
                {
                    values.Append(',');
                }
            }

            foreach (var column in where.Keys)
            {

                wherePart.Append(column + "=@" + column);

                if (!column.Equals(where.Last().Key))
                {
                    wherePart.Append("AND");
                }
            }

            query.Append(String.Format("UPDATE  {0} SET {1} WHERE  {2}", table, values, wherePart));
            using (con)

            {
                using (SqlCommand command = new SqlCommand(query.ToString()))
                {
                    command.Connection = con;
                    foreach (var datum in data)
                    {
                        command.Parameters.AddWithValue("@" + datum.Key, datum.Value);
                      
                    }
                    foreach (var datum in where)
                    {
                        command.Parameters.AddWithValue("@" + datum.Key, datum.Value);
                    }

                    try
                    {
                        con.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("ok data is updated");
                    }
                    catch (SqlException es)
                    {
                        MessageBox.Show(es.Message);
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }
        }




    }
}
