namespace Library.Classes;

public class SystemHandler : ISystemHandler {
    public string ListUsers() {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/ //TODO
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

    public string ConsultProcesses(string userName) {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/ //TODO
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "listProcesses";
                return scriptHandler.ExecuteScriptWParamUser(scriptName, userName);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        return string.Empty;
    }
    
    public string KillProcess(string idProceso) {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/ //TODO
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "killProcess";
                return scriptHandler.ExecuteScriptWParamIdProcess(scriptName, idProceso);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        return string.Empty;
    }
    
    public string PauseProcess(string idProceso) {
        UserHandler userHandler = new UserHandler();
        string user = userHandler.GetUser();
        /*if (userHandler.IsUserAccepted(user)) {*/ //TODO
        if (true) {
            try {
                ScriptHandler scriptHandler = new ScriptHandler();
                string scriptName = "pauseProcess";
                return scriptHandler.ExecuteScriptWParamIdProcess(scriptName, idProceso);
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
        /*if (userHandler.IsUserAccepted(user)) {*/ //TODO
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
