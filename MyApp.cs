using System.Linq;
using System.Reflection;
using EnvDTE80;

namespace Cselian.TfsX
{
	/// <summary>
	/// Starts the app, does any work, keeping VSApp interactions restricted to this file.
	/// </summary>
	public static class MyApp
	{
		private static DTE2 VSApp;
		private static EnvDTE.AddIn Addin;
		private static EnvDTE.Window AddinWindow;
		private static Engine Engine;

		public static void Init(DTE2 app, EnvDTE.AddIn addin)
		{
			VSApp = app;
			Addin = addin;
			CreateWindow();
			WireupEvents();
		}

		public static void InitUI(IWindowUI ui)
		{
			Engine = new Engine(ui);
		}

		private static void WireupEvents()
		{
			VSApp.Events.SolutionEvents.Opened += SolutionEvents_Opened;
		}

		private static void SolutionEvents_Opened()
		{
			AddinWindow.Visible = true;
			var path = VSApp.Solution.GetProperty("Path");
			Engine.SetSolution(VSApp.Solution.FullName, path);
		}

		private static void CreateWindow()
		{
			// http://www.codeproject.com/Articles/35407/Creating-Visual-Studio-Tool-Windows
			var wins = (Windows2)VSApp.Windows;
			var guid = "{87907470-2841-11de-8c30-0800200c9a66}";
			object w = null;
			var asm = Assembly.GetCallingAssembly().Location;
			AddinWindow = wins.CreateToolWindow2(Addin, asm, typeof(WindowUI).FullName, "TfsX Power Source Control", guid, ref w);

			AddinWindow.IsFloating = false;
			AddinWindow.Linkable = true;
		}
	}
}
