// using System;

// class ArrayProcessor
// {
//   private int[] arr;
//   public int Length => arr.Length;
//   public void Input()
//   {
//     Console.Write("Nhập số phần tử: ");
//     int n = int.Parse(Console.ReadLine());
//     arr = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//       Console.Write($"arr[{i}] = ");
//       // $"...": nội suy chuỗi
//       // {i}: chèn giá trị i vào chuỗi
//       // Console.ReadLine(): đọc chuỗi từ bàn phím
//       arr[i] = int.Parse(Console.ReadLine());
//     }
//   }

//   public void Display()
//   // Hiển thị mảng
//   {
//     Console.WriteLine(string.Join(" ", arr));
//     //join: nối các phần tử mảng thành chuỗi, cách nhau bởi dấu cách
//   }

//   public void BubbleSort()
//   //thuat toan sap xep noi bot
//   {
//     for (int i = 0; i < arr.Length - 1; i++)
//       for (int j = 0; j < arr.Length - i - 1; j++)
//         if (arr[j] > arr[j + 1])
//           (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
//   }

//   public void QuickSort(int left, int right)
//   //thuat toan sap xep nhanh
//   {
//     int i = left, j = right;
//     int pivot = arr[(left + right) / 2];
//     while (i <= j)
//     {
//       while (arr[i] < pivot) i++;
//       while (arr[j] > pivot) j--;
//       if (i <= j)
//       {
//         (arr[i], arr[j]) = (arr[j], arr[i]);
//         i++; j--;
//       }
//     }
//     if (left < j) QuickSort(left, j);
//     if (i < right) QuickSort(i, right);
//   }

//   public int LinearSearch(int key)
//   // tìm kiếm tuần tự
//   {
//     for (int i = 0; i < arr.Length; i++)
//       if (arr[i] == key) return i;
//     return -1;
//   }

//   public int BinarySearch(int key)
//   //tim kiem nhi phan
//   {
//     int left = 0, right = arr.Length - 1;
//     while (left <= right)
//     {
//       int mid = (left + right) / 2;
//       if (arr[mid] == key) return mid;
//       if (arr[mid] < key) left = mid + 1;
//       else right = mid - 1;
//     }
//     return -1;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     ArrayProcessor ap = new ArrayProcessor();
//     // tạo đối tượng ap của lớp ArrayProcessor
//     // lop ArrayProcessor: xu ly mang ben tren
//     ap.Input();
//     Console.Write("Mảng ban đầu: "); ap.Display();

//     ap.BubbleSort();
//     Console.Write("Sau BubbleSort: "); ap.Display();

//     ap.QuickSort(0, ap.Length - 1);
//     Console.Write("Sau QuickSort: "); ap.Display();
//     // ap.Length - 1: chi so cuoi cung cua mang
//     // cần thêm thuộc tính Length
//   }
// }
