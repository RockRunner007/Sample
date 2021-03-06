﻿Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework

Namespace Models
  Public Class ApplicationUser
    Inherits IdentityUser
    Public Async Function GenerateUserIdentityAsync(manager As UserManager(Of ApplicationUser)) As Task(Of ClaimsIdentity)
      ' Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
      Dim userIdentity = Await manager.CreateIdentityAsync(Me, DefaultAuthenticationTypes.ApplicationCookie)
      ' Add custom user claims here
      Return userIdentity
    End Function
  End Class
End Namespace