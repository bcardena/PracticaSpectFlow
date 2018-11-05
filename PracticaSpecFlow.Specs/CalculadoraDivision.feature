Feature: CalculadoraDivision
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the division of two numbers

@mytag
Scenario: tengo dos numeros a dividir
	Given entro el numero 4
	And I tambien entro el numero 2
	When presione el boton ok
	Then se muestra el numero 2
