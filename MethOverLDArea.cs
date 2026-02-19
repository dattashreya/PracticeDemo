using System;
class MethOverLDArea {
  static void Main() 
  {
      var obj = new Area(10,20);
      Console.WriteLine("len {0} and br {1} is",
      obj.len, obj.br);
      
      obj.AreaCalculation(11,10);
      Console.WriteLine("New area of {0}",
      obj.ar);
  }
}