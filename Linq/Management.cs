using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Linq
{
    public class Management
    {
        //uc-2
        public List<ProductReview> GetTopThreeRatedProducts(List<ProductReview> productReview)
        {
            var result = (from product in productReview
                          orderby product.Rating descending
                          select product).Take(3);

            return result.ToList();
        }

        // uc-3
        public List<ProductReview> GetRatedMoreThan3AndProductId1Or4Or9(List<ProductReview> product_Review)
        {
            var result = (from product in product_Review
                          where product.Rating > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9)
                          select product).ToList();

            return result;
        }


        //uc-4
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
        // uc-5

        public void RetrieveproductIdAndReview(List<ProductReview> product_Review)
        {
            var result = product_Review.Select(x => new { productId = x.ProductId, review = x.Review });

            foreach (var element in result)
            {
                Console.WriteLine(element.productId + " " + element.review);
            }

        }

        //uc-6
        public List<ProductReview> skipTopFiveRecords(List<ProductReview> product_Review)
        {
            var result = (from product in product_Review
                          select product).Skip(5);
            return result.ToList();
        }
       

               // UC 9
        public void IsLikeProducts(List<ProductReview> productReviewsList)
        {
            var records = from product in productReviewsList
                          where product.isLike == true
                          select product;

            Console.WriteLine("Liked Products are");

            foreach (var list in records)
            {
                Console.WriteLine($"ProductId: {list.ProductId}, UserId : {list.UserId}, Rating: {list.Rating}, Review : {list.Review}, IsLike : {list.IsLike}");
            }

        }
        // UC-10
        public void ProductAvarageRating(List<ProductReview> productReviews)
        {
            var records = productReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Average = x.Average() });

            Console.WriteLine("Liked Products are");

            foreach (var list in records)
            {
                Console.WriteLine($"ProductId: {list.ProductId}, Count : {list.Average}");
            }
        }

        //uc-11
        
        public List<ProductReview> ReviewMessageNice(List<ProductReview> product_Review)
        {
            var result = from product in product_Review
                         where product.Review == "Good"
                         select product;
            return result.ToList();
        }
    }


}


