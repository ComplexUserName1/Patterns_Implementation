using Implementation.Creational_Patterns.Builder.Interfaces;

namespace Implementation.Creational_Patterns.Builder.BL_Classes.Directors
{
    // Директор отвечает только за выполнение шагов построения в определённой
    // последовательности. Это полезно при производстве продуктов в определённом
    // порядке или особой конфигурации. Строго говоря, класс Директор
    // необязателен, так как клиент может напрямую управлять строителями.
    internal class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // Директор может строить несколько вариаций продукта, используя
        // одинаковые шаги построения.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
