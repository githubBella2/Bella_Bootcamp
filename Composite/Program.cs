using Composite;

class Program
{
    static void Main(string[] args)
    {
        #region COMPOSITE
        // Create shapes
        var triangle = new Triangle();
        var circle = new Circle();

        // Create a composite drawing
        var drawing = new Drawing();

        // Add shapes to the drawing
        drawing.Add(triangle);
        drawing.Add(circle);

        // Draw the composite drawing
        drawing.Draw("green");


        // Draw the composite drawing again
        drawing.Draw("blue");

        // Remove a shape from the composite drawing
        drawing.Remove(circle);

        // Draw the composite drawing again
        drawing.Draw("purple");

        // Clear the composite drawing
        drawing.Clear();
        #endregion

        #region BEFORE
        // Create shapes
        var triangle2 = new Triangle();
        var circle2 = new Circle();

        // Draw shapes individually
        triangle2.Draw("red");
        triangle2.Draw("blue");
        circle2.Draw("red");
        circle2.Draw("blue");


        #endregion
    }
}