
Imports System.Data.SqlClient
Imports Google.Cloud.Firestore


Public Class FormBancosCuentas

    Sub LoadBancosCuentas()

        Idbancos.Text = ""
        NombreBancos.Text = ""
        EstadoBancos.SelectedItem = "1"

        Idcuenta.Text = ""
        IdbancoCuenta.Text = ""
        NombreCuenta.Text = ""
        EstadoCuentas.SelectedItem = "1"

        CargarBancos()
        CargarCuentas()

    End Sub

    Public Sub CargarBancos()

        BancosDataGridView.DataSource = Nothing ' Limpiar datos existentes

        'Firebase() ' Obtener datos de Firebase

        'Dim Qref As Query = db.Collection("Banks")
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        '' Limpiar las columnas existentes
        'BancosDataGridView.Columns.Clear()

        '' Agregar columnas al DataGridView si aún no están presentes
        'BancosDataGridView.Columns.Add("idbankcolumn", "ID Bank")
        'BancosDataGridView.Columns.Add("namebankcolumn", "Name Bank")
        'BancosDataGridView.Columns.Add("statuscolumn", "Status")
        'BancosDataGridView.Columns.Add("namestatuscolumn", "Name Status")
        '' Agrega más columnas si es necesario

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ' Obtener el valor del estado
        '    Dim estado As Integer = Convert.ToInt32(data("status"))

        '    ' Determinar el nombre del estado
        '    Dim nameStatus As String
        '    If estado = 1 Then
        '        nameStatus = "ACTIVE"
        '    Else
        '        nameStatus = "DISABLE"
        '    End If

        '    ' Agregar los datos al DataGridView
        '    BancosDataGridView.Rows.Add(data("idbank"), data("namebank"), data("status"), nameStatus) ' Agrega los campos que desees mostrar
        'Next

        BancosDataGridView.Refresh()


        sql = "SELECT TOP (1000) [idbanco] IDBANK
           ,[nombre] BANKNAME
           ,[estado] STATUS
        ,case when [estado] = 1 then 'ACTIVE' ELSE 'DISABLE' END NAMESTATUS
           FROM [AHORROS].[dbo].[Bancos]
          Order by [idbanco] asc"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            BancosDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try

    End Sub

    Public Sub CargarCuentas()

        CuentasDataGridView.DataSource = Nothing ' Limpiar datos existentes

        'Firebase() ' Obtener datos de Firebase

        'Dim Qref As Query = db.Collection("Accounts")
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()


        ''cargo los bancos
        '' Obtener todos los nombres de los bancos
        'Dim bankNames As New Dictionary(Of String, String)()

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()
        '    Dim bankId As String = data("idbank").ToString()

        '    ' Verificar si ya hemos obtenido el nombre de este banco
        '    If Not bankNames.ContainsKey(bankId) Then
        '        Dim docRef As DocumentReference = db.Collection("Banks").Document(bankId)
        '        Dim bankSnapshot As DocumentSnapshot = Await docRef.GetSnapshotAsync()

        '        If bankSnapshot.Exists Then
        '            Dim bankData As Dictionary(Of String, Object) = bankSnapshot.ToDictionary()
        '            Dim bankName As String = bankData("namebank").ToString()
        '            bankNames.Add(bankId, bankName)
        '        End If
        '    End If
        'Next



        ' Limpiar las columnas existentes
        CuentasDataGridView.Columns.Clear()

        '' Agregar columnas al DataGridView si aún no están presentes
        'CuentasDataGridView.Columns.Add("idaccountcolumn", "ID Account")
        'CuentasDataGridView.Columns.Add("idbankcolumn", "ID Bank")
        'CuentasDataGridView.Columns.Add("namebankcolumn", "Name Bank")
        'CuentasDataGridView.Columns.Add("nameaccountcolumn", "Name Account")
        'CuentasDataGridView.Columns.Add("statuscolumn", "Status")
        'CuentasDataGridView.Columns.Add("namestatuscolumn", "Name Status")
        '' Agrega más columnas si es necesario

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ''busco en la lista de bancos creadas, y le mando el objeto a buscar
        '    Dim bankName As String = bankNames(data("idbank").ToString())

        '    ' Obtener el valor del estado
        '    Dim estado As Integer = Convert.ToInt32(data("status"))

        '    ' Determinar el nombre del estado
        '    Dim nameStatus As String
        '    If estado = 1 Then
        '        nameStatus = "ACTIVE"
        '    Else
        '        nameStatus = "DISABLE"
        '    End If

        '    ' Agregar los datos al DataGridView
        '    CuentasDataGridView.Rows.Add(data("idaccount"), data("idbank"), bankName, data("nameaccount"), data("status"), nameStatus) ' Agrega los campos que desees mostrar
        'Next

        CuentasDataGridView.Refresh()



        sql = "SELECT dbo.Cuentas.idcuenta IDACCOUNT,
                dbo.Bancos.idbanco IDBANK, 
                dbo.Bancos.nombre NAMEBANK,
                dbo.Cuentas.cuenta ACCOUNT, 
                dbo.Cuentas.estado STATUS,
                CASE WHEN Cuentas.estado = 1 then 'ACTIVE' ELSE 'DISABLE' END NAMESTATUS
                FROM dbo.Bancos INNER JOIN
                dbo.Cuentas ON dbo.Bancos.idbanco = dbo.Cuentas.idbanco"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            CuentasDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuardarBanco()
    End Sub

    Public Sub GuardarBanco()

        If MsgBox("Confirm", MsgBoxStyle.Question + MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then


            ''If BancosDataGridView.Rows.Count = 0 Then
            ''    Return
            ''End If

            '' Inicializa Firestore
            'Firebase()


            '' Obtiene el ID del banco de la fila actual
            'Dim idbank As Integer = Convert.ToInt32(Idbancos.Text)

            '' Verifica si ya existe un documento con el mismo ID
            'Dim docRef = db.Collection("Banks").Document(idbank)
            '    Dim docSnapshot = Await docRef.GetSnapshotAsync()

            '' Verifica si el documento ya existe
            'If docSnapshot.Exists Then
            '    ' Si el documento ya existe, actualiza sus datos
            '    Dim datos As New Dictionary(Of String, Object) From {
            '        {"namebank", Convert.ToString(NombreBancos.Text)},
            '        {"status", Convert.ToString(EstadoBancos.Text)}
            '    }

            '    Await docRef.SetAsync(datos, SetOptions.MergeAll)
            '    MessageBox.Show("Update item successfully")
            'Else
            '    ' Si el documento no existe, crea uno nuevo
            '    Dim datos As New Dictionary(Of String, Object) From {
            '        {"idbank", idbank},
            '        {"namebank", Convert.ToString(NombreBancos.Text)},
            '        {"status", Convert.ToString(EstadoBancos.Text)}
            '    }

            '    Await db.Collection("Banks").Document(idbank).SetAsync(datos)
            '    MessageBox.Show("Item has been created successfully")
            'End If



            cn.Open()
            cmd = New SqlCommand("SELECT [idbanco]
                              FROM [dbo].[Bancos]
                              WHERE [idbanco] = " + Idbancos.Text + "") With {
                                            .Connection = cn,
                                            .CommandType = CommandType.Text
                                        }
            dr = cmd.ExecuteReader()

            If dr.Read Then

                Using cn As New SqlConnection(My.Settings.AHORROSConnectionString)

                    cn.Open()

                    sql = "UPDATE [dbo].[Bancos]
                       SET [nombre] = @nombre
                          ,[estado] = @estado
                     WHERE [idbanco] = @idbanco"

                    cmd = New SqlCommand(sql, cn) With {
                .CommandText = "InsertBanco",
                .CommandType = CommandType.StoredProcedure
            }
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("trans", "U")
                    cmd.Parameters.AddWithValue("nombre", NombreBancos.Text)
                    cmd.Parameters.AddWithValue("estado", EstadoBancos.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("idbanco", Idbancos.Text)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using

            Else

                Using cn As New SqlConnection(My.Settings.AHORROSConnectionString)
                    cn.Open()
                    sql = "INSERT INTO [dbo].[Bancos]
                               ([idbanco]
                               ,[nombre]
                               ,[estado])
                         VALUES
                               (@idbanco
                               ,@nombre
                               ,@estado)"
                    cmd = New SqlCommand(sql, cn) With {
                .CommandText = "InsertBanco",
                .CommandType = CommandType.StoredProcedure
            }
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("trans", "I")
                    cmd.Parameters.AddWithValue("idbanco", Idbancos.Text)
                    cmd.Parameters.AddWithValue("nombre", NombreBancos.Text)
                    cmd.Parameters.AddWithValue("estado", EstadoBancos.SelectedItem.ToString)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using

            End If

            dr.Close()
            cn.Close()

            LoadBancosCuentas()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GuardarCuenta()
    End Sub

    Public Sub GuardarCuenta()
        If MsgBox("Confirm", MsgBoxStyle.Question + MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

            'If BancosDataGridView.Rows.Count = 0 Then
            '    Return
            'End If

            ' Inicializa Firestore
            'Firebase()


            '' Obtiene el ID del banco de la fila actual
            'Dim idbank As Integer = Convert.ToInt32(IdbancoCuenta.Text)
            'Dim idaccount As Integer = Convert.ToInt32(Idcuenta.Text)

            '' Verifica si ya existe un documento con el mismo ID
            'Dim docRef = db.Collection("Accounts").Document(idaccount.ToString)
            'Dim docSnapshot = Await docRef.GetSnapshotAsync()

            '' Verifica si el documento ya existe
            'If docSnapshot.Exists Then
            '    ' Si el documento ya existe, actualiza sus datos
            '    Dim datos As New Dictionary(Of String, Object) From {
            '        {"idbank", idbank},
            '        {"nameaccount", Convert.ToString(NombreBancos.Text)},
            '        {"status", Convert.ToString(EstadoBancos.Text)}
            '    }

            '    Await docRef.SetAsync(datos, SetOptions.MergeAll)
            '    MessageBox.Show("Update item successfully")
            'Else
            '    ' Si el documento no existe, crea uno nuevo
            '    Dim datos As New Dictionary(Of String, Object) From {
            '        {"idaccount", idaccount},
            '        {"idbank", idbank},
            '        {"namebank", Convert.ToString(NombreBancos.Text)},
            '        {"status", Convert.ToString(EstadoBancos.Text)}
            '    }

            '    Await db.Collection("Banks").Document(idaccount).SetAsync(datos)
            '    MessageBox.Show("Item has been created successfully")
            'End If


            cn.Open()
            cmd = New SqlCommand("SELECT [idcuenta]
                                  FROM [AHORROS].[dbo].[Cuentas]
                                  WHERE  [idcuenta] = " + Idcuenta.Text + "") With {
                                            .Connection = cn,
                                            .CommandType = CommandType.Text
                                        }
            dr = cmd.ExecuteReader()

            If dr.Read Then

                Using cn As New SqlConnection(My.Settings.AHORROSConnectionString)

                    cn.Open()

                    sql = "UPDATE [dbo].[Cuentas]
                           SET [idbanco] = @idbanco
                              ,[cuenta] = @cuenta
                              ,[estado] = @estado
                         WHERE [idcuenta] = @idcuenta"

                    cmd = New SqlCommand(sql, cn) With {
                .CommandText = "InsertCuenta",
                .CommandType = CommandType.StoredProcedure
            }
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("trans", "U")
                    cmd.Parameters.AddWithValue("idbanco", IdbancoCuenta.Text)
                    cmd.Parameters.AddWithValue("cuenta", NombreCuenta.Text)
                    cmd.Parameters.AddWithValue("estado", EstadoCuentas.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("idcuenta", Idcuenta.Text)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using

            Else

                Using cn As New SqlConnection(My.Settings.AHORROSConnectionString)
                    cn.Open()
                    sql = "INSERT INTO [dbo].[Cuentas]
                               ([idcuenta]
                               ,[idbanco]
                               ,[cuenta]
                               ,[estado])
                         VALUES
                               (@idcuenta
                               ,@idbanco
                               ,@cuenta
                               ,@estado)"
                    cmd = New SqlCommand(sql, cn) With {
                .CommandText = "InsertCuenta",
                .CommandType = CommandType.StoredProcedure
            }
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("trans", "I")
                    cmd.Parameters.AddWithValue("idcuenta", Idcuenta.Text)
                    cmd.Parameters.AddWithValue("idbanco", IdbancoCuenta.Text)
                    cmd.Parameters.AddWithValue("cuenta", NombreCuenta.Text)
                    cmd.Parameters.AddWithValue("estado", EstadoCuentas.SelectedItem.ToString)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                End Using

            End If

            dr.Close()
            cn.Close()

            LoadBancosCuentas()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub


    Private Sub GuardarBank_Click(sender As Object, e As EventArgs) Handles GuardarBank.Click
        GuardarBanco()
    End Sub

    Private Sub GuardarAccount_Click(sender As Object, e As EventArgs) Handles GuardarAccount.Click
        GuardarCuenta()
    End Sub

    Private Sub BancosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BancosDataGridView.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = BancosDataGridView.Rows(index)

            Idbancos.Text = selectedRow.Cells(0).Value
            NombreBancos.Text = selectedRow.Cells(1).Value
            EstadoBancos.SelectedItem = selectedRow.Cells(2).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CuentasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CuentasDataGridView.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = CuentasDataGridView.Rows(index)

            Idcuenta.Text = selectedRow.Cells(0).Value
            IdbancoCuenta.Text = selectedRow.Cells(1).Value
            NombreCuenta.Text = selectedRow.Cells(3).Value
            EstadoCuentas.SelectedItem = selectedRow.Cells(4).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormBancosCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBancosCuentas()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CMD_UFB_B.Click
        CargarBancosFB()
    End Sub

    Public Async Sub CargarBancosFB()

        If BancosDataGridView.Rows.Count = 0 Then
            Return
        End If

        ' Inicializa Firestore
        Firebase()

        ' Recorre cada fila del DataGridView
        For Each row As DataGridViewRow In BancosDataGridView.Rows

            ' Obtiene el ID del banco de la fila actual
            Dim idbank As Integer = Convert.ToInt32(row.Cells(0).Value)

            ' Verifica si ya existe un documento con el mismo ID
            Dim docRef = db.Collection("Banks").Document(idbank.ToString)
            Dim docSnapshot = Await docRef.GetSnapshotAsync()

            ' Verifica si el documento ya existe
            If docSnapshot.Exists Then
                ' Si el documento ya existe, actualiza sus datos
                Dim datos As New Dictionary(Of String, Object) From {
                    {"namebank", Convert.ToString(row.Cells(1).Value)},
                    {"status", Convert.ToString(row.Cells(2).Value)}
                }

                Await docRef.SetAsync(datos, SetOptions.MergeAll)
            Else
                ' Si el documento no existe, crea uno nuevo
                Dim datos As New Dictionary(Of String, Object) From {
                    {"idbank", idbank},
                    {"namebank", Convert.ToString(row.Cells(1).Value)},
                    {"status", Convert.ToString(row.Cells(2).Value)}
                }

                Await db.Collection("Banks").Document(idbank.ToString).SetAsync(datos)
            End If
        Next

        MessageBox.Show("Datos cargados en Firestore.")


    End Sub

    Private Sub CMD_UFB_A_Click(sender As Object, e As EventArgs) Handles CMD_UFB_A.Click
        CargarCuentasFB()
    End Sub

    Public Async Sub CargarCuentasFB()
        If CuentasDataGridView.Rows.Count = 0 Then
            Return
        End If

        ' Inicializa Firestore
        Firebase()

        ' Recorre cada fila del DataGridView
        For Each row As DataGridViewRow In CuentasDataGridView.Rows

            ' Obtiene el ID del banco de la fila actual
            Dim idaccount As Integer = Convert.ToInt32(row.Cells(0).Value)
            Dim idbank As Integer = Convert.ToInt32(row.Cells(1).Value)

            ' Verifica si ya existe un documento con el mismo ID
            Dim docRef = db.Collection("Accounts").Document(idaccount.ToString)
            Dim docSnapshot = Await docRef.GetSnapshotAsync()

            ' Verifica si el documento ya existe
            If docSnapshot.Exists Then
                ' Si el documento ya existe, actualiza sus datos
                Dim datos As New Dictionary(Of String, Object) From {
                    {"idbank", idbank},
                    {"nameaccount", Convert.ToString(row.Cells(3).Value)},
                    {"status", Convert.ToString(row.Cells(4).Value)}
                }

                Await docRef.SetAsync(datos, SetOptions.MergeAll)
            Else
                ' Si el documento no existe, crea uno nuevo
                Dim datos As New Dictionary(Of String, Object) From {
                    {"idaccount", idaccount},
                    {"idbank", idbank},
                    {"nameaccount", Convert.ToString(row.Cells(3).Value)},
                    {"status", Convert.ToString(row.Cells(4).Value)}
                }

                Await db.Collection("Accounts").Document(idaccount.ToString).SetAsync(datos)
            End If
        Next

        MessageBox.Show("Datos cargados en Firestore.")
    End Sub

End Class