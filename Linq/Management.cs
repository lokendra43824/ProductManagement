using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Linq
{
    public class Management
    {
        public readonly DataTable data = new DataTable();
        public void TopThreeRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("rating:" + list.Rating + " " + "ID: " + list.ProductId + " " + list.Review);
                 
            }
        }

    } }

