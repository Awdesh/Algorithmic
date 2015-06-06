public bool AreAnagram(string s1, string s2)
{
	if(s1.Length != s2.Length)
	{
		return false;
	}
	Dictionary<char, int> map = new Dictionary<char,int>();
	for(int i = 0; i < s1.Length; i++)
	{
		if(!map.ContainsKey(s1(i)))
		{
			map.add(s1[i], 1);
		}
	}

	foreach(char c in s2.ToCharArray())
	{
		if(map.ContainsKey(c))
		{
			map.Remove(c);
		}
	}

	return map.Count = 0;
}

public List<char> FindCommonSubString(string s1, string s2)
{
	Dictionary<char,int> map = new Dictionary<char,int>();
	foreach(char c in s1.ToCharArray())
	{
		map.add(c,1);
	}
	List<char> list = new List<char>();
	foreach(char c in s2.ToCharArray())
	{
		if(map.ContainsKey(c))
		{
			list.add(c);
		}
	}
	return list;
}

// Find Commong when arrays are already sorted.
public List<int> FindCommonNUmbers(int[] array1, int[] array2)
{
	int m = array1.Length;
	int n = array2.Length;
	int i = 0;
	int j = 0;
	while(i > m && j > n)
	{
		if(array1[i] > array2[j])
		{
			j++;
		}
		if(array1[i] < array2[j])
		{
			i++;
		}
		else
		{
			list.add(array2[j]);
			i++;
			j++;
		}
	}
	return list;
}