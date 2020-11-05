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
                 new ProductReview(){ProductId = 4, UserId = 4, Rating = 2, Review = "low", isLike = true },
                 new ProductReview(){ProductId = 5, UserId = 5, Rating = 1, Review = "flop", isLike = true },
            };
            //foreach (var list in productReviewList)
            // {
            // Console.WriteLine("ProductId:" + list.ProductId + " " + "userId: " + list.UserId);
            //}
            Management management = new Management();
            management.TopThreeRecords(productReviewList);
        }
    } }
