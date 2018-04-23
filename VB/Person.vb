Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Public Class Person
	Public Shared Function GetDemoData() As List(Of Person)
		Dim list As New List(Of Person)()
		list.Add(New Person() With {.ID = 1, .FirstName = "John", .LastName = "Doe"})
		list.Add(New Person() With {.ID = 2, .FirstName = "Jane", .LastName = "Doe"})
		Return list
	End Function

	Public Sub New()
	End Sub

	Private _ID As Integer
	Public Property ID() As Integer
		Get
			Return _ID
		End Get
		Set(ByVal value As Integer)
			_ID = value
		End Set
	End Property


	Private _FirstName As String
	Public Property FirstName() As String
		Get
			Return _FirstName
		End Get
		Set(ByVal value As String)
			_FirstName = value
		End Set
	End Property

	Private _LastName As String
	Public Property LastName() As String
		Get
			Return _LastName
		End Get
		Set(ByVal value As String)
			_LastName = value
		End Set
	End Property
End Class