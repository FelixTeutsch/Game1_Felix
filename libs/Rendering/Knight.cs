namespace libs;

public class Knight : GameObject
{
    public Knight() : base()
    {
        this.Type = GameObjectType.Queen;
        this.CharRepresentation = '♘';
    }


    public override void Move(int dx, int dy)
    {
        _prevPosX = _posX;
        _prevPosY = _posY;
        _posX += dx;
        _posY += dy;
    }
}