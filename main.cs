using System;

class Program {
  public static string [] myList;
  public static string name;
  public static int x = 0;
  public static void MyMethod(){
    Console.WriteLine ("Put in a name");
    
    // group.SetValue(value: name, index: x);
   
    
    
    myList = new string[100];
    for (int i = 0; i < 100; i++)
    {
      myList[i] = string.Format("", i);
        
    };
    myList[x] = Console.ReadLine();
    Console.WriteLine(myList[0]);
     x += 1;



    
  }
  public static void Main (string[] args) {
    while (true){
      MyMethod();
    }
    
  }
}