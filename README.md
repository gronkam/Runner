Паттерны проектирования:

1. Factory Pattern:
	Использован для создания объектов BaseEffect через EffectFactory, что обеспечивает гибкость в создании объектов и поддерживает отделение создания объектов от их использования.
	
2. Singleton Pattern (через Zenject):
	Использован для обеспечения единственного экземпляра определенных классов (например, EffectFactory, TimeManager) в течение жизненного цикла приложения.



Принципы SOLID:
1. Single Responsibility Principle (SRP):
	Большинство классов имеют четкое разделение ответственности, что упрощает их понимание и поддержку.

2. Open/Closed Principle (OCP):
	Классы BaseEffect, BaseEffectSettings и BaseEffectSettings<T> демонстрируют, как систему можно расширять без модификации существующего кода.
	
3. Liskov Substitution Principle (LSP): 
	Использование абстрактных базовых классов и интерфейсов, таких как BaseEffect, BaseEffectSettings, и IEffectContainer, позволяет подклассам и реализациям интерфейса замещать базовые классы и интерфейсы без нарушения ожидаемого поведения.
	
4. Interface Segregation Principle (ISP):
	Интерфейсы разделены на более мелкие, что делает систему более гибкой и адаптируемой к изменениям. Например IEffectable, ICharacter, ITickable
	
5. Dependency Inversion Principle (DIP):
	Зависимости от абстракций, а не от конкретных реализаций, обеспечивают более высокий уровень модульности и тестируемости. Использован во многих местах, например, ITime, ICoinDetector
	
Для добавление нового эффекта не нужно менять ни один класс. Например если нужно создать эффект, который увеличивает/уменьшает скорость на определенное число, это можно сделать следующим образом. Добавить классы SpeedIncreaseEffect и SpeedIncreaseEffectSettings по аналогии. Создать объект для настроек SpeedIncrease1.asset и добавить его в список EffectList.asset
Ссылка на коммит https://github.com/gronkam/Runner/commit/7e27e396e90e3c0655b259944e5798a8e211f26a#diff-f63ff26c3e23511acf446a916b976bd741c26f8d507a85c6122adc85800070d6
	
	
Design Patterns:

1. Factory Pattern:
	Used for creating BaseEffect objects through EffectFactory, which provides flexibility in object creation and supports the separation of object creation from their usage.
	
2. Singleton Pattern (via Zenject):
	Used to ensure a single instance of certain classes (e.g., EffectFactory, TimeManager) throughout the application's lifecycle.


SOLID Principles:

1. Single Responsibility Principle (SRP):
	Most classes have a clear separation of responsibility, which simplifies their understanding and maintenance.
	
2. Open/Closed Principle (OCP):
	Classes like BaseEffect, BaseEffectSettings, and BaseEffectSettings<T> demonstrate how the system can be extended without modifying existing code.
	
3. Liskov Substitution Principle (LSP):
	The use of abstract base classes and interfaces, such as BaseEffect, BaseEffectSettings, and IEffectContainer, allows subclasses and interface implementations to substitute base classes and interfaces without violating expected behavior.
	
4. Interface Segregation Principle (ISP):
	Interfaces are broken down into smaller ones, making the system more flexible and adaptable to changes. For example IEffectable, ICharacter, ITickable.
	
5. Dependency Inversion Principle (DIP):
	Dependencies on abstractions, not on concrete implementations, provide a higher level of modularity and testability. Used in many places, for example, ITime, ICoinDetector.
	
To add a new effect, there is no need to change any class. For instance, if there is a need to create an effect that increases/decreases the speed by a certain number, it can be done in the following way. Add SpeedIncreaseEffect and SpeedIncreaseEffectSettings classes analogously. Create a settings object SpeedIncrease1.asset and add it to the EffectList.asset list.
Commit link https://github.com/gronkam/Runner/commit/7e27e396e90e3c0655b259944e5798a8e211f26a#diff-f63ff26c3e23511acf446a916b976bd741c26f8d507a85c6122adc85800070d6