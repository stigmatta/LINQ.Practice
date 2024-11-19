
//#region task1
//Получить весь масcив целых
//List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var task1_1 = from var in arr select var;
//var task1_2 = arr.Select(var=>var);

//foreach (var item in task1_1)
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();

//foreach (var item in task1_2)
//{
//    Console.Write(item + " ");
//}


//Console.WriteLine();
//Console.WriteLine();


//// Получить четные целые

//var task2_1 = from var in arr
//              where var%2 == 0
//              select var;
//var task2_2 = arr.Where(var => var % 2 == 0);


//foreach (var item in task2_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//foreach (var item in task2_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();

////Получить нечетные целые

//var task3_1 = from var in arr
//              where var % 2 == 1
//              select var;
//var task3_2 = arr.Where(var => var % 2 == 1);


//foreach (var item in task3_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//foreach (var item in task3_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();


//// Получить значения больше заданного

//int value = 7;

//var task4_1 = from var in arr
//              where var > value
//              select var;
//var task4_2 = arr.Where(var => var>value);


//foreach (var item in task4_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//foreach (var item in task4_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();


//// Получить числа в заданном диапазоне

//int lowBorder = 3, highBorder = 6;

//var task5_1 = from var in arr
//              where var >=lowBorder && var <=highBorder
//              select var;
//var task5_2 = arr.Where(var => var >= lowBorder && var <= highBorder);

//foreach (var item in task5_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//foreach (var item in task5_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();

//// Получить числа кратные семи. Результат отсортировать по
////возрастанию

//var task6_1 = from var in arr
//              where var % 7 == 0
//              orderby var
//              select var;
//var task6_2 = arr.Where(var => var % 7 == 0).OrderBy(var => var);

//foreach (var item in task6_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//foreach (var item in task6_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();


//// Получить числа кратные восьми. Результат отсортировать
////по убыванию

//var task7_1 = from var in arr
//              where var % 8 == 0
//              orderby var descending
//              select var;
//var task7_2 = arr.Where(var => var % 8 == 0).OrderByDescending(var => var);

//foreach (var item in task7_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();

//foreach (var item in task7_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();
//#endregion


//#region task2
//List<string> cities = new List<string>() {
//    "Kyiv", "Lviv", "Odessa", "Kharkiv", "Dnipro", "Zaporizhzhia", "Ivano-Frankivsk",
//    "Vinnytsia", "Ternopil", "Chernihiv", "Cherkasy", "Sumy", "Poltava",
//    "Rivne", "Zhytomyr", "Chernivtsi", "Kropyvnytskyi", "Lutsk", "Uzhhorod",
//    "Mariupol", "Kremenchuk", "Mykolaiv", "Kherson", "Kramatorsk"};

//// Получить весь масcив городов
//var task1_1 = from city in cities
//              select city;
//var task1_2 = cities.Select(city => city);

//foreach (var item in task1_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//Console.WriteLine();


//foreach (var item in task1_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//// Получить города с длиной названия равной заданному

//int length = 6;
//var task2_1 = from city in cities
//              where city.Length == length
//              select city;
//var task2_2 = cities.Where(city=>city.Length==length);

//foreach (var item in task2_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//Console.WriteLine();


//foreach (var item in task2_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//// Получить города названия, которых начинается с буквы C

//var task3_1 = from city in cities
//              where city[0] == 'C'
//              select city;
//var task3_2 = cities.Where(city => city[0] == 'C');

//foreach (var item in task3_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//Console.WriteLine();


//foreach (var item in task3_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//// Получить города названия, которых заканчивается на букву l

//var task4_1 = from city in cities
//              where city.Last()=='l'
//              select city;
//var task4_2 = cities.Where(city => city.Last() == 'l');

//foreach (var item in task4_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//Console.WriteLine();


//foreach (var item in task4_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//// Получить города названия, которых начинаются на K и заканчиваются на букву K
//var task5_1 = from city in cities
//              where city[0] == 'K' && city.Last() == 'k'
//              select city;
//var task5_2 = cities.Where(city => city[0] == 'K' && city.Last() == 'k');

//foreach (var item in task5_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//Console.WriteLine();


//foreach (var item in task5_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();


////Получить города названия, которых начинаются на Ne. Результат отсортировать по убыванию

//var task6_1 = from city in cities
//              where city.StartsWith("Kr")
//              orderby city descending
//              select city;
//var task6_2 = cities.Where(city => city.StartsWith("Kr")).OrderByDescending(city => city);

//foreach (var item in task6_1)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//Console.WriteLine();


//foreach (var item in task6_2)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();


//#endregion

#region task3

List<Student> students = new List<Student>()
{
    new Student
    {
        Name = "Olena",
        LastName = "Shevchenko",
        Age = 20,
        EducationalInstitute = "Kyiv National University"
    },
    new Student
    {
        Name = "Boris",
        LastName = "Kovalenko",
        Age = 24,
        EducationalInstitute = "Lviv Polytechnic"
    },
    new Student
    {
        Name = "Kateryna",
        LastName = "Bondar",
        Age = 19,
        EducationalInstitute = "MIT"
    },
    new Student
    {
        Name = "Maksym",
        LastName = "Bronev",
        Age = 23,
        EducationalInstitute = "Dnipro Technical University"
    },
    new Student
    {
        Name = "Iryna",
        LastName = "Hrytsenko",
        Age = 21,
        EducationalInstitute = "Odessa National University"
    },
    new Student
    {
        Name = "Boris",
        LastName = "Tkachuk",
        Age = 24,
        EducationalInstitute = "Oxford"
    },
    new Student
    {
        Name = "Sofia",
        LastName = "Bronko",
        Age = 17,
        EducationalInstitute = "Oxford"
    }
};

// Получить весь массив студентов

var task1_1 = from student in students
              select student;
var task1_2 = students.Select(student=>student);

foreach(var item in task1_1)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();

foreach (var item in task1_2)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// Получить студентов с именем Boris
var task2_1 = from student in students
              where student.Name == "Boris"
              select student;
var task2_2 = students.Where(student => student.Name == "Boris");

foreach (var item in task2_1)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (var item in task2_2)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Получить студентов с фамилией, которая начинается с Bro
var task3_1 = from student in students
              where student.LastName.StartsWith("Bro")
              select student;
var task3_2 = students.Where(student => student.LastName.StartsWith("Bro"));

foreach (var item in task3_1)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (var item in task3_2)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Получить студентов, которые старше 19 лет
var task4_1= from student in students
             where student.Age>19
             select student;
var task4_2 = students.Where(student => student.Age > 19);

foreach (var item in task4_1)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (var item in task4_2)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Получить студентов, которые старше 20 лет и младше 23 лет
var task5_1= from student in students
             where student.Age>20 && student.Age<23
             select student;
var task5_2 = students.Where(student=>student.Age > 20&&student.Age<23);

foreach (var item in task5_1)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (var item in task5_2)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Получить студентов, которые учатся в MIT
var task6_1= from student in students
             where student.EducationalInstitute == "MIT"
             select student;
var task6_2 = students.Where(student => student.EducationalInstitute == "MIT");

foreach (var item in task6_1)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (var item in task6_2)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// Получить студентов, которые учатся в Oxford и их возраст старше 18 лет. Результат отсортировать по возрасту по убыванию.

var task7_1 = from student in students
              where student.EducationalInstitute == "Oxford" && student.Age > 18
              select student;
var task7_2 = students.Where(student=>student.EducationalInstitute=="Oxford" && student.Age > 18);

foreach (var item in task7_1)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (var item in task7_2)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
#endregion

