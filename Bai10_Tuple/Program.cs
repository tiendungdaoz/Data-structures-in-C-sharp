using System.Collections.Generic;
namespace TupleTrongCsharp
{
    class Program
    {
        static void Main(string[] argv)
        {
            //Khai bao Tuple
            var myTuple = Tuple.Create<int, string>(9,"Dao Tien Dung");
            var myTuple2 = new Tuple<int, string, bool>(10, "Do Thi Van",true);

            Console.WriteLine("ID: {0} || Name: {1}", myTuple2.Item1, myTuple2.Item2);

            var ngayThangNam = GetCurrentDayMonthYear();
            Console.WriteLine("Day: {0} || Month: {1} || Year: {2}", ngayThangNam.Item1, ngayThangNam.Item2, ngayThangNam.Item3);
            Console.WriteLine(ngayThangNam.ToString());
        }

        static Tuple<int, int,int> GetCurrentDayMonthYear()
        {
            //Lay ngay, thang, nam cua he thong
            DateTime now = DateTime.Now;

            var myTuple = Tuple.Create<int, int, int>(now.Day, now.Month, now.Year);
            return myTuple;
        }
    }
    
}