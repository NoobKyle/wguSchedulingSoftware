using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace wguSchedulingSoftware.DataModels
{
	public class Customers
	{
		private static DataTable customersDataTable = new DataTable();

		public static DataTable getAllPartsDataTable()
		{
			//Add colums that do not exist.
			if (!customersDataTable.Columns.Contains("ID")) { customersDataTable.Columns.Add("ID", typeof(int)); }
			if (!customersDataTable.Columns.Contains("Name")) { customersDataTable.Columns.Add("Name", typeof(string)); }
			if (!customersDataTable.Columns.Contains("Address")) { customersDataTable.Columns.Add("Address", typeof(string)); }
			if (!customersDataTable.Columns.Contains("Phone Number")) { customersDataTable.Columns.Add("Phone Number", typeof(string)); }

			return customersDataTable;
		}
	}
}
