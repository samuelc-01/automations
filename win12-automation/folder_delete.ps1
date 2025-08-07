
# Caminho da pasta pública
$folderPath = "C:\Users\samuel.cristian\code\windows_2012_dev\public_test_folder"

# Obter todos os arquivos (independentemente da data)
$files = Get-ChildItem -Path $folderPath -Recurse

# Verificar e excluir arquivos
foreach ($file in $files) {
    try {
        # Excluir o arquivo
        Remove-Item -Path $file.FullName -Force
        Write-Host "Arquivo deletado: $($file.FullName)"
    } catch {
        Write-Host "Erro ao deletar o arquivo: $($file.FullName)"
    }
}

Write-Host "hello word "