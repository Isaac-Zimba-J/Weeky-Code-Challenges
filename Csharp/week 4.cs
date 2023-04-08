

using System;
public class ReverseWords {

	public static void Main()
	{
		string[] s = "Heres a sentence to split".Split(' ');
		string ans = "";
		for (int i = s.Length - 1; i >= 0; i--) {
			ans += s[i] + " ";
		}
		
		Console.Write(ans.Substring(0, ans.Length - 1));
	}
}
