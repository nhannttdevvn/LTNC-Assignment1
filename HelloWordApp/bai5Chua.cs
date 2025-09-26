// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;

// namespace StudentApp
// {
//   // Enum khóa học
//   public enum CourseType
//   {
//     Java,
//     DotNet,
//     C_Cpp
//   }

//   // Class Student
//   public class Student
//   {
//     public string Name { get; set; }
//     public int Semester { get; set; }
//     public CourseType CourseType { get; set; }

//     public Student() { }

//     public Student(string name, int semester, CourseType courseType)
//     {
//       if (string.IsNullOrWhiteSpace(name))
//         throw new ArgumentException("Name cannot be empty");

//       Name = name;
//       Semester = semester;
//       CourseType = courseType;
//     }
//   }

//   // Class quản lý danh sách sinh viên
//   public class ClassSubject
//   {
//     public List<Student> StudentList { get; set; }
//     public string FileName { get; set; }

//     private Dictionary<string, int> report = new Dictionary<string, int>();

//     public ClassSubject(string fileName = "students.txt")
//     {
//       FileName = fileName;
//       StudentList = new List<Student>();
//     }

//     public void AddStudent(Student sv)
//     {
//       StudentList.Add(sv);
//     }

//     public bool RemoveStudent(string name)
//     {
//       Student sv = StudentList.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
//       if (sv == null) return false;
//       StudentList.Remove(sv);
//       return true;
//     }

//     public Student FindStudentByName(string name)
//     {
//       return StudentList.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
//     }

//     public List<Student> GetByStudentName(string name)
//     {
//       return StudentList
//              .Where(s => s.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
//              .ToList();
//     }

//     public void ReadFile()
//     {
//       if (!File.Exists(FileName)) return;

//       using (StreamReader fr = new StreamReader(FileName))
//       {
//         StudentList.Clear();
//         while (!fr.EndOfStream)
//         {
//           string line = fr.ReadLine();
//           if (string.IsNullOrWhiteSpace(line)) continue;
//           string[] s = line.Split(',');

//           if (s.Length == 3)
//           {
//             Student student = new Student
//             {
//               Name = s[0],
//               CourseType = Enum.Parse<CourseType>(s[1]),
//               Semester = int.Parse(s[2])
//             };
//             StudentList.Add(student);
//           }
//         }
//       }
//     }

//     public void SaveChangeToFile()
//     {
//       using (StreamWriter fw = new StreamWriter(FileName))
//       {
//         foreach (Student sv in StudentList)
//         {
//           fw.WriteLine($"{sv.Name},{sv.CourseType},{sv.Semester}");
//         }
//       }
//     }

//     public void GenerateReport()
//     {
//       report.Clear();
//       foreach (Student student in StudentList)
//       {
//         string key = student.Name + " | " + student.CourseType;
//         if (report.ContainsKey(key))
//           report[key]++;
//         else
//           report[key] = 1;
//       }
//     }

//     public void PrintReport()
//     {
//       Console.WriteLine("Student Name | Course | Total of Course");
//       foreach (var entry in report)
//       {
//         Console.WriteLine($"{entry.Key} | {entry.Value}");
//       }
//     }

//     public void Display()
//     {
//       Console.WriteLine("Danh sách sinh viên:");
//       foreach (Student sv in StudentList)
//       {
//         Console.WriteLine("{0} \t{1} \t{2}", sv.Name, sv.CourseType, sv.Semester);
//       }
//     }
//   }

//   // Chương trình chính
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       ClassSubject studentList = new ClassSubject("students.txt");
//       studentList.ReadFile();

//       Console.WriteLine("===== Student Management System =====");

//       // Hiển thị
//       studentList.Display();

//       // Thêm sinh viên
//       studentList.AddStudent(new Student("Nguyen Van A", 1, CourseType.Java));
//       studentList.AddStudent(new Student("Nguyen Van B", 2, CourseType.DotNet));
//       studentList.AddStudent(new Student("Nguyen Van C", 1, CourseType.C_Cpp));
//       studentList.SaveChangeToFile();

//       Console.WriteLine("\nSau khi thêm:");
//       studentList.Display();

//       // Tìm kiếm
//       Console.WriteLine("\nKết quả tìm kiếm theo tên 'Nguyen Van A':");
//       var searchResults = studentList.GetByStudentName("Nguyen Van A");
//       foreach (var sv in searchResults)
//       {
//         Console.WriteLine("{0} \t{1} \t{2}", sv.Name, sv.CourseType, sv.Semester);
//       }

//       // Xóa sinh viên
//       studentList.RemoveStudent("Nguyen Van B");
//       studentList.SaveChangeToFile();

//       Console.WriteLine("\nSau khi xóa Nguyen Van B:");
//       studentList.Display();

//       // Thống kê
//       studentList.GenerateReport();
//       Console.WriteLine("\n===== Report =====");
//       studentList.PrintReport();
//     }
//   }
// }
