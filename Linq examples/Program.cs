//reverse

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var query = numbers.Reverse();
foreach (var item in query)
{
    Console.WriteLine(item);
}

List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
numbers2.Reverse();
foreach (var item in numbers2)
{
    Console.WriteLine(item);
}




// ordering 

//List<Student> students = new List<Student>()
//{
//    new Student{Id = 101, Name = "Mehrshad", Family = "Khaki", Age = 21},
//    new Student{Id = 103, Name = "Ahmad", Family = "Heidari", Age = 22},
//    new Student{Id = 100, Name = "abas", Family = "Rashedi", Age = 22},
//    new Student{Id = 104, Name = "Mehdi", Family = "Ahmadvand", Age = 21},
//    new Student{Id = 102, Name = "Amir", Family = "Kochaki", Age = 20}
//};

//var query = students.OrderBy(x => x.Id);
//foreach (var item in query)
//{
//    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
//}

//var query2 = students.OrderByDescending(x => x.Name).ThenBy(x => x.Id);
//foreach (var item in query2)
//{
//    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
//}
//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Family { get; set; }
//    public int Age { get; set; }
//}


// filterfing ( Where , OfType)


//List<object> source = new List<object>
//{
//    new Person(){Id = 101 , Name = "Mohammd"},
//    new Person(){Id = 102 , Name = "Ali"},
//    new User(){Id = 201, Family = "Abari"},
//    new User(){Id = 202, Family = "Khakifirooz"}
//};

//var query = source.OfType<Person>();
//foreach (var item in query)
//{
//    Console.WriteLine($"Id is: {item.Id} and Name is: {item.Name}");
//}


//public class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}


//public class User
//{
//    public int Id { get; set; }
//    public string Family { get; set; }
//}

//string[] names = { "mohammad", " ali", "reza", "nima", "akram", "zahra" };

//var query = names.Where(x => CheckLenght(x));
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}


//static bool CheckLenght(string str)
//{
//    if (str.Length > 5)   // mohammad is the output
//        return true;
//    return false;
//}

//Console.ReadKey();





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
