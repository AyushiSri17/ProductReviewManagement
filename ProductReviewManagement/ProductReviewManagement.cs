using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewManagement
    {
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
    }
}
