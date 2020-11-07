using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Linq
{
    class DataTableManagement
    {

        public static DataTable table = new DataTable();
      //uc-8
        public void addDataTable()
        {
            table.Columns.Add("productId");
            table.Columns.Add("userId");
            table.Columns.Add("rating");
            table.Columns.Add("review");
            table.Columns.Add("isAlike");

            table.Rows.Add(1, 100, 4, "Good", true);
            table.Rows.Add(2, 101, 4, "Good", true);
            table.Rows.Add(3, 102, 3, "Good", true);
            table.Rows.Add(4, 103, 5, "Amazing", true);
            table.Rows.Add(5, 100, 1, "Worst", false);
            table.Rows.Add(6, 105, 4, "Good", true);
            table.Rows.Add(7, 106, 2, "Avg", false);
            table.Rows.Add(8, 102, 3, "Avg", false);
            table.Rows.Add(9, 108, 3, "Nice", false);
            table.Rows.Add(10, 104, 5, "Good", true);
            table.Rows.Add(11, 110, 4, "Good", true);
            table.Rows.Add(12, 106, 3, "Good", true);
            table.Rows.Add(3, 101, 1, "Bad", false);
            table.Rows.Add(11, 106, 4, "Good", true);
            table.Rows.Add(10, 101, 1, "Bad", false);

        }
        public void displayDataTable()
        {
            addDataTable();
            var result = table.AsEnumerable().Select(row => new
            {
                productId = Convert.ToInt32(row["productId"]),
                userId = Convert.ToInt32(row["userId"]),
                rating = Convert.ToInt32(row["rating"]),
                review = row["review"].ToString(),
                isALike = Convert.ToBoolean(row["isAlike"])
            });

            foreach (var element in result)
            {
                Console.WriteLine(element.productId + " " + " " + element.userId + " " + element.rating + "  " + element.review + " " + element.isALike);
            }
        }
    }
}
