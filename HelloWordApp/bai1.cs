// using System;
// class MaTran
// {
//   public int Rows { get; set; } // ai cung co the truy cap vao class
//   public int Cols { get; set; } // get: lay gia tri, set: gan gia tri
//   public int[,] Data { get; set; } //   mang 2 chieu

//   public MaTran(int rows, int cols) //ham khoi tao, tao moi bang New
//   {
//     Rows = rows;
//     Cols = cols;
//     Data = new int[rows, cols];
//   }
//   public void Nhap() // phuong thuc nhap ma tran
//   {
//     for (int i = 0; i < Rows; i++)
//     {
//       for (int j = 0; j < Cols; j++)
//       {
//         Console.Write($"Nhap phan tu [{i},{j}]: ");
//         Data[i, j] = int.Parse(Console.ReadLine());
//       }
//     }
//   }

//   public void Xuat() //phuong thuc xuat ma tran
//   {
//     for (int i = 0; i < Rows; i++)
//     {
//       for (int j = 0; j < Cols; j++)
//       {
//         Console.Write(Data[i, j] + "\t");
//       }
//       Console.WriteLine();
//     }
//   }

//   public static MaTran operator +(MaTran a, MaTran b) // nap chong toan tu +
//                                                       //static: khong can khoi tao doi tuong van co the su dung duoc
//                                                       //operator: dinh nghia lai toan tu
//                                                       //ma tran a, ma tran b: doi so truyen vao

//   {
//     if (a.Rows != b.Rows || a.Cols != b.Cols)
//     {
//       throw new InvalidOperationException("Khong the cong hai ma tran co kich thuoc khac nhau.");
//       //throw: nem ra ngoai le
//       //InvalidOperationException: ngoai le vi pham phep toan
//     }
//     MaTran result = new MaTran(a.Rows, a.Cols);
//     for (int i = 0; i < a.Rows; i++)
//     {
//       for (int j = 0; j < a.Cols; j++)
//       {
//         result.Data[i, j] = a.Data[i, j] + b.Data[i, j];
//       }
//     }
//     return result;
//   }
//   public static MaTran operator *(MaTran a, MaTran b)
//   {
//     if (a.Cols != b.Rows)
//     {
//       throw new InvalidOperationException("Khong the nhan hai ma tran voi kich thuoc khong phu hop.");
//     }
//     MaTran result = new MaTran(a.Rows, b.Cols);
//     for (int i = 0; i < a.Rows; i++)
//     {
//       for (int j = 0; j < b.Cols; j++)
//       {
//         result.Data[i, j] = 0;
//         for (int k = 0; k < a.Cols; k++)
//         {
//           result.Data[i, j] += a.Data[i, k] * b.Data[k, j];
//         }
//       }
//     }
//     return result;
//   }
//   public MaTran chuyenVi()
//   {
//     MaTran result = new MaTran(Cols, Rows);
//     for (int i = 0; i < Rows; i++)
//     {
//       for (int j = 0; j < Cols; j++)
//       {
//         result.Data[j, i] = Data[i, j];
//       }
//     }
//     return result;
//   }
//   public int tinhDet()
//   {
//     if (Rows != Cols)
//     {
//       throw new InvalidOperationException("Chi co the tinh dinh thuc cua ma tran vuong.");
//     }
//     return TinhDet(Data, Rows);
//   }
//   private int TinhDet(int[,] matrix, int n)
//   {//matrix: ma tran can tinh dinh thuc
//     //n: so hang (cot) cua ma tran
//     if (n == 1)
//     {
//       return matrix[0, 0];
//     }
//     if (n == 2)
//     {
//       return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
//     }
//     int det = 0;
//     for (int p = 0; p < n; p++)
//     {
//       int[,] subMatrix = new int[n - 1, n - 1];
//       for (int i = 1; i < n; i++)
//       {
//         int colIndex = 0;
//         for (int j = 0; j < n; j++)
//         {
//           if (j == p) continue;
//           subMatrix[i - 1, colIndex] = matrix[i, j];
//           colIndex++;
//         }
//       }
//       det += matrix[0, p] * TinhDet(subMatrix, n - 1) * (p % 2 == 0 ? 1 : -1);
//     }
//     return det;
//   }
// }
// class Program
// {
//   static void Main(string[] args)
//   // args: tham so truyen vao khi chay chuong trinh
//   // string[]: mang chua cac chuoi

//   {
//     Console.Write("Nhap so hang cua ma tran A: ");
//     int rowsA = int.Parse(Console.ReadLine());
//     // int.Parse: chuyen chuoi thanh so nguyen

//     Console.Write("Nhap so cot cua ma tran A: ");
//     int colsA = int.Parse(Console.ReadLine());
//     MaTran A = new MaTran(rowsA, colsA);
//     Console.WriteLine("Nhap ma tran A:");
//     A.Nhap();

//     Console.Write("Nhap so hang cua ma tran B: ");
//     int rowsB = int.Parse(Console.ReadLine());
//     Console.Write("Nhap so cot cua ma tran B: ");
//     int colsB = int.Parse(Console.ReadLine());
//     MaTran B = new MaTran(rowsB, colsB);
//     Console.WriteLine("Nhap ma tran B:");
//     B.Nhap();

//     try
//     {
//       MaTran C = A + B;
//       Console.WriteLine("Ma tran C (A + B):");
//       C.Xuat();
//     }
//     catch (InvalidOperationException ex)
//     // ex: doi tuong ngoai le
//     // InvalidOperationException: bat ngoai le vi pham phep toan
//     {
//       Console.WriteLine(ex.Message);
//     }

//     try
//     {
//       MaTran D = A * B;
//       Console.WriteLine("Ma tran D (A * B):");
//       D.Xuat();
//     }
//     catch (InvalidOperationException ex)
//     {
//       Console.WriteLine(ex.Message);
//     }

//     Console.WriteLine("Chuyen vi cua ma tran A:");
//     MaTran At = A.chuyenVi();
//     At.Xuat();

//     if (A.Rows == A.Cols)
//     {
//       int detA = A.tinhDet();
//       Console.WriteLine($"Dinh thuc cua ma tran A: {detA}");
//     }
//     else
//     {
//       Console.WriteLine("Khong the tinh dinh thuc cua ma tran A vi no khong phai la ma tran vuong.");
//     }

//     if (B.Rows == B.Cols)
//     {
//       int detB = B.tinhDet();
//       Console.WriteLine($"Dinh thuc cua ma tran B: {detB}");
//     }
//     else
//     {
//       Console.WriteLine("Khong the tinh dinh thuc cua ma tran B vi no khong phai la ma tran vuong.");
//     }
//   }
// }

