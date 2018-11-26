Imports System_Tools.ObjEstudiante
Public Class CRUD
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Estudiante As ObjEstudiante = New ObjEstudiante
        Dim Prueba = Estudiante.ConsultarListaEstudiante
        GrillaPrueba.DataSource = Prueba
        GrillaPrueba.DataBind()
    End Sub

End Class