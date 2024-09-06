# # Caminho da pasta pública
# $folderPath = "C:\{Nome_da_pasta_que_deseja}"

# # Definir o número de dias antes de excluir os arquivos
# $daysOld = 30

# # Obter arquivos mais antigos que o número de dias especificado
# $files = Get-ChildItem -Path $folderPath -Recurse | Where-Object { $_.LastWriteTime -lt (Get-Date).AddDays(-$daysOld) }

# # Verificar e excluir arquivos antigos
# foreach ($file in $files) {
#     try {
#         # Excluir o arquivo
#         Remove-Item -Path $file.FullName -Force
#         Write-Host "Arquivo deletado: $($file.FullName)"
#     } catch {
#         Write-Host "Erro ao deletar o arquivo: $($file.FullName)"
#     }
# }


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
