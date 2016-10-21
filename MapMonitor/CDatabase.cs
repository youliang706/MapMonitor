using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace Com.Database
{
    internal class CDatabase
    {
        //构造函数
        public CDatabase() { }

        //析构函数
        ~CDatabase()
        {
            mConn = null;
        }

        static OracleConnection mConn;

        //创建数据库连接
        public bool CreateConn(string connectionString)
        {
            try
            {
                mConn = new OracleConnection(connectionString);

                mConn.Open();
                mConn.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Execute(params string[] sql)
        {
            try
            {
                mConn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }

            //创建事物
            OracleTransaction st = mConn.BeginTransaction();

            OracleCommand command = new OracleCommand();
            command.Connection = mConn;
            command.Transaction = st;

            try
            {
                for (int i = 0; i < sql.Length; i++)
                {
                    command.CommandText = sql[i];
                    Console.WriteLine(command.CommandText);
                    command.ExecuteNonQuery();
                }

                //提交事物
                st.Commit();
            }
            catch (Exception ex)
            {
                //回滚事物
                st.Rollback();
                mConn.Close();
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
        }

        public void Execute(List<string> sql)
        {
            try
            {
                mConn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }

            //创建事物
            OracleTransaction st = mConn.BeginTransaction();

            OracleCommand command = new OracleCommand();
            command.Connection = mConn;
            command.Transaction = st;

            try
            {
                for (int i = 0; i < sql.Count; i++)
                {
                    command.CommandText = sql[i];
                    Console.WriteLine(command.CommandText);
                    command.ExecuteNonQuery();
                }

                //提交事物
                st.Commit();
            }
            catch (Exception ex)
            {
                //回滚事物
                st.Rollback();
                mConn.Close();
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
        }

        public DataTable GetRs(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                mConn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.TableMappings.Add("Table", "rs");

                OracleCommand command = new OracleCommand(sql, mConn);
                command.CommandType = CommandType.Text;

                adapter.SelectCommand = command;

                DataSet dataSet = new DataSet("rs");
                adapter.Fill(dataSet);

                dt = dataSet.Tables["rs"];
            }
            catch (Exception ex)
            {
                mConn.Close();
                throw ex;
            }
            finally
            {
                mConn.Close();
            }

            return dt;
        }

        public DataSet GetDs(string table)
        {
            DataSet ds = new DataSet();

            try
            {
                mConn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }

            try
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.TableMappings.Add("Table", "rs");

                OracleCommand command = new OracleCommand("SELECT * FROM " + table + " WHERE ROWNUM = 0", mConn);
                command.CommandType = CommandType.Text;

                adapter.SelectCommand = command;

                DataSet dataSet = new DataSet("rs");
                adapter.FillSchema(ds, SchemaType.Source);
            }
            catch (Exception ex)
            {
                mConn.Close();
                throw ex;
            }
            finally
            {
                mConn.Close();
            }

            return ds;
        }
    }
}
