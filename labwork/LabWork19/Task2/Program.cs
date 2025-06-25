ShapeFactory shapeFactory = new();

IShape shape = shapeFactory.GetShape("CIRCLE");
shape.Draw();

shape = shapeFactory.GetShape("RECTANGLE");
shape.Draw();

shape = shapeFactory.GetShape("SQUARE");
shape.Draw();

shape = shapeFactory.GetShape("TRIANGLE");
shape.Draw();