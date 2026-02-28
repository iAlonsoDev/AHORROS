
Imports System.Data.SqlClient
Imports System.Globalization
Imports Google.Cloud.Firestore

Public Class FormMovimientos

    ReadOnly obj As New BUSQUEDADINAMICA

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sender Is Nothing Then
            Throw New ArgumentNullException(NameOf(sender))
        End If


        ' LAS TRANSACCIONES REALIZADAS DESDE MI APPLICACION DE FLUTTER CON FIREBASE SE DESCARGARAN Y SE SUBIRAN A SQL SERVER,
        ' PARA SINCRONIZAR LA INFORMACION ENTRE MI APP FLUTTER Y MI APP VB.NET
        ' se probo con conexion full a firebase pero el consumo de datos era demasiado, la cuota de google
        If MsgBox("Load data to SQLServer from Firebase?", MsgBoxStyle.Question + MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            DownloadFirebase()
            LoadForm()
        Else
            LoadForm()
        End If
        'DownloadFirebase()

    End Sub

    Public Sub LoadForm()

        Timer1.Start()

        LlenarBancos()
        CargarIDBanco()

        LlenarCuentas()
        CargarIDCuentas()

        'LlenarBancos2()
        'CargarIDBanco2()

        'LlenarCuentas2()
        'CargarIDCuentas2()


        LlenarDisponible()
        txtPorV.Visible = False
        txtPorR.Visible = False
        txtPorA.Visible = False
        LlenarPor()
        LlenarTotal()
        LlenarUltimaTransaccion()
        BestAccount()
        BestRanking()
        Promedio()

        TotalTextBox.Text = Format(Val(TOT), "#,###.##")
        CargarMovimientos()
        RB_DEPOSITO.Checked = True
        TIPO = "DEPOSIT"
        ReferenciaTextBox.Text = "NINGUNA"
        DepositoTextBox.Text = ""
        DepositoTextBox.Focus()
        DepositoTextBox.Select()

        GrafCuenta()
        GrafBanco()

        IDAHORRO = 0

    End Sub

    Public Sub LlenarDisponible()

        '' Obtener datos de Firebase
        'Firebase()

        'Dim Qref As Query = db.Collection("Transactions")
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        'Dim totavailable As Double = 0

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    If data("idbank") != 6 &&  data("idbank") != 8 &&  data("idbank") != 9 Then
        '        totavailable += data("amount")
        '    End If
        '    ' Obtener idbank y namebank
        '    AVAL = totavailable
        '    Txt_TotalAvailable.Text = "L. " + Format(Val(totavailable), "#,###.##")
        'Next


        cn.Open()
        cmd = New SqlCommand("SELECT COALESCE(SUM(deposito), 0)  AS AVAILABLE
                    FROM [AHORROS].[dbo].[Movimientos] WHERE IDBANCO NOT IN (6, 8, 9)") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            AVAL = Convert.ToDouble(dr.Item("AVAILABLE"))
            Txt_TotalAvailable.Text = "L. " + Format(Val(AVAL), "#,###.##")
        End If

        dr.Close()
        cn.Close()

    End Sub

    Public Sub LlenarPor()
        ' Evitar división por cero y asegurar valores por defecto cuando no hay datos
        cn.Open()
        cmd = New SqlCommand("select 
                            y.diferencia,
                            y.porc,
                            case when y.valor < -10 then 'Rojo' else 
                            case when y.valor between -10 and -5 then 'Amarillo' 
                            else 'Verde' end end color
                            from (select x.*, str(((balance / best)-1) * 100) ++ '%'  porc, ((balance / best)-1) * 100 valor, balance - best diferencia
                            from (SELECT MAX(total) best, (SELECT sum(deposito) balance FROM [AHORROS].[dbo].[Movimientos]) balance FROM [AHORROS].[dbo].[Movimientos]) x
                            ) y") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }

        dr = cmd.ExecuteReader()

        If dr.Read Then
            ' Asignar valores defensivamente, manejando posibles DBNull
            Dim dif As Object = If(IsDBNull(dr.Item("diferencia")), 0, dr.Item("diferencia"))
            Dim porc As String = If(IsDBNull(dr.Item("porc")), "0.00%", Convert.ToString(dr.Item("porc")))
            Dim col As String = If(IsDBNull(dr.Item("color")), "Verde", Convert.ToString(dr.Item("color")))

            ' Convertir de forma segura a Decimal y formatear siempre con dos decimales
            Dim difDec As Decimal

            Try
                difDec = Convert.ToDecimal(dif)
            Catch ex As Exception
                difDec = 0D
            End Try
            txtDiferencia.Text = "L " & difDec.ToString("#,##0.00")
            txtPorV.Text = porc
            txtPorR.Text = porc
            txtPorA.Text = porc
            Color = col
        Else
            txtDiferencia.Text = "L 0.00"
            txtPorV.Text = "0.00%"
            txtPorR.Text = "0.00%"
            txtPorA.Text = "0.00%"
            Color = "Verde"
        End If

        txtPorV.Visible = False
        txtPorR.Visible = False
        txtPorA.Visible = False

        If (Color = "Rojo") Then
            txtPorR.Visible = True
        ElseIf (Color = "Amarillo") Then
            txtPorA.Visible = True
        Else
            txtPorV.Visible = True
        End If

        dr.Close()
        cn.Close()

    End Sub


    Public Sub GrafCuenta()

        'Dim totalMoneyPerAccount As New Dictionary(Of String, Double)()

        '' Obtener los nombres de los bancos
        'Dim bankNames As New Dictionary(Of Integer, String)()

        '' Cargar nombres de bancos desde la colección "Banks"
        'Dim banksRef As CollectionReference = db.Collection("Banks")
        'Dim banksSnap As QuerySnapshot = Await banksRef.GetSnapshotAsync()

        'For Each bankDoc As DocumentSnapshot In banksSnap.Documents
        '    Dim bankId As Integer = Convert.ToInt32(bankDoc.Id)
        '    Dim bankName As String = bankDoc.ToDictionary("namebank").ToString()
        '    bankNames.Add(bankId, bankName)
        'Next

        '' Obtener los nombres de las cuentas
        'Dim accountNames As New Dictionary(Of Integer, String)()

        '' Cargar nombres de cuentas desde la colección "Accounts"
        'Dim accountsRef As CollectionReference = db.Collection("Accounts")
        'Dim accountsSnap As QuerySnapshot = Await accountsRef.GetSnapshotAsync()

        'For Each accountDoc As DocumentSnapshot In accountsSnap.Documents
        '    Dim accountId As Integer = Convert.ToInt32(accountDoc.Id)
        '    Dim accountName As String = accountDoc.ToDictionary("nameaccount").ToString()
        '    accountNames.Add(accountId, accountName)
        'Next

        '' Cargar datos de transacciones y calcular total de dinero por cuenta
        'Firebase()

        'Try
        '    ' Obtener datos de Firebase
        '    Dim Qref As Query = db.Collection("Transactions")
        '    Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        '    ' Iterar sobre cada documento de transacción
        '    For Each transactionDoc As DocumentSnapshot In Snap.Documents
        '        ' Acceder a los campos del documento correctamente
        '        Dim idAccount As Integer = Convert.ToInt32(transactionDoc.ToDictionary("idaccount"))
        '        Dim idBank As Integer = Convert.ToInt32(transactionDoc.ToDictionary("idbank")) ' Suponiendo que idbank en Transactions se refiere a la cuenta
        '        Dim accountName As String = accountNames(idAccount)
        '        Dim amount As Double = Convert.ToDouble(transactionDoc.ToDictionary("amount"))
        '        ' Actualizar el total de dinero por cuenta
        '        If totalMoneyPerAccount.ContainsKey(accountName) Then
        '            totalMoneyPerAccount(accountName) += amount
        '        Else
        '            totalMoneyPerAccount(accountName) = amount
        '        End If
        '    Next

        '    ' Actualizar la gráfica con los datos obtenidos
        '    For Each kvp As KeyValuePair(Of String, Double) In totalMoneyPerAccount
        '        If kvp.Value <> 0 Then
        '            ''Desciption.Add(kvp.Key + " " + kvp.Value.ToString)
        '            Desciption.Add(kvp.Key + " - " + Format(Val(kvp.Value), "#,###.##").ToString)
        '            Amount.Add(kvp.Value)
        '        End If
        '    Next

        '    ' Enlazar los datos a la gráfica
        '    ChartTotCuenta.Series(0).Points.DataBindXY(Desciption, Amount)

        'Catch ex As Exception
        '    ' Manejar las excepciones según sea necesario
        '    Console.WriteLine($"Error: {ex.Message}")
        'End Try


        Amount = New ArrayList
        Desciption = New ArrayList
        Bank = New ArrayList

        cmd = New SqlCommand("TotCuentas", cn) With {
            .CommandType = CommandType.StoredProcedure
        }
        cn.Open()
        dr = cmd.ExecuteReader()

        While (dr.Read)
            Amount.Add(dr.GetDecimal(0))
            Bank.Add(dr.GetString(2))
            Desciption.Add(dr.GetString(1))
            ChartTotCuenta.Series(0).Points.DataBindXY(Desciption, Amount)
        End While

        dr.Close()
        cn.Close()

    End Sub

    Public Sub GrafBanco()

        'Dim totalMoneyPerBank As New Dictionary(Of String, Double)()


        '' Cargar datos de transacciones y calcular total de dinero por banco
        'Firebase()

        '' Obtener los nombres de los bancos
        'Dim bankNames As New Dictionary(Of Integer, String)()

        '' Cargar nombres de bancos desde la colección "Banks"
        'Dim banksRef As CollectionReference = db.Collection("Banks")
        'Dim banksSnap As QuerySnapshot = Await banksRef.GetSnapshotAsync()

        'For Each bankDoc As DocumentSnapshot In banksSnap.Documents
        '    Dim bankId As Integer = Convert.ToInt32(bankDoc.Id)
        '    Dim bankName As String = bankDoc.ToDictionary("namebank").ToString()
        '    bankNames.Add(bankId, bankName)
        'Next


        'Try
        '    ' Obtener datos de Firebase
        '    Dim Qref As Query = db.Collection("Transactions")
        '    Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        '    ' Iterar sobre cada documento de transacción
        '    For Each transactionDoc As DocumentSnapshot In Snap.Documents
        '        ' Acceder a los campos del documento correctamente
        '        Dim idBank As Integer = Convert.ToInt32(transactionDoc.ToDictionary("idbank"))
        '        Dim bankName As String = bankNames(idBank)
        '        Dim amount As Double = Convert.ToDouble(transactionDoc.ToDictionary("amount"))
        '        ' Actualizar el total de dinero por banco
        '        If totalMoneyPerBank.ContainsKey(bankName) Then
        '            totalMoneyPerBank(bankName) += amount
        '        Else
        '            totalMoneyPerBank(bankName) = amount
        '        End If
        '    Next

        '    ' Actualizar la gráfica con los datos obtenidos
        '    For Each kvp As KeyValuePair(Of String, Double) In totalMoneyPerBank
        '        Desciption2.Add(kvp.Key)
        '        Amount2.Add(kvp.Value)
        '    Next

        '    ' Enlazar los datos a la gráfica
        '    ChartTotBancos.Series(0).Points.DataBindXY(Desciption2, Amount2)

        'Catch ex As Exception
        '    ' Manejar las excepciones según sea necesario
        '    Console.WriteLine($"Error: {ex.Message}")
        'End Try



        Amount2 = New ArrayList
        Desciption2 = New ArrayList
        Bank2 = New ArrayList

        cmd = New SqlCommand("TotBancos", cn) With {
            .CommandType = CommandType.StoredProcedure
        }
        cn.Open()
        dr = cmd.ExecuteReader()

        While (dr.Read)
            Amount2.Add(dr.GetDecimal(0))
            Bank2.Add(dr.GetString(2))
            Desciption2.Add(dr.GetString(1))
            ChartTotBancos.Series(0).Points.DataBindXY(Desciption2, Amount2)
        End While

        dr.Close()
        cn.Close()

    End Sub

    Public Sub LlenarTotal()

        '' Obtener datos de Firebase
        'Firebase()

        'Dim Qref As Query = db.Collection("Transactions").OrderByDescending("idtransaction").Limit(1)
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ' Obtener idbank y namebank
        '    TOT = data("summary")
        '    TotalTextBox.Text = Format(Val(TOT), "#,###.##")
        '    TxtCant_TotalBalance.Text = "L. " + Format(Val(TOT), "#,###.##")
        'Next

        cn.Open()
        cmd = New SqlCommand("SELECT COALESCE(SUM(deposito), 0)  AS TOTAL
                            FROM [AHORROS].[dbo].[Movimientos]") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            TOT = dr.Item("TOTAL")
            TotalTextBox.Text = Format(Val(TOT), "#,###.##")
            TxtCant_TotalBalance.Text = "L. " + Format(Val(TOT), "#,###.##")
        End If

        dr.Close()
        cn.Close()

    End Sub

    Public Sub BestAccount()

        '' Diccionario para almacenar el total de dinero por banco
        'Dim totalMoneyPerBank As New Dictionary(Of Integer, Double)()

        'Firebase()

        'Try
        '    ' Obtener datos de Firebase
        '    Dim Qref As Query = db.Collection("Transactions")
        '    Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        '    ' Itera sobre cada documento de transacción
        '    For Each transactionDoc As DocumentSnapshot In Snap.Documents
        '        ' Accede a los campos del documento correctamente
        '        Dim idBank As Integer = Convert.ToInt32(transactionDoc.ToDictionary("idbank"))
        '        Dim amount As Double = Convert.ToDouble(transactionDoc.ToDictionary("amount"))
        '        ' Actualiza el total de dinero por banco
        '        If totalMoneyPerBank.ContainsKey(idBank) Then
        '            totalMoneyPerBank(idBank) += amount
        '        Else
        '            totalMoneyPerBank(idBank) = amount
        '        End If
        '    Next

        '    ' Encuentra el banco con más dinero
        '    Dim bankWithMostMoney As Integer = 0
        '    Dim mostMoney As Double = 0.0

        '    For Each kvp As KeyValuePair(Of Integer, Double) In totalMoneyPerBank
        '        If kvp.Value > mostMoney Then
        '            bankWithMostMoney = kvp.Key
        '            mostMoney = kvp.Value
        '        End If
        '    Next

        '    ' Obtén el nombre del banco con más dinero
        '    Dim bankDoc As DocumentSnapshot = Await db.Collection("Banks").Document(bankWithMostMoney.ToString()).GetSnapshotAsync()

        '    If bankDoc.Exists Then
        '        Dim bankName As String = bankDoc.ToDictionary("namebank").ToString()

        '        ' Actualiza la UI desde el hilo de la interfaz de usuario
        '        TxtTitle_TopBalance.Invoke(Sub()
        '                                       TxtTitle_TopBalance.Text = "TOP - " & bankName
        '                                       TxtCant_TopBalance.Text = "L. " & Convert.ToString(Format(Val(mostMoney), "#,###.##"))
        '                                   End Sub)
        '    End If

        'Catch ex As Exception
        '    ' Maneja las excepciones según sea necesario
        '    Console.WriteLine($"Error: {ex.Message}")
        'End Try



        cn.Open()
        cmd = New SqlCommand("SELECT        TOP (1) SUM(dbo.Movimientos.deposito) AS Amount, dbo.Bancos.nombre AS Description
                                FROM            dbo.Bancos INNER JOIN
                                                         dbo.Movimientos ON dbo.Bancos.idbanco = dbo.Movimientos.idbanco INNER JOIN
                                                         dbo.Cuentas ON dbo.Movimientos.idcuenta = dbo.Cuentas.idcuenta
                                GROUP BY dbo.Bancos.nombre
                                ORDER BY Amount DESC") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            TxtTitle_TopBalance.Text = "TOP" + " - " + dr.Item("Description")
            TxtCant_TopBalance.Text = "L." + " " + Convert.ToString(Format(Val(dr.Item("Amount")), "#,###.##"))
        End If

        dr.Close()
        cn.Close()

    End Sub

    Public Sub LlenarUltimaTransaccion()

        '' Obtener datos de Firebase
        'Firebase()

        'Dim Qref As Query = db.Collection("Transactions").OrderByDescending("idtransaction").Limit(1)
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ' Obtener idbank y namebank
        '    LAST = data("amount")
        '    TxtCant_LastTransaction.Text = "L. " + Format(Val(LAST), "#,###.##")
        'Next

        cn.Open()
        cmd = New SqlCommand("SELECT TOP(1) DEPOSITO, TIPO FROM Movimientos ORDER BY IDAHORRO DESC") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            LAST = dr.Item("DEPOSITO")
            TxtCant_LastTransaction.Text = "L. " + Format(Val(LAST), "#,###.##")
        End If

        dr.Close()
        cn.Close()

    End Sub

    Public Sub BestRanking()

        'Firebase()

        'Dim Qref As Query = db.Collection("Transactions").OrderByDescending("summary").Limit(1)
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ' Obtener idbank y namebank
        '    BEST = data("summary")
        '    Txt_BestRanking.Text = "L. " + Format(Val(BEST), "#,###.##")
        'Next

        cn.Open()
        cmd = New SqlCommand("SELECT COALESCE(max([total]), 0) as Best
                                FROM [AHORROS].[dbo].[Movimientos]") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            BEST = dr.Item("Best")
            Txt_BestRanking.Text = "L. " + Format(Val(BEST), "#,###.##")
        End If

        dr.Close()
        cn.Close()

    End Sub

    Public Sub Promedio()

        'CargarCantRegistros()

        'Firebase()

        'Dim Qref As Query = db.Collection("Transactions")
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()
        'Dim Tot As Integer

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ' Obtener idbank y namebank
        '    Tot += data("summary")

        'Next

        'PROM = (Tot / CantRegistros)
        'TxtCant_Promedio.Text = "L. " + Format(Val(PROM), "#,###.##")



        cn.Open()
        cmd = New SqlCommand("SELECT COALESCE(ROUND(SUM([total]) / COUNT(idahorro), 2), 0) PROM
                              FROM [AHORROS].[dbo].[Movimientos]") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            PROM = dr.Item("Prom")
            TxtCant_Promedio.Text = "Average: L. " + Format(Val(PROM), "#,###.##")
        End If

        dr.Close()
        cn.Close()

    End Sub

    'Public Async Sub CargarCantRegistros()

    '    Firebase()

    '    Dim Qref As Query = db.Collection("Transactions").OrderByDescending("idtransaction").Limit(1)
    '    Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

    '    If Snap.Documents.Count > 0 Then
    '        Dim docSnapshot As DocumentSnapshot = Snap.Documents(0)

    '        If docSnapshot.Exists Then
    '            ' Access the data inside the document
    '            Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

    '            ' Obtain idtransaction
    '            CantRegistros = data("idtransaction")
    '        End If
    '    End If

    '    'For Each docSnapshot As DocumentSnapshot In Snap.Documents
    '    '    ' Acceder a los datos dentro de cada documento
    '    '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

    '    '    ' Obtener idbank y namebank
    '    'Next

    'End Sub



    Public Sub LlenarBancos()

        'Firebase() ' Obtener datos de Firebase

        'Dim Qref As Query = db.Collection("Banks").WhereEqualTo("status", "1").OrderBy("namebank")
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        '' Crear una lista para almacenar los nombres de los bancos
        'Dim bankNames As New List(Of String)

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ' Agregar el nombre del banco a la lista
        '    bankNames.Add(data("namebank").ToString())
        'Next

        '' Asignar la lista como origen de datos del ComboBox
        'BancoComboBox.DataSource = bankNames
        'BancoComboBox.SelectedIndex = 0


        ''BancosDataGridView.Refresh()

        sql = "SELECT [idbanco]
         ,[nombre]
        FROM [AHORROS].[dbo].[Bancos] WHERE estado = '1'
        Order by nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        BancoComboBox.DataSource = ds.Tables(0)
        BancoComboBox.DisplayMember = "Nombre"

    End Sub


    'Sub LlenarBancos2()

    '    sql = "SELECT TOP (1000) [idbanco]
    '     ,[nombre]
    '    FROM [AHORROS].[dbo].[Bancos] WHERE estado = '1'
    '    Order by nombre asc"
    '    da = New SqlDataAdapter(sql, cn)
    '    ds = New DataSet
    '    da.Fill(ds)

    '    BancoComboBox2.DataSource = ds.Tables(0)
    '    BancoComboBox2.DisplayMember = "Nombre"

    'End Sub

    Public Sub CargarIDBanco()

        '' Obtener datos de Firebase
        'Firebase()
        'Dim Qref As Query = db.Collection("Banks").WhereEqualTo("namebank", BancoComboBox.Text)
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        ''For Each docSnapshot As DocumentSnapshot In Snap.Documents
        ''    ' Acceder a los datos dentro de cada documento
        ''    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        ''    ' Obtener idbank y namebank
        ''    IDBan = data("idbank")
        ''Next


        'If Snap.Documents.Count > 0 Then
        '    Dim docSnapshot As DocumentSnapshot = Snap.Documents(0)

        '    If docSnapshot.Exists Then
        '        ' Access the data inside the document
        '        Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '        IDBan = data("idbank")
        '    End If
        'End If

        '' al cargar los nombre de los bancos y los id, llamamos las cuentas
        LlenarCuentas()


        cn.Open()
        cmd = New SqlCommand("SELECT [idbanco]
                              FROM [AHORROS].[dbo].[Bancos]
                              WHERE [nombre] = '" + BancoComboBox.Text + "'") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            IDBan = dr.Item("idbanco")
        End If

        dr.Close()
        cn.Close()

    End Sub

    'Sub CargarIDBanco2()

    '    cn.Open()
    '    cmd = New SqlCommand("SELECT [idbanco]
    '                          FROM [AHORROS].[dbo].[Bancos]
    '                          WHERE [nombre] = '" + BancoComboBox2.Text + "'") With {
    '        .Connection = cn,
    '        .CommandType = CommandType.Text
    '    }
    '    dr = cmd.ExecuteReader()
    '    If dr.Read Then
    '        IDBan2 = dr.Item("idbanco")
    '    End If

    '    dr.Close()
    '    cn.Close()

    'End Sub


    Public Sub LlenarCuentas()

        'Firebase() ' Obtener datos de Firebase

        'Dim Qref As Query = db.Collection("Accounts").WhereEqualTo("idbank", IDBan).WhereEqualTo("status", "1").OrderBy("nameaccount")
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        '' Crear una lista para almacenar los nombres de los bancos
        'Dim accountNames As New List(Of String)

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ' Agregar el nombre del banco a la lista
        '    accountNames.Add(data("nameaccount").ToString())
        'Next

        '' Asignar la lista como origen de datos del ComboBox
        'DescripcionComboBox.DataSource = accountNames

        ''DescripcionComboBox.SelectedIndex = 0

        sql = "SELECT  Cuentas.idcuenta, Cuentas.cuenta
                FROM            Cuentas INNER JOIN
                Bancos ON Cuentas.idbanco = Bancos.idbanco
                WHERE Cuentas.estado = '1' AND Bancos.nombre = '" + BancoComboBox.Text + "'
                order by Cuentas.cuenta asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        DescripcionComboBox.DataSource = ds.Tables(0)
        DescripcionComboBox.DisplayMember = "cuenta"

    End Sub

    'Sub LlenarCuentas2()

    '    sql = "SELECT        TOP (10) Cuentas.idcuenta, Cuentas.cuenta
    '            FROM            Cuentas INNER JOIN
    '            Bancos ON Cuentas.idbanco = Bancos.idbanco
    '            WHERE Cuentas.estado = '1' AND Bancos.nombre = '" + BancoComboBox2.Text + "'
    '            order by Cuentas.cuenta asc"
    '    da = New SqlDataAdapter(sql, cn)
    '    ds = New DataSet
    '    da.Fill(ds)

    '    DescripcionComboBox2.DataSource = ds.Tables(0)
    '    DescripcionComboBox2.DisplayMember = "cuenta"

    'End Sub

    Public Sub CargarIDCuentas()

        ' Obtener datos de Firebase
        'Firebase()
        'Dim Qref As Query = db.Collection("Accounts").WhereEqualTo("nameaccount", DescripcionComboBox.Text)
        'Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        ''For Each docSnapshot As DocumentSnapshot In Snap.Documents
        ''    ' Acceder a los datos dentro de cada documento
        ''    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        ''    ' Obtener idbank y namebank
        ''    IDAcc = data("idaccount")
        ''Next

        'If Snap.Documents.Count > 0 Then
        '    Dim docSnapshot As DocumentSnapshot = Snap.Documents(0)

        '    If docSnapshot.Exists Then
        '        ' Access the data inside the document
        '        Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()
        '        IDAcc = data("idaccount")
        '    End If
        'End If

        cn.Open()
        cmd = New SqlCommand("SELECT [idcuenta]
                              FROM [AHORROS].[dbo].[Cuentas]
                              WHERE [cuenta] = '" + DescripcionComboBox.Text + "'
                              AND ESTADO = '1'") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            IDAcc = dr.Item("idcuenta")
        End If

        dr.Close()
        cn.Close()

    End Sub

    'Sub CargarIDCuentas2()

    '    cn.Open()
    '    cmd = New SqlCommand("SELECT [idcuenta]
    '                          FROM [AHORROS].[dbo].[Cuentas]
    '                          WHERE [cuenta] = '" + DescripcionComboBox2.Text + "'
    '                          AND ESTADO = '1'") With {
    '        .Connection = cn,
    '        .CommandType = CommandType.Text
    '    }
    '    dr = cmd.ExecuteReader()
    '    If dr.Read Then
    '        IDAcc2 = dr.Item("idcuenta")
    '    End If

    '    dr.Close()
    '    cn.Close()

    'End Sub

    Public Sub CargarMovimientos()

        ''MovimientosDataGridView.DataSource = Nothing ' Limpiar datos existentes

        'Firebase() ' Obtener datos de Firebase

        'Dim Qref As Query = db.Collection("Transactions").OrderByDescending("idtransaction").Limit(100)
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

        ''cargo las cuentas
        '' Obtener todos los nombres de los bancos
        'Dim accountNames As New Dictionary(Of String, String)()

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()
        '    Dim accountId As String = data("idaccount").ToString()

        '    ' Verificar si ya hemos obtenido el nombre de este banco
        '    If Not accountNames.ContainsKey(accountId) Then
        '        Dim docRef As DocumentReference = db.Collection("Accounts").Document(accountId)
        '        Dim accountSnapshot As DocumentSnapshot = Await docRef.GetSnapshotAsync()

        '        If accountSnapshot.Exists Then
        '            Dim accountData As Dictionary(Of String, Object) = accountSnapshot.ToDictionary()
        '            Dim accountName As String = accountData("nameaccount").ToString()
        '            accountNames.Add(accountId, accountName)
        '        End If
        '    End If
        'Next

        '' Limpiar las columnas existentes
        'MovimientosDataGridView.Columns.Clear()

        'Agregar columnas al DataGridView si aún no están presentes
        'MovimientosDataGridView.Columns.Add("idtransactioncolumn", "ID Transaction")
        'MovimientosDataGridView.Columns.Add("idbankcolumn", "ID Bank")
        'MovimientosDataGridView.Columns.Add("namebankcolumn", "Name Bank")
        'MovimientosDataGridView.Columns.Add("typecolumn", "Type")
        'MovimientosDataGridView.Columns.Add("datecolumn", "Date")
        'MovimientosDataGridView.Columns.Add("detailscolumn", "Details")
        'MovimientosDataGridView.Columns.Add("idaccountcolumn", "ID Account")
        'MovimientosDataGridView.Columns.Add("nameaccountcolumn", "Name Account")
        'MovimientosDataGridView.Columns.Add("amountcolumn", "Amount")
        'MovimientosDataGridView.Columns.Add("summarycolumn", "Summary")
        'Agrega más columnas si es necesario

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    ' Acceder a los datos dentro de cada documento
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    ''busco en la lista de bancos creadas, y le mando el objeto a buscar
        '    Dim bankName As String = bankNames(data("idbank").ToString())
        '    Dim accountName As String = accountNames(data("idaccount").ToString())

        '    ' Suponiendo que "date" es el nombre del campo donde está almacenado el timestamp en Firebase
        '    ' Suponiendo que "date" es el nombre del campo donde está almacenado el timestamp en Firebase
        '    Dim timestamp As Google.Cloud.Firestore.Timestamp = data("date")
        '    Dim fecha As DateTime = timestamp.ToDateTime()

        '    ' Convertir la fecha a formato local de EE. UU.
        '    Dim fechaUSA As DateTime = fecha.ToLocalTime()

        '    ' Formatear la fecha en formato de cadena de EE. UU.
        '    'Dim fechaUSAString As String = fechaUSA.ToString("MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)
        '    Dim fechaUSAString As String = fechaUSA.ToString("dddd, dd MMMM yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)


        '    ' Agregar los datos al DataGridView
        '    MovimientosDataGridView.Rows.Add(data("idtransaction"), data("idbank"), bankName, data("type"), fechaUSAString, data("details"), data("idaccount"), accountName, Format(Val(data("amount")), "#,###.##"), Format(Val(data("summary")), "#,###.##")) '' Agrega los campos que desees mostrar
        'Next

        MovimientosDataGridView.Refresh()


        sql = "SELECT top(100) dbo.Movimientos.idahorro idtransaction, 
                                dbo.Bancos.idbanco idbank, 
                                dbo.Bancos.nombre AS bankname, 
                                dbo.Movimientos.tipo as type, 
                                dbo.Movimientos.fecha date, 
                                dbo.Movimientos.referencia details, 
                                dbo.Cuentas.idcuenta idaccount, 
                                dbo.Cuentas.cuenta AS account, 
                                FORMAT(dbo.Movimientos.deposito, 'N2', 'es-US') amount, 
                                FORMAT(ROUND(dbo.Movimientos.total, 2), 'N2', 'en-US') summary
                FROM            dbo.Movimientos INNER JOIN
                                dbo.Bancos ON dbo.Movimientos.idbanco = dbo.Bancos.idbanco INNER JOIN
                                dbo.Cuentas ON dbo.Movimientos.idcuenta = dbo.Cuentas.idcuenta
                where dbo.Movimientos.fecha >= DATEADD(DAY, -30, GETDATE())
                ORDER BY dbo.Movimientos.idahorro DESC"

        'sql = "SELECT dbo.Movimientos.idahorro idtransaction, 
        '                        dbo.Bancos.idbanco idbank, 
        '                        dbo.Bancos.nombre AS bankname, 
        '                        dbo.Movimientos.tipo as type, 
        '                        dbo.Movimientos.fecha date, 
        '                        dbo.Movimientos.referencia details, 
        '                        dbo.Cuentas.idcuenta idaccount, 
        '                        dbo.Cuentas.cuenta AS account, 
        '                        FORMAT(dbo.Movimientos.deposito, 'N2', 'es-US') amount, 
        '                        FORMAT(ROUND(dbo.Movimientos.total, 2), 'N2', 'en-US') summary
        '        FROM            dbo.Movimientos INNER JOIN
        '                        dbo.Bancos ON dbo.Movimientos.idbanco = dbo.Bancos.idbanco INNER JOIN
        '                        dbo.Cuentas ON dbo.Movimientos.idcuenta = dbo.Cuentas.idcuenta
        '        ORDER BY dbo.Movimientos.idahorro DESC"


        cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            MovimientosDataGridView.DataSource = dt

        cn.Close()

    End Sub

    Public Sub Guardar()

        If ReferenciaTextBox.Text = "" Then
            ReferenciaTextBox.Focus()
            MessageBox.Show("Se debe agregar descripcion")
        Else

            If MsgBox("Confirm", MsgBoxStyle.Question + MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

                CargarID()

                '' Inicializa Firestore
                'Firebase()

                '' Recorre cada fila del DataGridView

                '' Obtiene el ID del banco de la fila actual
                'Dim fecha As Date = Convert.ToDateTime(Now).ToUniversalTime()

                '' Verifica si ya existe un documento con el mismo ID
                'Dim docRef = db.Collection("Transactions").Document(IDAHORRO.ToString)
                'Dim docSnapshot = Await docRef.GetSnapshotAsync()

                '' Verifica si el documento ya existe
                'If docSnapshot.Exists Then
                '    '' Si el documento ya existe, actualiza sus datos
                '    Dim datos As New Dictionary(Of String, Object) From {
                '        {"idbank", IDBan},
                '        {"details", Convert.ToString(ReferenciaTextBox.Text)},
                '        {"idaccount", Convert.ToInt32(IDAcc)}
                '    }

                '    Await docRef.SetAsync(datos, SetOptions.MergeAll)
                '    MessageBox.Show("Update item successfully")
                'Else
                '    ' Si el documento no existe, crea uno nuevo
                '    Dim datos As New Dictionary(Of String, Object) From {
                '        {"idtransaction", IDAHORRO},
                '        {"idbank", Convert.ToInt32(IDBan)},
                '        {"type", Convert.ToString(TIPO)},
                '        {"date", fecha},
                '        {"details", Convert.ToString(ReferenciaTextBox.Text)},
                '        {"idaccount", Convert.ToInt32(IDAcc)},
                '        {"amount", Convert.ToDouble(DepositoTextBox.Text)},
                '        {"summary", Convert.ToDouble(TotalTextBox.Text)}
                '    }

                '    Await db.Collection("Transactions").Document(IDAHORRO.ToString).SetAsync(datos)
                '    MessageBox.Show("Item has been created successfully")
                'End If


                ''CargarIDCuentas()

                cn.Open()
                cmd = New SqlCommand("SELECT TOP(1) [idahorro]
                                    FROM [AHORROS].[dbo].[Movimientos]
                                    WHERE idahorro = " & IDAHORRO & "
                                    ORDER BY [idahorro] DESC") With {
                                                                .Connection = cn,
                                                                .CommandType = CommandType.Text
                                                                  }
                dr = cmd.ExecuteReader()

                If dr.Read = True Then
                    dr.Close()
                    sql = "UPDATE [dbo].[Movimientos]
                            SET [idbanco] = @idbanco
                            ,[tipo] = @tipo
                            ,[fecha] = @fecha
                            ,[referencia] = @referencia
                            ,[idcuenta] = @idcuenta
                            ,[deposito] = @deposito
                            ,[total] = @total
                            WHERE [idahorro] = @idahorro"

                    cmd = New SqlCommand(sql, cn) With {
                .CommandText = "InsertMovimiento",
                .CommandType = CommandType.StoredProcedure
            }
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("trans", "U")
                    cmd.Parameters.AddWithValue("idahorro", IDAHORRO)
                    cmd.Parameters.AddWithValue("idbanco", IDBan)
                    cmd.Parameters.AddWithValue("tipo", TIPO)
                    cmd.Parameters.AddWithValue("referencia", ReferenciaTextBox.Text)
                    cmd.Parameters.AddWithValue("fecha", Convert.ToDateTime(LblDate.Text))
                    cmd.Parameters.AddWithValue("idcuenta", IDAcc)
                    cmd.Parameters.AddWithValue("deposito", Convert.ToDouble(DepositoTextBox.Text))
                    cmd.Parameters.AddWithValue("total", (TOT + Convert.ToDouble(DepositoTextBox.Text)))
                    cmd.ExecuteNonQuery()

                    cn.Close()

                    '' si actualizamos cualquier registro, recalculara la sumatoria a partir del valor al 1 que se esta actualizando
                    RecalcularTotalesDesde(IDAHORRO)

                Else
                    dr.Close()
                    sql = "INSERT INTO [dbo].[Movimientos]
                               ([idbanco]
                               ,[tipo]
                               ,[fecha]
                               ,[referencia]
                               ,[idcuenta]
                               ,[deposito]
                               ,[total])
                                VALUES
                               (@idbanco
                               ,@tipo
                               ,@fecha
                               ,@referencia
                               ,@descripcion
                               ,@deposito
                               ,@total)"
                        cmd = New SqlCommand(sql, cn) With {
                    .CommandText = "InsertMovimiento",
                    .CommandType = CommandType.StoredProcedure
                }
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("trans", "I")
                        cmd.Parameters.AddWithValue("idahorro", IDAHORRO)
                        cmd.Parameters.AddWithValue("idbanco", IDBan)
                        cmd.Parameters.AddWithValue("tipo", TIPO)
                        cmd.Parameters.AddWithValue("referencia", ReferenciaTextBox.Text)
                        cmd.Parameters.AddWithValue("fecha", Convert.ToDateTime(LblDate.Text))
                        cmd.Parameters.AddWithValue("idcuenta", IDAcc)
                        cmd.Parameters.AddWithValue("deposito", DepositoTextBox.Text)
                        cmd.Parameters.AddWithValue("total", CANT)
                        cmd.ExecuteNonQuery()
                    cn.Close()

                End If

            End If

        End If

        LoadForm()

    End Sub

    Sub RecalcularTotalesDesde(id As Integer)
        cn.Open()
        Dim cmd As New SqlCommand("EXEC RecalcularTotalesDesde @id", cn)
        cmd.Parameters.AddWithValue("@id", id)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Totales recalculados desde el ID " & id, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.Close()
    End Sub


    Public Sub CargarID()

        'If IDAHORRO = 0 Then
        '    Firebase()

        '    Dim Qref As Query = db.Collection("Transactions").OrderByDescending("idtransaction").Limit(1)
        '    Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()

        '    'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    '    ' Acceder a los datos dentro de cada documento
        '    '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

        '    '    ' Obtener idbank y namebank
        '    '    IDAHORRO = data("idtransaction") + 1
        '    'Next


        '    If Snap.Documents.Count > 0 Then
        '        Dim docSnapshot As DocumentSnapshot = Snap.Documents(0)

        '        If docSnapshot.Exists Then
        '            ' Access the data inside the document
        '            Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()
        '            ' Obtener idbank y namebank
        '            IDAHORRO = data("idtransaction") + 1
        '        End If
        '    End If
        'End If

        If IDAHORRO = 0 Then
            cn.Open()
            cmd = New SqlCommand("SELECT TOP(1) [idahorro] + 1 AS ID
                                FROM [AHORROS].[dbo].[Movimientos]
                                ORDER BY [idahorro] DESC") With {
                .Connection = cn,
                .CommandType = CommandType.Text
            }
            dr = cmd.ExecuteReader()
            If dr.Read Then
                IDAHORRO = dr.Item("ID")
            Else
                IDAHORRO = 0
            End If

            dr.Close()
            cn.Close()
        End If

    End Sub

    Private Sub RB_DEPOSITO_CheckedChanged(sender As Object, e As EventArgs) Handles RB_DEPOSITO.CheckedChanged

        TIPO = "DEPOSIT"

    End Sub

    Private Sub RB_RETIRO_CheckedChanged(sender As Object, e As EventArgs) Handles RB_RETIRO.CheckedChanged

        TIPO = "WITHDRAWAL"

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles TxtSave.Click

        Guardar()

    End Sub


    Private Sub DepositoTextBox_TextChanged(sender As Object, e As EventArgs) Handles DepositoTextBox.TextChanged

        If IDAHORRO = 0 Then
            TotalTextBox.Text = Format(TOT + Val(DepositoTextBox.Text), "#,###.##")
            CANT = TOT + Val(DepositoTextBox.Text)

            If Val(DepositoTextBox.Text) > 0 Then
                RB_DEPOSITO.Checked = True
            Else
                RB_RETIRO.Checked = True
            End If

        Else
            TotalTextBox.Text = TOT + Val(DepositoTextBox.Text)
            If Val(DepositoTextBox.Text) > 0 Then
                RB_DEPOSITO.Checked = True
            Else
                RB_RETIRO.Checked = True
            End If
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

        LoadForm()

    End Sub

    Private Sub DepositoTextBox_Click(sender As Object, e As EventArgs) Handles DepositoTextBox.Click

        DepositoTextBox.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If IDAHORRO >= 1 Then
        Else
            LblDate.Text = Now
        End If

    End Sub

    Private Sub ReferenciaTextBox_Click(sender As Object, e As EventArgs) Handles ReferenciaTextBox.Click

        ReferenciaTextBox.Text = ""

    End Sub


    Private Sub RectangleShape5_Click(sender As Object, e As EventArgs) Handles GuardarMov.Click

        Guardar()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        LoadForm()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Cmb_Delete.Click

        If MsgBox("Delete?", MsgBoxStyle.Question + MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

            If IDAHORRO > 1 Then
                cn.Open()
                cmd = New SqlCommand("SELECT TOP(1) [idahorro]
                                FROM [AHORROS].[dbo].[Movimientos]
                                WHERE idahorro = " & IDAHORRO & "
                                ORDER BY [idahorro] DESC") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
                dr = cmd.ExecuteReader()

                If dr.Read <> vbNull Then

                    Using cn As New SqlConnection(My.Settings.AHORROSConnectionString)
                        cn.Open()
                        sql = " DELETE FROM [dbo].[Movimientos]
		                        WHERE idahorro = @idahorro"

                        cmd = New SqlCommand(sql, cn) With {
                    .CommandText = "InsertMovimiento",
                    .CommandType = CommandType.StoredProcedure
                }
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("trans", "D")
                        cmd.Parameters.AddWithValue("idahorro", IDAHORRO)
                        cmd.Parameters.AddWithValue("idbanco", IDBan)
                        cmd.Parameters.AddWithValue("tipo", TIPO)
                        cmd.Parameters.AddWithValue("referencia", ReferenciaTextBox.Text)
                        cmd.Parameters.AddWithValue("fecha", Convert.ToDateTime(LblDate.Text))
                        cmd.Parameters.AddWithValue("idcuenta", IDAcc)
                        cmd.Parameters.AddWithValue("deposito", Convert.ToDouble(DepositoTextBox.Text))
                        cmd.Parameters.AddWithValue("total", TOT)
                        cmd.ExecuteNonQuery()
                        cn.Close()
                    End Using

                    dr.Close()
                    cn.Close()

                    LoadForm()

                End If

            Else

                MessageBox.Show("No record selected")

            End If

        End If

    End Sub

    Private Sub BancoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BancoComboBox.SelectedIndexChanged

        CargarIDBanco()
        LlenarCuentas()

    End Sub

    Private Sub DescripcionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DescripcionComboBox.SelectedIndexChanged

        CargarIDCuentas()

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click

        If FormBancosCuentas.Visible = True Then
            FormBancosCuentas.Hide()
        Else
            FormBancosCuentas.CargarBancos()
            FormBancosCuentas.CargarCuentas()
            FormBancosCuentas.Show()
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        If FormSaldosBancos.Visible = True Then
            FormSaldosBancos.Timer1.Stop()
            FormSaldosBancos.Hide()
            LoadA = 0
        Else
            LoadA = 1
            FormSaldosBancos.Timer1.Start()
            FormSaldosBancos.Show()
        End If

    End Sub

    Private Sub TxtBuscar_Click(sender As Object, e As EventArgs) Handles TxtBuscar.Click

        TxtBuscar.Text = ""

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        'If (TxtBuscar.Text = "" Or TxtBuscar.Text = "Search...") Then
        '    CargarMovimientos()
        'Else
        obj.SEARCHDESCRIPTION(TxtBuscar.Text, MovimientosDataGridView)
        'End If

    End Sub

    Private Sub RB_TRANSFERENCIA_CheckedChanged(sender As Object, e As EventArgs) Handles RB_TRANSFERENCIA.CheckedChanged

        TIPO = "TRANSFER"

    End Sub


    Private Sub CMD_UFB_T_Click(sender As Object, e As EventArgs) Handles CMD_UFB_T.Click
        CargarTransactionFB()
    End Sub


    Public Async Sub CargarTransactionFB()

        If MovimientosDataGridView.Rows.Count = 0 Then
            Return
        End If

        ' Inicializa Firestore
        Firebase()

        Dim contador As Integer = 0
        ProgressBar1.Maximum = MovimientosDataGridView.Rows.Count

        ' Recorre cada fila del DataGridView
        For Each row As DataGridViewRow In MovimientosDataGridView.Rows
            contador += 1
            Label1.Text = "Data loading.. " + Convert.ToString(contador)
            ProgressBar1.Value = contador

            ' Obtiene el ID del banco de la fila actual
            Dim idtransaction As Int32 = Convert.ToInt32(row.Cells(0).Value)
            Dim fecha As Date = Convert.ToDateTime(row.Cells(4).Value).ToUniversalTime()

            ' Verifica si ya existe un documento con el mismo ID
            Dim docRef = db.Collection("Transactions").Document(idtransaction.ToString)
            Dim docSnapshot = Await docRef.GetSnapshotAsync()

            ' Verifica si el documento ya existe
            If docSnapshot.Exists Then
                '' Si el documento ya existe, actualiza sus datos
                Dim datos As New Dictionary(Of String, Object) From {
                    {"idtransaction", idtransaction},
                    {"idbank", Convert.ToInt32(row.Cells(1).Value)},
                    {"type", Convert.ToString(row.Cells(3).Value)},
                    {"details", Convert.ToString(row.Cells(5).Value)},
                    {"idaccount", Convert.ToInt32(row.Cells(6).Value)},
                    {"amount", Convert.ToDouble(row.Cells(8).Value)},
                    {"summary", Convert.ToDouble(row.Cells(9).Value)}
                }
                Await docRef.SetAsync(datos, SetOptions.MergeAll)
            Else
                ' Si el documento no existe, crea uno nuevo
                Dim datos As New Dictionary(Of String, Object) From {
                    {"idtransaction", idtransaction},
                    {"idbank", Convert.ToInt32(row.Cells(1).Value)},
                    {"type", Convert.ToString(row.Cells(3).Value)},
                    {"date", fecha},
                    {"details", Convert.ToString(row.Cells(5).Value)},
                    {"idaccount", Convert.ToInt32(row.Cells(6).Value)},
                    {"amount", Convert.ToDouble(row.Cells(8).Value)},
                    {"summary", Convert.ToDouble(row.Cells(9).Value)}
                }

                Await db.Collection("Transactions").Document(idtransaction.ToString).SetAsync(datos)
            End If
        Next

        MessageBox.Show("Item has been updated successfully")
        ProgressBar1.Value = 0
        Label1.Text = ""


    End Sub

    Private Sub CMD_DFB_T_Click(sender As Object, e As EventArgs) Handles CMD_DFB_T.Click

        DownloadFirebase()

    End Sub

    Public Async Sub DownloadFirebase()
        'MovimientosDataGridView.DataSource = Nothing ' Limpiar datos existentes

        Firebase() ' Obtener datos de Firebase

        Dim Qref As Query = db.Collection("Transactions").OrderByDescending("idtransaction").Limit(100)
        ''Dim Qref As Query = db.Collection("Transactions").OrderByDescending("idtransaction")
        Dim Snap As QuerySnapshot = Await Qref.GetSnapshotAsync()


        'cargo los bancos
        ' Obtener todos los nombres de los bancos
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

        'cargo las cuentas
        ' Obtener todos los nombres de los bancos
        'Dim accountNames As New Dictionary(Of String, String)()

        'For Each docSnapshot As DocumentSnapshot In Snap.Documents
        '    Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()
        '    Dim accountId As String = data("idaccount").ToString()

        '    ' Verificar si ya hemos obtenido el nombre de este banco
        '    If Not accountNames.ContainsKey(accountId) Then
        '        Dim docRef As DocumentReference = db.Collection("Accounts").Document(accountId)
        '        Dim accountSnapshot As DocumentSnapshot = Await docRef.GetSnapshotAsync()

        '        If accountSnapshot.Exists Then
        '            Dim accountData As Dictionary(Of String, Object) = accountSnapshot.ToDictionary()
        '            Dim accountName As String = accountData("nameaccount").ToString()
        '            accountNames.Add(accountId, accountName)
        '        End If
        '    End If
        'Next

        ' Limpiar las columnas existentes
        DataGridTransactions.Columns.Clear()

        ' Agregar columnas al DataGridView si aún no están presentes
        DataGridTransactions.Columns.Add("idtransactioncolumn", "ID Transaction")
        DataGridTransactions.Columns.Add("idbankcolumn", "ID Bank")
        'DataGridTransactions.Columns.Add("namebankcolumn", "Name Bank")
        DataGridTransactions.Columns.Add("typecolumn", "Type")
        DataGridTransactions.Columns.Add("datecolumn", "Date")
        DataGridTransactions.Columns.Add("detailscolumn", "Details")
        DataGridTransactions.Columns.Add("idaccountcolumn", "ID Account")
        'DataGridTransactions.Columns.Add("nameaccountcolumn", "Name Account")
        DataGridTransactions.Columns.Add("amountcolumn", "Amount")
        DataGridTransactions.Columns.Add("summarycolumn", "Summary")
        'Agrega más columnas si es necesario

        For Each docSnapshot As DocumentSnapshot In Snap.Documents
            ' Acceder a los datos dentro de cada documento
            Dim data As Dictionary(Of String, Object) = docSnapshot.ToDictionary()

            'busco en la lista de bancos creadas, y le mando el objeto a buscar
            'Dim bankName As String = bankNames(data("idbank").ToString())
            'Dim accountName As String = accountNames(data("idaccount").ToString())

            ' Suponiendo que "date" es el nombre del campo donde está almacenado el timestamp en Firebase
            Dim timestamp As Google.Cloud.Firestore.Timestamp = data("date")
            Dim fecha As DateTime = timestamp.ToDateTime()

            ' Convertir la fecha a formato local de EE. UU.
            Dim fechaUSA As DateTime = fecha.ToLocalTime()

            ' Formatear la fecha en formato de cadena de EE. UU.
            'Dim fechaUSAString As String = fechaUSA.ToString("MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)
            Dim fechaUSAString As String = fechaUSA.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)


            ' Agregar los datos al DataGridView
            DataGridTransactions.Rows.Add(data("idtransaction"),
                                          data("idbank"),
                                          data("type"),
                                          fechaUSAString,
                                          data("details"),
                                          data("idaccount"),
                                          Format(Val(data("amount")), "#,###.##"),
                                          Format(Val(data("summary")), "#,###.##")) '' Agrega los campos que desees mostrar
            '' Agregar los datos al DataGridView
            'DataGridTransactions.Rows.Add(data("idtransaction"),
            '                              data("idbank"),
            '                              bankName,
            '                              data("type"),
            '                              fechaUSAString,
            '                              data("details"),
            '                              data("idaccount"),
            '                              accountName,
            '                              Format(Val(data("amount")), "#,###.##"),
            '                              Format(Val(data("summary")), "#,###.##")) '' Agrega los campos que desees mostrar
        Next

        DataGridTransactions.Refresh()

        CargarTransactionSQL()

    End Sub

    Public Sub CargarTransactionSQL()
        If DataGridTransactions.Rows.Count = 0 Then
            Return
        End If

        Using cn As New SqlConnection(My.Settings.AHORROSConnectionString)
            cn.Open()

            sql = "
    MERGE INTO [dbo].[Movimientos] AS target
    USING (VALUES (@idtransaction, @idbank, @idaccount, @type, @date, @details, @amount, @summary)) 
          AS source (idahorro, idbanco, idcuenta, tipo, fecha, referencia, deposito, total)
    ON (target.idahorro = source.idahorro)
    WHEN MATCHED THEN
        UPDATE SET target.idbanco = source.idbanco,
                   target.idcuenta = source.idcuenta,
                   target.tipo = source.tipo,
                   target.fecha = source.fecha,
                   target.referencia = source.referencia,
                   target.deposito = source.deposito,
                   target.total = source.total
    WHEN NOT MATCHED THEN
        INSERT (idahorro, idbanco, idcuenta, tipo, fecha, referencia, deposito, total)
        VALUES (source.idahorro, source.idbanco, source.idcuenta, source.tipo, source.fecha, source.referencia, source.deposito, source.total);"

            Dim cmd As New SqlCommand(sql, cn)

            For Each row As DataGridViewRow In DataGridTransactions.Rows
                If row.IsNewRow Then Continue For

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@idtransaction", row.Cells("idtransactioncolumn").Value)
                cmd.Parameters.AddWithValue("@idbank", row.Cells("idbankcolumn").Value)
                cmd.Parameters.AddWithValue("@idaccount", row.Cells("idaccountcolumn").Value)
                cmd.Parameters.AddWithValue("@type", Convert.ToString(row.Cells("typecolumn").Value))
                cmd.Parameters.AddWithValue("@date", Convert.ToString(row.Cells("datecolumn").Value))
                cmd.Parameters.AddWithValue("@details", Convert.ToString(row.Cells("detailscolumn").Value))
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(row.Cells("amountcolumn").Value))
                cmd.Parameters.AddWithValue("@summary", Convert.ToDecimal(row.Cells("summarycolumn").Value))
                cmd.ExecuteNonQuery()
            Next

            cn.Close()
            MessageBox.Show("Data has been loaded.")
        End Using



        LoadForm()
    End Sub

    Private Sub MovimientosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovimientosDataGridView.CellContentClick
        If e.RowIndex < 0 Then Exit Sub ' Evita errores si se hace clic en el encabezado

        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow = MovimientosDataGridView.Rows(index)

        IDAHORRO = selectedRow.Cells(0).Value
        IDBan = selectedRow.Cells(1).Value
        BancoComboBox.Text = selectedRow.Cells(2).Value
        TIPO = selectedRow.Cells(3).Value.ToString

        If TIPO = "DEPOSIT" Then
            RB_DEPOSITO.Checked = True
        ElseIf TIPO = "WITHDRAWAL" Then
            RB_RETIRO.Checked = True
        Else
            RB_TRANSFERENCIA.Checked = True
        End If

        LblDate.Text = selectedRow.Cells(4).Value
        ReferenciaTextBox.Text = selectedRow.Cells(5).Value.ToString
        IDAcc = selectedRow.Cells(6).Value
        DescripcionComboBox.Text = selectedRow.Cells(7).Value
        DepositoTextBox.Text = selectedRow.Cells(8).Value
        TotalTextBox.Text = selectedRow.Cells(9).Value

        ' se trae el valor total y se le resta el valor con el que se recargo en su momento
        TOT = selectedRow.Cells(9).Value - selectedRow.Cells(8).Value
    End Sub

    'Private Sub BancoComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    CargarIDBanco2()
    '    LlenarCuentas2()

    'End Sub

    'Private Sub DescripcionComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    CargarIDCuentas2()

    'End Sub
End Class
