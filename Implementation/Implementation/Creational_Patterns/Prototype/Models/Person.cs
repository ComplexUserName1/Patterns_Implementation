using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Prototype.Models
{
    // P.S. Можно написать реализацию посредством интерфейса ICloneable,
    // но там придётся лишние привидения делать в точке входа,
    // где будет использоваться имплементация копирования
    // + метод неоднозначно придётся назвать просто Clone
    // и он сам по себе точно не говорит в нём будет происходить
    // поверхностное или глубокое копирование, что создаст будущему мне
    // лишние проблемы, так как придётся лезть в реализацию метода и
    // уже точно самому смотреть какой тип копирования там используется

    // P.S.S. Так то можно использовать паттерн стратегии для обхода
    // это проблемы и просто передавать стратегию копирования(поверхностное/глубокое копирование),
    // но я не хочу бессмысленно усложнять имплементацию путём сопряжения
    // нескольких паттернов, так как изначальная цель создания репозитория
    // была как раз таки в короткой и максимально понятной реализации определённого паттерна.
    internal class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);//Хоть IDE и ругается на этот метод, но нам в любом случае его не нужно заменять,
                                           //так как это глубокое копирование
                                           //(+ мы используем его для создания новой immutable строки с новой ссылкой на другую ячейку в памяти).
            return clone;
        }
    }
}
