# DZ_DesignPatterns

## Abstract Factory

Паттерн "Абстрактна фабрика" (Abstract Factory) це паттерн що породжує, який дозволяє створювати сімейства пов'язаних об'єктів, не прив'язуючись до конкретних класів об'єктів, що створюються.

Абстрактну фабрику потрібно використовувати:
1.	Коли система не повинна залежати від способу створення та компонування нових об'єктів;
2.	Коли об'єкти, що створюються, повинні використовуватися разом і є взаємопов'язаними.

Паттерн визначає наступних учасників:

-	Абстрактні класи: ProductA та ProductB визначають інтерфейс для класів, об'єкти яких створюватимуться у програмі;
-	Конкретні класи ConcreteProductA1/ConcreteProductA2 та ConcreteProductB1/ConcreteProductB2 представляють конкретну реалізацію абстрактних класів;
-	Абстрактний клас фабрики AbstractFactory визначає методи створення об'єктів. Причому методи повертають абстрактні продукти;
-	Конкретні класи фабрик ConcreteFactory1 та ConcreteFactory2 реалізують абстрактні методи базового класу та безпосередньо визначають які конкретні продукти використовувати.


```mermaid
  classDiagram
    AbstractFactory : CreateProductA()
    AbstractFactory : CreateProductB()
    AbstractFactory <|-- ConcreteFactory1
    AbstractFactory <|-- ConcreteFactory2

    ConcreteProductA2 <-- ConcreteFactory2
    ConcreteProductA1 <-- ConcreteFactory1
    ProductA <|-- ConcreteProductA2
    ConcreteProductA1 --|> ProductA

    ConcreteProductB2 <-- ConcreteFactory2
    ConcreteProductB1 <-- ConcreteFactory1
    ProductB <|-- ConcreteProductB2
    ConcreteProductB1 --|> ProductB

    ConcreteFactory2 : CreateProductA()
    ConcreteFactory2 : CreateProductB()
    ConcreteFactory1 : CreateProductA()
    ConcreteFactory1 : CreateProductB()
```


## Facade

Фасад (Facade) є шаблоном проектування, який дозволяє приховати складність системи за допомогою надання спрощеного інтерфейсу для взаємодії з нею.

Фасад потрібно використовувати:
1.	Коли є складна система, та необхідно спростити з нею роботу. Фасад дозволить визначити одну точку взаємодії між клієнтом та системою;
2.	Коли треба зменшити кількість залежностей між клієнтом та складною системою. Фасадні об'єкти дозволяють відокремити, ізолювати компоненти системи від клієнта та розвивати та працювати з ними незалежно;
3.	Коли потрібно визначити підсистеми компонентів у складній системі. Створення фасадів для компонентів кожної окремої підсистеми дозволить спростити взаємодію між ними та підвищити їхню незалежність один від одного.

Паттерн визначає наступних учасників:
-	Класи Subsystem1, Subsystem2 і т.д. є компонентами складної підсистеми, з якими має взаємодіяти клієнт;
-	Facade – безпосередньо фасад, який надає інтерфейс клієнту для роботи з компонентами.


```mermaid
  classDiagram
    Facade : Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    Facade : Operation()
    Facade : Subsystem1 _subsystem1
    Facade : Subsystem2 _subsystem2

    Facade o-- Subsystem1
    Facade o-- Subsystem2

    Subsystem1 : operation1()
    Subsystem1 : opertaionN()
    Subsystem2 : operation2()
    Subsystem2 : operationM()
```
