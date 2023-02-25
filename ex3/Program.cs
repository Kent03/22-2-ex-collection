using System;
using System.Collections.Generic;
//Định nghĩa một lớp Sinh viên chứa các thông tin cá nhân
// Lê Hoang Khoi-20mc-20it438
class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo ds sinh viên
        var students = new List<Student>()
        {
            new Student() { ID = 1, Name = "Khoi", Age = 18 },
            new Student() { ID = 2, Name = "Hoa", Age = 20 },
            new Student() { ID = 3, Name = "Huy", Age = 19 },
            new Student() { ID = 4, Name = "Ha", Age = 22 },
            new Student() { ID = 5, Name = "Tuan", Age = 21 }
        };

        // Danh sách theo tên
        students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));

        // In ra danh sách
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}
