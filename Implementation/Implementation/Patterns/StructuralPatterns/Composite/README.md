﻿**Название и классификация паттерна﻿**
 
﻿**Компоновщик﻿** — паттерн, структурирующий объекты.
 
﻿**Назначение﻿**
 
Компонует объекты в древовидные структуры для представления иерархий «часть — целое». Позволяет клиентам единообразно трактовать индивидуальные и составные объекты.

﻿**Применимость﻿**
 
Основные условия для применения паттерна компоновщик:
* требуется представить иерархию объектов вида «часть — целое»;
* клиенты должны по единым правилам работать с составными и индивидуальными объектами.

﻿**Отношения﻿**
 
Клиенты используют интерфейс класса Component для взаимодействия с объектами в составной структуре. Если получателем запроса является
листовый объект Leaf, то он и обрабатывает запрос. Когда же получателем является составной объект Composite, то обычно он перенаправляет запрос своим потомкам — возможно, с выполнением некоторых дополнительных операций до или после перенаправления.

﻿**Результаты﻿**
 
Паттерн компоновщик:
* определяет иерархии классов, состоящие из примитивных и составных объектов. Из примитивных объектов можно составлять более сложные, которые, в свою очередь, участвуют в более сложных композициях и так далее. Любой клиент, ожидающий получить примитивный объект, может работать и с составным;
* упрощает архитектуру клиента. Клиенты могут единообразно работать с индивидуальными и объектами и с составными структурами. Обычно клиенту неизвестно, взаимодействует ли он с листовым или составным объектом. Это упрощает код клиента, поскольку нет необходимости писать функции, ветвящиеся в зависимости от того, с объектом какого класса они работают;
* облегчает добавление новых видов компонентов. Новые подклассы классов Composite или Leaf будут автоматически работать с уже существующими структурами и клиентским кодом. Изменять клиент при добавлении новых компонентов не нужно;
* способствует созданию общего дизайна. Впрочем, такая простота добавления новых компонентов имеет и свои отрицательные стороны: становится трудно установить ограничения на то, какие объекты могут входить в состав композиции. Иногда бывает нужно, чтобы составной объект мог включать только определенные виды компонентов. Паттерн компоновщик не позволяет воспользоваться для реализации таких ограничений статической системой типов. Вместо этого приходится проводить проверки во время выполнения.
