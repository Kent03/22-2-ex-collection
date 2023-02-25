using System;
using System.Collections.Generic;

//chương trình tính tổng tất cả các số trong một danh sách
//theo thứ tự sau: first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last – n
//LeHoangKhoi-20mc-20it438
class Program
{
    static void Main(string[] args)
    {
        //tạo một danh sách các số nguyên 
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int first = numbers[0];
        int last = numbers[numbers.Count - 1];
        int sum = 0;  //tạo một biến gọi là "sum"

        //sử dụng vòng lặp for để lặp lại các phần tử trong danh sách
        for (int i = 0; i <= numbers.Count / 2; i++)
        {
            if (i == numbers.Count / 2 && numbers.Count % 2 != 0)
            {
                sum += first + i;
            }
            else
            {
                sum += first + i + last - i;
            }
        }

        Console.WriteLine("The sum is: " + sum);
    }
}
