using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to linq");
            //uc-1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId = 1, UserId = 1, Rating = 5, Review = "excellent", isLike = true },
                 new ProductReview(){ProductId = 2, UserId = 2, Rating = 4, Review = "good", isLike = true },
                 new ProductReview(){ProductId = 3, UserId = 3, Rating = 3, Review = "average", isLike = true },
                 new ProductReview(){ProductId = 4, UserId = 4, Rating = 4, Review = "low", isLike = true },
                 new ProductReview(){ProductId = 5, UserId = 5, Rating = 1, Review = "flop", isLike = true },
                  new ProductReview(){ProductId = 1, UserId = 3, Rating = 4, Review = "excellent", isLike = true },
                 new ProductReview(){ProductId = 2, UserId = 4, Rating = 1, Review = "low", isLike = true },
                 new ProductReview(){ProductId = 3, UserId = 5, Rating = 3, Review = "average", isLike = true },
                 new ProductReview(){ProductId = 4, UserId = 2, Rating = 4, Review = "low", isLike = true },
                 new ProductReview(){ProductId = 5, UserId = 3, Rating = 4, Review = "flop", isLike = true },
            };


            Management management = new Management();






            List<ProductReview> RiviewMessageGood = management.ReviewMessageNice(productReviewList);

            displayList(RiviewMessageGood);
        }

        public static void displayList(List<ProductReview> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("productID : " + "  " + item.ProductId + " user Id: " + "  " + item.UserId + " Rating: " + "  " + item.Rating + " Review: " + "  " + item.Review + " IsLike: " + "  " + item.isLike);
            }
        }

    }


}

