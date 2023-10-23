using System.Collections;
namespace StackTrongCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khoi tao 1 stack
            Stack myStack = new Stack();
            Stack myStack2 = new Stack(10);

            //Khoi tao 1 ArrayList
            ArrayList myArr = new ArrayList();
            myArr.Add(10);
            myArr.Add(15);
            myArr.Add(5);

            Stack myStack3= new Stack(myArr);

            Stack myStack4 = new Stack();
            myStack4.Push("Dao Tien Dung");
            myStack4.Push("Malisa");
            myStack4.Push("Do Thi Van");
            myStack4.Push("Alibaba");

            Console.WriteLine("So phan tu cua stack myStack4 la: " + myStack4.Count);

            Console.WriteLine("Gia tri doi tuong tai vi tri tren cung trong Stack: {0}", myStack4.Peek());

            //Lay cac phan tu ra khoi stack
            Console.WriteLine("Poping ...");
            int length = myStack4.Count;
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("{0} ",myStack4.Pop());
            //}
            for (int i = myStack4.Count; i > 0; i--)
            {
                Console.Write("{0} ", myStack4.Pop());
            }
            Console.WriteLine();

            Console.WriteLine("So phan tu cua stack myStack la: {0}", myStack4.Count);
        }
    }
}