using System;
using System.IO;

namespace Prac4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Archivo ob = new Archivo();
			string ruta;

			Console.WriteLine("Ingrese la ruta del archivo a leer: ");
			ruta=Console.ReadLine();

			ob.leerArchivo(Path.GetFullPath(ruta));
		}
	}
}
