using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Cselian.TfsX
{
	/// <summary>
	/// Helps in saving / loading ChangeItems
	/// </summary>
	public class IOHelper
	{
		private const string FileName = "pendingchanges.xml";

		public static List<ChangeItem> LoadFrom(string path)
		{
			var file = new FileInfo(Path.Combine(path, FileName));
			if (!file.Exists)
			{
				return new List<ChangeItem>();
			}

			var rdr = new XmlTextReader(file.OpenRead());
			var xml = new XmlSerializer(typeof(List<ChangeItem>));
			return (List<ChangeItem>)xml.Deserialize(rdr);
		}

		public static void SaveTo(List<ChangeItem> items, string path)
		{
			var file = new FileInfo(Path.Combine(path, FileName));
			if (file.Exists)
			{
				file.Delete();
			}

			var xml = new XmlSerializer(typeof(List<ChangeItem>));

			var op = file.OpenWrite();
			xml.Serialize(op, items);
			op.Close();
		}
	}
}
