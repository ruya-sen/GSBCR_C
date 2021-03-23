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
    public class RegionDAO
    {
        public REGION FindById(string code)
        {
            //A faire : rechercher une région par son nom
            REGION reg = null;
            using (var context = new gsb_visite_groupe3Entities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGIONs
                          where r.REG_CODE == code
                          select r;
                reg = req.SingleOrDefault<REGION>();

            }
            return reg;
        }

        public List<REGION> FindAll()
        {
            //A faire : charger toutes les régions
            List<REGION> lesReg = null;
            using (var context = new gsb_visite_groupe3Entities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.REGION
                          select f;
                lesReg = req.ToList<REGION>();

            }
            return lesReg;
        }

        public List<REGION> FindBySecteur(string secteurCode)
        {
            //A faire : charger les régions d'un secteur
            return null;
        }
    }
}
