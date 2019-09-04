using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_13
{
    class Program
    {
        static void XuLyChuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi");
            s = Console.ReadLine();
            int Deminhoa = 0, Deminthuong = 0, Demso = 0, Demkt = 0;
            char[] arr = s.ToCharArray();
            for(int i=0;i<arr.Length;i++)
            {
                if (char.IsLower(arr[i]))
                    Deminthuong++;
                if (char.IsUpper(arr[i]))
                    Deminhoa++;
                if (char.IsWhiteSpace(arr[i]))
                    Demkt++;
                if (char.IsNumber(arr[i]))
                    Demso++;
            }
            Console.WriteLine("Có {0} ký tự in thường",Deminthuong);
            Console.WriteLine("Có {0} ký tự in HOA", Deminhoa);
            Console.WriteLine("Có {0} ký tự số ", Demso);
            Console.WriteLine("Có {0} ký tự khoảng trắng ", Demkt);
            Console.ReadLine();
        }
        static void XuLyChuoi1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi");
            s = Console.ReadLine();
            int Deminhoa = 0, Deminthuong = 0, Demso = 0, Demkt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char kt = s[i];
                if (char.IsLower(kt))
                    Deminthuong++;
                if (char.IsUpper(kt))
                    Deminhoa++;
                if (char.IsWhiteSpace(kt))
                    Demkt++;
                if (char.IsNumber(kt))
                    Demso++;
            }
            Console.WriteLine("Có {0} ký tự in thường", Deminthuong);
            Console.WriteLine("Có {0} ký tự in HOA", Deminhoa);
            Console.WriteLine("Có {0} ký tự số ", Demso);
            Console.WriteLine("Có {0} ký tự khoảng trắng ", Demkt);
            Console.ReadLine();
        }
        static void XuLyChuoi2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s;
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi");
            s = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập chuỗi tiếp theo");
            string s2 = Console.ReadLine();
            int kq = s.ToLower().CompareTo(s2.ToLower());
            if(kq==0)
            {
                Console.WriteLine("s và s2 giống nhau");
            }
            else if(kq<0)
            {
                Console.WriteLine("s < s2");
            }
            else
            {
                Console.WriteLine("s . s2");
            }
            Console.ReadLine();
        }
        static void XuLyChuoi3()
        {
            String s = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void XuLyChuoi4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s="D:/baihat/nhactrinh/dem thay ta la thac do.mp3";
            int vt = s.IndexOf("/");
            Console.WriteLine("Tìm thấy ký tự / ở vị trí thứ {0}",vt);
            int vt2 = s.LastIndexOf("/");
            Console.WriteLine("Tìm thấy ký tự / ở vị trí thứ {0}", vt2);
            Console.ReadLine();
        }
        static void XuLyChuoi5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "D:/baihat/nhactrinh/dem thay ta la thac do.mp3";
            int vt = s.LastIndexOf("/");
            string tenbh = s.Substring(vt + 1);
            Console.WriteLine(tenbh);
            int vt2 = tenbh.LastIndexOf(".");
            string tenbh2 = tenbh.Substring(0, vt2);
            Console.WriteLine(tenbh2);
            Console.ReadLine();
        }
        static void XuLyChuoi6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string live = "SV113 Nguyễn Thị Hạnh phúc;phuc@gmail.com";
            string[] arr = live.Split(';');
            Console.WriteLine("Mã= {0}",arr[0]);
            Console.WriteLine("Tên= {0}", arr[1]);
            Console.WriteLine("Email= {0}", arr[2]);
            Console.ReadLine();
        }
        static void ToiUuChuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào 1 tên: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Chuỗi gốc bạn nhập: ");
            Console.WriteLine(ten);
            ten = ten.Trim();
            string[] arr = ten.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ten = "";
            for (int i=0;i<arr.Length;i++)
            {
                string word = arr[i];
                word = word.ToLower();
                char[] arrWord = word.ToCharArray();
                arrWord[0] = char.ToUpper(arrWord[0]);
                string newWord = new string(arrWord);
                ten += newWord + " ";
            }
            Console.WriteLine("Chuỗi sau khi tối ưu: ");
            Console.WriteLine(ten);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //XuLyChuoi6();
            ToiUuChuoi();
        }
    }
}
