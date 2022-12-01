using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
	internal class Examen
	{
		private DateTime DateDebut;
		private DateTime DateFin;
		private String Matiere;
		
		private List<Question> questions;
		public Examen()
		{

		}
		public Examen( DateTime DateDebut, DateTime DateFin,String Matiere, List<Question> questions)
		{
			
			this.DateDebut = DateDebut;
			this.DateFin = DateFin;
			this.Matiere= Matiere;
			this.questions = questions;
		}
		public DateTime getDateDebut()
		{
			return DateDebut;
		}
		public DateTime getDatefin()
		{
			return DateFin;
		}
		public String getMatiere() { 
			return Matiere;
		}	
		public List<Question> getQuestions()
		{
			return questions;
		}
		public void setDateDebut(DateTime DateDebut)
		{
			this.DateDebut = DateDebut;
		}
		public void setDateFin(DateTime DateFin)
		{
			this.DateFin = DateFin;
		}
		public void setMatiere(String Matiere)
		{
			this.Matiere = Matiere;
		}
		public void setquestions(List<Question> questions)
		{
			this.questions = questions;
		}
	}
}
