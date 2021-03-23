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
    public class TypePraticienDAO
    {
        public TYPE_PRATICIEN FindById(string code)
        {
            //A faire : rechercher un type praticien par son code
            TYPE_PRATICIEN typ = null;
            using (var context = new gsb_visite_groupe3Entities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from t in context.TYPE_PRATICIEN.Include("LePraticien")
                          where t.TYP_CODE == code
                          select t;
                typ = req.SingleOrDefault<TYPE_PRATICIEN>();

            }
            return typ;
        }

        public List<TYPE_PRATICIEN> FindAll()
        {
            //A faire : charger tous les types praticiens
            List<TYPE_PRATICIEN> typs = null;
            using (var context = new gsb_visite_groupe3Entities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.TYPE_PRATICIEN.Include("LePraticien")
                          select m;
                typs = req.ToList<TYPE_PRATICIEN>();

            }
            return typs;
        }

    }
}
