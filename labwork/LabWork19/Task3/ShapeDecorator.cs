abstract class ShapeDecorator : IShape
{
    protected IShape _decoratedShape;

    public ShapeDecorator(IShape decoratedShape) 
        => _decoratedShape = decoratedShape;

    public virtual void Draw() 
        => _decoratedShape.Draw();
}

