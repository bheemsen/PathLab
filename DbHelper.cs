using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Web;

using System.Collections;

/// <summary>
///ConnectionForm provides methods to Connect And fetch or update database
/// </summary>
public class DbHelper : IDisposable
{
    private OleDbConnection con = new OleDbConnection();
    private OleDbCommand cmd = new OleDbCommand();
    private OleDbDataAdapter da = new OleDbDataAdapter();
    private DataSet ds = new DataSet();
    private string ExInfo = null;

    public string ExceptionInfo
    {
        set
        {
            ExInfo = value;
        }

        get
        {
            return ExInfo;
        }
    }

    public DbHelper()
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        cmd.Connection = con;
        da.SelectCommand = cmd;
    }

    /// <summary>
    /// Method to get multiple records from database according to SQL Query.
    /// </summary>
    /// <param name="Query">SQL Query to execute.</param>
    /// <param name="AliasName">Virtual table name.</param>
    /// <returns>System.Data.DataSet</returns>

    OleDbTransaction objTransaction;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Query">SQL Query to execute.</param>
    /// <returns></returns>
    public bool NonQuery(string Query)
    {

        try
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            objTransaction = con.BeginTransaction();
            cmd.Transaction = objTransaction;
            cmd.CommandText = Query;
            int Result = cmd.ExecuteNonQuery();
            if (Result > 0)
            {
                objTransaction.Commit();
                return true;
            }
            else
            {
                objTransaction.Rollback();
                return false;
            }
        }
        catch (Exception ex)
        {
            objTransaction.Rollback();
            ExceptionInfo = ex.Message;
            return false;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Query">SQL Query to execute.</param>
    /// <returns></returns>
    public bool NonQuery(string ProcedureName, OleDbParameter[] Parameters)
    {

        try
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            if (con.State == ConnectionState.Closed)
                con.Open();
            objTransaction = con.BeginTransaction();
            cmd.Transaction = objTransaction;
            cmd.CommandText = ProcedureName;
            if (Parameters != null)
                cmd.Parameters.AddRange(Parameters);
            int Result = cmd.ExecuteNonQuery();
            if (Result > 0)
            {
                objTransaction.Commit();
                return true;
            }
            else
            {
                objTransaction.Rollback();
                return false;
            }
        }
        catch (Exception ex)
        {
            objTransaction.Rollback();
            ExceptionInfo = ex.Message;
            return false;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public bool NonQuery(string[] ProcedureName, OleDbParameter[][] Parameters)
    {

        try
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            if (con.State == ConnectionState.Closed)
                con.Open();
            objTransaction = con.BeginTransaction();
            cmd.Transaction = objTransaction;
            int i = 0;
            int flag = 0;
            foreach (string Procedure in ProcedureName)
            {
                cmd.CommandText = Procedure;
                cmd.Parameters.Clear();
                if (Parameters[i] != null)
                    cmd.Parameters.AddRange(Parameters[i]);
                int Result = cmd.ExecuteNonQuery();
                if (Result > 0)
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                    break;
                }
                i++;
            }
            if (flag == 0)
            {
                objTransaction.Commit();
                return true;
            }
            else
            {
                objTransaction.Rollback();
                return false;
            }
        }
        catch (Exception ex)
        {
            objTransaction.Rollback();
            ExceptionInfo = ex.Message;
            return false;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public int ExecuteNonQuery(string ProcedureName, params OleDbParameter[] Parameters)
    {
        int Result = 0;
        try
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            objTransaction = con.BeginTransaction();
            cmd.Transaction = objTransaction;
            cmd.CommandText = ProcedureName;
            if (Parameters != null)
            {
                cmd.Parameters.AddRange(Parameters);
            }
            Result = cmd.ExecuteNonQuery();
            if (Result > 0)
            {
                objTransaction.Commit();

            }
            else
            {
                objTransaction.Rollback();

            }
        }
        catch (Exception ex)
        {
            objTransaction.Rollback();
            ExceptionInfo = ex.Message;

        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        return Result;
    }

    public object GetScaler(string Query)
    {
        try
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            objTransaction = con.BeginTransaction();

            cmd.Transaction = objTransaction;
            cmd.CommandText = Query;
            object Result = cmd.ExecuteScalar();
            if (Result != null)
            {
                objTransaction.Commit();
                return Result;
            }
            else
            {
                objTransaction.Rollback();
                return Result;
            }
        }
        catch (Exception ex)
        {
            objTransaction.Rollback();
            ExceptionInfo = ex.Message;
            return false;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public object GetScaler(string ProcedureName, params OleDbParameter[] Parameters)
    {
        try
        {

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            if (con.State == ConnectionState.Closed)
                con.Open();
            objTransaction = con.BeginTransaction();
            cmd.Transaction = objTransaction;
            cmd.CommandText = ProcedureName;
            if (Parameters != null)
                cmd.Parameters.AddRange(Parameters);
            object Result = cmd.ExecuteScalar();
            if (Result != null)
            {
                objTransaction.Commit();
                return Result;
            }
            else
            {
                objTransaction.Rollback();
                return Result;
            }
        }
        catch (Exception ex)
        {
            objTransaction.Rollback();
            ExceptionInfo = ex.Message;
            return false;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public DataSet ExecuteDataSet(string ProcedureName, OleDbParameter[] Params_Array, string AliasName)
    {
        try
        {
            ds.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ProcedureName;
            if (Params_Array != null)
                cmd.Parameters.AddRange(Params_Array);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, AliasName);
            return ds;
        }
        catch (Exception ex)
        {
            ExceptionInfo = ex.Message;
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public DataSet ExecuteDataSet(string ProcedureName, params OleDbParameter[] Params_Array)
    {
        try
        {
            //ds.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ProcedureName;
            if (Params_Array != null)
                cmd.Parameters.AddRange(Params_Array);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            ExceptionInfo = ex.Message;
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public void ClearTable(string TableName)
    {
        if (ds.Tables.Contains(TableName))
            ds.Tables[TableName].Clear();
    }

    public DataSet GetDataSet(string Query, string AliasName)
    {
        try
        {
           // ds.Clear();
            cmd.CommandText = Query;
            da.Fill(ds, AliasName);
            return ds;
        }
        catch (Exception ex)
        {
            ExceptionInfo = ex.Message;
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public DataTable GetTable(string Query)
    {
        try
        {
            ds.Clear();
            cmd.CommandText = Query;
            da.Fill(ds);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            ExceptionInfo = ex.Message;
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public DataSet GetDataSet2(string ProcedureName, OleDbParameter[] Params_Array, string AliasName)
    {
        try
        {
            //ds.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ProcedureName;
            if (Params_Array != null)
                cmd.Parameters.AddRange(Params_Array);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, AliasName);
            return ds;
        }
        catch (Exception ex)
        {
            ExceptionInfo = ex.Message;
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public bool TruncateTable(string tableName)
    {
        bool result;
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "TRUNCATE TABLE " + tableName;
            cmd.ExecuteNonQuery();
            result = true;
        }
        catch (Exception ex)
        {
            result = false;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        return result;
    }

    public void Dispose()
    {
        if (con != null)
        {
            con.Dispose();
        }
        if (cmd != null)
        {
            cmd.Dispose();
        }
        if (da != null)
        {
            da.Dispose();
        }
        if (ds != null)
        {
            ds.Dispose();
        }
    }
}