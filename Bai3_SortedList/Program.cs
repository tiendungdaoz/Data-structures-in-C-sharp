using Bai3_SortedList;
using System.Collections;
namespace SortedListInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao va khoi tao vung nho SortedList
            SortedList myList = new SortedList();
            SortedList myList2 = new SortedList(10);
            SortedList myList3 = new SortedList(myList2);

            //Sap xep theo key do minh tu dinh nghia trong lop SortPerson
            SortedList myList4 = new SortedList(new SortPerson());

            //Tao myList5 coppy cac doi tuong trong myList2 va sap xep key do minh tu dinh nghia
            SortedList myList5 = new SortedList(myList2, new SortPerson());

            /*Doan code nay se bi loi vi Key cua myList la cac doi tuong thuoc 1 lop
             *Nhung chua dinh nghia cach so sanh cac doi tuong do cho myList
             */
            //myList.Add(new Person("Dao Tien Dung",22), 10);
            //myList.Add(new Person("Do Thi Van", 20), 9);
            Console.WriteLine("Cac doi tuong thuoc SortedList myList:");
            myList.Add("Dao Tien Dung", "VN");
            myList.Add("Do Thi Van", "VN");
            myList.Add("Tony", "America");
            myList.Add("Yuki", "Japan");
            myList.Add("Alibaba", "Indo");
            foreach (DictionaryEntry item in myList)
            {
                Console.WriteLine("Key: {0} => Value: {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            Console.WriteLine("Cac doi tuong thuoc SortedList myList6:");
            SortedList myList6 = new SortedList(new SortPerson());
            myList6.Add(new Person("Dao Tien Dung",22), 10);
            myList6.Add(new Person("Do Thi Van", 20), 9);
            myList6.Add(new Person("Mailisa", 39), 15);
            foreach (DictionaryEntry item in myList6)
            {
                Console.WriteLine("Key: {0} => Value: {1}", item.Key, item.Value);
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
                }
                else if (p1.Age < p2.Age)
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
