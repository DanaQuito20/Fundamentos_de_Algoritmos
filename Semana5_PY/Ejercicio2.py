x = int(input("Ingrese el lado 1: "))
y = int(input("Ingrese el lado 2: "))
z = int(input("Ingrese el lado 3: "))
if (x == y == z):
    print("Este es un triángulo equilátero.")
elif (x == y or y == z or x == z):
    print("Este es un triángulo isósceles.")
else:
    print("Este es un triángulo escaleno.")