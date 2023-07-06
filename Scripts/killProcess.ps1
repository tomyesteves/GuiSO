param(
    [string]$procesoId
)

$procesos = Get-Process
$procesoAEliminar = $procesos | Where-Object {$_.Id -eq $procesoId}
if ($procesoAEliminar) {
    Stop-Process -Id $procesoId -Force
    Write-Host "Proceso eliminado correctamente"
} else {
    Write-Host "No se encontró ningún proceso con el ID especificado"
}
