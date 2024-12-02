namespace OpenClosedPrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StoreOC store = new StoreOC();

            store.Products.Add(new Product("C#", 100));

            Console.WriteLine($"Discounted price of C# is: {store.GetProductPrice("C#")}");
        }
    }
}
