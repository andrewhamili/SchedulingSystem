Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Module GlobalVariableModule
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;userid=root;Password=9Wy3Z3xTApDKUtPVN+TegRLTGR2mj8_M3*3ZJwSts83g9+pL?ZLEn?3xnuMR!2g;database=scheduling"
    Public comm As MySqlCommand
    Public a As Integer
    Public b As Integer
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
    Public activeusername As String
    Public activeuserfname As String
    Public activeusermname As String
    Public activeuserlname As String
    Public activeusertype As String
    Public tempcurrentusertype As String
    Public settime As Integer
    Public bmp As Bitmap
    Public subsPrint As String
    Public attempt As Integer
    Public reportwindowquery As String
    Public daytext As String
    Public query As String
    Public AssignSubejectPendingRowCounter As Integer = 0
    Public timeout As Integer = 0
    Public printquery As String
    Public dbconnectinstatus As Boolean = False
    Public closinglistener As Boolean
    Public hovercheck As Boolean
    Dim PCWithName As String = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
    Dim splitter As String() = PCWithName.Split("\")
    Public pcname As String = splitter(1)
    Public backupfilelength As Long
    Public mysqldir As String = "C:\Program Files\MySQL\MySQL Server 5.6\bin"
    Public defaultrundir As String





End Module
