using Homework3.Domain;
using Homework3.Domain.Helpers;
using Homework3.Domain.Models;


Rectangle firstRectangle = new Rectangle(5, 3);
Rectangle secondRectangle = new Rectangle(2, 8);

Circle firstCircle = new Circle(8);
Circle secondCircle = new Circle(4);

GenericDb<Shape> database = new GenericDb<Shape>();

List<Shape> shapeList = new List<Shape>(); 
shapeList.Add(firstRectangle);
shapeList.Add(secondRectangle);
shapeList.Add(firstCircle);
shapeList.Add(secondCircle);

foreach (Shape shape in shapeList)
{
    database.PrintGetPerimiter(shape);
    database.PrintGetArea(shape);
    Helper<Shape>.CheckType(shape);
}

