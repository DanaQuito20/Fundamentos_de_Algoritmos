#Utilizando For
#for i in range (1, 11):
  #print(i, end = " ")

#Utilizando While
#j = 0
#while j < 10:
  #print(j, end = " ")
  #j = j + 1      #j += 1





#Utilizando For
#for i in range (10, 0, -1):
  #print(i, end = " ")

#Utilizando While
#j = 10
#while (j >= 1):
  #print(j, end = " ")
  #j = j - 1     #j -= 1





#Casuística
i = 1
suma = 0.0
menorE = 0
mayorE = 0
estudiantes = int(input("Ingrese la cantidad de estudiantes: "))

while (i <= estudiantes):
  edad = int(input("Ingrese la edad: "))
  suma = suma + edad
  i = i + 1

  if (edad < 18):
    menorE += 1
  else:
    mayorE += 1

print("El promedio de edades es de", suma / estudiantes)
print("Hay", menorE, "estudiantes menores de edad y", mayorE, "estudiantes mayores de edad.")