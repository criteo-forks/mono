//
// System.Web.Configuration.CodeSubDirectory
//
// Authors:
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (c) Copyright 2005 Novell, Inc (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#if NET_2_0
using System;
using System.Configuration;
using System.ComponentModel;

namespace System.Web.Configuration
{
	public sealed class CodeSubDirectory : ConfigurationElement
	{
		static ConfigurationPropertyCollection props;
		string directoryName;

		static CodeSubDirectory ()
		{
			props = new ConfigurationPropertyCollection ();
/*			ConfigurationPropertyFlags flags = ConfigurationPropertyFlags.IsKey | ConfigurationPropertyFlags.Required;
			NonEmptyStringFlags strFlags = NonEmptyStringFlags.TrimWhitespace;
			ConfigurationProperty prop = new NonEmptyStringConfigurationProperty ("directoryName", "", flags, strFlags);
			props.Add (prop);
*/		}

		public CodeSubDirectory (string directoryName)
		{
			this.directoryName = directoryName;
		}

		[TypeConverter (typeof (WhiteSpaceTrimStringConverter))]
		[ConfigurationProperty ("directoryName", DefaultValue = "", Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey)]
		public string DirectoryName {
			get { return directoryName; }
			set { directoryName = value; }
		}

		protected override ConfigurationPropertyCollection Properties {
			get { return props; }
		}
	}
}
#endif // NET_2_0

