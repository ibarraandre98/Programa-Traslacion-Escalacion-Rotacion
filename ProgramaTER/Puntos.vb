﻿Public Class Puntos
    Dim x As Integer
    Dim y As Integer
    Dim def As Integer
    Dim pol As Integer

    Sub New(ByVal x, y, def, pol)
        Me.x = x
        Me.y = y
        Me.def = def
        Me.pol = pol
    End Sub

    Public Property setgetx()
        Set(ByVal x)
            Me.x = x
        End Set
        Get
            Return x
        End Get
    End Property

    Public Property setgety()
        Set(ByVal y)
            Me.y = y
        End Set
        Get
            Return y
        End Get
    End Property

    Public Property setgetdef()
        Set(ByVal def)
            Me.def = def
        End Set
        Get
            Return def
        End Get
    End Property

    Public Property setgetpol()
        Set(ByVal pol)
            Me.pol = pol
        End Set
        Get
            Return pol
        End Get
    End Property
End Class
