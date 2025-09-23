n = int(input("Ingrese un número: "))

suma = 0

for i in range(1, n + 1):
    print(i)

    if (i % 2 == 0):
        suma += i

print("La suma de pares es", suma)