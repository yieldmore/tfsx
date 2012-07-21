using System.Collections.Generic;
using System.Linq;
using EnvDTE;

namespace Cselian.TfsX
{
	/// <summary>
	/// 
	/// </summary>
	public static class VSExtensions
	{
		public static string GetProperty(this Solution sln, string name)
		{
			/*
ExtenderCATID
ProjectDependencies
Extender
ActiveConfig
Path
ExtenderNames
Description
Name
StartupProject
			 */
			return (string)sln.Properties.Cast<Property>().First(x => x.Name == name).Value;
		}
	}
}
