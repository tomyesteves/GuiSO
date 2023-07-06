param(
    [string]$procesoId
)

$procesos = Get-Process
$procesoAPausar = $procesos | Where-Object {$_.Id -eq $procesoId}
if ($procesoAPausar) {
    Suspend-Process -Id $procesoId
    Write-Host "Proceso pausado correctamente"
} else {
    Write-Host "No se encontró ningún proceso con el ID especificado"
}
