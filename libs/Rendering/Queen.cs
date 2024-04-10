namespace libs;

public class Queen : GameObject
{
    public Queen() : base()
    {
        this.Type = GameObjectType.Queen;
        this.CharRepresentation = '♕';
    }


    public override void Move(int dx, int dy)
    {
        _prevPosX = _posX;
        _prevPosY = _posY;
        _posX += dx;
        _posY += dy;
    }
}