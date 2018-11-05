Feature: CalculadoraResta
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the resta of two numbers

@mytag
Scenario: Dado dos numeros
	Given Entro el numero 30 en la calculadora
	And tambien ingreso 20 en la calculadora
	When presiono add
	Then el resultado debe ser 10
