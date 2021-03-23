using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSBCR.BLL;
using GSBCR.modele;
using System.Collections.Generic;

namespace UnitTestGSCR.BLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChargerVisiteur()
        {
            VISITEUR v = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
            Assert.IsNotNull(v, "visiteur a131 avec mdp 30BFD069 non chargé");
            VISITEUR v1 = VisiteurManager.ChargerVisiteur("a131", "vide");
            Assert.IsNull(v1, "visiteur a131 a été chargé avec un mdp faux");
        }
        [TestMethod]
        public void TestChargerRapportVisiteurEnCours()
        {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurEncours("a131");
            foreach (RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "Rapport visite n'appartient pas au matricule a131");
                Assert.AreEqual("1", r.RAP_ETAT, "Etat différent de 1");
                ok = (r.RAP_NUM >= 46 && r.RAP_NUM <= 53);
                Assert.IsTrue(ok, "Pb dans les n° de rapport " + r.RAP_NUM );
               
            }
        }
        [TestMethod]
        public void TestChargerRapportVisiteurFinis()
        {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurFinis("a131");
            foreach (RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "Rapport visite n'appartient pas au matricule a131");
                ok = (r.RAP_ETAT == "2" || r.RAP_ETAT == "3");
                Assert.IsTrue(ok, "Pb dans les id d'états" + r.RAP_ETAT);
                ok = (r.RAP_NUM >= 3 && r.RAP_NUM <= 49);
                Assert.IsTrue(ok, "Pb dans les n° de rapport " + r.RAP_NUM);
            }
        }
    }
}
