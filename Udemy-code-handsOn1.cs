using System;
class Udemy-code-handsOn1 {
  static void Main() {
        int result = 20;
        int temp = 10;
        char op = '*';
         
        switch(op) {
        case '+':
            result = result + temp;
            break;
        case '*':
            result = result * temp;
            break;
        case '-':
            result = result - temp;
            break;
        default:
            result = 0;
            break;
        }
        
        Console.Write(result);
  }
}
