# C# Console Game Engine

## Definition

Simple game engine for console games

## Getting Started

1. Create Game instance and set the FPS.
```csharp
Game game = new Game();
game.FPS = 15;
```
2. Create Class for your game object.
```csharp
public class Snake : GameObject
{
    public Vector2D Direction = new Vector2D(1, 0);
    
    public Snake(int x, int y, char icon, ConsoleColor color, string name):base(x, y, icon, color)
    {
        Name = name;
    }
    
    public override void Update()
    {
        Pos += Direction;
        if (Pos.X >= Console.WindowWidth)
        {
            Pos.X = 0;
        }
        if (Pos.X < 0)
        {
            Pos.X = Console.WindowWidth - 1;
        }
        if (Pos.Y >= Console.WindowHeight)
        {
            Pos.Y = 0;
        }
        if (Pos.Y < 0)
        {
            Pos.Y = Console.WindowHeight - 1;
        }
    }
}
```
3. Create your game object instance and add to Game.gameObjects collection.
```csharp
Game game = new Game();
game.FPS = 15;

Snake snake = new Snake(0, 0, '@', ConsoleColor.Red, "Player");
snake.Direction = new Vector2D(1, 0); //Right direction

game.Add(snake);
```
4. Start the game.
```csharp
game.Start();
```
