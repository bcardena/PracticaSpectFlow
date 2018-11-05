using System;
using TechTalk.SpecFlow;
using ProCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaSpecFlow.Specs
{
    [Binding]
    public class CalculadoraMultiplicacionSteps
    {
        private Calculadora calculadora = new Calculadora();
        private int resultado;
        [Given(@"ingreso el numero (.*) en la calculadora")]
        public void GivenIngresoElNumeroEnLaCalculadora(int numero1)
        {
            calculadora.PrimerNumero = numero1;
        }
        
        [Given(@"tambien entro (.*) en la calculadora")]
        public void GivenTambienEntroEnLaCalculadora(int numero2)
        {
            calculadora.SegundoNumero = numero2;
        }

        [When(@"presiono adicionar")]
        public void WhenPresionoAdicionar()
        {
            resultado = calculadora.Multiplicar();
        }

        [Then(@"el resultado sera (.*)")]
        public void ThenElResultadoSera(int resultadoEsperado)
        {
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
