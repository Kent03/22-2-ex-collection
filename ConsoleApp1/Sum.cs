using System;
using System.Collections.Generic;

//tính tổng các số bằng nhau liền kề trong danh sách các số thập phân:
//LeHoangKhoi-20mc-20it438
class Program
{
    //Hàm SumAdjacentEqualNumbers lấy một danh sách các số thập phân làm đầu vào
    //và trả về một danh sách mới có tổng các số bằng nhau liền kề
    static void Main(string[] args)
    {
        List<decimal> numbers = new List<decimal> { 1.1m, 2.2m, 3.3m, 3.3m, 4.4m, 5.5m, 5.5m, 6.6m };

        List<decimal> result = SumAdjacentEqualNumbers(numbers);

        Console.WriteLine("Original list: [{0}]", string.Join(", ", numbers));
        Console.WriteLine("Resulting list: [{0}]", string.Join(", ", result));
    }
    // tạo một danh sách các số thập phân và gọi hàm
    // SumAdjacentEqualNumbersđể lấy danh sách kết quả
    static List<decimal> SumAdjacentEqualNumbers(List<decimal> numbers)
    {
        List<decimal> result = new List<decimal>();
        decimal sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == numbers.Count - 1 || numbers[i] != numbers[i + 1])
            {
                sum += numbers[i];
                result.Add(sum);
                sum = 0;
            }
            else
            {
                sum += numbers[i];
            }
        }

        return result;
    }
}
