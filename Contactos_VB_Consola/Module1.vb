Module Module1
    Private length As Integer = 0
    Private index As Integer = 0
    Private valor As Integer
    Private x() As Contacto
    Sub Main()
        Console.WriteLine("cuantos contactos desea agregar?")
        valor = Integer.Parse(Console.ReadLine())
        length = valor
        Dim salir As Boolean = False
        While Not salir
            x = New Contacto(length) {}
            x(index) = New Contacto
            Console.WriteLine("ingrese el nombre")
            x(index).Nombr = Console.ReadLine()
            Console.WriteLine("ingrese la fecha de nacimiento")
            x(index).FechaNacimient = DateTime.Parse(Console.ReadLine())
            Console.WriteLine("ingrese el numero de telefono")
            x(index).Telefon = Console.ReadLine()
            Console.WriteLine("ingrese correo electronico")
            x(index).Corre = Console.ReadLine()
            Console.WriteLine(x(index).ToString())
            index += 1
            Console.WriteLine("presione enter para continuar...")
            Console.ReadLine()
            If length = index Then
                Console.WriteLine("presione enter para salir...")
                Console.ReadLine()
            End If
        End While


        'Console.WriteLine("¿Cuántos contactos désea guardar?")
        'Dim valor As Integer = Integer.Parse(Console.ReadLine())
        'Dim length As Integer = valor
        'Dim index As Integer = 0
        'Dim x() As Contacto
        'Dim salir As Boolean = False
        'While Not salir
        '    Console.Clear()
        '    x = New Contacto(length) {}
        '    x(index) = New Contacto()
        '    Console.WriteLine("favor de ingresar nombre")
        '    x(index).Nombr = Console.ReadLine()
        '    Console.WriteLine("favor de ingresar fecha de nacimiento con el siguiente formato (AA/MM/DD)")
        '    x(index).FechaNacimient = DateTime.Parse(Console.ReadLine())
        '    Console.WriteLine("favor de ingresar número de telefono")
        '    x(index).Telefon = Console.ReadLine()
        '    Console.WriteLine("favor de ingresar correo electonico")
        '    x(index).Corre = Console.ReadLine()
        '    Console.Clear()
        '    Console.WriteLine(x(index).ToString() + "\npresione enter para continuar")
        '    Console.ReadLine()
        '    index = index + 1
        '    If length = index Then
        '        salir = True
        '    End If
        'End While
        'Console.WriteLine("presione enter para salir")
        'Console.ReadKey()
    End Sub
End Module
