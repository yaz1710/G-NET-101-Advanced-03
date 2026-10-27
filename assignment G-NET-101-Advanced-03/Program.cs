namespace assignment_adv_03
{
 
    internal class program
    {
        static void main(String[] args)

         #region q1 session2
        //            class Product
        //        {
        //            public int Id { get; set; }
        //            public string Name { get; set; }
        //            public string Category { get; set; }
        //            public double Price { get; set; }
        //            public int Stock { get; set; }
        //        }

        //        class Program
        //        {
        //            static List<Product> catalog = new List<Product>
        //{
        //    new Product { Id = 1, Name = "laptop", Category = "electronics", Price = 1200, Stock = 10 },
        //    new Product { Id = 2, Name = "phone", Category = "electronics", Price = 800, Stock = 25 },
        //    new Product { Id = 3, Name = "t--shirt", Category = "clothing", Price = 30, Stock = 100 },
        //    new Product { Id = 4, Name = "jeans", Category = "clothing", Price = 60, Stock = 50 },
        //    new Product { Id = 5, Name = "chocolate", Category = "food", Price = 5, Stock = 200 },
        //    new Product { Id = 6, Name = "coffee Beans", Category = "food   ", Price = 15, Stock = 80 },
        //    new Product { Id = 7, Name = "C# Book", Category = "books", Price = 45, Stock = 30 },
        //    new Product { Id = 8, Name = "novel", Category = "books", Price = 20, Stock = 60 },
        //    new Product { Id = 9, Name = "  headphones", Category = "electronics", Price = 150, Stock = 40 },
        //    new Product { Id = 10, Name = "jacket", Category = "clothing", Price = 90, Stock = 15 }
        //    };


        //            static List<T> TransformProducts<T>(
        //                List<Product> products,
        //                Func<Product, T> function)
        //            {
        //                List<T> result = new List<T>();

        //                foreach (Product p in products)
        //                {
        //                    result.Add(function(p));
        //                }

        //                return result;
        //            }

        //            static void Main(string[] args)
        //            {

        //                Console.WriteLine("--- Summary List ---");

        //                List<string> summary = TransformProducts(
        //                    catalog,
        //                    p => $"{p.Name} (${p.Price})"
        //                );

        //                foreach (string item in summary)
        //                {
        //                    Console.WriteLine(item);
        //                }

        //                Console.WriteLine();


        //                Console.WriteLine("--- Price Labels ---");

        //                List<string> labels = TransformProducts(
        //                    catalog,
        //                    p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}"
        //                );

        //                foreach (string item in labels)
        //                {
        //                    Console.WriteLine(item);
        //                }
        //            }
        //        }
        #endregion
        #region q2 session 2
        //class Product
        //    {
        //        public int Id { get; set; }
        //        public string Name { get; set; }
        //        public string Category { get; set; }
        //        public double Price { get; set; }
        //        public int Stock { get; set; }
        //    }

        //    class Program
        //    {
        //        static List<Product> catalog = new List<Product>
        //    {
        //        new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
        //        new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
        //        new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
        //        new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
        //        new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
        //        new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
        //        new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
        //        new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
        //        new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
        //        new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 90, Stock = 15 }
        //    };


        //        static List<Product> FilterProducts(
        //            List<Product> products,
        //            Predicate<Product> condition)
        //        {
        //            List<Product> result = new List<Product>();

        //            foreach (Product p in products)
        //            {
        //                if (condition(p))
        //                {
        //                    result.Add(p);
        //                }
        //            }

        //            return result;
        //        }

        //        static void Main()
        //        {
        //            Console.WriteLine("--- Low-Stock Alert ---");

        //            List<Product> lowStock = FilterProducts(
        //                catalog,
        //                p => p.Stock < 20
        //            );

        //            foreach (Product p in lowStock)
        //            {
        //                Console.WriteLine(
        //                    $"[LOW STOCK] {p.Name}: only {p.Stock} left!"
        //                );
        //            }
        //        }
        //    }
        #endregion
        #region session 3 q1 :1
        //List<int> grades = new List<int>()
        //{
        //    85, 92, 78, 95, 88, 70, 100, 65
        //};
        #endregion
        #region session 3 q1:2 
        //Console.WriteLine("Original Grades: " + string.Join(", ", grades));
        //Console.WriteLine("Count: " + grades.Count);
        //Console.WriteLine("First Grade: " + grades.First());
        //Console.WriteLine("Last Grade: " + grades.Last());
        #endregion
        #region session 3 q1:3
        //grades.Sort();
        //Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));
        #endregion
        #region session3 q1:4
        //int firstAbove90 = grades.FirstOrDefault(g => g > 90);
        //        Console.WriteLine("First Grade Above 90: " + firstAbove90);
        #endregion
        #region session3 q1:5
        //List<int> failingGrades = grades.Where(g => g < 75).ToList();
        //        Console.WriteLine("Failing Grades: " + string.Join(", ", failingGrades));
        #endregion
        #region session 3 q1 :6 
        //grades.RemoveAll(g => g< 75);
        //Console.WriteLine("Grades After Removing Failures: " + string.Join(", ", grades));
        #endregion
        #region session3 q1:7
        //bool has100 = grades.Any(g => g == 100);
        //        Console.WriteLine("Has Grade 100: " + has100);
        #endregion
        #region session3 q1 :8
        //List<string> gradeStrings = grades
        //    .Select(g => $"Grade: {g}")
        //    .ToList();

        //        gradeStrings.ForEach(g => Console.WriteLine(g));
        #endregion
        #region session 3 q6 :1
        //            Stack<string> history = new Stack<string>();

        //        history.Push("google.com");
        //history.Push("github.com");
        //history.Push("stackoverflow.com");
        //history.Push("youtube.com");
        //history.Push("claude.ai");]
        #endregion
        #region session 3 q6:2
        //Console.WriteLine("Current page: " + history.Peek());
        #endregion
        #region session 3 q6 :3
        //            for (int i = 0; i< 3; i++)
        //{
        //    Console.WriteLine("Leaving: " + history.Pop());
        //}
        #endregion
        #region session 3 q6:4
            Console.WriteLine("Current page after back: " + history.Peek());
        #endregion
}


}