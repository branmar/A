//Ball Testing

using A3_03DesigningAndBuildingClasses.BallColors;

Ball one = new Ball(new Color(23, 66, 12));
Ball two = new Ball(new Color(77, 233, 94), 1000);
Ball three = new Ball(new Color(244, 170, 55, 50));

for (int i = 0; i < 5; i++)
{
    one.Throw();
}

two.Throw();

Console.WriteLine("Before pop:");
Console.WriteLine("Ball 1 thrown {0} times", one.GetTimesThrown());
Console.WriteLine("Ball 2 thrown {0} times", two.GetTimesThrown());
Console.WriteLine("Ball 3 thrown {0} times", three.GetTimesThrown());

one.Pop();
two.Pop();

for (int i = 0; i < 3; i++)
{
    one.Throw();
    two.Throw();
    three.Throw();
}

Console.WriteLine("After pop, throw 3 times:");
Console.WriteLine("Ball 1 thrown {0} times", one.GetTimesThrown());
Console.WriteLine("Ball 2 thrown {0} times", two.GetTimesThrown());
Console.WriteLine("Ball 3 thrown {0} times", three.GetTimesThrown());