namespace Library.Classes;

public class UserHandler :IUserHandler {

    public string GetUser() {
        try {
            return Environment.UserName;
        }
        catch (Exception e) {
            Console.WriteLine("[ ERROR ] -> " + e);
            return string.Empty;
        }
    }

    public List<string> GetUsersAccepted() {
        try {
            return new List<string> {
            "CAMP_USER",
            "CAMP_ADMIN",
            "CAMP_DOC"
        };
        }
        catch (Exception e) {
            Console.WriteLine("[ ERROR ] -> " + e);
            return null;
        }
        
    }

    public bool IsUserAccepted(string user) {
        try {
            return GetUsersAccepted().Contains(user);
        }
        catch (Exception e) {
            Console.WriteLine("[ ERROR ] -> " + e);
            return false;
        }
       
    }
}
