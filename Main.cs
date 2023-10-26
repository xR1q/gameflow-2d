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
        }
    }
}
