using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFCompiler
{
	class Element
	{
		public byte value = 0;
		public Element PreviousElement { get; set; }
		public Element NextElement { get; set; }
	}
}
