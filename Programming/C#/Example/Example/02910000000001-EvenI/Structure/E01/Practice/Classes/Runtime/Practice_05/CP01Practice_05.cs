using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_02;
using Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_03;
using Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_04;

namespace Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_05
{
	internal class CP01Practice_05<T> where T : IComparable
	{
		public CP01Practice_03<T>[] ContainerLists { get; private set; } = null;

		public CP01Practice_05(int a_nSize = 5)
		{
			this.ContainerLists = new CP01Practice_03<T>[a_nSize];

			for(int i = 0; i < a_nSize; ++i)
			{
				this.ContainerLists[i] = new CP01Practice_03<T>();
			}
		}
	}
}
