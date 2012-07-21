using System;

namespace Cselian.TfsX
{
	/// <summary>
	/// Represents a change to a file
	/// </summary>
	public class ChangeItem
	{
		public enum ChangeType
		{
			Added,
			Modified,
			Deleted
		}

		public string FileName { get; set; }

		public string RelPath { get; set; }

		public string Changelist { get; set; }

		public ChangeType Change { get; set; }

		public DateTime Modified { get; set; }
	}
}
