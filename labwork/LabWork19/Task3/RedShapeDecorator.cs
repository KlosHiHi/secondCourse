class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

    public override void Draw()
    {
        _decoratedShape.Draw();
        SetRedBorder(_decoratedShape);
    }

    private void SetRedBorder(IShape decoratedShape) 
        => Console.WriteLine("Цвет границы: Красный");
}