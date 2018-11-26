Imports System_Tools.CRUDDataContext
Public Class ObjEstudiante
    Dim Context As New CRUDDataContext

    Public Function ConsultarListaEstudiante()
        Dim ListaEstudiantes = From Estudiante In Context.Estudiante


        Return ListaEstudiantes.ToList()

    End Function

End Class
