// Итоговая проверочная работа. 
// ЗАДАЧА.
// Написать программу,  которая из имеющегося массива строк формирует массив из строк, длинна которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Решение задачи

// создаем начальный массив типа string
string[] firsArray = { "hello", "2", "word", ":-)", "123", "156", "computer scence", "Russia", "Denmark", "Kaz" };


// объявляем пустую строковую переменную - str
string str = string.Empty;
// перебираем все элементы firsArray[] массива до предпоследнего
// если удовлетворяют условию записываем в строку через запятую
for (int i = 0; i < firsArray.Length - 1; i++)
{
    if (firsArray[i].Length <= 3) str = str + firsArray[i] + ",";
}
// Проверяем последний элемент массива firsArray[] 
// если удовлетворяет условию записываем в строку str
if (firsArray[firsArray.Length - 1].Length <= 3) str = str + firsArray[firsArray.Length - 1];

// Делим строку str сплитом и записываем в массив secondArr[]
string[] secondArr = str.Split(",");

//Выводим итоговый массив secondArr[] в консоль
Console.Write("[");
for (int i = 0; i < secondArr.Length - 1; i++)
{
    Console.Write(secondArr[i] + ", ");
}
Console.WriteLine(secondArr[secondArr.Length - 1] + "]");

