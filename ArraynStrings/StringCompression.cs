using System;
using System.Collections.Generic;

namespace HomePractice
{
	/// <summary>
	/// String compression.-: Compress string and remove duplicate characters by character frequency.
	/// </summary>
	public class StringCompression
	{
		public char[] Compress(string s)
		{
			int count = 1;
			int index = s.Length - 1;
			char[] chArray = s.ToCharArray ();

			for (int i = chArray.Length - 1; i > 0; i--) {
				if (chArray [i - 1] == chArray [i]) {
					count++;
				} else {
					char temp = chArray [i];
					chArray [index] = (char)count;
					chArray [index - 1] = temp;
					count = 1;
					index -= 2;
				}
			}

			chArray [index] = (char)count;
			chArray [index - 1] = chArray[0];

			int newLength = s.Length - index + 1;

			int j = 0;
			char[] ar = new char[newLength];
			while(index <= chArray.Length)
			{
				ar [j] = chArray [index - 1];
				j++;
				index++;
			}

			return s.Length > newLength ? ar: s.ToCharArray();
		}
	}
}


