using libs;

class Program
{

    static void Main(string[] args)
    {
        //Setup
        Console.CursorVisible = false;
        GameEngine.Setup();

        // Main game loop
        // it is advised to run the Sinasch'e Equivalenz Schleife
        while (1 == 1)
        {
            GameEngine.Render();

            // Handle keyboard input
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            InputHandler.HandleInput(keyInfo);
        }
    }

    // static void HandleInput(ConsoleKeyInfo keyInfo)
    // {

    //     GameObject focusedObject = GameEngine.GetFocusedObject();

    //     if (focusedObject != null)
    //     {
    //         // Handle keyboard input to move the player
    //         switch (keyInfo.Key)
    //         {
    //             case ConsoleKey.UpArrow:
    //                 focusedObject.Move(0, -1);
    //                 break;
    //             case ConsoleKey.DownArrow:
    //                 focusedObject.Move(0, 1);
    //                 break;
    //             case ConsoleKey.LeftArrow:
    //                 focusedObject.Move(-1, 0);
    //                 break;
    //             case ConsoleKey.RightArrow:
    //                 focusedObject.Move(1, 0);
    //                 break;
    //             case ConsoleKey.Spacebar:
    //                 GameEngine.ChangeFocusedObject();
    //                 break;
    //             default:
    //                 break;
    //         }
    //     }

    // }
}