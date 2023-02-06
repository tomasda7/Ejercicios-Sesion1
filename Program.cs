//Ejercicio 1

string GetName(string name) { return name; }

Console.WriteLine(GetName("Tomás"));

//Ejercicio 2

string GetHour() {
    string time = DateTime.Now.ToString("T");

    return "La hora actual es " + time;
}

Console.WriteLine(GetHour());
