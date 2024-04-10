namespace libs;

public static class InputHandler
{
    public static void HandleInput(ConsoleKeyInfo keyInfo)
    {

        GameObject focusedObject = GameEngine.GetFocusedObject();

        if (focusedObject != null)
        {
            // Handle keyboard input to move the player
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    focusedObject.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    focusedObject.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    focusedObject.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    focusedObject.Move(1, 0);
                    break;
                case ConsoleKey.Spacebar:
                    GameEngine.ChangeFocusedObject();
                    break;
                default:
                    break;
            }
        }

    }

}