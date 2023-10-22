using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Chapters.Book_2_Chapter_5
{
    internal class Customers
    {
        private RepairServicesDataSetTableAdapters.CustomersTableAdapter adapter =
                    new RepairServicesDataSetTableAdapters.CustomersTableAdapter();
        public static string LastError;

        public DataTable Items
        {
            get
            {
                DataTable table = adapter.GetData();
                table.DefaultView.Sort = "Name";
                return table;
            }
        }

        public bool Insert(short custId, string name, string phone)
        {
            try
            {
                LastError = String.Empty;
                adapter.Insert(custId, name, phone);
                return true;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return false;
            }
        }

        public short HighestCustId()
        {
            short input = (short)adapter.GetHighestCustId();
            return input;
        }

        public bool UpdateInfo(string name, string phone, short custId)
        {
            LastError = String.Empty;
            try
            {
                int recs = adapter.UpdateInfo(name, phone, custId);
                if (recs > 0) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return false;
            }
        }

        public RepairServicesDataSet.CustomersRow FindByCustId(short custId)
        {
            RepairServicesDataSet.CustomersDataTable table = new
            RepairServicesDataSet.CustomersDataTable();
            table = adapter.GetData();
            return table.FindByCustId(custId);
        }
    }
}
