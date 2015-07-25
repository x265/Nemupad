using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace nemupad
{
	class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string file;
			string lang;

			if (args.Length > 1)
			{
				file = args[1];
				lang = args[0];
			}
			else if (args.Length > 0)
			{
				file = args[0];
				lang = "eng"; // load default
			}
			else
			{
				file = null;
				lang = "eng"; // load default
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain(file, lang));
		}
	}
}
