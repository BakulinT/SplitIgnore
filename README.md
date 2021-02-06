# SplitIgnore
Неполное разделение строки на подстроки. Метод SplitIgnore похож на метод String.Split, за исключением того, что часть строки, выделенная указателями, будет проигнорирвана при разделении.

## Описание метода
```c#
public static string[] split(string str, char separator, char marker)
```
### Параметры
- ```str``` - разбиваемая строка
- ```separator``` - разделитель
- ```marker``` - маркер

**Пример**

Разделение строки "C:\Program Files MyDirectory" по символу пробел.
```c#
string[] str = SplitIgnore.split(@"'C:\Program Files' MyDirectory MyFile", ' ', '\'');
foreach (string s in str)
{
    Console.WriteLine(s);
}
```
Результат:
```
C:\Program Files
MyDirectory
MyFile
```