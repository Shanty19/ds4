Module area

    Sub Main()
        Dim radio As Single
        Dim area As Single
        Dim Circunferencia As Single
        Const pi = 3.1415926

        Console.Write("Ingrese le radio: ")
        radio = Console.ReadLine

        area = pi * radio ^ 2
        Circunferencia = 2 * pi * radio

        Console.WriteLine("El area es : {0}", area)
        Console.WriteLine("La circunferencia es : {0}", Circunferencia)

        Console.ReadKey()
    End Sub
End Module
