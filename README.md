# import math

# import sys

# 

# class Calculadora:

# &#x20;   def \_\_init\_\_(self):

# &#x20;       self.historial = \[]

# 

# &#x20;   def agregar\_historial(self, operacion, resultado):

# &#x20;       self.historial.append(f"{operacion} = {resultado}")

# 

# &#x20;   def mostrar\_historial(self):

# &#x20;       print("\\n--- Historial de Operaciones ---")

# &#x20;       if not self.historial:

# &#x20;           print("No hay operaciones registradas.")

# &#x20;       else:

# &#x20;           for item in self.historial:

# &#x20;               print(item)

# &#x20;       print("--------------------------------")

# 

# &#x20;   def sumar(self, a, b): return a + b

# &#x20;   def restar(self, a, b): return a - b

# &#x20;   def multiplicar(self, a, b): return a \* b

# &#x20;   def dividir(self, a, b):

# &#x20;       if b == 0:

# &#x20;           raise ValueError("Error: No se puede dividir para cero.")

# &#x20;       return a / b

# 

# &#x20;   def potencia(self, base, exp): return math.pow(base, exp)

# &#x20;   def raiz\_cuadrada(self, a):

# &#x20;       if a < 0:

# &#x20;           raise ValueError("Error: Raíz de un número negativo.")

# &#x20;       return math.sqrt(a)

# &#x20;   def logaritmo(self, a, base=10):

# &#x20;       if a <= 0:

# &#x20;           raise ValueError("Error: El logaritmo solo está definido para números positivos.")

# &#x20;       return math.log(a, base)

# &#x20;   

# &#x20;   def seno(self, angulo): return math.sin(math.radians(angulo))

# &#x20;   def coseno(self, angulo): return math.cos(math.radians(angulo))

# &#x20;   def tangente(self, angulo): return math.tan(math.radians(angulo))

# 

# def pedir\_numero(mensaje):

# &#x20;   while True:

# &#x20;       try:

# &#x20;           return float(input(mensaje))

# &#x20;       except ValueError:

# &#x20;           print("Dato inválido. Ingresa un número.")

# 

# def main():

# &#x20;   calc = Calculadora()

# &#x20;   

# &#x20;   while True:

# &#x20;       print("\\n" + "="\*30)

# &#x20;       print("          CALCULADORA")

# &#x20;       print("="\*30)

# &#x20;       print("1. Sumar")

# &#x20;       print("2. Restar")

# &#x20;       print("3. Multiplicar")

# &#x20;       print("4. Dividir")

# &#x20;       print("5. Potencia")

# &#x20;       print("6. Raíz Cuadrada")

# &#x20;       print("7. Logaritmo")

# &#x20;       print("8. Seno, Coseno, Tangente")

# &#x20;       print("9. Ver Historial")

# &#x20;       print("0. Salir")

# &#x20;       print("="\*30)

# &#x20;       

# &#x20;       opcion = input("Elige una opción: ")

# &#x20;       

# &#x20;       if opcion == '0':

# &#x20;           print("Saliendo...")

# &#x20;           sys.exit()

# &#x20;           

# &#x20;       elif opcion == '9':

# &#x20;           calc.mostrar\_historial()

# &#x20;           continue

# 

# &#x20;       try:

# &#x20;           if opcion in \['1', '2', '3', '4', '5']:

# &#x20;               n1 = pedir\_numero("Ingresa el primer número: ")

# &#x20;               n2 = pedir\_numero("Ingresa el segundo número: ")

# &#x20;               

# &#x20;               if opcion == '1':

# &#x20;                   res = calc.sumar(n1, n2)

# &#x20;                   calc.agregar\_historial(f"{n1} + {n2}", res)

# &#x20;               elif opcion == '2':

# &#x20;                   res = calc.restar(n1, n2)

# &#x20;                   calc.agregar\_historial(f"{n1} - {n2}", res)

# &#x20;               elif opcion == '3':

# &#x20;                   res = calc.multiplicar(n1, n2)

# &#x20;                   calc.agregar\_historial(f"{n1} \* {n2}", res)

# &#x20;               elif opcion == '4':

# &#x20;                   res = calc.dividir(n1, n2)

# &#x20;                   calc.agregar\_historial(f"{n1} / {n2}", res)

# &#x20;               elif opcion == '5':

# &#x20;                   res = calc.potencia(n1, n2)

# &#x20;                   calc.agregar\_historial(f"{n1} ^ {n2}", res)

# &#x20;               

# &#x20;               print(f"\\n=> RESULTADO: {res}")

# 

# &#x20;           elif opcion in \['6', '7']:

# &#x20;               n1 = pedir\_numero("Ingresa el número: ")

# &#x20;               if opcion == '6':

# &#x20;                   res = calc.raiz\_cuadrada(n1)

# &#x20;                   calc.agregar\_historial(f"√{n1}", res)

# &#x20;               elif opcion == '7':

# &#x20;                   res = calc.logaritmo(n1)

# &#x20;                   calc.agregar\_historial(f"log({n1})", res)

# &#x20;                   

# &#x20;               print(f"\\n=> RESULTADO: {res}")

# 

# &#x20;           elif opcion == '8':

# &#x20;               ang = pedir\_numero("Ingresa el ángulo en grados: ")

# &#x20;               print(f"\\n=> Seno({ang}°) = {calc.seno(ang):.4f}")

# &#x20;               print(f"=> Coseno({ang}°) = {calc.coseno(ang):.4f}")

# &#x20;               print(f"=> Tangente({ang}°) = {calc.tangente(ang):.4f}")

# &#x20;               calc.agregar\_historial(f"Trig({ang}°)", "Calculado")

# 

# &#x20;           else:

# &#x20;               print("Opción no válida. Intenta de nuevo.")

# 

# &#x20;       except ValueError as e:

# &#x20;           print(f"\\n\[!] {e}")

# &#x20;       except Exception as e:

# &#x20;           print(f"\\n\[!] Error: {e}")

# 

# if \_\_name\_\_ == "\_\_main\_\_":

# &#x20;   main()

