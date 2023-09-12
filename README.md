# project0

Вариант: 7

Ответы на вопросы
8 Какая дисциплина (вариант контроля) типов принята в языке C#?
  В языке программирования C# используется статическая проверка типов, что означает, что типы переменных определяются на этапе компиляции, а не во время выполнения. 
  Это позволяет выявлять ошибки типов на ранних стадиях разработки и улучшает надежность программ.

C# также поддерживает динамический тип данных с использованием ключевого слова dynamic, но это является исключением из общего правила статической проверки типов и обычно используется в случаях, 
когда необходимо работать с данными, тип которых нельзя определить на этапе компиляции, например, при взаимодействии с объектами, полученными из динамических источников данных. 
Однако, даже при использовании dynamic, C# по-прежнему выполняет проверку типов во время выполнения, но без строгой статической проверки.

15 Приведите синтаксис оператора выбора в общем виде. Проиллюстрируйте его фрагментом программы на языке C#.
  switch (выражение)
  {
      case константа1:
          последовательность_операторов1;
      break;
      case константа2:
          последовательность_операторов2;
      break;
  
      ...
  
      case константаN:
          последовательность_операторовN;
      break;
      default
          последовательность_операторов;
  }


22 Какой символ используется для указания полного имени объекта в языке C#?
В языке программирования C# для указания полного имени объекта или доступа к членам объекта используется точка (.).
С точкой вы разделяете иерархию объектов, классов или пространств имен, чтобы обратиться к членам объекта или типам внутри этих пространств имен.
Точка (.) позволяет вам навигировать по иерархии объектов и типов в C# и вызывать их методы, свойства и поля.

5 Является ли среда CLR многоязычной?
   Да, является.
   
12 Как обозначается область видимости переменной в языке C#?
  В языке программирования C# область видимости переменной обозначается с помощью фигурных скобок {}.
Переменные, объявленные внутри определенной пары фигурных скобок, считаются локальными для этой области видимости и могут использоваться только внутри нее.
Эта область видимости также называется блоком кода.
    
