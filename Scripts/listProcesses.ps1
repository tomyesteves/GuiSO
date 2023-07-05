# Solicitar el nombre de usuario
$usuario = Read-Host "Ingrese el nombre de usuario"
# Obtener procesos actuales del sistema
$procesos = Get-Process
# Mostrar la lista de procesos
foreach ($proceso in $procesos) {
    $procesoId = $proceso.Id
    $procesoNombre = $proceso.Name
    $procesoCpu = $proceso.CPU
    $procesoEstado = $proceso.Status
    Write-Host "ID: $procesoId"
    Write-Host "Nombre: $procesoNombre"
    Write-Host "% CPU: $procesoCpu"
    Write-Host "Estado: $procesoEstado"
    Write-Host "-----------------------------------------"
}
# Solicitar la acción a realizar
$accion = Read-Host "Ingrese la acción a realizar (eliminar/pausar)"
# Realizar la acción seleccionada
switch ($accion) {
    "eliminar" {
        $procesoId = Read-Host "Ingrese el ID del proceso a eliminar"
        $procesoAEliminar = $procesos | Where-Object {$_.Id -eq $procesoId}
        if ($procesoAEliminar) {
            Stop-Process -Id $procesoId -Force
            Write-Host "Proceso eliminado correctamente"
        } else {
            Write-Host "No se encontró ningún proceso con el ID especificado"
        }
    }
    "pausar" {
        $procesoId = Read-Host "Ingrese el ID del proceso a pausar"
        $procesoAPausar = $procesos | Where-Object {$_.Id -eq $procesoId}
        if ($procesoAPausar) {
            Suspend-Process -Id $procesoId
            Write-Host "Proceso pausado correctamente"
        } else {
            Write-Host "No se encontró ningún proceso con el ID especificado"
        }
    }
    default {
        Write-Host "Acción no reconocida"
    }
}