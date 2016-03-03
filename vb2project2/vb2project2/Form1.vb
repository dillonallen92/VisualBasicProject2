Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Public Class Ship
        Private _health As Double
        Private _damage As Double
    End Class

    Public Class Enemy
        Inherits Ship
        Private _speed As Double = 20.0
    End Class

End Class
