param(
    [string]$usuario
)

$procesos = Get-Process -IncludeUserName

foreach ($proceso in $procesos) {
    $usuarioSplit = $proceso.UserName -split "\\"
    $dominio = $userNameSplit[0]
    $nombreUsuario = $usuarioSplit[1]

    if ($proceso.UserName -eq $nombreUsuario) {
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
}
