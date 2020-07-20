Imports System.Net
Imports System.Web.Http
Imports LIMSLive.Biz
Imports Newtonsoft.Json.Linq
Imports System.Data.SqlClient
Imports Microsoft.AspNet.SignalR

Public MustInherit Class BaseController
    Inherits ApiController
    Protected ReadOnly NotificationHub As New Lazy(Of IHubContext)(Function() GlobalHost.ConnectionManager.GetHubContext(Of NotificationHub)())
End Class