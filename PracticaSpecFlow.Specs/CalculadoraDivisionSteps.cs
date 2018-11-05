using System;
using TechTalk.SpecFlow;
using ProCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaSpecFlow.Specs
{
    [Binding]
    public class CalculadoraDivisionSteps
    {
        private Calculadora calculadora = new Calculadora();
        private int resultado;
        [Given(@"entro el numero (.*)")]
        public void GivenEntroElNumero(int numero1)
        {
            calculadora.PrimerNumero = numero1;
        }

        [Given(@"I tambien entro el numero (.*)")]
        public void GivenITambienEntroElNumero(int numero2)
        {
            calculadora.SegundoNumero = numero2;
        }

        [When(@"presione el boton ok")]
        public void WhenPresioneElBotonOk()
        {
            resultado = calculadora.Dividir();
        }

        [Then(@"se muestra el numero (.*)")]
        public void ThenSeMuestraElNumero(int resultadoEsperado)
        {
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
