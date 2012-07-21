using System;
using System.Collections.Generic;
using System.Linq;

namespace Cselian.TfsX
{
	/// <summary>
	/// Extension Methods on Lists
	/// </summary>
	public static class ListHelper
	{
		/// <summary>
		/// See if any in the list is contained in the given text
		/// </summary>
		public static bool ContainsAny(this string txt, params string[] list)
		{
			return list.Any(x => txt.IndexOf(x, 0, StringComparison.OrdinalIgnoreCase) != -1);
		}

		public static bool AnyIs(this IEnumerable<ChangeItem> list, ChangeItem item)
		{
			return list.Any(x => x.RelPath.Equals(item.RelPath, StringComparison.OrdinalIgnoreCase)
				&& x.FileName.Equals(item.FileName, StringComparison.OrdinalIgnoreCase));
		}
	}
}
