








string[] names = { "Mehrshad", "Ahmad", "Mehdi", "Amir", "Sheida", "Rozhin" };

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
