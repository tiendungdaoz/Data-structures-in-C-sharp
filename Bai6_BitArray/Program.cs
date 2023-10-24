using System.Collections;
namespace BitArrayTrongCsharp 
{
    class Program
    {
        static void PrintBits(BitArray myBitArr, int width)
        {
            int i = width;
          
            foreach (bool item in myBitArr)
            {
                if (i < 1)
                {
                    i = width;
                    Console.WriteLine();
                }
                i--;
                Console.Write(item.GetHashCode() + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args) 
        {
            //Khong the khoi tao 1 BitArray rong
            BitArray myBitArr = new BitArray(10);  //Gia tri mac dinh la 0 (false)

            BitArray myBitArr2 = new BitArray(10, true);   //Khoi tao gia tri ban dau la: 1(true)

            bool[] myBool = new bool[5] {true, true,false,true,false };
            BitArray myBitArr3 = new BitArray(myBool);
            Console.WriteLine("So bit cua myBitArr3 la: {0}", myBitArr3.Length);
            Console.WriteLine("Cac bit do la:");
            PrintBits(myBitArr3,1);

            byte[] myByte = new byte[6] { 1, 2, 3, 4, 10, 9 };
            BitArray myBitArr4 = new BitArray(myByte);
            Console.WriteLine("So bit cua myBitArr4 la: {0}", myBitArr4.Count);
            Console.WriteLine("Cac bit do la:");
            PrintBits(myBitArr4, 8);

            //Vidu
            bool[] myBool2 = new bool[5] { true, true, false, true, false };
            BitArray myBitArr5 = new BitArray(myBool2);
            bool[] myBool3 = new bool[5] { false, true, false, false, false };
            BitArray myBitArr6 = new BitArray(myBool3);
            Console.Write("Gia tri cua myBitArr5 la: ");
            PrintBits(myBitArr5, 5);
            Console.Write("Gia tri cua myBitArr6 la: ");
            PrintBits(myBitArr6, 5);
            Console.WriteLine("Thuc hien lan luot cac phep toan AND, OR, XOR tren myBitArr5 va myBitArr6");

            BitArray andBit = myBitArr5.Clone() as BitArray;
            andBit.And(myBitArr6);
            Console.Write("Ket qua phep And: ");
            PrintBits(andBit, 5);

            BitArray orBit = myBitArr5.Clone() as BitArray;
            orBit.Or(myBitArr6);
            Console.Write("Ket qua phep Or: ");
            PrintBits(orBit, 5);

            BitArray xorBit = myBitArr5.Clone() as BitArray;
            xorBit.Xor(myBitArr6);
            Console.Write("Ket qua phep Xor: ");
            PrintBits(xorBit, 5);

            Console.Write("Ket qua cua phep Not myBitArr5: ");
            myBitArr5.Not();
            PrintBits(myBitArr5, 5);
        }
    }
}