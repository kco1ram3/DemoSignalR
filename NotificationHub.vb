﻿Imports System
Imports System.Web
Imports Microsoft.AspNet.SignalR
Imports Microsoft.AspNet.SignalR.Hubs

<HubName("notification")>
Public Class NotificationHub
    Inherits Hub

    Public Sub Send(ByVal name As String, ByVal message As String)
        Clients.All.broadcastMessage(name, message)
    End Sub

End Class
