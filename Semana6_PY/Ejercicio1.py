num = int(input("Ingrese número de la tabla: "))
i = 1

while num <= 0:
    num = int(input("Número inválido. Ingrese número de la tabla: "))

while i <= 12:
    print(f"{num} x {i} = {num * i}")
    i+=1