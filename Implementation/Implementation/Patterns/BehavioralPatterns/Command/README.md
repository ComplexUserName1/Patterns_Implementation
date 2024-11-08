﻿**Название и классификация паттерна﻿**
 
﻿**Команда﻿** — паттерн поведения объектов.
 
﻿**Назначение﻿**
 
Инкапсулирует запрос в объекте, позволяя тем самым параметризовать клиенты для разных запросов, ставить запросы в очередь или протоколировать их, а также поддерживать отмену операций.

﻿**Другие названия﻿**
 
Action (действие), Transaction (транзакция).

﻿**Применимость﻿**
 
Основные условия для применения паттерна команда:
* параметризация объектов выполняемым действием, как в случае с пунктами меню MenuItem. В процедурном языке такую параметризацию можно выразить с помощью функции обратного вызова, то есть такой функции, которая регистрируется, чтобы быть вызванной позднее. Команды представляют собой объектно-ориентированную альтернативу функциям обратного вызова;
* определение, постановка в очередь и выполнение запросов в разное время. Время жизни объекта Command не обязательно должно зависеть от времени жизни исходного запроса. Если получатель запроса удается реализовать так, чтобы он не зависел от адресного пространства, то объект-команду можно передать другому процессу, который займется его выполнением;
* поддержка отмены операций. Операция Execute объекта Command может сохранить состояние, необходимое для отмены действий, выполненных
командой. В этом случае в интерфейсе класса Command должна быть дополнительная операция Unexecute, которая отменяет действия, выполненные предшествующим обращением к Execute. Выполненные команды хранятся в списке истории. Для реализации произвольного числа уровней отмены и повтора команд нужно обходить этот список соответственно в обратном и прямом направлениях, вызывая при посещении каждого элемента команду Unexecute или Execute;
* поддержка протоколирования изменений, чтобы их можно было выполнить повторно после сбоя в системе. Дополнив интерфейс класса Command операциями сохранения и загрузки, вы сможете вести протокол изменений во внешней памяти. Для восстановления после сбоя нужно будет загрузить сохраненные команды с диска и повторно выполнить их с помощью операции Execute;
* структурирование системы на основе высокоуровневых операций, построенных из примитивных. Такая структура типична для информационных систем с поддержкой транзакций. Транзакция инкапсулирует набор изменений данных. Паттерн команда позволяет моделировать транзакции. У всех команд есть общий интерфейс, что дает возможность работать одинаково с любыми транзакциями. С помощью этого паттерна можно легко добавлять в систему новые виды транзакций.

﻿**Отношения﻿**
 
* клиент создает объект ConcreteCommand и устанавливает для него получателя;
* инициатор Invoker сохраняет объект ConcreteCommand;
* инициатор отправляет запрос, вызывая операцию команды Execute. Если поддерживается отмена выполненных действий, то ConcreteCommand перед вызовом Execute сохраняет информацию о состоянии, достаточную для выполнения отмены;
* объект ConcreteCommand вызывает операции получателя для выполнения запроса.
На следующей схеме видно, как Command разрывает связь между инициатором и получателем (а также запросом, который должен выполнить последний).

![image](https://github.com/user-attachments/assets/a79ea5e8-3c88-409e-a4a3-202b11e25e38)

﻿**Результаты﻿**
Основные результаты применения паттерна команда:
* команда отделяет объект, инициирующий операцию, от объекта, располагающего информацией о том, как ее выполнить;
* команды — это самые настоящие объекты. Их можно обрабатывать и расширять точно так же, как любые другие объекты;
* из простых команд можно собирать составные, например класс MacroCommand, рассмотренный выше. В общем случае составные команды описываются паттерном компоновщик (196);
* новые команды добавляются легко, поскольку никакие существующие классы изменять не нужно.
