using Einkommenssteuer;

class Program {
    static void Main(string[] args) {
        SteuerberechnerAb2016 steuerberechner = new();
        
        Console.WriteLine("Gib dein zu versteuerndes Einkommen ein:");
        float einkommen = Helpers.FloatEingabeLesen();

        float steuern = steuerberechner.CalculateSteuer(einkommen);
        Console.WriteLine($"Die Steuern betragen {steuern}.");
    }
}