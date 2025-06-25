IShape circle = new Circle();
IShape redCircle = new RedShapeDecorator(new Circle());
IShape greenRectangle = new GreenShapeDecorator(new Rectangle());

Console.WriteLine("Круг с обычной границей");
circle.Draw();

Console.WriteLine("\nКруг с красной границей");
redCircle.Draw();

Console.WriteLine("\nПрямоугольник с зелёной границей");
greenRectangle.Draw();

Console.WriteLine("\nКруг с зелёной границей");
circle = new GreenShapeDecorator(new Circle());
circle.Draw();
