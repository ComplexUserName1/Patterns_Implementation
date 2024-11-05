using Implementation.StructuralPatterns.Flyweight.Interfaces;

namespace Implementation.StructuralPatterns.Flyweight.BLClasses
{
    // Фабрика Легковесов создает объекты-Легковесы и управляет ими. Она
    // обеспечивает правильное разделение легковесов. Когда клиент запрашивает
    // легковес, фабрика либо возвращает существующий экземпляр, либо создает
    // новый, если он ещё не существует.
    internal class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _characters = new();

        public ICharacter GetCharacter(char symbol)
        {
            var key = symbol;

            if (!_characters.ContainsKey(key))
            {
                Console.WriteLine("CharacterFactory: Can't find a flyweight, creating new one.");

                _characters.Add(key, new Character(symbol));
            }
            else
            {
                Console.WriteLine("CharacterFactory: Reusing existing flyweight.");
            }

            return _characters[key];
        }
    }
}
