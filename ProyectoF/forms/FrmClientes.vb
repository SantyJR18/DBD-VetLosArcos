Imports System.Runtime.InteropServices

Public Class FrmClientes

    'Se oculta TPDetClt

    Private Sub TCClientes_VisibleChanged(sender As Object, e As EventArgs) Handles TCClientes.VisibleChanged
        TCClientes.TabPages.Remove(TPDetClt)
    End Sub

    Private Sub BtnNuevoClt_Click(sender As Object, e As EventArgs) Handles BtnNuevoClt.Click
        TCClientes.TabPages.Remove(TPClt)
        TCClientes.TabPages.Add(TPDetClt)
        TCClientes.Text = "Agregar nuevo cliente"
    End Sub


    Private Sub BtnEditarClt_Click(sender As Object, e As EventArgs) Handles BtnEditarClt.Click
        TCClientes.TabPages.Remove(TPClt)
        TCClientes.TabPages.Add(TPDetClt)
        TCClientes.Text = "Editar cliente"
    End Sub

    Private Sub BtnGuardarClt_Click(sender As Object, e As EventArgs)
        'Hay que hacer esto dentro de un If verificando una funcion que devuelva el valor verdadero si
        'se guardaron los cambios
        TCClientes.TabPages.Remove(TPDetClt)
        TCClientes.TabPages.Add(TPClt)
        'Esto afuera del If
        'MessageBox.Show(Message)
    End Sub


    Private Sub BtnCancelarClt_Click(sender As Object, e As EventArgs)
        TCClientes.TabPages.Remove(TPDetClt)
        TCClientes.TabPages.Add(TPClt)
    End Sub

    Private Sub BtnEliminarRegClt_Click(sender As Object, e As EventArgs) Handles BtnEliminarRegClt.Click
        Dim resultado = MessageBox.Show("¿Está seguro de eliminar al paciente selccionado?", "Advertencia",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'Para confirmar si el paciente se elimina
        'If (resultado == DialogResult.Yes) Then 
        'la funcion
        'MessageBox.Show(Message)
    End Sub

    'Cierra el form
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    'Agrega color rojo al boton cerrar
    Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles BtnCerrar.MouseHover
        BtnCerrar.BackColor = Color.Red
    End Sub

    'Devuelve el color al boton cerrar
    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.BackColor = Color.DodgerBlue
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub titleBarRec_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Clase Singleton que es un patrón de diseño que restringe la instanciación de una clase a un objeto
    Public Class Singleton
        Private Shared _instance As Singleton

        Private Sub New()
            'Constructor privado para prevenir la isntancicacion del objeto de afuera de la clase
        End Sub

        Public Shared Function GetInstance() As Singleton
            If _instance Is Nothing Then
                _instance = New Singleton()
            End If

            Return _instance
        End Function
    End Class

End Class