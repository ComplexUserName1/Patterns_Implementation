namespace Implementation.Structural_Patterns.Adapter.BL_Classes.Adaptees
{
    // Адаптируемый класс содержит некоторое полезное поведение, но его
    // интерфейс несовместим  с существующим клиентским кодом. Адаптируемый
    // класс нуждается в некоторой доработке,  прежде чем клиентский код сможет
    // его использовать.
    internal class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}
