
Imports System.Data.SqlClient

Public Class FormSaldosBancos

    Public Sub SaldosLoad()
        sql = "SELECT Round(sum(Movimientos.[deposito]),2) AS AMOUNT,
                CASE WHEN Bancos.nombre = 'EFECTIVO' THEN 'CASH' ELSE Bancos.nombre END as a,
                'L' + CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(Round(sum(Movimientos.[deposito]),2) AS MONEY), 1)) as b
                INTO #TEMP
                FROM            Movimientos INNER JOIN
                            Cuentas ON Movimientos.idcuenta = Cuentas.idcuenta INNER JOIN
                            Bancos ON Movimientos.idbanco = Bancos.idbanco
                GROUP BY Bancos.nombre

                SELECT #TEMP.b AS AMOUNT,  A +' - '+ B AS DESSCRIPTION, A AS BANK FROM #TEMP
                WHERE #TEMP.b <> 'L0.00'  
                ORDER BY BANK DESC
                DROP TABLE #TEMP"

        '"Select Case
        '        Cuentas.cuenta as ACCOUNT,
        '        CASE WHEN Bancos.nombre = 'EFECTIVO' THEN 'CASH' ELSE Bancos.nombre END as a,
        '        'L' + CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(Round(sum(Movimientos.[deposito]),2) AS MONEY), 1)) as b
        '        INTO #TEMP
        '        From dbo.Movimientos INNER Join
        '                                 dbo.Bancos ON dbo.Movimientos.idbanco = dbo.Bancos.idbanco INNER Join
        '                                 dbo.Cuentas ON dbo.Movimientos.idcuenta = dbo.Cuentas.idcuenta
        '        Group By Cuentas.cuenta, Bancos.nombre

        '        Select Case#TEMP.b AS AMOUNT,  A +' - '+ ACCOUNT +' '+ B AS DESSCRIPTION, A AS BANK FROM #TEMP
        '        WHERE #TEMP.b <> 'L0.00'  
        '        ORDER BY BANK DESC
        '        DROP TABLE #TEMP"


        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            SaldosDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If LoadA = 1 Then
            SaldosLoad()
        End If
    End Sub

    Private Sub FormSaldosCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaldosLoad()
    End Sub

    Private Sub SaldosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SaldosDataGridView.CellContentClick

    End Sub
End Class