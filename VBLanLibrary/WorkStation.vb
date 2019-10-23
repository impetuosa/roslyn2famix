﻿Public Class WorkStation
    Inherits Node
    Private _type As String
    Private _conf As Int64


    Public WriteOnly Property Conf As Int64
        Set(value As Int64)
            _conf = value
        End Set
    End Property

    Public ReadOnly Property Type As String
        Get
            Return _type
        End Get
    End Property

    Public Sub Originate(packet As Packet)
        packet.Originator = Me
        Me.Send(packet)
    End Sub

    Public Overrides Sub Accept(packet As Packet)
        If (packet.Originator.Equals(Me)) Then
            Console.WriteLine("The receiver of following packet does not exist:")
            Console.WriteLine(packet.ToString())
        Else
            Me.Send(packet)
        End If
    End Sub
    Public Function CanOriginate() As Boolean
        Return True
    End Function
    Public Overrides Function GetName() As String
        Return MyBase.GetName()
    End Function

End Class
