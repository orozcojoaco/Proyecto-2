using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using SharpDX.XAudio2;
using System.Diagnostics;

namespace Project1.Clases
{
    public class Entidad
    {
        public enum Estado {
        
        IDLE = 0,
        MOVIENDOSE = 1,
        SALTANDO = 2,
        COLISION = 3
        }
        public enum IMG_Direccion
        {
            IDLE = 0,
            IZQUIERDA = 1,
            DERECHA= 2,
            ARRIBA= 3,
            ABAJO= 4
        }
        protected private float _velocidad_X= 0;
        protected private float _velocidad_Y = 0;
        protected private Vector2 _posicion;
        protected private int _pantalla_alto;
        protected private int _pantalla_largo;
        protected private List<Texture2D> ListaTexturas = new List<Texture2D>();
        protected private SpriteBatch SpriteBatch;
        protected private Texture2D img_Colision;

        public int X {  get; set; }
        public int Y { get; set; }
        public int Largo { get; set; }
        public int Alto { get; set; }
        public Texture2D Imagen { get; set; }
        public Estado EstadoEntidad { get; set; }
        public Color ColorEntidad { get; set; }

        public Entidad()
        {
        }

        public Entidad (int pantalla_alto, int pantalla_largo, ContentManager cm, SpriteBatch sb, Color color)
        {
            this.EstadoEntidad = Estado.IDLE;
            this.SpriteBatch = sb;
            this._pantalla_alto = pantalla_alto;
            this._pantalla_largo = pantalla_largo;
            this.ColorEntidad = color;
        }
        public virtual void Dibujar()
        {
            this.SpriteBatch.Draw(this.Imagen, this._posicion, this.ColorEntidad);
        }
        public virtual void Mover(float velecidad_x, float velocidad_y)
        {
            if ((this._posicion.X +velecidad_x) >= 0 && (this._posicion.X + this.Largo + velecidad_x)<= this._pantalla_largo) 
            {
                this._posicion.X += velecidad_x;
            }
            this._posicion.Y += velocidad_y;
            this.Imagen = this.ListaTexturas[0];
        }
        public virtual void Parar()
        { }
        

    }
}
