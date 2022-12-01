using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
	internal class Question
	{
		private String qst;
		private int id;

		public Question() {
		}

		public Question(string qst, int id)
		{
			this.qst = qst;
			this.id = id;
		}

		//getrs et seters 
		public String getQst()
		{
			return qst;
		}
		public int getId()
		{
			return id;
		}
		 public void setId(int id)
		{
			this.id = id;
		}
		public void setQst(String qst)
		{
			this.qst = qst;
		}
	}


}
