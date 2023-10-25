using System.Collections.Generic;
namespace DictionaryTrongCsharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Khai bao va khoi tao vung nho cho Dictionary
            Dictionary<string, string> myDic = new Dictionary<string, string>();
            Dictionary<string, string> myDic2 = new Dictionary<string, string>(5);
            Dictionary<string, string> myDic3 = new Dictionary<string, string>(myDic2);

            //Vidu
            Dictionary<string, string> myDic4 = new Dictionary<string, string>();
            myDic4.Add("Dao Tien Dung", "BKHN");
            myDic4.Add("Do Thi Van", "FPT");
            myDic4.Add("Sakura", "Osaka");
            foreach (KeyValuePair<string,string> item in myDic4)
            {
                Console.WriteLine("Key: {0} || Value: {1}", item.Key, item.Value);
            }

            //Truy xuat thong qua key
            Console.WriteLine("Gia tri Value tuong ung voi Key \"Dao Tien Dung\" la: {0}", myDic4["Dao Tien Dung"]);
            myDic4["Tony"] = "Oxford";
            Console.WriteLine(myDic4.Count);
        }
    }
}