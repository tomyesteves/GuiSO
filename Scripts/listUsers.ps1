function ObtenerEstadoRespaldo($nombreUsuario) {
    $rutaRespaldo = "C:\CAMP_BACKUP\$nombreusuario"
    $respaldoRealizado = Test-Path $rutaRespaldo

    if ($respaldoRealizado) {
        return "SI"
    } else {
        return "NO"
    }
}

$usuarios = Get-LocalUser
$grupos = Get-LocalGroup

# Recorrer la lista de usuarios
foreach ($usuario in $usuarios) {
    foreach ($grupo2 in $grupos) {
        $nombreUsuario = $usuario.Name
        $miembros= Get-LocalGroupMember -Group $grupo2
        foreach ($miembro in $miembros) {
            $partes = $miembro -split "\\"
            $parteDerecha = $partes[1]
            if ($parteDerecha -eq $nombreUsuario) {
                $grupo = $grupo2.Name
            }
        }
    }
    $ultimoAcceso = $usuario.LastLogon
    $respaldo = ObtenerEstadoRespaldo($nombreUsuario)
	$data = [PSCustomObject]@{
		Usuario = $nombreUsuario
		Grupo = $grupo
		UltimoAcceso = $ultimoAcceso
		Respaldo = $respaldo
	}
		
    $jsonObject = $data | ConvertTo-Json
	Write-Host $jsonObject
}
