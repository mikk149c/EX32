using Database;
using Smart_menu;
using System;
using System.Collections.Generic;

namespace Database_Menu
{
	internal class ActionInsertAddress : IMenuPoint
	{
		private DatabseController databseController;

		public ActionInsertAddress(DatabseController databseController)
		{
			this.databseController = databseController;
		}

		public string GetMenuPointName()
		{
			return "Insæt adrasse";
		}

		public void Invoke()
		{
			Console.WriteLine("Intast Gade navn");
			string street = Console.ReadLine();
			Console.WriteLine("Intast Hus nummer");
			string housNb = Console.ReadLine();
			Console.WriteLine("Intast Post Nummer");
			List<string> zipCodes = databseController.GetZipCodes();
			string zipCode = "";
			ConsoleKeyInfo key;
			do
			{
				int inputLine = Console.CursorTop;
				Console.WriteLine(zipCode);
				key = Console.ReadKey();
				zipCode += key.KeyChar;
				for (int i = inputLine; i < Console.WindowHeight; i++)
					Menu.ClearLine(i);
				foreach (string s in zipCodes)
					if (s.StartsWith(zipCode))
						Console.WriteLine(s);
				Console.SetCursorPosition(0, inputLine);
			} while (!key.Key.Equals(ConsoleKey.Enter));
			databseController.InsertAddress(street, housNb, zipCode);
		}
	}
}