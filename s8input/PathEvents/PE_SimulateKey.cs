using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace s8input.PathEvents
{
	public class PE_SimulateKey : IPathEvent
	{
		private Key key;
		public Key Key { get { return key; } }

		public void Do()
		{

		}

		public PE_SimulateKey(Key key)
		{
			this.key = key;

		}
	}
}
