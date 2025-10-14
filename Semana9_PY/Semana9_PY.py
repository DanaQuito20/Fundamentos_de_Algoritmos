from Triángulo import Triángulo
t = Triángulo()

def menu1() -> None:
    print("Bienvenidos al sistema de cálculos de áreas y perímetros\n")
    print("********************Menú de opciones********************")
    print("*                       1. Cuadrado                    *")
    print("*                       2. Rectángulo                  *")
    print("*                       3. Trapecio                    *")
    print("*                       4. Triángulo                   *")
    print("*                       5. Salir                       *")
    print("********************************************************\n")

def menu2() -> int:
    print("*********************************************************")
    print("*                       1. Área                         *")
    print("*                       1. Perímetro                    *")
    print("*********************************************************\n")

    opcion2 = int(input("Ingrese una opción: "))
    return opcion2

while True:
    menu1()
    while True:
        opcion = int(input("Ingrese una opción: "))
        if opcion in (1, 2, 3, 4, 5):
            break
        else: print("Opción no válida. Ingrese nuevamente...\n")

    match opcion:
        case 1:
            opc2 = menu2()
            match opc2:
                case 1: t.area()
                case 2: t.perimetro()
                    
        case 2: print() 
        case 3: print()
        case 4: print()
        case 5: quit()

    while True:
        continuar = input("¿Desea continuar? (S / N): ")
        if continuar in ("S", "s", "N", "n"): break
        else: print("Error. Presione 'S' o 'N'")

    if continuar == "N" or continuar == "n": break

    opcion2 = input("¿Desea continuar? (S / N): ")