using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewManagement
    {
        //-----------------------UC-2---------------------------
        public static void RetreiveTop3Records(List<ProductReview> list)
        {
            Console.WriteLine("LINQ method Syntax\n");
            List<ProductReview> sortedInDesending = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProductReviews(sortedInDesending);
            //Console.WriteLine("\n");
            //List<ProductReview> top3 = sortedInDesending.Take(3).ToList();//ToList conversion because return type is IEnumerable
            //Program.DisplayProductReviews(top3);
            Console.WriteLine("LINQ Query Syntax\n");
            List<ProductReview> result = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            Program.DisplayProductReviews(result);
        }
        //-----------------------UC-3---------------------------
        public static void FetchRecordsBasedOnRatingAndProductId(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9)).ToList();
            Program.DisplayProductReviews(result);
        }
        //-----------------------UC-4---------------------------
        public static void FindingEachCountOfProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(p => p.ProductId).Select(p => new { Id = p.Key, count = p.Count() }).ToList();
            foreach (var product in result)
            {
                Console.WriteLine("ProductId: " + product.Id + " ->  " + "Count: " + product.count);
            }
        }
        //-----------------------UC-5---------------------------
        public static void DisplayProductIdAndReview(List<ProductReview> list)
        {
            var result = list.Select(p => new { Id = p.ProductId, Review = p.Review }).ToList();
            foreach (var product in result)
            {
                Console.WriteLine("ProductId: " + product.Id + " ->  " + "Review: " + product.Review);
            }
        }
        //-----------------------UC-6---------------------------
        public static void SkipTop5Records(List<ProductReview> list)
        {
            List<ProductReview> result = list.Skip(5).ToList();
            Program.DisplayProductReviews(result);
        }
    }
}
