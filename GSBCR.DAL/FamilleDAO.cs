using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public class FamilleDAO
    {
        public FAMILLE FindById(string code)
        {
            //A faire : rechercher une famille de médicaments par son code
            FAMILLE fam = null;
            using (var context = new gsb_visite_groupe3Entities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLE.Include("laFamille")
                          where f.FAM_CODE == code
                          select f;
                fam = req.SingleOrDefault<FAMILLE>();
            }
            return fam;
        }

        public List<FAMILLE> FindAll()
        {
            //A faire : charger toutes les familles de médicaments
            List<FAMILLE> lesFam = null;
            using (var context = new gsb_visite_groupe3Entities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLE.Include("laFamille")
                          select f;
                lesFam = req.ToList<FAMILLE>();
            }
            return lesFam;
        }

    }
}
