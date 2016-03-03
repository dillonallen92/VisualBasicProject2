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

    End Class

End Class
