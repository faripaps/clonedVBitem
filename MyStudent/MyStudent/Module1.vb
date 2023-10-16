Imports System.Data.OleDb

Module Module1
    Public dbcon As New OleDb.OleDbConnection
    Public Sub connectDB()
        If dbcon.State = ConnectionState.Closed Then
            dbcon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\studentDB.mdb; User Id=admin;Password=;" ' "Provider=Microsoft.ACE.OLEDB.12.0; data source=C:\Users\Software\Desktop\\munyaWork\Student-Management-System-VB.Net-master\Student-Management-System-VB.Net-master\Flat Design\studentDB.accdb;Persist Security Info=False;"
            dbcon.Open()
        End If
    End Sub

End Module