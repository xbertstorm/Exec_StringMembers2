using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Q1：將  abc  左右的空白刪除");
			Q01();
			Console.WriteLine();
			Console.WriteLine("Q2：將字串 Allen Kuo轉成大寫ALLEN KUO");
			Q02();
			Console.WriteLine();
			Console.WriteLine("Q3：將字串aLLeN kUO轉換成Allen Kuo");
			Q03();
			Console.WriteLine();
			Console.WriteLine("Q4：假設有表示日期的字串1100225, 請將它轉成表示西元年的日期20210225");
			Q04();
			Console.WriteLine();
			Console.WriteLine("Q5：比對使用者輸入值是否為Allen不拘大小寫");
			Q05();
			Console.WriteLine();
			Console.WriteLine("Q6：比對使用者輸入值是否為Allen, 區分大小寫");
			Q06();
			Console.WriteLine();
			Console.WriteLine("Q7：計算兩數之和,並只呈現小數二位數");
			Q07();
			Console.WriteLine();
			Console.WriteLine("Q8：隱藏手機的資訊");
			Q08();

			Console.Read();
		}

		/// <summary>
		/// 將"  abc  " 左右的空白刪除
		/// </summary>
		private static void Q01()
		{
			string word = "  abc  ";

			Console.WriteLine(word.Trim());
		}

		/// <summary>
		/// 將字串 "Allen Kuo" 轉成大寫 "ALLEN KUO"
		/// </summary>
		private static void Q02()
		{
			string name = "Allen Kuo";

			Console.WriteLine(name.ToUpper());
		}

		/// <summary>
		/// 將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
		/// </summary>
		private static void Q03()
		{
			string name = "aLLeN kUO";

			Console.WriteLine(name[0].ToString().ToUpper() + name.Substring(1, 4).ToString().ToLower() + name[5] + name[6].ToString().ToUpper() + name.Substring(7).ToString().ToLower());
		}

		/// <summary>
		/// 假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
		/// </summary>
		private static void Q04()
		{
			string date = "1100225";
			string change = date.Substring(0, 3);

			int realyear = int.Parse(date.Substring(0, 3)) + 1911;

			Console.WriteLine(realyear + date.Substring(3, 4));
		}

		/// <summary>
		/// 比對使用者輸入值是否為 "Allen" 不拘大小寫
		/// </summary>
		private static void Q05()
		{
			Console.Write("請輸入：");
			string input = Console.ReadLine();
			string ans = "allen";

			string test = input.ToLower();
			if (test == ans)
				Console.WriteLine("比對成功。");
			else
				Console.WriteLine("比對失敗。");
		}

		/// <summary>
		/// 比對使用者輸入值是否為 "Allen", 區分大小寫
		/// </summary>
		private static void Q06()
		{
			Console.Write("請輸入：");
			string input = Console.ReadLine();
			string ans = "Allen";

			string test1 = ans[0].ToString();
			string test2 = ans.Substring(1, 4);

			int inputlen = input.Length;
			int anslen = ans.Length;  //llen

			if (inputlen == anslen)
			{
				if (input[0] == ans[0])
				{
					if (input.Substring(1, 4) == test2)
					{
						Console.WriteLine("比對正確。");
					}
					else
						Console.WriteLine("比對錯誤。");
				}
				else
					Console.WriteLine("比對錯誤。");
			}
			else
				Console.WriteLine("比對錯誤。");
		}
		private static void Q07()
		{
			Console.WriteLine("請輸入兩個數字(小數)");
			Console.Write("請輸入第一個數字：");
			string input1 = Console.ReadLine();
			Console.Write("請輸入第二個數字：");
			string input2 = Console.ReadLine();

			double num1 = double.Parse(input1), num2 = double.Parse(input2), ans;
			ans = num1 + num2;

			Console.WriteLine(ans.ToString("f2"));
		}
		private static void Q08()
		{
			Console.Write("請輸入一串電話號碼：");
			string phone = Console.ReadLine();
			string result = phone.Substring(0, 4) + new string('*', 4) + phone.Substring(8);

			Console.WriteLine(result);
		}
	}
}
