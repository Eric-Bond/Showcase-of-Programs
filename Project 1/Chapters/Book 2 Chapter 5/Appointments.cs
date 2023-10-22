using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Chapters.Book_2_Chapter_5
{
    internal class Appointments
    {
        private RepairServicesDataSetTableAdapters.AppointmentsTableAdapter adapter
        = new RepairServicesDataSetTableAdapters.AppointmentsTableAdapter();
        public static string LastError;

        public bool Insert(short typeId, string description, bool licensed, short custId, DateTime Scheduled)
        {
            try
            {
                LastError = String.Empty;
                adapter.Insert(typeId, description, licensed, custId, Scheduled);
                return true;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return false;
            }
        }
        public static DateTime CombinedDateTime(DateTime aDate, DateTime aTime)
        {
            TimeSpan ts = new TimeSpan(aTime.Hour, aTime.Minute, 0);
            return aDate.Add(ts);
        }

        public DataTable Items
        { get { return adapter.GetData(); } }

        public DataTable GetByCustomerId(short custId)
        {
            DataTable table = adapter.GetData();
            table.DefaultView.RowFilter = "CustId = " + custId;
            return table;
        }

        public bool Update(short typeId, string description, bool licensed, short custId, DateTime Scheduled, int apptId)
        {
            LastError = String.Empty;
            try
            {
                adapter.Update(typeId, description, licensed, custId, Scheduled, apptId);
                return true;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return false;
            }
        }

        public RepairServicesDataSet.AppointmentsRow FindByApptId(short apptId)
        {
            RepairServicesDataSet.AppointmentsDataTable table = new
            RepairServicesDataSet.AppointmentsDataTable();
            table = adapter.GetData();
            return table.FindByApptId(apptId);
        }

        public bool Delete(int apptId)
        {
            int rowsAffected = adapter.Delete(apptId);
            return (rowsAffected > 0);
        }

        public DataTable AppointmentList
        {
            get
            {
                RepairServicesDataSetTableAdapters.AppointmentListTableAdapter
                listAdapter = new
                RepairServicesDataSetTableAdapters.AppointmentListTableAdapter();
                return listAdapter.GetData();
            }
        }

        public DataTable GetByRepairType(short typeId)
        {
            DataTable table = adapter.GetData();
            table.DefaultView.RowFilter = "TypeId = " + typeId;
            return table;
        }
    }
}
