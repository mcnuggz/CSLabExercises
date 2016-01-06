Imports System

Namespace LabExercises
    Public Class Exercise3
        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub StringSplitter(ByVal input As String)
            Dim split1 As String
            Dim split2 As String
            Dim middle As Integer = 0

            If(input.Length Mod 2 <> 0) Then
               middle = input.Length / 2
                split1 = input.Substring(0, middle)
                split2 = input.Substring(middle)
                Console.WriteLine(split1)
                Console.WriteLine(split2)

            Else
                middle = input.Length / 2
                split1 = input.Substring(0, middle)
                split2 = input.Substring(middle)
                Console.WriteLine(split1)
                Console.WriteLine(split2)
            End If

        End Sub
    End Class
End Namespace