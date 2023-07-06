namespace Library;

public interface ISystemHandler {
    public string ListUsers();
    public string ConsultProcesses();
    public string KillProcess();
    public string PauseProcess();
    public string Backup();
    public string Exit();
}
