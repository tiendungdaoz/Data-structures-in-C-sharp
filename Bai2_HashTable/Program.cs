using System.Collections;
namespace HashTableTrongCSharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Khai bao va cap phat vung nho cho Hashtable
            Hashtable myHash = new Hashtable();
            Hashtable myHash2 = new Hashtable(10);
            Hashtable myHash3 = new Hashtable(myHash2);
            Hashtable myHash4 = myHash2;

            //Bai tap vi du
            myHash.Add("Dung", "Dao Tien Dung");
            myHash.Add("Van", "Do Thi Van");
            myHash.Add("Lisa", "Malia Lisa");

            Console.WriteLine(myHash["Van"]);
            Console.WriteLine(myHash["Tony"]); //Gia tri null vi khong co key "One" trong myHash

            if (myHash["Tony"] == null)
            {
                Console.WriteLine("Key \"Tony\" is not exists");
            }

            //1 phan tu trong Hashtable la 1 doi tuong co kieu du lieu DictionaryEntry
            Console.WriteLine("So phan tu cua Hashtable myHash: {0}",myHash.Count);
            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine();

            //Thuc hien viec gan gia tri cho 1 key khong ton tai
            //=> hashtable tu them 1 phan tu moi voi key va value tuong ung
            myHash["Alibaba"] = "Kakaka";
            Console.WriteLine("So phan tu cua Hashtable myHash: {0}", myHash.Count);
            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
