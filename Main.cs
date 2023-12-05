using GF2D;
using GF2D.Core;
using GF2D.Graphics;
using GF2D.Utils.UI;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace TestApp
{
    public class Main : Game
    {
        protected override void Initialize()
        {
        }
        protected override void LoadContent()
        {
        }
        protected override void Update(GameTime gameTime)
        {
        }
        protected override void Render(GameTime gameTime)
        {   
            GL.ClearColor(Color4.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }
    }
}