// See https://aka.ms/new-console-template for more information

using GenericsAssignment2.cs;

GenericCache<int> intCache = new GenericCache<int>();

intCache.AddItem("Number1", 55, TimeSpan.FromSeconds(5));
intCache.AddItem("Number2", 56, TimeSpan.FromSeconds(4));
intCache.AddItem("Number3", 57, TimeSpan.FromSeconds(3));

intCache.Display();

Console.WriteLine("Waiting for the cache items to be expired...");
System.Threading.Thread.Sleep(10000);

////retrieving the expired items

try
{
    Console.WriteLine($"Retrieved item: {intCache.GetItem("Number2")}");
} catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

GenericCache<string> stringCache = new GenericCache<string>();
stringCache.AddItem("String1", "Bubu", TimeSpan.FromSeconds(9));
stringCache.AddItem("String2", "Bebe", TimeSpan.FromSeconds(8));
stringCache.AddItem("String3", "Bibi", TimeSpan.FromSeconds(7));

Console.WriteLine($"The second string received: {stringCache.GetItem("String2")}");