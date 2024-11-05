using Implementation.StructuralPatterns.Flyweight.Interfaces;

namespace Implementation.StructuralPatterns.Flyweight.BLClasses
{
    // Легковес хранит общую часть состояния (также называемую внутренним
    // состоянием), которая принадлежит нескольким реальным бизнес-объектам.
    // Легковес принимает оставшуюся часть состояния (внешнее состояние,
    // уникальное для каждого объекта) через его параметры метода.
    internal class Character : ICharacter
    {
        private readonly char _symbol;
        private int _size;
        private string _font;

        public Character(char symbol)
        {
            _symbol = symbol;
        }

        public void Display(int size, string font)
        {
            _size = size;
            _font = font;

            Console.WriteLine($"Flyweight: Displaying shared state - Symbol: {_symbol} and unique state - Size: {_size}, Font: {_font}\n");
        }
    }
}
