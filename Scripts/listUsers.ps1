$usuarios = Get-LocalUser

foreach ($usuario in $usuarios) {
    $grupo = $usuario | Get-LocalGroup
	
    $ultimoAcceso = (Get-WmiObject -Class Win32_UserProfile | Where-Object {$_.SID -eq $usuario.SID}).LastUseTime
	
    Write-Host "Nombre de usuario: $($usuario.Name)"
    Write-Host "Grupo: $($grupo)"
    Write-Host "Fecha de último acceso: $ultimoAcceso"
    Write-Host "-----------------------------------------"
}
