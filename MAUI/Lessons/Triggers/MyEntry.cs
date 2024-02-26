using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triggers
{
	public class MyEntry : Entry
	{
		public int TextLength { get { return Text.Length; } }
	}
}
