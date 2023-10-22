using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Chapters.Book_2_Chapter_5
{
    internal class RepairTypes
    {
        private RepairServicesDataSetTableAdapters.RepairTypesTableAdapter
                        adapter = new RepairServicesDataSetTableAdapters.
                        RepairTypesTableAdapter();

        public DataTable Items
        {
            get
            {
                DataTable table = adapter.GetData();
                table.DefaultView.Sort = "Description";
                return table;
            }
        }
    }
}
