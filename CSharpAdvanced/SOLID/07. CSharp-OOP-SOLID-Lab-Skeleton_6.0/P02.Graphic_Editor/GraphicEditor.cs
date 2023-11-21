using System;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        IShape shape;
        public void DrawShape(IShape shape)
        {
            this.shape = shape;
        }
    }
}
