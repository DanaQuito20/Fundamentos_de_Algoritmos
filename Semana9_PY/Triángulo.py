class Triángulo:
    def area(self) -> None:
        base = int(input("Ingresa la base: "))
        altura = int(input("Ingresa la altura"))
        print("Área: ", ((base * altura) / 2))

    def perimetro(self) -> None:
        lado1 = int(input("Ingresa el lado 1: "))
        lado2 = int(input("Ingresa el lado 2: "))
        lado3 = int(input("Ingresa el lado 3: "))
        print("Perímetro: ", (lado1 + lado2 + lado3))