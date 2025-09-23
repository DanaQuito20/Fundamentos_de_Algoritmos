cantidad = int(input("Ingrese la cantidad de número: "))
pares = impares = ceros = 0

for i in range(1, cantidad + 1):
    num = int(input(f"Ingrese número {i}: "))

    if (num == 0):
        ceros+=1
    elif (num % 2 == 0):
        pares+=1
    else:
        impares+=1

print("Cantidad de pares: ", pares)
print("Cantidad de impares: ", impares)
print("Cantidad de ceros: ", ceros)