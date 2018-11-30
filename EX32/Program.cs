using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Menu;
using Database;

namespace EX32
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			program.Run();
		}

		public DatabaseController DBC { get; set; }

		public Program()
		{
			string conStr =
				"Server=EALSQL1.eal.local;" +
				"Database=Ex31Klinik;" +
				"User Id=A_STUDENT24;" +
				"Password=A_OPENDB24";
			DBC = new DatabaseController(conStr);
		}

		private void Run()
		{
			MainMenu menu = new MainMenu(DBC);
			menu.Run();
		}
	}
}
