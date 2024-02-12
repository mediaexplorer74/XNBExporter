// XNBExport.ExportGame

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;

#nullable disable
namespace XNBExport
{
  public class ExportGame : Game
  {
    private GraphicsDeviceManager gdm;
    private string[] name;
    private Texture2D[] texture;

    public ExportGame(string name)
    {
      if (name != "")
      {
        this.name = new string[1]{ name };
      }
      else
      {
        this.name = Directory.GetFiles(".", "*.xnb");
        for (int index = 0; index < this.name.Length; ++index)
          this.name[index] = this.name[index].Split(new string[1]
          {
            ".xnb"
          }, StringSplitOptions.RemoveEmptyEntries)[0];
      }
      this.gdm = new GraphicsDeviceManager((Game) this);
    }

    protected override void Draw(GameTime gameTime)
    {
        for (int index = 0; index < this.texture.Length; ++index)
        {
            using (Stream stream = (Stream)File.Open(this.name[index] + ".png", FileMode.Create))
            {
                this.texture[index].SaveAsPng(stream, this.texture[index].Width, this.texture[index].Height);
            }
        }

        base.Draw(gameTime);
        this.Exit();
    }

    protected override void LoadContent()
    {
      this.texture = new Texture2D[this.name.Length];

      for (int index = 0; index < this.texture.Length; ++index)
      {
        this.texture[index] = this.Content.Load<Texture2D>(this.name[index]);
      }

      base.LoadContent();
    }
  }
}
