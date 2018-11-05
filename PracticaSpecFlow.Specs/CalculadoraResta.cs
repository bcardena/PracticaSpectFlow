using System;
using TechTalk.SpecFlow;
using ProCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaSpecFlow.Specs
{
    [Binding]
    public class CalculadoraSteps
    {
        private Calculadora calculadora = new Calculadora();
        private int resultado;

        [Given(@"Entro el numero (.*) en la calculadora")]
        public void GivenIHaveEnteredIntoTheCalculator(int numero1)
        {
            calculadora.PrimerNumero = numero1;
        }

        [Given(@"tambien ingreso (.*) en la calculadora")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int numero2)
        {
            calculadora.SegundoNumero = numero2;
        }

        [When(@"presiono add")]
        public void WhenIPressAdd()
        {
            resultado = calculadora.Restar();
        }
        
        [Then(@"el resultado debe ser (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int resultadoEsperado)
        {
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
