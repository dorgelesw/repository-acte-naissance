using P7GestAct.Models.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7GestAct.Models.Repositories
{
    interface IRepository
    {
        //Arrondissement
        //IEnumerable<Arrondissement> Arrondissements { get; }
        //int addArrondissement(Arrondissement arr);
        //int updateArrondissement(Arrondissement arr);
        //Arrondissement deleteArrondissement(Int64 id);
        //Arrondissement findArrondissement(Int64 id);

        //Centre
        //IEnumerable<Centre> Centres { get; }
        //int addCentre(Centre centre);
        //int updateCentre(Centre centre);
        //Centre deleteCentre(Int64 id);
        //Centre findCentre(Int64 id);

        //Commune
        //IEnumerable<Commune> Communes { get; }
        //int addCommune(Commune commune);
        //int updateCommune(Commune commune);
        //Commune deleteCommune(Int64 id);
        //Commune findCommune(Int64 id);

        //Contact
        IEnumerable<Contact> Contacts { get; }
        int addContact(Contact contact);
        int updateContact(Contact contact);
        Contact deleteContact(Int64 id);
        Contact findContact(Int64 id);

        //Declaration
        IEnumerable<Declaration> Declarations { get; }
        int addDeclaration(Declaration declaration);
        int updateDeclaration(Declaration declaration);
        Declaration deleteDeclaration(Int64 id);
        Declaration findDeclaration(Int64 id);

        //Domicile
        IEnumerable<Domicile> Domiciles { get; }
        int addDomicile(Domicile domicile);
        int updateDomicile(Domicile domicile);
        Domicile deleteDomicile(Int64 id);
        Domicile findDomicile(Int64 id);

        //Etat Civil
        IEnumerable<EtatCivil> EtatCivils { get; }
        int addEtatCivil(EtatCivil etatCivil);
        int updateEtatCivil(EtatCivil etatCivil);
        EtatCivil deleteEtatCivil(Int64 id);
        EtatCivil findEtatCivil(Int64 id);

        //Mere
        IEnumerable<Mere> Meres { get; }
        int addMere(Mere mere);
        int updateMere(Mere mere);
        Mere deleteMere(Int64 id);
        Mere findMere(Int64 id);

        //Naissance
        IEnumerable<Naissance> Naissances { get; }
        int addNaissance(Naissance naissance);
        int updateNaissance(Naissance naissance);
        Naissance deleteNaissance(Int64 id);
        Naissance findNaissance(Int64 id);

        //Pere
        IEnumerable<Pere> Peres { get; }
        int addPere(Pere pere);
        int updatePere(Pere pere);
        Pere deletePere(Int64 id);
        Pere findPere(Int64 id);

        //Personne
        IEnumerable<Personne> Personnes { get; }
        int addPersonne(Personne personne);
        int updatePersonne(Personne personne);
        Personne deletePersonne(Int64 id);
        Personne findPersonne(Int64 id);
    }
}
