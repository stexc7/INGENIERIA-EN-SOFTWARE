# INGENIERIA-EN-SOFTWARE

Allan Cardenas Montaño
def calculadora():
    print("--- CALCULADORA CON VALIDACIONES (Allan) ---")
    
    # 1. VALIDACIÓN: Asegurar que los datos ingresados sean números
    try:
        num1 = float(input("Ingresa el primer número: "))
        num2 = float(input("Ingresa el segundo número: "))
    except ValueError:
        print("Error: ¡Debes ingresar un número válido, no letras o texto!")
        return

    print("\nSelecciona la operación:")
    print("1. Suma (+)")
    print("2. Resta (-)")
    print("3. Multiplicación (*)")
    print("4. División (/)")
    
    opcion = input("Elige una opción (1-4): ")

    if opcion == '1':
        print(f"Resultado: {num1 + num2}")
    elif opcion == '2':
        print(f"Resultado: {num1 - num2}")
    elif opcion == '3':
        print(f"Resultado: {num1 * num2}")
    elif opcion == '4':
        # 2. VALIDACIÓN: Evitar la división por cero
        if num2 == 0:
            print("Error: No se puede dividir entre cero.")
        else:
            print(f"Resultado: {num1 / num2}")
    else:
        print("Opción no válida.")

# Ejecutar la calculadora
calculadora()
