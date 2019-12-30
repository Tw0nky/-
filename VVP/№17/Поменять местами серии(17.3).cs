using static System.Console;
namespace Поменять_местами_серии_17._3_
{
    class Program
    {
		static void Main(string[] args)
		{
			Write("Введите размерность массива:");
			int n = int.Parse(ReadLine());
			Write("Введите K (K>0):");
			int k = int.Parse(ReadLine());
			int[] mas1 = new int[n];
			int[] mas2 = new int[n];
			int bgin = 0, end = 0, l = 1, i, j = -1, a = (k == 1 ? 1 : 0);
			for (i = 0; i < n; i++)
			{
				Write("Введите элемент массива:");
				mas1[i] = int.Parse(ReadLine());
			}
			for (i = 1; i < n; i++)
			{
				if (mas1[i - 1] != mas1[i])
				{
					l++;
					if (l == k)
						bgin = i;
					end = i;
					
				}
				if (l == k)
					a++;
			}
			for (i = 0; i < bgin; i++)
			{
				mas2[++j] = mas1[i];
			}
			for (i = end; i < n; i++)
			{
				mas2[++j] = mas1[i];
			}
			for (i = bgin + a; i < end; i++)
			{
				mas2[++j] = mas1[i];
			}
			for (i = bgin; i < bgin + a; i++)
			{
				mas2[++j] = mas1[i];
			}
			for (i = 0; i < n; i++)
			{
				mas1[i] = mas2[i];
			}
			WriteLine("Массив после преобразования:");
			for (i = 0; i < n; i++)
			{
				Write($"{mas1[i]} ");
			}
		}
    }
}