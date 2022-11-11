using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 

      //store three rovers in an array
      Rover[] rovers ={lunokhod,apollo,sojourner };
      
     

  //Create an array of type Object[]
  Object[] probes = {lunokhod,apollo,sojourner,sputnik };

  //GetType() for object
  //returns the actual type of the object,
  foreach(Object obj in probes)
  {
    Console.WriteLine(obj.GetType());
  }


  // create an array of type IDirectable[] containing all the probes
IDirectable[] direcatables = {lunokhod,apollo,sojourner,sputnik };

     //call the method
      DirectAll(direcatables);		
    }

    //// accepts one argument of type IDirectable[]
    public static void DirectAll(IDirectable[] directables)
     {
      foreach(IDirectable d in directables)
      {
        //call methods
        Console.WriteLine(d.GetInfo());
      
        Console.WriteLine(d.Explore());
        Console.WriteLine(d.Collect());
      }
     }
  }
}
