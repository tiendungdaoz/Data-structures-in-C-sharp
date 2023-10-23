using System.Collections;
namespace QueueTrongCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            Queue myQueue2 = new Queue(10);

            ArrayList myArr = new ArrayList();
            myArr.Add(10);
            myArr.Add(20);
            myArr.Add(5);

            //Khai bao va khoi tao vung nho cho myQueue3, coppy cac phan tu cua myArr vao myQueue3
            Queue myQueue3 = new Queue(myArr);

            Console.WriteLine(myQueue3.Peek()); //10 (phan tu dc them vao dau tien)

            //Vidu
            Queue myQueue4 = new Queue();
            myQueue4.Enqueue("Dao Tien Dung");
            myQueue4.Enqueue("Alibaba");
            myQueue4.Enqueue("Sizuka");
            Console.WriteLine("So luong phan tu cua Queue myQueue4: " + myQueue4.Count);
            Console.WriteLine("Phan tu dau tien trong myQueue4: {0}", myQueue4.Peek());
            Console.WriteLine("So luong phan tu cua Queue myQueue4: " + myQueue4.Count);

            Console.WriteLine("Dequeue ...");
            int length = myQueue4.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} ", myQueue4.Dequeue());
            }
            Console.WriteLine("So luong phan tu cua Queue myQueue4: " + myQueue4.Count);
        }
    }
}
