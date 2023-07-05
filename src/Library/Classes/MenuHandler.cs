namespace Library.Classes;

public class MenuHandler : IMenuHandler {
    public string ShowOption() {
        string options = "";
        options += "Seleccione una opción \n";
        options += "a. Listar usuarios    \n";
        options += "b. Consultar procesos \n";
        options += "c. Realizar respaldo  \n";
        options += "d. Salir              \n";
        return options;
    }
}
