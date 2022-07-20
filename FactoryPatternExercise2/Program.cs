using FactoryPatternExercise2;

Console.WriteLine("What database they want to use: a List, SQL, or Mongo");
var input = Console.ReadLine();
var x = DataAccessFactory.GetDataAccessType(input);
x.LoadData();
x.SaveData();