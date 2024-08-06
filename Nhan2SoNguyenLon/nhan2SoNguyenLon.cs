using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhan2SoNguyenLon
{
    class nhan2SoNguyenLon
    {
        static void Main(string[] args)
        {
            // Nhập 2 số nguyên lớn
            Console.Write("Nhập số thứ nhất: ");
            string num1 = Console.ReadLine();
            Console.Write("Nhập số thứ hai: ");
            string num2 = Console.ReadLine();

            // Gọi hàm nhân 2 số nguyên lớn
            string result = MultiplyLargeIntegers(num1, num2);

            // Hiển thị kết quả
            Console.WriteLine("Kết quả: " + result);
            Console.ReadLine();
        }

        static string MultiplyLargeIntegers(string num1, string num2)
        {
            // Chuyển chuỗi sang mảng chữ số
            int[] digits1 = num1.ToCharArray().Select(c => (int)c - '0').ToArray();
            int[] digits2 = num2.ToCharArray().Select(c => (int)c - '0').ToArray();

            // Lấy độ dài của 2 số
            int len1 = digits1.Length;
            int len2 = digits2.Length;

            // Khởi tạo mảng kết quả có độ dài bằng tổng độ dài 2 số
            int[] result = new int[len1 + len2];

            // Thực hiện phép nhân từng chữ số
            for (int i = len1 - 1; i >= 0; i--)
            {
                for (int j = len2 - 1; j >= 0; j--)
                {
                    int product = digits1[i] * digits2[j];
                    int sum = result[i + j + 1] + product;
                    result[i + j + 1] = sum % 10;
                    result[i + j] += sum / 10;
                }
            }

            // Loại bỏ các chữ số 0 ở đầu
            int start = 0;
            while (start < result.Length && result[start] == 0)
            {
                start++;
            }

            // Chuyển mảng kết quả về chuỗi
            StringBuilder sb = new StringBuilder();
            for (int i = start; i < result.Length; i++)
            {
                sb.Append(result[i]);
            }

            return sb.ToString();
        }
    }
}
