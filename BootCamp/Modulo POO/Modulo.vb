Module Module1

    Sub Main()

        For index = 1 To 10
            Din p As New Password ()

            If p.esFuerte () Then
                Console.WriteLine(p.contrasenia & "Es Fuerte " )
            Else
                Console.WriteLine(p.contrasenia & "No es Fuerte")

            End If

        
        Next

        





    End Sub

End Module


