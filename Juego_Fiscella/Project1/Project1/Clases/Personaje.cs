using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Clases
{
    public class Personaje : Entidad
    {
        public Personaje(int pantalla_alto, int pantalla_largo, ContentManager cm, SpriteBatch sb, Color color) : base(pantalla_alto, pantalla_largo, cm, sb, color)
        {

            this._velocidad_X = 0;
            this._velocidad_Y = 0;
            this._posicion = new Vector2(300, 300);
            this._pantalla_alto = pantalla_alto;
            this._pantalla_largo = pantalla_largo;
            this.SpriteBatch = sb;

            this.Init(cm, this.SpriteBatch);
        }

        private void Init (ContentManager cm, SpriteBatch sb)
        {
            this.ListaTexturas.Add(cm.Load<Texture2D>("cars_normal"));
            this.ListaTexturas.Add(cm.Load<Texture2D>("cars_izq"));
            this.ListaTexturas.Add(cm.Load<Texture2D>("cars_der"));
            this._posicion = new Vector2(this._pantalla_largo / 2, this._pantalla_alto - 100);
            this.X=(int)this._posicion.X;
            this.Y=(int)this._posicion.Y;

            this.Imagen = this.ListaTexturas[0];
            this.Largo = this.Imagen.Width;
            this.Alto = this. Imagen.Height;

        }
        public override void Mover(float velecidad_x, float velocidad_y)
        {
            if ((this._posicion.X + velecidad_x) >= 0 && (this._posicion.X + this.Largo + velecidad_x) <= this._pantalla_largo)
            {
                this._posicion.X += velecidad_x;
            }
            this._posicion.Y += velocidad_y;
            int img = 0;

            if (velecidad_x > 0)
            {
                img = 2;
            }
            else
            {
                if (_velocidad_X < 0) { img  = 1; }else{ img = 0;}
                
            }
            this.Imagen = this.ListaTexturas[img];
        }
    }
}
