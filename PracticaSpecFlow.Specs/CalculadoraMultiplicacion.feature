Feature: CalculadoraMultiplicacion
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the multiplica of two numbers

@mytag
Scenario: Dado dos numeros a multiplicar
	Given ingreso el numero 2 en la calculadora
	And tambien entro 3 en la calculadora
	When presiono adicionar
	Then el resultado sera 6
