using System.Collections.Generic;
using System.IO;

namespace Cselian.TfsX
{
	/// <summary>
	/// Controls the ui and listens to events
	/// </summary>
	public class Engine
	{
		private readonly FileSystemWatcher Watcher = new FileSystemWatcher();

		private IWindowUI Window;
		private List<ChangeItem> Items = new List<ChangeItem>();
		private bool IsAttached;
		private string RootFol;

		public Engine(IWindowUI win)
		{
			Window = win;
			Window.AttachClicked += Window_AttachClicked;
			Watcher.Changed += Watcher_Changed;
			Watcher.Created += Watcher_Created;
			Watcher.Deleted += Watcher_Deleted;
		}

		public void SetSolution(string name, string rootPath)
		{
			rootPath = Directory.GetParent(rootPath).FullName;
			Watcher.Path = rootPath;
			Watcher.SynchronizingObject = Window as System.Windows.Forms.UserControl;
			Watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.FileName;

			Window.Root = rootPath;

			RootFol = Path.Combine(rootPath, ".tfsignore");
			IsAttached = Directory.Exists(RootFol);
			if (IsAttached)
			{
				Watcher.EnableRaisingEvents = true;
				Items = IOHelper.LoadFrom(RootFol);
			}

			Window.IsAttached = IsAttached;
		}

		private void Window_AttachClicked()
		{
			if (!IsAttached)
			{
				Watcher.EnableRaisingEvents = true;
				var di = Directory.CreateDirectory(RootFol);
				di.Attributes = di.Attributes | FileAttributes.Hidden | FileAttributes.System;
			}
			else
			{
				// confirm?
				System.Windows.Forms.MessageBox.Show("TODO: Confirm and remove directory");
				
				// Watcher.EnableRaisingEvents = false;
				// Directory.Delete(RootFol);
			}

			IsAttached = !IsAttached;
			Window.IsAttached = IsAttached;
		}

		private void Watcher_Created(object sender, FileSystemEventArgs e)
		{
			Add(e, ChangeItem.ChangeType.Deleted);
		}

		private void Watcher_Changed(object sender, FileSystemEventArgs e)
		{
			Add(e, ChangeItem.ChangeType.Deleted);
		}

		private void Watcher_Deleted(object sender, FileSystemEventArgs e)
		{
			Add(e, ChangeItem.ChangeType.Deleted);
		}

		private void Add(FileSystemEventArgs e, ChangeItem.ChangeType type)
		{
			var itm = new ChangeItem
			{
				Change = type,
				FileName = e.Name,
				RelPath = e.FullPath.Substring(RootFol.Length)
			};

			Window.AddItem(itm);
			Items.Add(itm);
			IOHelper.SaveTo(Items, RootFol);
		}
	}
}
