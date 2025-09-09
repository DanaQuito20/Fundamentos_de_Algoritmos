def ej1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al curso de Fundamentos de Algoritmos de la carrera de {carrera}.")
def ej2():
    print("\"Danayra\"")

def ej3():
    num1 = int(input("Ingrese numero 1: "))
    num2 = int(input("Ingrese numero 2: "))

    suma = num1 + num2
    resta = num1 - num2
    multiplicacion = num1 * num2
    division = num1 / num2

    print("La suma es", suma, "la resta es", resta, "la multiplicacion es", multiplicacion, "y la division es", division,".")

import math #Importando librería math
def ej4():
    num = float(input("Ingrese un decimal: "))

    raizCuadrada = math.sqrt(num)
    valorEntero = round(num, 2)
    elevarCubo = math.pow(num, 3)
    raizCubica = num ** (1 / 3)

    print("La raiz cuadrada es", raizCuadrada, "el valor entero es", valorEntero, "la elevacion al cubo es", elevarCubo, "y la raíz cúbica es", raizCubica,".")

def ej5():
    num = input("Ingrese un numero: ")

    entero = int(num)
    decim = float(num)

    resto = entero % 2
    division = decim / 3

    print("El resto es", resto, "y la division es", division, ".")

ej4()