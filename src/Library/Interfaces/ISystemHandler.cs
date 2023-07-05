namespace Library;

public interface ISystemHandler {
    public string ListUsers();
    public string ConsultProcesses();
    public string Backup();
    public void Exit();
}
