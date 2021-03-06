//2750 - insertion sort 삽입정렬

using System;

class Program
{
	public static void Main(string[] args)
	{
		//입력

		var count = int.Parse(Console.ReadLine());
		
		int[] arr = new int[count];
		
		for (int p = 0; p < count; p++)
		{
			arr[p] = int.Parse(Console.ReadLine());
		}
		
		//정렬
		for (int i = 1; i < count; i++)
		{
			int key = arr[i];
			for (int j = i - 1; j >= 0; j--)
			{
				if (key > arr[j])
					break;
				arr[j + 1] = arr[j];
				arr[j] = key;
			}
		}
		
		//출력
		Console.Write(string.Join("\n", arr));
	}
}