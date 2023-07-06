namespace Library.Classes;

public class SystemHandler : ISystemHandler {
    public string ListUsers() {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "listUsers";
                return scriptHandler.ExecuteScript(scriptName);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        return string.Empty;
    }

    public string ConsultProcesses() {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "listProcesses";
                return scriptHandler.ExecuteScript(scriptName);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        return string.Empty;
    }
    
    public string KillProcess() {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "killProcess";
                return scriptHandler.ExecuteScript(scriptName);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        return string.Empty;
    }
    
    public string PauseProcess() {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "pauseProcess";
                return scriptHandler.ExecuteScript(scriptName);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        return string.Empty;
    }

    public string Backup() {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "makeBackup";
                return scriptHandler.ExecuteScript(scriptName);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        return string.Empty;
    }

    public string Exit() {
        return "Saliendo del sistema...";
    }
}
