namespace HashSet_trong_Csharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            HashSet<int> set1 = new HashSet<int>() {1,3,4,6,8 };
            HashSet<int> set2 = new HashSet<int>() { 2, 5, 7, 9 };

            set1.Add(11);
            set2.Remove(2);
            Console.WriteLine("Cac doi tuong trong HashSet set1:");
            foreach (var data in set1)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Cac doi tuong trong HashSet set2:");
            foreach (var data in set2)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Set1 sau khi hop voi set2:");
            set1.UnionWith(set2);
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");


            if (set1.IsSupersetOf(set2))
            {
                Console.WriteLine($"HashSet set1 la tap chua HashSet set2");
            }
        }
    }
}