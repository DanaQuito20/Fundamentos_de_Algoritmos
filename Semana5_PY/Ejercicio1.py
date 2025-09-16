edad = int(input("Ingrese la edad: "))
if (edad >= 18):
    print("Elegible para votar.")

    if (edad >= 25):
        print("Elegible para ser candidato.")
    else:
        print("No es elegible para ser candidato.")
else:
    print("No es elegible para votar.")