//I have replciated the code from the following yt-tutorial for excersise purposes: https://www.youtube.com/watch?v=kxxsFmWU8YU

namespace ReturnKeywordExcercise;

class Program
  {
  static void Main( string[] args )
    {
    int cubedNumber = Cube( 5 );
    //responsible for the visualization of the result of the calculation
    Console.Write( cubedNumber );
    Console.ReadLine();
    }
  static int Cube( int num )
    {
    //the calculation-result gets intialized
    int result = num * num * num;
    //after the calculation is finished the result gets returned bakc tot he caller-method of Cube() which is Main()
    return result;
    }
  }