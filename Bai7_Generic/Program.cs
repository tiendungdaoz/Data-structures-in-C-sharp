using Bai7_Generic;

namespace GenericTrongCsharp
{
    class Program
    {
        //Swap 2 so nguyen
        static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b= temp;
        }

        //Swap 2 so co kieu du lieu bat ky bang viec sd Generic
        static void Swap2<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args) 
        {
            int a = 9; int b = 6;
            double c = 9.4, d = 10.5;

            //Sd Generic cho phuong thuc
            Swap2<int>(ref a,ref b);
            Swap2<double>(ref c,ref d);

            //Sd Generic cho lop
            MyGeneric<int> myGe = new MyGeneric<int>(10);
            myGe.SetItemsValue(0, 10);
            myGe.SetItemsValue(1, 100);
            myGe.Items[3] = 15;
            Console.WriteLine("So luong phan tu trong thuoc tinh items cua doi tuong myGe: {0}", myGe.Items.Length);
            Console.WriteLine("Cac phan tu trong mang: ");
            for (int i = 0; i < myGe.Items.Length; i++)
            {
                Console.WriteLine(myGe.GetByInDex(i));
            }
        }
    }
}