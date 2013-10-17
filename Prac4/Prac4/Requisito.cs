using System;

namespace Prac4
{
	public class Requisito
	{
		public string id;
		public string nombre;
		public string domicilio;
		public string telefono;

		public Requisito ()
		{
		}

		public void imprimir(){
			Console.Write("Id: ");
			Console.WriteLine(this.id);
			Console.Write("Nombre: ");
			Console.WriteLine(this.nombre);
			Console.Write("Domicilio: ");
			Console.WriteLine(this.domicilio);
			Console.Write("Telefono: ");
			Console.WriteLine(this.telefono);
		}
	}
}

