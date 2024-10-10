
Imports Google.Cloud.Firestore

Public Class FORM_FIREBASE
    Private db As FirestoreDb

    Private Sub FORM_FIREBASE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa Firebase en el módulo CONEXION
        CONEXION.Firebase()
        ' Asigna la instancia de FirestoreDb del módulo CONEXION
        db = CONEXION.db
        Llenar()
    End Sub


    Private Async Sub Llenar()
        Firebase()

        Try
            ' Realizar consulta a Firestore
            Dim Qref As Query = db.Collection("Banks").WhereEqualTo("status", "1")
            Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

            ' Añadir columnas a DataGridView si no están presentes
            If DataGridView1.Columns.Count = 0 Then
                DataGridView1.Columns.Add("idbank", "idbank")
                DataGridView1.Columns.Add("namebank", "namebank")
                DataGridView1.Columns.Add("status", "status")
                ' Añadir más columnas si es necesario
            End If

            ' Llenar DataGridView
            For Each docSnapshot As DocumentSnapshot In Snap.Documents
                Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()
                DataGridView1.Rows.Add(data("idbank"), data("namebank"), data("status"))
            Next

            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error realizando la consulta a Firestore: " & ex.Message)
        End Try


    End Sub
End Class
