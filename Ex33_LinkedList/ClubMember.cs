using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_LinkedList
{
    public class ClubMember
    {
        private int nr;
        private string fNavn;
        private string lNavn;
        private int alder;

        public int Nr { get {return nr;} set {nr = value;} }
        public string Fnavn { get { return fNavn; } set { fNavn = value; } }
        public string Lnavn { get { return lNavn; } set { lNavn = value; } }
        public int Alder { get { return alder; } set { alder = value; } }


        
        public ClubMember(int nummer, string Fname, string Lname, int alder)
        {
            Nr = nummer;
            Fnavn = Fname;
            Lnavn = Lname;
            Alder = alder;
        }
        public override string ToString()
        {
            return Nr + " " + Fnavn + " " + Lnavn + " " + Alder;
        }
    }
}
