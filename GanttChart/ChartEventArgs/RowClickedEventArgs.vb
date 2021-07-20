Imports System.Drawing

Namespace GanttChart
    <System.Serializable>
    Public Class RowClickedEventArgs
        Public Property ClickedRow As Row
        Public Property CursorLocation As Point
    End Class
End Namespace
