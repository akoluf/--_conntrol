# Итоговая работа по прохождению курса "Выбор специализации"
#### [студент Агафонов М.С]


### Для выполнения проверочной работы необходимо:
1. Создать репозиторий GitHub;
2. Нарисовать блок схему алгоритма;
3. Создать в репозитории файл README.md
4. Написать программу, решающую задачу
5. Использовать контроль версий в работе над этим проектом

### Задача:

Написать программу,  которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры: 
```sh
["hello", "2", "word", ":-)"] ---> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] ---> ["-2"]
["Russia", "Denmark", "Kazan", ""] ---> []
```

### Решение Задачи:

Блок схема решения задачи представлена по [ссылке](https://github.com/akoluf/--_conntrol/blob/master/BlockSheme.jpg)

Код программы реализации задачи   - [(скачать)](https://github.com/akoluf/--_conntrol/blob/master/Program.cs)
```sh
string[] firsArray = { "hello", "2", "word", ":-)", "123", "156", "computer scence", "Russia", "Denmark", "Kaz" };
string str = string.Empty;
for (int i = 0; i < firsArray.Length - 1; i++)
{
    if (firsArray[i].Length <= 3) str = str + firsArray[i] + ",";
}
if (firsArray[firsArray.Length - 1].Length <= 3) str = str + firsArray[firsArray.Length - 1];
string[] secondArr = str.Split(",");
Console.Write("[");
for (int i = 0; i < secondArr.Length - 1; i++)
{
    Console.Write(secondArr[i] + ", ");
}
Console.WriteLine(secondArr[secondArr.Length - 1] + "]");