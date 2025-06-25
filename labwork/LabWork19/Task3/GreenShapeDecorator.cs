class GreenShapeDecorator : ShapeDecorator
{
    public GreenShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

    public override void Draw()
    {
        _decoratedShape.Draw();
        SetGreenBorder(_decoratedShape);
    }

    private void SetGreenBorder(IShape decoratedShape)
        => Console.WriteLine("Цвет границы: Зелёный");
}
