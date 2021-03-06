﻿Imports MySql.Data.MySqlClient
Module GlobalVariableModule


    Public MySQLConn As New MySqlConnection 'Variable for handling MySQL Connection
    Public connstring As String = "server=" & My.Settings.hostname & ";username=" & My.Settings.username & ";password=" & My.Settings.password & ";" 'This is the connection string to be used to connect to the MySQL Database

    Public database As String = "Database=scheduling;"

    Public comm As New MySqlCommand 'MySQL Command Handler
    Public reader As MySqlDataReader 'MySQL query result reader

    Public SystemTitle As String = "Faculty Workload Scheduling System" 'Variable to be used for the Dialog box titles.
    Public usertype As String = "" 'Public Variable to storte the logged-in user's usertype
    Public activeusername As String = "" 'Public Variable to store the activeuser's username
    Public activeuserfname As String = "" 'Public Variable to store the logged-in user's first name.
    Public activeuserlname As String = "" 'Public Variable to store the logged-in user's last name.

    Public SchoolYear As String = ""
    Public Semester As String = ""


    Public data As New DataSetPrint
    Public PrintAction As String

    Public Status As Boolean = False

    Public EntryText As String

    Public Sub CheckOpenConnection_AND_CloseIt()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
    End Sub
End Module
