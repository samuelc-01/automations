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
        ' Definir a planilha ativa (primeira planilha no documento)
        oSheet = oDoc.Sheets(0)
        
        ' Encontrar o último índice preenchido na coluna J
        i = 1
        Do While oSheet.getCellByPosition(9, i).getString() <> ""
            i = i + 1
        Loop
        oRangeJ = oSheet.getCellRangeByPosition(9, 1, 9, i - 1)
        
        ' Encontrar o último índice preenchido na coluna O
        j = 1
        Do While oSheet.getCellByPosition(14, j).getString() <> ""
            j = j + 1
        Loop
        oRangeO = oSheet.getCellRangeByPosition(14, 1, 14, j - 1)
      
        ' Percorrer as células da coluna J
        For i = 0 To oRangeJ.Rows.getCount() - 1
            oCellJ = oRangeJ.getCellByPosition(0, i)
            valorJ = oCellJ.getString()
            
            ' Verificar se o valor da célula J está presente na coluna O
            encontrado = False
            For j = 0 To oRangeO.Rows.getCount() - 1
                oCellO = oRangeO.getCellByPosition(0, j)
                valorO = oCellO.getString()
                
                If valorJ = valorO Then
                    ' Se encontrado, pintar a célula correspondente na coluna J de verde
                    oCellJ.CellBackColor = RGB(0, 200, 0) ' Verde
                    encontrado = True
                    Exit For ' Parar a busca na coluna O assim que um valor é encontrado
                End If
            Next j
        Next i
        
        MsgBox "Processo concluído."
    Else
        MsgBox "Documento não encontrado."
    End If
End Sub
