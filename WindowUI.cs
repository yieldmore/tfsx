using System.Linq;
using System.Windows.Forms;

namespace Cselian.TfsX
{
	public partial class WindowUI : UserControl, IWindowUI
	{
		public WindowUI()
		{
			MyApp.InitUI(this);
			InitializeComponent();
		}

		#region Interface Implementation

		public event VoidHandler AttachClicked;

		string IWindowUI.Root
		{
			set { tsRoot.Text = value; }
		}

		bool IWindowUI.IsAttached
		{
			set { btnAttach.Text = value ? "Detach" : "Attach"; }
		}

		void IWindowUI.SetItems(System.Collections.Generic.List<ChangeItem> items)
		{
			lvwItems.Items.Clear();
			lvwItems.Items.AddRange(items.Select(x => new LvwItem(x, GroupOf(x))).ToArray());
		}

		void IWindowUI.AddItem(ChangeItem x)
		{
			lvwItems.Items.Add(new LvwItem(x, GroupOf(x)));
		}

		#endregion

		private void btnAttach_Click(object sender, System.EventArgs e)
		{
			if (null != AttachClicked)
			{
				AttachClicked();
			}
		}

		private ListViewGroup GroupOf(ChangeItem item)
		{
			if (item.Changelist == null)
			{
				return null;

			}

			return lvwItems.Groups.Cast<ListViewGroup>().FirstOrDefault(x => x.Name == item.Changelist)
				?? lvwItems.Groups.Add(item.Changelist, item.Changelist);
		}

		private class LvwItem : ListViewItem
		{
			public LvwItem(ChangeItem item, ListViewGroup grp)
			{
				Text = item.FileName;
				SubItems.AddRange(new string[] { item.RelPath, "todo", "todo", item.Change.ToString() });

				Group = grp;
			}
		}
	}
}
