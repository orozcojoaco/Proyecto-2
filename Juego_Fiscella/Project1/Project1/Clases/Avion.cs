using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1.Clases
{
    public class Avion : Enemigos
    {
        public Avion(int pantalla_alto, int pantalla_largo, ContentManager cm, SpriteBatch sb, Color color) : base(pantalla_alto, pantalla_largo, cm, sb, color
        {
           
            this.Init(cm, sb);
        }
        
        private void Init(ContentManager cm, SpriteBatch sb)
        {
            this.ListaTexturas.Add(cm.Load<Texture2D>("enemigo1"));

            var random = new Random();

            this._posicion.X = random.Next(100, 500); ;
            this._posicion.Y = -10;

            this.X = (int)this._posicion.X;
            this.Y = (int)this._posicion.Y;

            this.Imagen = this.ListaTexturas[0];
            this.Largo = this.Imagen.Width;
            this.Alto = this.Imagen.Height;

        }
    
        public override void Mover(float velocidad_x, float velocidad_y)
        {
        this._posicion.Y += velocidad_y;
        }
    }
}
