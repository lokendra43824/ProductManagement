using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Linq
{
    public class Management
    {

        public List<ProductReview> GetTopThreeRatedProducts(List<ProductReview> productReview)
        {
            var result = (from product in productReview
                          orderby product.Rating descending
                          select product).Take(3);

            return result.ToList();
        }


        public List<ProductReview> GetRatedMoreThan3AndProductId1Or4Or9(List<ProductReview> product_Review)
        {
            var result = (from product in product_Review
                          where product.Rating > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9)
                          select product).ToList();

            return result;
        }



        public void RetrieveCount(List<ProductReview> productReview)
        {


            var result = productReview.GroupBy(x => x.ProductId)
                         .Select(x => new { productId = x.Key, count = x.Count() });
            Console.WriteLine("productId" + "\t " + "NoOfReviews");
            foreach (var x in result)
            {
                Console.WriteLine("   " + x.productId + "\t\t    " + x.count);
            }
        }


        public void RetrieveproductIdAndReview(List<ProductReview> product_Review)
        {
            var result = product_Review.Select(x => new { productId = x.ProductId, review = x.Review });

            foreach (var element in result)
            {
                Console.WriteLine(element.productId + " " + element.review);
            }

        }





    }
}

