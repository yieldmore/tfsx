using System.Collections.Generic;
namespace Cselian.TfsX
{
	/// <summary>
	/// Represents an empty Event Handler
	/// </summary>
	public delegate void VoidHandler();

	/// <summary>
	/// 
	/// </summary>
	public interface IWindowUI
	{
		event VoidHandler AttachClicked;

		bool IsAttached { set; }

		/// <summary>
		/// Solution Root - to show in the status bar
		/// </summary>
		string Root { set; }

		void SetItems(List<ChangeItem> items);

		void AddItem(ChangeItem item);
	}
}
