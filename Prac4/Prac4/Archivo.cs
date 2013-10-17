using System;
using System.IO;

namespace Prac4
{
	public class Archivo
	{

		public Archivo ()
		{
		}

		public void leerArchivo (string ruta)
		{
			string entra;
			Console.Clear ();

			if (Path.GetExtension (ruta) == ".csv") {

				try {
					StreamReader archivo = new StreamReader (ruta);

					entra = archivo.ReadToEnd ();
						
					String [] array = entra.Split ('\n');

					for (int i=0; i<array.Length; i++) {
						string[] datos = array [i].Split (',');
						Requisito ob = new Requisito ();

						ob.id = datos [0];
						ob.nombre = datos [1];
						ob.domicilio = datos [2];
						ob.telefono = datos [3];

						ob.imprimir ();
						Console.WriteLine ("----------------");
					}

					archivo.Close ();

				} catch (FileNotFoundException e){
						Console.WriteLine("El archivo no existe");
				}
				catch (Exception ex){};
			
			} else 
				Console.WriteLine("La extension del archivo no es compatible");

		}

	}
}

