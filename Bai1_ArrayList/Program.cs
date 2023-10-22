using Bai1_ArrayList;
using System.Collections;

namespace ArrayListTrongCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao va khoi tao vung nho cho ArrayList
            ArrayList myArray = new ArrayList();

            ArrayList myArray2 = new ArrayList(5);  //Chi dinh kich thuoc ngay khi khoi tao

            /*
             * Khoi tao myArray3 co kich thuoc = myArray2
             * Sao chep toan bo phan tu trong myArray2 vao myArray3
             * myArray3 va myArray2 thuoc 2 vung nho khac nhau. Nhung gia tri cua 2 vung nho nay thi giong nhau
             */
            ArrayList myArray3 = new ArrayList(myArray2);

            /*
            * Sao chep toan bo phan tu trong myArray2 vao myArray4
            * myArray4 va myArray2 thuoc cung 1 vung nho. Khi myArray2 thay doi -> myArray4 thay doi theo va nguoc lai
            */
            ArrayList myArray4 = myArray2;
            
            //BaiTapViDu:
            ArrayList arrPersons = new ArrayList();

            //Them 3 person vao danh sach
            arrPersons.Add(new Person("Dao Tien Dung", 22));
            arrPersons.Add(new Person("Do Thi Van", 20));
            arrPersons.Add(new Person("Malisa", 29));
            arrPersons.Add(new Person("Nguyen Huy Hoang", 24));

            Console.WriteLine("Danh sach cac person trong ArrayList:");
            foreach (Person person in arrPersons)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine();
            //Thuc hien sap xep cac doi tuong trong ArrayList theo thuoc tinh tuoi
            arrPersons.Sort(new SortPerson());
            Console.WriteLine("Danh sach cac person sap xep theo thu tu tuoi tang dan:");
            foreach (Person person in arrPersons) 
            {
                Console.WriteLine(person.ToString());
            }

        }
    }

    //Dinh nghia class SortPerson sap xep doi tuong person theo thuoc tinh age
    class SortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = (Person)x;   //Hoac Person p1 = x as Person;
            Person p2 = (Person)y;

            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (p1.Age > p2.Age)
                {
                    return 1;
                } else if (p1.Age < p2.Age)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }  
    }
}
