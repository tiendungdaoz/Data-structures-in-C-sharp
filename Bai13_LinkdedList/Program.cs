namespace LinkedList_trong_Csharp
{
    class Program 
    {
        static void Main(string[] args)
        {
            LinkedList<string> cacBaiHoc = new LinkedList<string>();

            LinkedListNode<string> bh1 = cacBaiHoc.AddFirst("Bai hoc 1");
            var bh3 = cacBaiHoc.AddLast("Bai hoc 3");
            var bh2 = cacBaiHoc.AddAfter(bh1, "Bai hoc 2");
            cacBaiHoc.AddLast("Bai hoc 4");
            cacBaiHoc.AddLast("Bai hoc 5");

            foreach (var data in cacBaiHoc)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("--------------");

            var node1 = bh2.Previous;
            Console.WriteLine(node1.Value);

            Console.WriteLine(bh2.Value);
         
            var node3 = bh2.Next;
            Console.WriteLine(node3.Value);

            LinkedListNode<string> nodeDauTien = cacBaiHoc.First;
            Console.WriteLine("-----------Nut tu dau den cuoi: ");
            while (nodeDauTien != null)
            {
                Console.WriteLine(nodeDauTien.Value);
                nodeDauTien = nodeDauTien.Next;
            }

            LinkedListNode<string> nodeCuoiCung = cacBaiHoc.Last;
            Console.WriteLine("-----------Nut tu cuoi len dau: ");
            while(nodeCuoiCung != null) 
            {
                Console.WriteLine(nodeCuoiCung.Value);
                nodeCuoiCung = nodeCuoiCung.Previous;
            }
        }
    }
}