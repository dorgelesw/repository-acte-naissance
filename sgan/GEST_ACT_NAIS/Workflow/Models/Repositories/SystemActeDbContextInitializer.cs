using P7GestAct.Models.DataClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace P7GestAct.Models.Repositories
{
    public class SystemActeDbContextInitializer : DropCreateDatabaseAlways<SystemActeDbContext>
    {
        protected override void Seed(SystemActeDbContext context)
        {
            new List<Pays>{
                new Pays(){Pays_Name="Cameroun", Pays_Small_Name="Cm"}
            }.ForEach(contry => context.Pays.Add(contry));
            context.SaveChanges();

            new List<Langue>{
               new Langue(){Langue_Name="Français", Langue_Small_Name="fr",PaysID=1},
               new Langue(){Langue_Name="Anglais", Langue_Small_Name="En",PaysID=1}
           }.ForEach(language => context.Langues.Add(language));
            context.SaveChanges();

           

            new List<Region>{
                new Region(){Region_Name="Centre", Region_Chef_Lieu="Yaoude", PaysID=1},
                new Region(){Region_Name="Ouest", Region_Chef_Lieu="Bafoussam", PaysID=1},
                new Region(){Region_Name="Littoral", Region_Chef_Lieu="Douala", PaysID=1}
            }.ForEach(region => context.Regions.Add(region));
            context.SaveChanges();

            new List<Departement>{
                new Departement(){Dept_Name="Haute-Sanaga", Dept_Chef_Lieu="", RegionID=1},
                new Departement(){Dept_Name="Mfoundi", Dept_Chef_Lieu="Yaounde", RegionID=1},
                new Departement(){Dept_Name="Nde", Dept_Chef_Lieu="Bagangte", RegionID=2},
                new Departement(){Dept_Name="Mifi", Dept_Chef_Lieu="Bafoussam", RegionID=2}
            }.ForEach(departement => context.Departements.Add(departement));
            context.SaveChanges();

            new List<Arrondissement>{
                new Arrondissement(){Arrondissement_Name="Yaounde 1", DapartementID=2},
                new Arrondissement(){Arrondissement_Name="Yaounde 2", DapartementID=2},
                new Arrondissement(){Arrondissement_Name="Yaounde 3", DapartementID=2},
                new Arrondissement(){Arrondissement_Name="Yaounde 7", DapartementID=2},             
            }.ForEach(arrondissement => context.Arrondissements.Add(arrondissement));
            context.SaveChanges();

            new List<Commune>{
                new Commune(){ Commune_Name="Yaoundé 1", ArrondissementID=1},
                new Commune(){ Commune_Name="Yaoundé 2", ArrondissementID=2},
                new Commune(){ Commune_Name="Yaoundé 7", ArrondissementID=4}
            }.ForEach(commune => context.Communes.Add(commune));
            context.SaveChanges();

            new List<Centre>{
                new Centre(){ C_Name="CHU Yaounde", C_Lieux="Melen", CommuneID=2},
                new Centre(){ C_Name="Hopital Central", C_Lieux="Messa", CommuneID=1}
            }.ForEach(centre => context.Centres.Add(centre));
            context.SaveChanges();

            new List<Personne>{
                new Personne{P_Name ="DJOMSSI Emmanuel", P_Date_Naissance= DateTime.Now, P_Lieu_Naissance="Yaounde", P_Sexe='M', ArrondissementID=1}
            }.ForEach(personne => context.Personnes.Add(personne));
            context.SaveChanges();

            new List<Domicile>{
                new Domicile{Pays="Cameroun", Ville="Yaounde", Proprietaire="DJOMSSI", PersonneID=1}
            }.ForEach(domicille => context.Domiciles.Add(domicille));
            context.SaveChanges();

            new List<EtatCivil>{
                new EtatCivil{Nationalite="Camerounaise", Status_Matrinomiale="Celebataire", Profession="Medecin", PersonneID=1}
            }.ForEach(civil => context.EtatCivils.Add(civil));
            context.SaveChanges();

            new List<Contact>{
                new Contact{Tel="+237675436778", Email="emma@yahoo.fr", BP="3016", PersonneID=1}
            }.ForEach(contact => context.Contacts.Add(contact));
            context.SaveChanges();
        }
    }
}