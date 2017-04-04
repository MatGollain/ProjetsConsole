﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public static class Results
    {
        public static void CalculerTravailRéalisé(List<Taches> p)
        {

        }
        // méthodes de calcules / affichage? 
        /*
        CalculerTempsTotal
            => Surcharge en fonction du besoin / personne / version / métier etc
        CalculerTempsActivité
        CalculerTempsMétierRéalisé
        CalculerTempsMétierRestant
        CalculerTempsMétierTotal
        CalculerTempsPersonneRéalisé
        CalculerTempsPersonneRestant
        CalculerTempsPersonneTotal
        */

        public static int DuréeTotaleActivité(List<Production> data, CodeActivités act, string ver)//Calcul de la durée prévue totale par activité. On appelle en paramètre
        {
            return data.Where(a => a.ActivitéTache == act && a.Version == ver).Sum(dtp => dtp.DuréeTravailPrévu);           
        }

        public static int DuréeTravailRéalPersVer(List<Production> data, string codper, string ver)
        {
            return data.Where(p => p.CodePersonne == codper && p.Version == ver).Sum(dtr => dtr.DuréeTravailRéalisé);
        }

        public static int DuréeTravailRestPersVer(List<Production> data, string codper, string ver)
        {
            return data.Where(p => p.CodePersonne == codper && p.Version == ver).Sum(dtres => dtres.DuréeTravailRestant);
        }



    }
}
