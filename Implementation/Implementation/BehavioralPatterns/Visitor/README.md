﻿**Название и классификация паттерна﻿**
 
﻿**Посетитель﻿** — паттерн поведения объектов.
 
﻿**Назначение﻿**
 
Описывает операцию, выполняемую с каждым объектом из некоторой структуры. Паттерн посетитель позволяет определить новую операцию, не изменяя классы этих объектов.

﻿**Применимость﻿**
 
Основные условия для применения паттерна посетитель:
* в структуре присутствуют объекты многих классов с различными интерфейсами, и вы хотите выполнять над ними операции, зависящие от конкретных классов;
* над объектами, входящими в состав структуры, должны выполняться разнообразные, не связанные между собой операции и вы не хотите «засорять» классы такими операциями. Посетитель позволяет объединить родственные операции, поместив их в один класс. Если структура объектов является общей для нескольких приложений, то паттерн посетитель позволит в каждое приложение включить только относящиеся к нему операции;
* классы, определяющие структуру объектов, изменяются редко, но новые операции над этой структурой добавляются часто. При изменении классов, представленных в структуре, придется переопределить интерфейсы всех посетителей, а это может вызвать затруднения. Поэтому если классы меняются достаточно часто, то, вероятно, лучше определить операции прямо в них.

﻿**Отношения﻿**
 
* Клиент, использующий паттерн посетитель, должен создать объект класса ConcreteVisitor, а затем обойти всю структуру, посетив каждый ее элемент.
* При посещении элемента последний вызывает операцию посетителя, соответствующую своему классу. Элемент передает этой операции себя в аргументе, чтобы посетитель мог при необходимости получить доступ к его состоянию.

На представленной диаграмме взаимодействий показаны отношения между объектом, структурой, посетителем и двумя элементами.

![image](https://github.com/user-attachments/assets/c5480527-c540-445f-970e-15c365f9a41b)

﻿**Результаты﻿**
 
Основные достоинства и недостатки паттерна посетитель:
* упрощение добавления новых операций. С помощью посетителей легко добавлять операции, зависящие от компонентов сложных объектов. Для определения новой операции над структурой объектов достаточно просто ввести нового посетителя. Напротив, если функциональность распределена по нескольким классам, то для определения новой операции придется изменить каждый класс;
* объединение родственных операций и отсечение тех, которые не имеют к ним отношения. Родственное поведение не разносится по всем классам, присутствующим в структуре объектов, оно локализовано в посетителе. Не связанные друг с другом функции распределяются по отдельным подклассам класса Visitor. Это способствует упрощению как классов, определяющих элементы, так и алгоритмов, инкапсулированных в посетителях. Все относящиеся к алгоритму структуры данных можно скрыть в посетителе;
* трудности с добавлением новых классов ConcreteElement. Паттерн посетитель усложняет добавление новых подклассов класса Element. Каждый новый конкретный элемент требует объявления новой абстрактной операции в классе Visitor, которую нужно реализовать в каждом из существующих классов ConcreteVisitor. Иногда большинство конкретных посетителей могут унаследовать операцию по умолчанию, предоставляемую классом Visitor, что скорее исключение, чем правило. Поэтому при решении вопроса о том, стоит ли использовать паттерн посетитель, нужно прежде всего посмотреть, что будет изменяться чаще: алгоритм, применяемый к объектам структуры, или классы объектов, составляющих эту структуру. Вполне вероятно, что с сопровождением иерархии классов Visitor возникнут трудности, если новые классы ConcreteElement добавляются часто. В таких случаях проще определить операции прямо в классах, представленных в структуре. Если же иерархия классов Element стабильна, но постоянно расширяется набор операций или модифицируются алгоритмы, то паттерн посетитель поможет лучше управлять такими изменениями;
* посещение различных иерархий классов. Итератор (см. описание паттерна итератор) может посещать объекты структуры по мере ее обхода, вызывая операции объектов. Но итератор не способен работать со структурами, состоящими из объектов разных типов. Так, интерфейс класса Iterator, рассмотренный на с. 310, может всего лишь получить доступ к объектам типа Item:

```
template <class Item>
class Iterator {
  // ...
  Item CurrentItem() const;
};
```

Отсюда следует, что все элементы, которые итератор может посетить, должны иметь общий родительский класс Item.

У посетителя таких ограничений нет. Ему разрешено посещать объекты, не имеющие общего родительского класса. В интерфейс класса Visitor можно добавить операции для объектов любого типа. Например, в следующем объявлении

```
class Visitor {
public:
  // ...
  void VisitMyType(MyType*);
  void VisitYourType(YourType*);
};
```

классы MyType и YourType необязательно должны быть связаны отношением наследования;

* накопление состояния. Посетители могут накапливать информацию о состоянии при посещении объектов структуры. Если не использовать этот паттерн, то состояние придется передавать в дополнительных аргументах операций, выполняющих обход, или хранить в глобальных переменных;
* нарушение инкапсуляции. Применение посетителей подразумевает, что класс ConcreteElement имеет достаточно развитый интерфейс, для того чтобы посетители могли справиться со своей работой. Поэтому при использовании данного паттерна приходится предоставлять открытые операции для доступа к внутреннему состоянию элементов, что ставит под угрозу инкапсуляцию.