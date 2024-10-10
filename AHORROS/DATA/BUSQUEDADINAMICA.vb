

Imports System.Data.SqlClient


Public Class BUSQUEDADINAMICA

    Sub SEARCHDESCRIPTION(ByVal id As String, ByVal dgv As DataGridView)

        da = New SqlDataAdapter("SELECT dbo.Movimientos.idahorro idtransaction, 
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
                WHERE dbo.Movimientos.referencia LIKE '%" + id + "%'
                ORDER BY dbo.Movimientos.idahorro DESC", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt


    End Sub

End Class
