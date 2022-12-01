using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
	internal class Proposition
	{
		private int id;
		private bool val;
		private String proposition;

		public Proposition() { 
		}
		public Proposition(int id, bool val, string proposition)
		{
			this.id = id;
			this.val = val;
			this.proposition = proposition;
		}
		public int getId()
		{
			return id;
		}
		public bool getval()
		{
			return val;
		}
		public String getproposition()
		{
			return proposition;
		}
		public void setval(bool val)
		{
			this.val = val;
		}
		public void setId(int id)
		{
			this.id = id;
		}
		public void setProposition(String proposition)
		{
			this.proposition = proposition;	
		}

	}
}
