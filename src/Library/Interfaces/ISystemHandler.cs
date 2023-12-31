namespace Library;

public interface ISystemHandler {
    public string ListUsers();
    public string ConsultProcesses(string user);
    public string KillProcess(string idProceso);
    public string PauseProcess(string idProceso);
    public string Backup();
    public string Exit();
}
