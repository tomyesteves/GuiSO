namespace Library;

internal interface IScriptHandler {
    public string ExecuteScript(string scriptName);
    public string ExecuteScriptWParamIdProcess(string script, string idProcess);
    public string ExecuteScriptWParamUser(string script, string userName);
}

