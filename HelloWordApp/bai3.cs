// using System;
// using System.Collections.Generic;

// class TextProcessor
// {
//   static string Normalize(string text)
//   {

//     string result = "";
//     bool lastSpace = false;

//     foreach (char c in text)
//     {
//       if (c == ' ')
//       {
//         if (!lastSpace)
//         {
//           result += c;
//           lastSpace = true;
//         }
//       }
//       else
//       {
//         result += c;
//         lastSpace = false;
//       }
//     }

//     result = result.Trim();


//     char[] arr = result.ToCharArray();
//     bool capitalize = true;
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if (capitalize && Char.IsLetter(arr[i]))
//       {
//         arr[i] = Char.ToUpper(arr[i]);
//         capitalize = false;
//       }

//       if (arr[i] == '.' || arr[i] == '!' || arr[i] == '?')
//       {
//         capitalize = true;
//       }
//     }

//     return new string(arr);
//   }

//   static Dictionary<string, int> WordFrequency(string text)
//   {
//     Dictionary<string, int> frequency = new Dictionary<string, int>();

//     string[] words = text.ToLower().Split(' ');

//     foreach (string word in words)
//     {
//       if (word == "") continue;

//       if (frequency.ContainsKey(word))
//         frequency[word]++;
//       else
//         frequency[word] = 1;
//     }

//     return frequency;
//   }

//   static void Main()
//   {
//     Console.OutputEncoding = System.Text.Encoding.UTF8;

//     Console.WriteLine("Enter text:");
//     string input = Console.ReadLine();

//     string normalized = Normalize(input);

//     Dictionary<string, int> frequency = WordFrequency(normalized);
//     int totalWords = 0;
//     foreach (var pair in frequency)
//       totalWords += pair.Value;

//     int distinctWords = frequency.Count;

//     Console.WriteLine("\n--- Normalized Text ---");
//     Console.WriteLine(normalized);

//     Console.WriteLine($"\nTotal words: {totalWords}");
//     Console.WriteLine($"Distinct words: {distinctWords}");

//     Console.WriteLine("\n--- Word Frequency ---");
//     foreach (var pair in frequency)
//     {
//       Console.WriteLine($"{pair.Key} : {pair.Value}");
//     }
//   }
// }
