﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Neo.Debugger {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {

            MainForm.targetAVMPath = args.Length > 0 ? args[0] : null;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
