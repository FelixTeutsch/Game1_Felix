namespace libs;

public class King : GameObject
{

    public King() : base()
    {
        this.Type = GameObjectType.King;
        this.CharRepresentation = '♔';
        this.Color = ConsoleColor.DarkGreen;
    }


    public override void Move(int dx, int dy)
    {
        _prevPosX = _posX;
        _prevPosY = _posY;
        _posX += dx;
        _posY += dy;
    }
}