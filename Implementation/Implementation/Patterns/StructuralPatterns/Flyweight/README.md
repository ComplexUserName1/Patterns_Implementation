﻿**Название и классификация паттерна﻿**
 
﻿**Приспособленец﻿** — паттерн, структурирующий объекты.
 
﻿**Назначение﻿**
 
Применяет совместное использование для эффективной поддержки множества мелких объектов.

﻿**Применимость﻿**
 
Эффективность паттерна приспособленец во многом зависит от того, как и где он используется. Применяйте этот паттерн, когда выполнены все нижеперечисленные условия:
* в приложении используется большое число объектов;
* из-за этого затраты на хранение высоки;
* большую часть состояния объектов можно вынести вовне;
* многие группы объектов можно заменить относительно небольшим количеством совместно используемых объектов, поскольку внешнее состояние вынесено;
* приложение не зависит от идентичности объекта. Поскольку объекты-приспособленцы могут использоваться совместно, то проверка на идентичность возвратит признак истинности для концептуально различных объектов.

﻿**Отношения﻿**
 
* Состояние, необходимое приспособленцу для нормальной работы, классифицируется на внутреннее или внешнее. Внутреннее состояние хранится в самом объекте ConcreteFlyweight. Внешнее состояние хранится или вычисляется клиентами. Клиент передает его приспособленцу при вызове операций;
* клиенты не должны создавать экземпляры класса ConcreteFlyweight напрямую, а могут получать их только от объекта FlyweightFactory. Это позволит гарантировать корректное совместное использование.

﻿**Результаты﻿**
 
При использовании приспособленцев возможны затраты на передачу, поиск или вычисление внутреннего состояния на стадии выполнения, особенно если раньше оно хранилось как внутреннее. Однако такие затраты с лихвой компенсируются экономией памяти за счет совместного использования объектов-приспособленцев.

Экономия памяти обусловлена несколькими причинами:
* уменьшение общего числа экземпляров;
* сокращение объема памяти, необходимого для хранения внутреннего состояния;
* вычисление, а не хранение внешнего состояния (если это действительно так).
Чем выше степень совместного использования приспособленцев, тем существеннее экономия. С увеличением объема совместного состояния экономия также возрастает. Самого большого эффекта удается добиться, когда суммарный объем внутренней и внешней информации о состоянии велик, а внешнее состояние вычисляется, а не хранится. Тогда совместное использование уменьшает стоимость хранения внутреннего состояния, а за счет вычислений сокращается память, отводимая под внешнее состояние.
Паттерн приспособленец часто применяется вместе с компоновщиком для представления иерархической структуры в виде графа с совместно используемыми листовыми узлами. Из-за разделения указатель на родителя не может храниться в листовом узле-приспособленце, а должен передаваться ему как часть внешнего состояния. Это оказывает заметное влияние на способ взаимодействия объектов иерархии между собой.
