// filterfing ( Where , OfType)

string[] names = { "mohammad", " ali", "reza", "nima", "akram", "zahra" };

var query = names.Where(x => CheckLenght(x));
foreach (var item in query)
{
    Console.WriteLine(item);
}


static bool CheckLenght(string str)
{
    if (str.Length > 5)   // mohammad is the output
        return true;
    return false;
}

Console.ReadKey();















//using Linq_examples;

//List<Student> students = new List<Student>()
//{
//    new Student {Id = 00001, Name = "mehrshad", Age =21 , Family = "khaki"},
//    new Student {Id = 00002, Name = "amir", Age =22, Family = "kochaki"},
//    new Student {Id = 00003, Name = "ahmad", Age =21, Family = "heidari"},
//    new Student {Id = 00004, Name = "mehdi", Age =22, Family = "ahmadvand"}
//};                           

//// where 
//var query = students.Where(x => x.Name == "mehrshad");

//foreach (var item in query)
//{
//    Console.WriteLine($"the id is {item.Id} and his age is {item.Age} , name is {item.Name}");
//}

//// select
//var query2 = students.Select(x => new Student
//{
//    Age = x.Age,
//    Name = x.Name
//});
//foreach (var item in query2)
//{
//   Console.WriteLine($"name is {item.Name} , age is = {item.Age}");
//}


//// annonymouse
//var query3 = students.Select(x => new
//{
//    Id = x.Id,
//    fullname = $"{x.Name} {x.Family} "
//});
//foreach (var item in query3)
//{
//    Console.WriteLine($"full name is: {item.fullname} and Id : {item.Id}");
//}
//Console.ReadKey();













//string[] names = { "Mehrshad", "Ahmad", "Mehdi", "Amir", "Sheida", "Rozhin" };

// query synrax

//var result = from name in names
//             where name.EndsWith("d")
//             select name;
//foreach (var name in result)
//{
//    Console.WriteLine(name);
//}
//-----------------------------------------------------------------

// method syntax

//var result = names.Where(name => name.EndsWith("d"));
//foreach (var name in result)
//{
//    Console.WriteLine(name);
//}
//-----------------------------------------------------------------

// mixed syntax

//var result = (from name in names
//              where name.StartsWith("M")
//              select name).Reverse();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
