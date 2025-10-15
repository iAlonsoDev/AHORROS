Imports System.Data.SqlClient
Imports FirebaseAdmin
Imports Google.Cloud.Firestore

Public Module CONEXION

    Public cn As New SqlConnection(My.Settings.AHORROSConnectionString)
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public da As SqlDataAdapter
    Public sql, TIPO, Color As String

    '' variables de FORM MOVIMIENTOS
    Public TOT, AVAL, CANT, LAST, BEST, PROM As Double
    Public IDBan, IDBan2, IDAcc, IDAcc2 As Integer

    Public Amount = New ArrayList
    Public Desciption = New ArrayList
    Public Bank = New ArrayList
    Public Amount2 = New ArrayList
    Public Desciption2 = New ArrayList
    Public Bank2 = New ArrayList

    '' variables de FORM BANCOSCUENTAS
    Public IDBC, IDCB, IDAHORRO, CantRegistros As Integer


    '' variables disparadoras
    Public LoadA As Integer

    '' VARIABLES FIREBASE
    Public db As FirestoreDb

    Public Sub Firebase()
        Try
            ' Ruta completa al archivo de credenciales
            Dim pathToKeyFile As String = "C:\DATA\PROGRAMACION\Visual_Studio\AHORROS\AHORROS\alonsodev-59063-4b12104e10c3.json"

            ' Verificar si el archivo de credenciales existe
            If Not System.IO.File.Exists(pathToKeyFile) Then
                Throw New Exception("El archivo de credenciales no se encuentra en la ruta especificada.")
            End If

            ' Establecer la variable de entorno para Google Application Credentials
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToKeyFile)

            ' Inicializar el Firebase Admin SDK con las credenciales de la cuenta de servicio
            Dim credential As Google.Apis.Auth.OAuth2.GoogleCredential = Google.Apis.Auth.OAuth2.GoogleCredential.FromFile(pathToKeyFile)

            ' Verificar si la instancia de FirebaseApp ya ha sido creada
            If FirebaseApp.DefaultInstance Is Nothing Then
                FirebaseApp.Create(New AppOptions() With {.Credential = credential})
            End If

            ' Crear una instancia de FirestoreDb
            db = FirestoreDb.Create("alonsodev-59063")

            ''MessageBox.Show("Firebase inicializado correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error inicializando Firebase: " & ex.ToString())
        End Try
    End Sub



End Module
