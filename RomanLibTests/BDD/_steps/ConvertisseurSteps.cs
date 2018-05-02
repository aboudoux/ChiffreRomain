using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanLib;
using TechTalk.SpecFlow;

namespace RomanLibTests.BDD._steps
{
    [Binding]
    public class ConvertisseurSteps
    {
        private static string ChiffreRomain
        {
            get { return ScenarioContext.Current.Get<string>("ChiffreRomain"); }
            set { ScenarioContext.Current.Set(value, "ChiffreRomain"); }
        }

        private static int ChiffreConverti
        {
            get { return ScenarioContext.Current.Get<int>("ChiffreConverti"); }
            set { ScenarioContext.Current.Set(value, "ChiffreConverti"); }
        }


        [Given(@"J ai entrée le chiffre romain ""(.*)"" dans le convertisseur")]
        public void GivenJAiEntreeLeChiffreRomainDansLeConvertisseur(string chiffreRomain)
        {
            ChiffreRomain = chiffreRomain;
        }

        [When(@"Je demande la conversion du chiffre romain en numérique")]
        public void WhenJeDemandeLaConversionDuChiffreRomainEnNumerique()
        {
            ChiffreConverti = RomanConverter.Convert(ChiffreRomain);
        }

        [Then(@"le résultat de la conversion est (.*)")]
        public void ThenLeResultatDeLaConversionEst(int resultat)
        {
            Assert.AreEqual(resultat, ChiffreConverti);

        }
    }
}
