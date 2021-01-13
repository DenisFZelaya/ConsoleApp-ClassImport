using System;

    public class ClassPerson
    {
		public int id;
		public String nombre;
		public String apellido;

		// Constructor
		public ClassPerson(int id, String nombre, String apellido)
		{
			this.id = id;
			this.nombre = nombre;
			this.apellido = apellido;
		}


	//public string getNombre() { return this.nombre}

	public void mostrarInformacion()
		{
			Console.WriteLine("Datos Personales ");
			Console.WriteLine("Id: " + this.id);
			Console.WriteLine("Nombre: " + this.nombre);
			Console.WriteLine("Apellido: " + this.apellido);
		}
	}

