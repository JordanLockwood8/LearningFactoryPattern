
using FactoryPatternExcersize2;

Console.WriteLine("what database you want to use List, SQL, or Mogo");
var answer =  Console.ReadLine().ToLower();

var database = DataAccessFactory.GetDataAccessType(answer);
database.SaveData();
database.LoadData();