using System.Diagnostics;

namespace Library.Classes;

public class ScriptHandler : IScriptHandler {
    public string ExecuteScript(string script) {

        ProcessStartInfo startInfo = new() {
            FileName = "powershell.exe",
            Arguments = "Set-ExecutionPolicy RemoteSigned",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = new () {
            StartInfo = startInfo
        };

        process.Start();
        string salida = process.StandardOutput.ReadToEnd();
        string errores = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(errores)) {
            return errores;
        }

        process = new Process();

        startInfo.Arguments = $"& '.\\Scripts\\{script}.ps1'";
        process.StartInfo = startInfo;
        process.Start();

        salida = process.StandardOutput.ReadToEnd();
        errores = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(errores))
        {
            return errores;
        }

        return salida;
    }

    public string ExecuteScriptWParamIdProcess(string script, string idProcess) {
        ProcessStartInfo startInfo = new()
        {
            FileName = "powershell.exe",
            Arguments = $"Set-ExecutionPolicy RemoteSigned -procesoId {idProcess}",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = new()
        {
            StartInfo = startInfo
        };

        process.Start();
        string salida = process.StandardOutput.ReadToEnd();
        string errores = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(errores))
        {
            return errores;
        }

        process = new Process();

        startInfo.Arguments = $"& '.\\Scripts\\{script}.ps1'";
        process.StartInfo = startInfo;
        process.Start();

        salida = process.StandardOutput.ReadToEnd();
        errores = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(errores))
        {
            return errores;
        }

        return salida;
    }


    public string ExecuteScriptWParamUser(string script, string userName) {
        ProcessStartInfo startInfo = new() {
            FileName = "powershell.exe",
            Arguments = $"Set-ExecutionPolicy RemoteSigned -usuario {userName}",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = new() {
            StartInfo = startInfo
        };

        process.Start();
        string salida = process.StandardOutput.ReadToEnd();
        string errores = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(errores)) {
            return errores;
        }

        process = new Process();

        startInfo.Arguments = $"& '.\\Scripts\\{script}.ps1'";
        process.StartInfo = startInfo;
        process.Start();

        salida = process.StandardOutput.ReadToEnd();
        errores = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(errores)) {
            return errores;
        }

        return salida;
    }
}
