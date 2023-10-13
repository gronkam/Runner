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
	Использование абстрактных базовых классов и интерфейсов, таких как BaseEffect, BaseEffectSettings, и IEffectContainer, позволяет подклассам и 
	реализациям интерфейса замещать базовые классы и интерфейсы без нарушения ожидаемого поведения.
	
4. Interface Segregation Principle (ISP):
	Интерфейсы разделены на более мелкие, что делает систему более гибкой и адаптируемой к изменениям. Например IEffectable, ICharacter, ITickable
	
5. Dependency Inversion Principle (DIP):
	Зависимости от абстракций, а не от конкретных реализаций, обеспечивают более высокий уровень модульности и тестируемости. Использован во многих местах, например, ITime, ICoinDetector
	
	
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
	The use of abstract base classes and interfaces, such as BaseEffect, BaseEffectSettings, and IEffectContainer, allows subclasses and interface 
	implementations to substitute base classes and interfaces without violating expected behavior.
	
4. Interface Segregation Principle (ISP):
	Interfaces are broken down into smaller ones, making the system more flexible and adaptable to changes. For example IEffectable, ICharacter, ITickable.
	
5. Dependency Inversion Principle (DIP):
	Dependencies on abstractions, not on concrete implementations, provide a higher level of modularity and testability. Used in many places, for example, ITime, ICoinDetector.