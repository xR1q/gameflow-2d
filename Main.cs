using GF2D;
using GF2D.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace TestApp
{
    public class Main : Game
    {
        private readonly Painter painter;

        public Main()
        {
            painter = new();
        }
        protected override void Render(GameTime gameTime)
        {
            GL.ClearColor(Color4.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            painter.ReadyPrimitive();
            painter.DrawRectangle(new(400, 300), new(200, 1), Color4.Red, new(0.5f, 0.5f), (float)gameTime.Total.TotalMilliseconds);
            painter.DrawRectangle(new(400, 300), new(200, 1), Color4.Yellow, new(0.5f, 0.5f), -(float)gameTime.Total.TotalMilliseconds);
            painter.DrawRectangle(new(400, 300), new(200, 1), Color4.Green, new(0.5f, 0.5f), (float)gameTime.Total.TotalMilliseconds + 45);
            painter.DrawRectangle(new(400, 300), new(200, 1), Color4.BlueViolet, new(0.5f, 0.5f), -(float)gameTime.Total.TotalMilliseconds - 45);
        }
    }
}
