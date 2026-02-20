using System;
using System.Collections.Generic;
  public class ProgramCustomerOrder1 {
      static void Main() {
          var cust = new Customer(1);
          cust.Orders.Add(new Order());
          cust.Orders.Add(new Order());
          // count of orders   
          Console.WriteLine(cust.Orders.Count);
    }
}
