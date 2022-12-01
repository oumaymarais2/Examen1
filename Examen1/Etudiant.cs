using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
	internal class Etudiant
	{
		public String CNE;
		public String Nom;
		public String Prenom;

		//Constructeur sans parametres 
		public Etudiant() {
		}
		//Constructeur parametré
		public Etudiant(string CNE, string Nom, string Prenom)
		{
			this.CNE = CNE;
			this.Nom = Nom;
			this.Prenom = Prenom;
		}
		public String getCne (){
			return CNE;
		}
		public String getNom() {
			return Nom;
		}
		public String getPrenom()
		{
		return Prenom;
		}

		public void setCne(String CNE)
		{
			this.CNE = CNE;
		}
		public void setNom(String Nom)
		{
			this.Nom = Nom;
		}
		public void setPrenom(String Prenom)
		{
			this.Prenom = Prenom;
		}

	}
}
