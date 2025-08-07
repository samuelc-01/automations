Sub PintarRepetidos()
    Dim oDoc As Object
    Dim oSheet As Object
    Dim oRangeJ As Object
    Dim oRangeO As Object
    Dim oCellJ As Object
    Dim oCellO As Object
    Dim i As Integer
    Dim j As Integer
    Dim valorJ As String
    Dim valorO As String
    Dim encontrado As Boolean
    
    ' Obter o documento atual
    oDoc = ThisComponent
    
    If Not IsEmpty(oDoc) Then
    
        oSheet = oDoc.Sheets(0)
        
        oRangeJ = oSheet.getCellRangeByName("J2:J3836")
        oRangeO = oSheet.getCellRangeByName("O2:O105")
 
     
        For i = 0 To oRangeJ.Rows.getCount() - 1
            oCellJ = oRangeJ.getCellByPosition(0, i)
            valorJ = oCellJ.getString()
            
            ' Verificar se o valor da célula J está presente na coluna O
            encontrado = False
            For j = 0 To oRangeO.Rows.getCount() - 1
                oCellO = oRangeO.getCellByPosition(0, j)
                valorO = oCellO.getString()
                
                If valorJ = valorO Then
                   
                    oCellJ.CellBackColor = RGB(0, 200, 0) ' Verde
                    encontrado = True
                    Exit For 
                End If
            Next j
        Next i
    Else
        MsgBox "Documento não encontrado."
    End If
End Sub