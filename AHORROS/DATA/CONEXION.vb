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
            Dim pathToKeyFile As String = "C:\DATA\DEVELOPMENT\Visual_Studio\AHORROS\AHORROS\alonsodev-59063-0ef8c3033075.json"

            ' Verificar si el archivo existe
            If Not System.IO.File.Exists(pathToKeyFile) Then
                Throw New Exception("El archivo de credenciales no se encuentra en: " & pathToKeyFile)
            End If

            ' Establecer variable de entorno
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToKeyFile)

            ' Crear instancia de FirestoreDb directamente
            ' Con Google.Cloud.Firestore no necesitas FirebaseApp
            db = FirestoreDb.Create("alonsodev-59063")

            ' Opcional: Verificar conexión
            If db IsNot Nothing Then
                Console.WriteLine("Firebase Firestore inicializado correctamente.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error inicializando Firebase: " & ex.Message & vbCrLf & vbCrLf &
                          "Detalles: " & ex.ToString(), "Error de Conexión",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Module
