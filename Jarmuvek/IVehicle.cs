namespace Jarmuvek
{
    // Interfész a járművekhez
    public interface IVehicle
    {
        void Start();   // Metódus a jármű indításához
        void Stop();    // Metódus a jármű leállításához

        // Tulajdonság a jármű sebességének lekérdezéséhez és beállításához
        int Speed { get; set; }
    }
}