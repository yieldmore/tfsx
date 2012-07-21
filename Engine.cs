namespace Cselian.TfsX
{
	/// <summary>
	/// Controls the ui and listens to events
	/// </summary>
	public class Engine
	{
		public static IWindowUI Window { get; set; }

		public Engine(IWindowUI win)
		{
			Window = win;
		}

		public void SetSolution(string name, string rootPath)
		{
			Window.Root = rootPath;
		}
	}
}
