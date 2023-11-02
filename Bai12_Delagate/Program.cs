namespace DelegateTrongCsharp
{
    class Program
    {
        //Khai bao kieu du lieu myDelagate
        delegate int myDelegate(string a);

        static void Main(string[] args) 
        {
            //Cac bien delagate voi kieu du lieu MyDelagate
            myDelegate convertToInt = new myDelegate(ConvertStringToInt);
            myDelegate showString = new myDelegate(ShowString);

            //Multicast 1 delagate
            myDelegate multicast = convertToInt + showString;

            #region Vidu1
            string strNumber = "100";
            int valueConverted = convertToInt(strNumber);
            Console.WriteLine("Gia tri sau khi chuyen: {0}",valueConverted);
            Console.WriteLine();
            #endregion

            #region Multicast delegate
            Console.WriteLine("Ket qua sau khi chay multicast");
            multicast(strNumber);
            Console.WriteLine();
            #endregion

            #region Call-back Function
            NhapVaShowTen(showString);
            #endregion

        }
        static int ConvertStringToInt(string str)
        {
            bool kiemTra;
            int value = 0;
            kiemTra = Int32.TryParse(str, out value);
            if (kiemTra == true)
            {
                Console.WriteLine("Da ep kieu du lieu thanh cong");
            }else
            {
                Console.WriteLine("Ep kieu du lieu that bai");
            }
            return value;
        }
        static int ShowString(string str) 
        {
            Console.WriteLine(str);
            return 0;
        }

        //Dung delegate cho call-back function
        static void NhapVaShowTen(myDelegate showTen)
        {
            Console.Write("Moi ban nhap ho va ten: ");
            string ten = Console.ReadLine();
            showTen(ten);
        }
    }
}