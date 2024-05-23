using DAL_PizzaHut;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PizzaHut
{
    public class ClsBLLPizzaHut
    {
        ClsDALPizzaHut dal = new ClsDALPizzaHut();
        public DataTable getTableWidget()
        {
            return dal.getTableWidget();
        }
        public int getRole(string username, string password)
        {
            return dal.getRole(username, password);
        }
        public DataTable getFoodWidget(int categoryID)
        {
            return dal.getFoodWidget(categoryID);
        }
        public List<Tuple<string, float>> getPricebySize(int foodID)
        {
            return dal.getPricebySize(foodID);
        }
        public DataTable GetCustomersList()
        {
            return dal.GetCustomersList();
        }
        public bool AddCustomer(string name, string address, string phonenum, string description)
        {
            return dal.AddCustomer(name, address, phonenum, description);
        }
        public bool DelCustomer(int id)
        {
            return dal.DelCustomer(id);
        }
        public bool UpdateCustomer(int customerID, string name, string address, string phonenum, string description)
        {
            return dal.UpdateCustomer(customerID, name, address, phonenum, description);
        }
        public DataTable GetTable_Orders(int id)
        {
            return dal.GetTable_Orders(id);
        }
        public string GetTableName(int id)
        {
            return dal.GetTableName(id);
        }
        public string GetFoodImage_fromOrder(int id)
        {
            return dal.GetFoodImage_fromOrder(id);
        }
        public bool AddFoodOrder(int foodID, int sizeID, int tableID, int quantity)
        {
            return dal.AddFoodOrder(foodID, sizeID, tableID, quantity);
        }
        public bool UpdateFoodQuantity(int orderID, int quantity)
        {
            return dal.UpdateFoodQuantity(orderID, quantity);
        }
        public bool UpdateDeliveryFoodQuantity(int orderID, int quantity)
        {
            return dal.UpdateDeliveryFoodQuantity(orderID, quantity);
        }
        public DataTable GetOrderList()
        {
            return dal.GetOrderList();
        }
        public DataTable GetDeliveryOrderList()
        {
            return dal.GetDeliveryOrderList();
        }

        public void UpdatePeopleNum(int id, int num)
        {
            dal.UpdatePeopleNum(id, num);
        }
        public void UpdatePeopleStatus(int id, int status)
        {
            dal.UpdatePeopleStatus(id, status);
        }
        public bool AddDelieveryFoodOrder(int foodID, int sizeID, int customerID, int quantity)
        {
            return dal.AddDelieveryFoodOrder(foodID, sizeID, customerID, quantity);
        }

        public DataTable GetDelivery_Orders(int customerid)
        {
            return dal.GetDelivery_Orders(customerid);
        }
        public bool CreateBillbyTable(int tableid, int customerID, string payment)
        {
            return dal.CreateBillbyTable(tableid, customerID, payment);
        }
        public DataTable GetBillList()
        {
            return dal.GetBillList();
        }
        public DataTable GetWarehouseProduct()
        {
            return dal.GetWarehouseProduct();
        }
    }
}
