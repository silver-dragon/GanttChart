﻿Imports System.Drawing

Namespace GanttChart
    <System.Serializable>
    Public Class TimeBlockClickedEventArgs
        Public Property ClickedTimeBlock As TimeBlock
        Public Property RelatedRow As Row
        Public Property CursorLocation As Point
    End Class
End Namespace
