using System;

namespace UD5E20
{
	class Program
	{
		static void Main(string[] args)
		{
			
			string texto = "Introduce un tamaño";
			int tam = int.Parse(texto);

			
			int[] array1 = new int[tam];
			int[] array2;

			
			fillNumAleatorio(array1, 10, 100);

			
			array2 = array1;

			
			array1 = new int[tam];

			
			fillNumAleatorio(array1, 10, 100);

			
			int[] array3 = multiplicador(array1, array2);

			

			Console.WriteLine("Array1");
			mostrarArray(array1);

			Console.WriteLine("Array2");
			mostrarArray(array2);

			Console.WriteLine("Array3");
			mostrarArray(array3);

			
			System.GC.Collect();

		}
		public static void fillNumAleatorio(int[] array, int a, int b)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Random aleatorio = new Random();
				array[i] = (aleatorio.Next() * (a - b) + b); ;
			}
		}

		public static void mostrarArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("En el indice " + i + " esta el valor " + array[i]);
			}
		}

		public static int[] multiplicador(int[] array1, int[] array2)
		{
			int[] array3 = new int[array1.Length];
			for (int i = 0; i < array1.Length; i++)
			{
				array3[i] = array1[i] * array2[i];
			}
			return array3;
		}
	}

}

