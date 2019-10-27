Public Class TabPageCollectionEditor
    Inherits System.ComponentModel.Design.CollectionEditor

    Public Sub New(ByVal type As Type)
        MyBase.New(type)
    End Sub

    Protected Overrides Function CreateCollectionItemType() As System.Type
        Return GetType(ColorTabPage)
    End Function

    Protected Overrides Function CreateNewItemTypes() As System.Type()
        Return New Type() {GetType(TabPage), GetType(ColorTabPage)}
    End Function

    ''assembly system.design, component model

End Class
