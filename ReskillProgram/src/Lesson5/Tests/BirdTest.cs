using ReskillProgram.src.Lesson5.Flys;

namespace ReskillProgram.src.Lesson5.Tests
{
     
    static void Main(string[] args)
    {
        Bird bird = new Bird();
        bird.CurrentPosition = 7;
        bird.FlyTo(1000);
        Console.WriteLine(bird.ToString());
    }
    
}
