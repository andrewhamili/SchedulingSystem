Imports MySql.Data.MySqlClient
Module GlobalVariableModule


    Public MySQLConn As New MySqlConnection 'Variable for handling MySQL Connection
    Public connstring As String = "server=localhost;username=root;password=root;Database=scheduling" 'This is the connection string to be used to connect to the MySQL Database
    Public comm As New MySqlCommand 'MySQL Command Handler
    Public reader As MySqlDataReader 'MySQL query result reader

    Public SystemTitle As String = "Scheduling System" 'Variable to be used for the Dialog box titles.
    Public usertype As String = "" 'Public Variable to storte the logged-in user's usertype
    Public activeusername As String = "" 'Public Variable to store the activeuser's username
    Public activeuserfname As String = "" 'Public Variable to store the logged-in user's first name.
    Public activeuserlname As String = "" 'Public Variable to store the logged-in user's last name.


End Module
