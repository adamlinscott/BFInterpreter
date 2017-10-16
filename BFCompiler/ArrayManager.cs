using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFCompiler
{
	class ArrayManager
	{
		public Element CurrentElement;

		public ArrayManager()
		{
			CurrentElement = new Element();
		}

		public void TraverseLeft()
		{
			if (CurrentElement.PreviousElement == null)
			{
				CurrentElement.PreviousElement = new Element();
				CurrentElement.PreviousElement.NextElement = CurrentElement;
				CurrentElement = CurrentElement.PreviousElement;
			}
			else
			{
				CurrentElement = CurrentElement.PreviousElement;
			}
		}

		public void TraverseRight()
		{
			if (CurrentElement.NextElement == null)
			{
				CurrentElement.NextElement = new Element();
				CurrentElement.NextElement.PreviousElement = CurrentElement;
				CurrentElement = CurrentElement.NextElement;
			}
			else
			{
				CurrentElement = CurrentElement.NextElement;
			}
		}

		public void IncrementValue()
		{
			CurrentElement.value++;
		}

		public void DecrementValue()
		{
			CurrentElement.value--;
		}
	}
}
