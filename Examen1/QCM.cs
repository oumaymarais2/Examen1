using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
	internal class QCM:Question
	{
		private List<Proposition> propositions;
		public QCM() {
		}
		public QCM(String qst, int id, List<Proposition> propositions) : base(qst, id)
		{
			this.propositions = propositions;
		}

		public Proposition getproposition(int index) {
			return propositions[index];
		}
		public List<Proposition> getPropositions()
		{
			return propositions;
		}
		
		
		public void setPropositions(List<Proposition> propositions)
		{
			this.propositions = propositions;
		}

	}
}
