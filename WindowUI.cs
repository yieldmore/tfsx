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

		string IWindowUI.Root
		{
			set { tsRoot.Text = value; }
		}
	}
}
