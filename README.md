# Backend Developer Test
# Instructions
- You need to complete this test within 3 hours 
from the time you receive it.
- Submit the answers by email or Telegram.
- Submit answers for questions 1 and 2 in a Word (or WordPad) document.
- Submit programing assignments, questions 3 and 4, 
as a ZIP file of the entire Visual Studio solution.
## Question 1: Testing Fundamentals
*** THIS IS NOT A PROGRAMMING TASK ***

Imagine that someone has already developed a program in C#, .NET Core 
that accepts a positive integer number as input and 
outputs all prime numbers that the input is divisible by.

Example: for input `350`, the output is: `2, 5, 7`.

You need to test that the program works correctly.
 Write what test cases you will need to execute to verify that.

Example:
```
Test 1

1. Enter 350

Expected output: 2, 5, 7
```
## Answer 1
Если программа выдаёт только уникальные множители (делители), то если
 после первого выполнения делений получилась не 1, то сортируем делители
 по убыванию, теперь берём первый делитель делим до упора на
 максимальный делитель, до упора это делить пока резльтат деления не
 будет равен 1 или когда в очередной раз поделить нацело будет уже
 нельзя, потом делим на второй делитель и так перебираем их все, после
 полного перебора всех делителей должна получиться 1, если нет, то тест
 не пройдён.

Тест прогоняем 5 раз (автоматически в цикле)

## Question 2: SQL Proficiency
The database has two tables:

Table 1: department
- id INT PRIMARY KEY
- name VARCHAR(50)

Table 2: employee
- id INT PRIMARY KEY 
- department_id INT
- manager_id INT(11)
- name VARCHAR(50)
- income DECIMAL

Write a query that outputs all employees that do not have a manager,
 who works in the same department.

## Answer 2
Не понял часть про "who works in the same department" - "которые
 работают в одном отделе", в одном отделе с кем ? 

Имеется в виду что в отделе где менеджер есть, то как определить
 что в отделе есть менеджер ? 
 
Или имелось в виду что вывести сотрудников без менеджера если в отделе
 более одного сотрудника ? 

Как понять что у сотрудника нет начальника ?
 manager_id имеет значение NULL ? 

Или равно 0 и менеджер с идентификатором 0 имеет
 имя "Менеджер не назначен" ?

Будем исходить из того что условие отсутствия назначеного менеджера
 вычисляется выражением : `manager_id IS NULL.`

Работники у которых нет начальника
```
SELECT
    id AS employee_id,
    name AS employee_name
FROM
    employee
WHERE
    manager_id IS NULL
;
```
С дополнительным требованием "who works in the same department",
 оба варината какие то монструозные или разбивать надо на два запроса.
Исходя из того что вопрос про основы SQL, не думаю что монструозность
 требуется.

## Question 3: OOP Design Fundamentals
Write a console application in C#, .NET Core that computes
 the area and perimeter of a circle and rectangle.
 Create an abstract class "Shape" and a factory method that generates
 objects of types Circle and Rectangle.

Example Input
```
circle:10
rectangle:10x20
Example Output
Area: 314.16, Perimeter: 62.83
Area: 200, Perimeter: 60
```
## Answer 3
[Shape](https://github.com/SbWereWolf/bitior/blob/master/Shape/shape/Program.cs)

## Question 4: Algorithms
Write a console application in C#, .NET Core that for a given word,
 derives a palindrome by inserting the minimum number of characters into
 that word. (A palindrome is a word that reads the same backward
 as forward, e.g. "madam".)
 
Example Input
```
abb
a
aabb
Example Output
abb => abba (not bbabb)
a => a
aabb => aabbaa (instead of bbaabb, lexicographically higher one
```
## Answer 4
[Palindrome](https://github.com/SbWereWolf/bitior/blob/master/Palindrome/Palindrome/Program.cs)