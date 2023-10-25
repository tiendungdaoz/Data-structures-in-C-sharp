using System.Collections.Generic;
namespace ListTrongCsharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Khoi tao 1 List so nguyen rong
            List<int> myList = new List<int>();

            List<int> myList2 = new List<int>(10);  //Khoi tao voi so phan tu la: 10
            
            /*
             * Khoi tao va sao chep toan bo cac phan tu cua myList2 vao myList3
             * Thuoc 2 vung nho khac nhau
             */
            List<int> myList3= new List<int>(myList2);

            //Vi du SD lisy
            List<string> myList4 = new List<string>();
            myList4.Add("Dao Tien Dung");
            myList4.Add("Do Thi Van");

            Console.WriteLine("So luong phan tu trong myList4: {0}", myList4.Count);
            Console.WriteLine("Cac phan tu do la: ");
            foreach (string item in myList4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Chen 1 phan tu vao vi tri 1 List
            myList4.Insert(1, "Alibaba");
            Console.WriteLine("List myList4 sau khi insert: ");
            foreach (string item in myList4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Kiem tra 1 phan tu co ton tai trong List hay khong
            bool isExists = myList4.Contains("KUKA");
            if (isExists == false)
            {
                Console.WriteLine("\"KUKA\" khong ton tai trong myList4");
            }
        }
    }
}