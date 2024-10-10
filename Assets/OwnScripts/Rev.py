def arbol_de_navidad(altura):
    for i in range(altura):      
        print(' ' * (altura - i - 1) + '*' * (2 * i + 1))
    print('Feliz Navidad')

altura = int(input("Ingrese la altura del árbol: "))
arbol_de_navidad(altura)