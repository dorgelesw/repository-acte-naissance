using P7GestAct.Models.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P7GestAct.Models.Repositories
{
    public class SystemActeRepository : IRepository
    {
        private SystemActeDbContext context = new SystemActeDbContext();

        //Personne
        public IEnumerable<Personne> Personnes {
            get { return context.Personnes; }
        }

        public int addPersonne(Personne p)
        {
            context.Personnes.Add(p);
            return context.SaveChanges();
        }

        public int updatePersonne(Personne p)
        {
            Personne oldP = context.Personnes.Find(p.PersonneID);
            if (oldP != null)
            {
                oldP.P_Name = p.P_Name;
                oldP.P_Date_Naissance = p.P_Date_Naissance;
                oldP.P_Lieu_Naissance = p.P_Lieu_Naissance;
                oldP.P_Sexe = p.P_Sexe;

                return context.SaveChanges();
            }
            return -1;
        }

        public Personne deletePersonne(Int64 id) 
        {
            Personne p=null;

            IEnumerable<Domicile> domiciles = context.Domiciles.Where(Domicile => Domicile.PersonneID == id);
            if (domiciles != null)
            {
                IEnumerable<Contact> contacts = context.Contacts.Where(Contact => Contact.PersonneID == id);

                if (contacts != null)
                {
                    IEnumerable<EtatCivil> etatCivils = context.EtatCivils.Where(EtatCivil => EtatCivil.PersonneID == id);
                    if (etatCivils != null)
                    {
                        IEnumerable<Declaration> declarations = context.Declarations.Where(Declaration => Declaration.PersonneID == id);
                        if (declarations != null)
                        {
                            p = context.Personnes.Find(id);
                            if (p != null)
                            {
                                context.Personnes.Remove(p);
                                context.SaveChanges();
                            }
                        }
                    }
                }
            }
           
            return p;
        }

        public Personne findPersonne(Int64 id)
        {
            Personne p = context.Personnes.Find(id);
            return p;
        }

        //Domicile
        public IEnumerable<Domicile> Domiciles 
        {
            get { return context.Domiciles; }
        }

        public int addDomicile(Domicile domicile)
        {
            context.Domiciles.Add(domicile);
            return context.SaveChanges();
        }

        public int updateDomicile(Domicile domicile)
        {
            Domicile oldD = context.Domiciles.Find(domicile.DomicileID);
            if (oldD != null)
            {
                oldD.Pays = domicile.Pays;
                oldD.Ville = domicile.Ville;
                oldD.Proprietaire = domicile.Proprietaire;

                return context.SaveChanges();
            }
            return -1;
        }
        public Domicile deleteDomicile(Int64 id)
        {
            Domicile d = context.Domiciles.Find(id);
            if (d != null)
            {
                context.Domiciles.Remove(d);
                context.SaveChanges();
            }
            return d;
        }
        public Domicile findDomicile(Int64 id)
        {
            Domicile d = context.Domiciles.Find(id);
            if (d != null)
            {
                d.Personne = context.Personnes.Find(d.PersonneID);
            }
            return d;
        }

        //EtatCivil
        public IEnumerable<EtatCivil> EtatCivils
        {
            get { return context.EtatCivils; }
        }

        public int addEtatCivil(EtatCivil etatCivil)
        {
            context.EtatCivils.Add(etatCivil);
            return context.SaveChanges();
        }

        public int updateEtatCivil(EtatCivil etatCivil)
        {
            EtatCivil oldEtatCivil = context.EtatCivils.Find(etatCivil.EtatCivilID);
            if (oldEtatCivil != null)
            {
                oldEtatCivil.Nationalite = etatCivil.Nationalite;
                oldEtatCivil.Profession = etatCivil.Profession;
                oldEtatCivil.Status_Matrinomiale = etatCivil.Status_Matrinomiale;
                oldEtatCivil.CNI = oldEtatCivil.CNI;
                oldEtatCivil.ActeReconnaissanceParentale = etatCivil.ActeReconnaissanceParentale;
                oldEtatCivil.ActeMariage = etatCivil.ActeMariage;

                return context.SaveChanges();
            }
            return -1;
        }
        public EtatCivil deleteEtatCivil(Int64 id)
        {
            EtatCivil c = context.EtatCivils.Find(id);
            if (c != null)
            {
                context.EtatCivils.Remove(c);
                context.SaveChanges();
            }
            return c;
        }
        public EtatCivil findEtatCivil(Int64 id)
        {
            EtatCivil c = context.EtatCivils.Find(id);
            if (c != null)
            {
                c.Personne = context.Personnes.Find(c.PersonneID);
            }
            return c;
        }

        //Contact
        public IEnumerable<Contact> Contacts 
        {
            get { return context.Contacts; }
        }
        public int addContact(Contact contact)
        {
            context.Contacts.Add(contact);
            return context.SaveChanges();
        }
        public int updateContact(Contact contact)
        {
            Contact oldContact = context.Contacts.Find(contact.ContactID);
            if (oldContact != null)
            {
                oldContact.Email = contact.Email;
                oldContact.Tel = contact.Tel;
                oldContact.BP = contact.BP;

                return context.SaveChanges();
            }
            return -1;
        }
        public Contact deleteContact(Int64 id)
        {
            Contact c = context.Contacts.Find(id);
            if (c != null)
            {
                context.Contacts.Remove(c);
                context.SaveChanges();
            }
            return c;
        }
        public Contact findContact(Int64 id)
        {
            Contact c = context.Contacts.Find(id);
            if (c != null)
            {
                c.Personne = context.Personnes.Find(c.PersonneID);
            }
            return c;
        }

        //Declaration
        public IEnumerable<Declaration> Declarations 
        {
            get { return context.Declarations; }
        }
        public int addDeclaration(Declaration declaration)
        {
            context.Declarations.Add(declaration);
            return context.SaveChanges();
        }
        public int updateDeclaration(Declaration declaration)
        {
            Declaration old = context.Declarations.Find(declaration.DeclarationID);
            if (old != null)
            {
                old.D_Date_Heure = declaration.D_Date_Heure;
                old.D_Lieu = declaration.D_Lieu;
                old.D_Name = declaration.D_Name;

                return context.SaveChanges();
            }
            return -1;
        }
        public Declaration deleteDeclaration(Int64 id)
        {
            Declaration declaration = null;

            IEnumerable<Naissance> naissances = context.Naissances.Where(Naissance => Naissance.DeclarationID == id);
            if (naissances != null)
            {
                declaration = context.Declarations.Find(id);
                if (declaration != null)
                {
                    context.Declarations.Remove(declaration);
                    context.SaveChanges();
                }                   
            }
            return declaration;
        }
        public Declaration findDeclaration(Int64 id)
        {
            Declaration d = context.Declarations.Find(id);
            if (d != null)
            {
                d.Personne = context.Personnes.Find(d.PersonneID);
                d.Centre = context.Centres.Find(d.CentreID);
            }
            return d;
        }

        //Naissance
        public IEnumerable<Naissance> Naissances 
        {
            get { return context.Naissances; }
        }
        public int addNaissance(Naissance naissance)
        {
            context.Naissances.Add(naissance);
            return context.SaveChanges();
        }
        public int updateNaissance(Naissance naissance)
        {
            Naissance old = context.Naissances.Find(naissance.NaissanceID);
            if (old != null)
            {
                old.N_Name = naissance.N_Name;
                old.N_Prenom = naissance.N_Prenom;
                old.N_Date_Heure = naissance.N_Date_Heure;
                old.N_Lieux = naissance.N_Lieux;
                old.N_Filiation = naissance.N_Filiation;
                old.N_Sexe = naissance.N_Sexe;

                return context.SaveChanges();
            }
            return -1;
        }
        public Naissance deleteNaissance(Int64 id)
        {
            Naissance naissance = context.Naissances.Find(id);
            if (naissance != null)
            {
                context.Naissances.Remove(naissance);
                context.SaveChanges();
            }
            return naissance;
        }
        public Naissance findNaissance(Int64 id)
        {
            Naissance n = context.Naissances.Find(id);
            if (n != null)
            {
                n.Declaration = context.Declarations.Find(n.DeclarationID);
                n.Mere = context.Meres.Find(n.MereID);
                n.Pere = context.Peres.Find(n.PereID);
            }
            return n;
        }

        //Pere
        public IEnumerable<Pere> Peres 
        {
            get { return context.Peres; }
        }
        
        public int addPere(Pere pere)
        {
            context.Peres.Add(pere);
            return context.SaveChanges();
        }
        public int updatePere(Pere pere)
        {
            Pere old = context.Peres.Find(pere.PersonneID);
            if (old != null)
            {
                old.P_Name = pere.P_Name;
                old.P_Nom_Famille = pere.P_Nom_Famille;
                old.P_Date_Naissance = pere.P_Date_Naissance;
                old.P_Lieu_Naissance = pere.P_Lieu_Naissance;
                old.P_Sexe = pere.P_Sexe;

                return context.SaveChanges();
            }
            return -1;
        }
        public Pere deletePere(Int64 id)
        {
            return null;
        }
        public Pere findPere(Int64 id)
        {
            Pere p = context.Peres.Find(id);
            return p;
        }

        //Mere
        public IEnumerable<Mere> Meres 
        {
            get { return context.Meres; }
        }
        public int addMere(Mere mere)
        {
            context.Meres.Add(mere);
            return context.SaveChanges();
        }
        public int updateMere(Mere mere)
        {
            Mere old = context.Meres.Find(mere.PersonneID);
            if (old != null)
            {
                old.P_Name = mere.P_Name;
                old.M_Nom_Famille_Naissance = mere.M_Nom_Famille_Naissance;
                old.P_Date_Naissance = mere.P_Date_Naissance;
                old.P_Lieu_Naissance = mere.P_Lieu_Naissance;
                old.P_Sexe = mere.P_Sexe;

                return context.SaveChanges();
            }
            return -1;
        }
        public Mere deleteMere(Int64 id)
        {
            return null;
        }
        public Mere findMere(Int64 id)
        {
            Mere m = context.Meres.Find(id);
            return m;
        }
    }
}