using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
	internal class QuestionOuverte : Question
	{
		private String reponse;

		public QuestionOuverte() : base() { //appel au constructeur de la classe mere 
		}
		public QuestionOuverte(String qst, int id ,string reponse) : base(qst,id)
		{
			this.reponse = reponse;
		}

		// geters et seters
		public String GetReponse()
		{
			return reponse;
		}
		public void setReponse(String reponse)
		{
			this.reponse = reponse;
		}
	}
}
