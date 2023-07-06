$procesos = Get-Process
foreach ($proceso in $procesos) {

    $data = [PSCustomObject]@{
        ID = $proceso.Id
        Nombre = $proceso.Name
        CPU = $proceso.CPU
        Estado = $proceso.Status
    }

    # Convert the object to JSON
    $jsonObject = $data | ConvertTo-Json

    Write-Host $jsonObject
}
