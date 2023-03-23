using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem");

            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() {ProductId=3, UserId=1, IsLike=true, Review ="Good", Rating=80},
                new ProductReview() {ProductId=1, UserId=2, IsLike=false, Review="Bad", Rating=20},
                new ProductReview() {ProductId=4, UserId=3, IsLike=true, Review ="Average", Rating=50},
                new ProductReview() {ProductId=2, UserId=4, IsLike=true, Review="Good", Rating=90},
                new ProductReview() {ProductId=5, UserId=5, IsLike=true, Review ="Average", Rating=60},
                new ProductReview() {ProductId=1, UserId=6, IsLike=false, Review="Bad", Rating=30},
                new ProductReview() {ProductId=5, UserId=7, IsLike=true, Review ="Good", Rating=80},
                new ProductReview() {ProductId=6, UserId=8, IsLike=false, Review="Bad", Rating=10},
                new ProductReview() {ProductId=7, UserId=9, IsLike=true, Review ="Average", Rating=65},
                new ProductReview() {ProductId=3, UserId=10, IsLike=false, Review="Bad", Rating=15},
                new ProductReview() {ProductId=5, UserId=11, IsLike=true, Review="Good", Rating=85},
                new ProductReview() {ProductId=8, UserId=12, IsLike=true, Review="Nice", Rating=51}
            };
            Console.WriteLine("Please Select options");
            Console.WriteLine("1. Display all data");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Displaying all review\n");
                    DisplayProductReviews(list);
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
            Console.ReadLine();           
        }
        public static void DisplayProductReviews(List<ProductReview> list)
        {
            foreach (ProductReview productReview in list)
            {
                Console.WriteLine(productReview);
            }
        }
    }
}
