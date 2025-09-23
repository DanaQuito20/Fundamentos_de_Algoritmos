sumaP = sumaI = 0

while True:
    num = int(input("Ingrese un número positivo (0 para salir): "))

    if (num < 0):
        print("Número inválido. Ingrese un número positivo.")
        continue

    if (num == 0):
        break

    if (num % 2 == 0):
        sumaP+=num
    else:
        sumaI+=num

print(f"Suma de pares: {sumaP}")
print(f"Suma de impares: {sumaI}")