**Название и классификация паттерна**

**Стратегия** — паттерн поведения объектов.

**Назначение**

Определяет семейство алгоритмов, инкапсулирует каждый из них и делает их взаимозаменяемыми. Стратегия позволяет изменять алгоритмы независимо от клиентов, которые ими пользуются.

**Другие названия**

Policy (политика).

**Применимость**

Основные условия для применения паттерна стратегия:
* наличие множества родственных классов, отличающихся только поведением. Стратегия позволяет настроить класс одним из многих возможных вариантов поведения;
* наличие нескольких разновидностей алгоритма. Например, можно определить два варианта алгоритма, один из которых требует больше времени, а другой — больше памяти. Стратегии разрешается применять, когда варианты алгоритмов реализованы в виде иерархии классов [HO87];
* в алгоритме содержатся данные, о которых клиент не должен «знать». Используйте паттерн стратегия, чтобы не раскрывать сложные, специфичные для алгоритма структуры данных;
* в классе определено много вариантов поведения, представленных разветвленными условными операторами. В этом случае проще перенести код из ветвей в отдельные классы стратегий.

**Отношения**

* Классы Strategy и Context взаимодействуют для реализации выбранного алгоритма. Контекст может передать стратегии все необходимые алгоритму данные в момент его вызова. Вместо этого контекст может позволить обращаться к своим операциям в нужные моменты, передавая ссылку на самого себя операциям класса Strategy;
* контекст переадресует запросы своих клиентов объекту-стратегии. Обычно клиент создает объект ConcreteStrategy и передает его контексту, после чего клиент взаимодействует исключительно с контекстом. Часто в распоряжении клиента находится несколько классов ConcreteStrategy, которые он может выбирать.

**Результаты**

Основные достоинства и недостатки паттерна стратегия:
* семейства родственных алгоритмов. Иерархия классов Strategy определяет семейство алгоритмов или вариантов поведения, которые можно повторно использовать в разных контекстах. Наследование позволяет вычленить общую для всех алгоритмов функциональность;
* альтернатива порождению подклассов. Наследование поддерживает многообразие алгоритмов или поведений. Можно напрямую породить от Context подклассы с различными поведениями. Но при этом поведение
жестко «зашивается» в класс Context. Реализации алгоритма и контекста смешиваются, что затрудняет понимание, сопровождение и расширение контекста. Кроме того, заменить алгоритм динамически уже не удастся. В результате вы получаете множество родственных классов, отличающихся только алгоритмом или поведением. Инкапсуляция алгоритма в отдельный класс Strategy позволяет изменять его независимо от контекста;
* стратегии позволяют избавиться от условных конструкций. С паттерном стратегия удается отказаться от условных операторов при выборе нужного поведения. Когда различные поведения помещаются в один класс, трудно выбрать нужное без применения условных операторов. Инкапсуляция же каждого поведения в отдельный класс Strategy решает эту проблему.
Так, без использования стратегий код для разбиения текста на строки мог бы выглядеть следующим образом:

```
void Composition::Repair () {
  switch (_breakingStrategy) {
  case SimpleStrategy:
  ComposeWithSimpleCompositor();
  break;
  case TeXStrategy:
  ComposeWithTeXCompositor();
  break;
  // ...
  }
  // При необходимости объединить результаты
  // с существующей композицией
}
```

Паттерн стратегия позволяет обойтись без конструкции выбора за счет делегирования задачи разбиения на строки объекту Strategy:

```
void Composition::Repair () {
  _compositor->Compose();
  // При необходимости объединить результаты
  // с существующей композицией
}
```

Если код содержит много условных операторов, то часто это признак того, что нужно применить паттерн стратегия;
* выбор реализации. Стратегии могут предлагать различные реализации одного и того же поведения. Клиент вправе выбирать подходящую стратегию в зависимости от своих требований к быстродействию и памяти;
* клиенты должны знать о различных стратегиях. Потенциальный недостаток этого паттерна в том, что для выбора подходящей стратегии клиент должен понимать, чем отличаются разные стратегии. Поэтому наверняка придется раскрыть клиенту некоторые особенности реализации. Отсюда следует, что паттерн стратегия стоит применять лишь тогда, когда различия в поведении важны для клиента;
* затраты на передачу информации между стратегией и контекстом. Интерфейс Strategy совместно используется всеми подклассами ConcreteStrategy — какой бы сложной или тривиальной ни была их реализация. Поэтому вполне вероятно, что некоторые стратегии не будут пользоваться всей передаваемой им информацией, особенно простые. Это означает, что в отдельных случаях контекст создаст и проинициализирует параметры, которые никому не нужны. Если возникнет проблема, то между классами Strategy и Context придется установить более тесную связь;
* увеличение числа объектов. Применение стратегий увеличивает число объектов в приложении. Иногда эти издержки можно сократить, если реализовать стратегии в виде объектов без состояния, которые могут совместно использоваться несколькими контекстами. Остаточное состояние хранится в самом контексте и передается при каждом обращении к объекту-стратегии. Совместно используемые стратегии не должны сохранять состояние между вызовами. В описании паттерна приспособленец этот подход обсуждается более подробно.
