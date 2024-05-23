using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PizzaHut
{
    public class ClsDALPizzaHut
    {
        DataConnection dc;
        SqlDataAdapter da;

        public ClsDALPizzaHut()
        {
            dc = new DataConnection();
        }
        //Load Table
        public DataTable getTableWidget()
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SELECT * FROM DTables Order by ID asc";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Load Menu
        public DataTable getFoodWidget(int categoryID)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SELECT * FROM Menu where CategoryID like " + categoryID + " Order by ID asc";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public List<Tuple<string, float>> getPricebySize(int foodID)
        {
            List<Tuple<string, float>> sizeprice = new List<Tuple<string, float>>();
            string sizename;
            float price;
            SqlConnection con = dc.GetConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT B.SizeName, A.Price FROM PriceProduct A, Size B WHERE A.SizeID = B.SizeID and A.FoodID like " + foodID + " order by B.SizeID asc", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        sizename = dr["SizeName"].ToString();
                        price = float.Parse(dr["Price"].ToString());
                        sizeprice.Add(new Tuple<string, float>(sizename, price));
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return sizeprice;
        }

        public void UpdatePeopleNum(int id, int num)
        {
            SqlConnection con = dc.GetConnect();
            string sql = "UPDATE DTables SET NoofMems = " + num +" where ID like " + id;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetDelivery_Orders(int customerid)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SP_DeliveryOrder";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@customerID", SqlDbType.Int);
            cmd.Parameters["@customerID"].Value = customerid;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void UpdatePeopleStatus(int id, int status)
        {
            SqlConnection con = dc.GetConnect();
            string sql = "UPDATE DTables SET StatusID = " + status + " where ID like " + id;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Get Role ID & Username
        public int getRole(string username, string password)
        {
            int id = -1;
            SqlConnection con = dc.GetConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserName like'" + username + "' and PassWord like '" + password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = int.Parse(dr["RoleID"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        //StartCustomerControlArea
        public DataTable GetCustomersList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SELECT * FROM Customers";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool AddCustomer(string name,string address, string phonenum, string description)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_AddCustomer";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar);
                cmd.Parameters["@CustomerName"].Value = name;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar);
                cmd.Parameters["@Address"].Value = address;
                cmd.Parameters.Add("@Phonenum", SqlDbType.NVarChar);
                cmd.Parameters["@Phonenum"].Value = phonenum;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar);
                cmd.Parameters["@Description"].Value = description;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DelCustomer(int customerID)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_DelCustomer";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = customerID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateCustomer(int customerID, string name, string address, string phonenum, string description)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_UpdateCustomer";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = customerID;
                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar);
                cmd.Parameters["@CustomerName"].Value = name;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar);
                cmd.Parameters["@Address"].Value = address;
                cmd.Parameters.Add("@Phonenum", SqlDbType.NVarChar);
                cmd.Parameters["@Phonenum"].Value = phonenum;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar);
                cmd.Parameters["@Description"].Value = description;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        //EndCustomerControlArea

        //StartTableDetailsArea
        public DataTable GetTable_Orders(int id)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SP_TableOrder";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@tableID", SqlDbType.Int);
            cmd.Parameters["@tableID"].Value = id;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public string GetTableName(int id)
        {
            string name;
            SqlConnection con = dc.GetConnect();
            string sql = "Select TableName from DTables where ID = " + id;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            name = ds.Tables[0].Rows[0]["TableName"].ToString();
            return name;
        }
        public string GetFoodImage_fromOrder(int id)
        {
            string image;
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "Select DISTINCT A.Image from Menu A join PriceProduct B on A.ID = B.FoodID join Order_Product C on C.PriceProductID = B.ID where C.OrderID like " + id;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            image = ds.Tables[0].Rows[0]["Image"].ToString();
            return image;
        }
        public bool AddFoodOrder(int foodID, int sizeID, int tableID, int quantity)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_AddFoodOrder";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@FoodID", SqlDbType.Int);
                cmd.Parameters["@FoodID"].Value = foodID;
                cmd.Parameters.Add("@SizeID", SqlDbType.Int);
                cmd.Parameters["@SizeID"].Value = sizeID;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters["@Quantity"].Value = quantity;
                cmd.Parameters.Add("@TableID", SqlDbType.Int);
                cmd.Parameters["@TableID"].Value = tableID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateFoodQuantity(int orderID, int quantity)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_UpdateFoodQuantity";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@OrderID", SqlDbType.Int);
                cmd.Parameters["@OrderID"].Value = orderID;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters["@Quantity"].Value = quantity;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateDeliveryFoodQuantity(int orderID, int quantity)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_UpdateDeliveryFoodQuantity";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@OrderID", SqlDbType.Int);
                cmd.Parameters["@OrderID"].Value = orderID;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters["@Quantity"].Value = quantity;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //EndTableDetailsArea

        public DataTable GetOrderList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SP_GetOrderList";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetDeliveryOrderList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SP_GetDelieveryOrderList";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool AddDelieveryFoodOrder(int foodID, int sizeID, int customerID, int quantity)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_AddDelieveryOrderbyCustomer";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@FoodID", SqlDbType.Int);
                cmd.Parameters["@FoodID"].Value = foodID;
                cmd.Parameters.Add("@SizeID", SqlDbType.Int);
                cmd.Parameters["@SizeID"].Value = sizeID;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters["@Quantity"].Value = quantity;
                cmd.Parameters.Add("@customerID", SqlDbType.Int);
                cmd.Parameters["@customerID"].Value = customerID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool CreateBillbyTable(int tableid, int customerID, string payment)
        {
            SqlConnection con = dc.GetConnect();
            try
            {
                string sql = "SP_CreateBillbyTable";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@tableID", SqlDbType.Int);
                cmd.Parameters["@tableID"].Value = tableid;
                cmd.Parameters.Add("@payment", SqlDbType.NVarChar);
                cmd.Parameters["@payment"].Value = payment;
                cmd.Parameters.Add("@customerID", SqlDbType.Int);
                cmd.Parameters["@customerID"].Value = customerID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable GetBillList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SELECT * FROM Bills";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetWarehouseProduct()
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnect();
            string sql = "SELECT * FROM WarehouseItems";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}