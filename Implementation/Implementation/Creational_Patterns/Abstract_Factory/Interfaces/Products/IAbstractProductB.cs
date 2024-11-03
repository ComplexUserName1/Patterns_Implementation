using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Products
{
    // Базовый интерфейс другого продукта. Все продукты могут взаимодействовать
    // друг с другом, но правильное взаимодействие возможно только между
    // продуктами одной и той же конкретной вариации.
    internal interface IAbstractProductB
    {
        // Продукт B способен работать самостоятельно...
        string UsefulFunctionB();

        // ...а также взаимодействовать с Продуктами А той же вариации.
        //
        // Абстрактная Фабрика гарантирует, что все продукты, которые она
        // создает, имеют одинаковую вариацию и, следовательно, совместимы.
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
