using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Clases
{
    public class Enemigos : Entidad
    {
        public Enemigos(int pantalla_alto, int pantalla_largo, ContentManager cm, SpriteBatch sb, Color color) : base(pantalla_alto, pantalla_largo, cm, sb, color)
        {

            this._velocidad_X = 0;
            this._velocidad_Y = 0;
            this._posicion = new Vector2(300, 300);
            this._pantalla_alto = pantalla_alto;
            this._pantalla_largo = pantalla_largo;
            this.SpriteBatch = sb;

            this.Init(cm, this.SpriteBatch);
        }

        public abstract override void Mover(float velocidad_x, float velocidad_y)
        {
            
        }
    }
}
