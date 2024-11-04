using Implementation.StructuralPatterns.Flyweight.BLClasses;

namespace Implementation.StructuralPatterns.Flyweight
{
    internal class FlyweightImplementation
    {
        // В принципе максимально простая реализация приспособленца, проще уже некуда.
        static void Main(string[] args)
        {
            // Клиентский код обычно создает кучу предварительно заполненных
            // легковесов на этапе инициализации приложения.
            // К примеру таблица из символов.
            var factory = new CharacterFactory();

            AddSymbolToDictionary(factory, 'A', 12, "Arial");

            AddSymbolToDictionary(factory, 'B', 14, "Times New Roman");

            AddSymbolToDictionary(factory, 'A', 23, "Times New Roman");
        }

        // Клиентский код либо сохраняет, либо вычисляет внешнее состояние и
        // передает его методам легковеса.
        public static void AddSymbolToDictionary(CharacterFactory factory, char symbol, int size, string font)
        {
            Console.WriteLine("Client: Adding a Symbol to Dictionary of Flyweights.");

            var flyweight = factory.GetCharacter(symbol);

            flyweight.Display(size, font);
        }
    }
}
