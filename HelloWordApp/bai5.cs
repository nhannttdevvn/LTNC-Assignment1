// // Viết một chương trình C# chạy trên console để quản lý thông tin sinh viên.
// //  Mỗi sinh viên có các thuộc tính:
// // Name (họ tên sinh viên, kiểu chuỗi)
// // Semester (học kỳ, kiểu số nguyên)
// // CourseName (tên môn học, chỉ cho phép: Java, .Net, C/C++)
// // Các chức năng yêu cầu
// // 1. Đọc danh sách sinh viên từ tệp
// // 2. Cho phép tìm kiếm sinh viên theo name
// // 3. Cho phép sửa hoặc xóa thông tin của sinh viên
// // 4. Cho phép thống kê số lần đăng ký 
// // Thống kê số lần đăng ký khóa học của từng sinh viên.
// // Kết quả hiển thị:
// // Student Name | Course | Total of Course
// // Ví dụ:
// // Nguyen Van A | Java | 2
// // Nguyen Van B | Java | 1
// // Nguyen Van C | Java | 1



// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace StudentApp
// {
//   public class Student
//   {
//     private string name;
//     [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8")]

//     public int Semester { get; set; }
//     public CourseType CourseType { get; set; }
//     // CourseType courseName;

//     public Student()
//     {
//       name = string.Empty;
//       semester = 0;
//       courseType = null;
//     }

//     public Student(string name, int semester, CourseType courseType)
//     {
//       this.name = name;
//       this.semester = semester;
//       this.courseType = courseType;
//     }

//     public string Name
//     {
//       get { return name; }
//       set
//       {
//         if ((name == null) || (name.Length == 0)) name = value;
//         throw new ArgumentException("Name cannot be null or empty");
//       }
//       // throw new ArgumentException("Name cannot be null or empty"); => nem ngoai le

//     }
//     public int Semester
//     {
//       get { return semester; }
//       set { semester = value; }
//     }
//     public CourseType CourseType
//     {
//       get { return courseType; }
//       set { courseType = value; }
//     }
//   }

//   public class ClassSubject
//   {
//     // ArrayList lsv = new ArrayList(); cũ không dùng nữa
//     public List<Student> StudentList = new List<Student>();
//     public String FileName { get; set; }


//     Dictionary<string, int> courseCount = new Dictionary<string, int>();

//     public ClassSubject()
//     {
//       FileName = "students.txt";
//       StudentList = new List<Student>();
//     }
//     public ClassSubject(string fileName)
//     {
//       this.FileName = fileName;
//     }

//     public bool AddStudent(Student sv)
//     {
//       if (this.StudentList.Contains(sv)) return false;
//       StudentList.Add(student);
//       return true;
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

//     public Boolean IsDoublecate(Student sv)
//     {
//       return false;
//     }

//     private void ReadFile()
//     {
//       StreamReader fr = new StreamReader(FileName);
//       StudentList.Clear();
//       while (!fr.EndOfStream)
//       {
//         string line = fr.ReadLine();
//         string[] parts = line.Split(',');
//         while (!fr.EndOfStream)
//         {
//           string line = fr.ReadLine();
//           string[] s = line.Split(',');

//           Student student = new Student();
//           student.Name = student[0];
//           student.Semester = int.Parse(s[2]);
//           switch (s[1])
//           {
//             case "Java":
//               student.CourseType = CourseType.Java;
//               break;
//             case ".Net":
//               student.CourseType = CourseType.DotNet;
//               break;
//             case "C/C++":
//               student.CourseType = CourseType.C_Cpp;
//               break;
//             default:
//               throw new Exception("Invalid course name");
//               //nem ngoai le
//           }
//           StudentList.Add(student);
//         }
//         //    catch(Exception ex)
//         // {
//         //     Console.WriteLine("Error reading file: " + ex.Message);
//         //   }
//         // finally
//         // {
//         //     fr.Close();

//         //   }
//       }

//     }


//     public void GenerateReport()
//     {
//       foreach (Student student in StudentList)
//       {
//         string key = student.Name + " | " + student.CourseType;
//         if (report.ContainsKey(key))
//         {
//           report[key]++;
//         }
//         else
//         {
//           report[key] = 1;
//         }
//       }
//     }

//     public void Print()
//     {
//       Console.WriteLine("Student Name | Course | Total of Course");
//       foreach (var entry in report)
//       {
//         Console.WriteLine(entry.Key + " | " + entry.Value);
//       }
//     }


//     public void saveChangeToFile()
//     {
//       StreamWriter fw = new StreamWriter(FileName);
//       foreach (Student sv in StudentList)
//       {
//         fw.WriteLine($"{sv.Name},{sv.CourseType},{sv.Semester}");
//       }
//       fw.Close();
//     }

//     public IStudentList<Student> GetbyStudentName(string name)
//     {
//       List<Student> sts = StudentList.Where(s => s.Name = studentName).ToList();
//       StudentList l = new StudentList();
//       l.StudentList = l;
//       return l;
//     }

//     public void Display()
//     {
//       foreach (Student sv in StudentList)
//       {
//         Console.WriteLine("{0} \t{1} \t{2}", sv.Name, sv.CourseType, sv.Semester);
//       }
//     }


//   }
// }




// using studentApp;
// console.WriteLine("Student Management System");
// StudentList studentList = new StudentList("students.txt");
// studentList.ReadFile();
// studentList.Display();
// studentList.GenerateReport();
// studentList.Print();
// studentList.SaveChangeToFile();
// studentList.AddStudent(new Student("Nguyen Van A", 1, CourseType.Java));
// studentList.RemoveStudent("Nguyen Van B");
// studentList.SaveChangeToFile();
// var searchResults = studentList.GetbyStudentName("Nguyen Van A");
// foreach (var sv in searchResults)
// {
//   Console.WriteLine("{0} \t{1} \t{2}", sv.Name, sv.CourseType, sv.Semester);
// }
// if (arr[i] == key) return i;
//     }
//     return -1;
//     }

