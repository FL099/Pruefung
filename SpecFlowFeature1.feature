Feature: Trigonometric functions
	In order to avoid silly mistakes
	As a math idiot
	I want to be be able to calculate sin, cos and tan

@mytag
Scenario Outline: calc trigonometric funcs
	Given I enter <contexval>
	When I enter <method>
	Then <ergebn>

	Examples: 
	| contextval | method  | ergebn |
	| 3.1415     | sinus   | 0      |
	| 3.1415     | cosinus | -1     |
	| 3.1415     | tangens | 0      |
