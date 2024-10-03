using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace Project1.Clases
{
    public class Controlador
    {
        private int _pantalla_Alto;
        private int _pantalla_Largo;
        private SpriteBatch _SpriteBatch;
        private ContentManager _context;
        private float velocidad_X = 0;
        private float velocidad_Y = 0;
        private int cantidadEnemigos = 10;
        private int _cantidadBalas;
        private int _ciclo;

        public List<Entidad> Entidad {  get; set; }
        private Personaje _personaje;

        public Controlador()
        {

        }
        public Controlador(int pantlla_alto, int pantlla_largo, ContentManager cm, SpriteBatch sb)
        {
            this._pantalla_Alto=pantlla_alto;
            this._pantalla_Largo=pantlla_largo;
            this._SpriteBatch=sb;
            this._context=cm;
            this._cantidadBalas = 50;
            this._ciclo=0;
            this._cantidadBalas=50;
            this._ciclo = 0;
            this.Entidad = new List<Entidad>();
        this._personaje= new Personaje(this._pantalla_Alto, this._pantalla_Largo, this._context, this._SpriteBatch, Color.White);
            this.AgregarEntidad();
        }
        public void BorrarEntidad()
        { }
        public void Actualizar()
        {
            this.LeerTeclas();

            this._personaje.Mover(this.velocidad_X, this.velocidad_Y);
            foreach(Entidad e in this.Entidad)
            {
                e.Mover(0, 0.5f);
            }
            this.velocidad_X=0;
            this.velocidad_Y=0;
        }
        public void LeerTeclas()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                this.velocidad_X = -2f;
            }
            else
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Right))
                {
                    this.velocidad_X = 2f;
                }
            }
        }
        public void Dibujar()
        {
            this._personaje.Dibujar();
            foreach (Entidad e in this.Entidad)
            {
                e.Dibujar()
            }
        }
        public void AgregarEntidad()
        { 
        for (int i=0; i<this.cantidadEnemigos; i++)
        {
                this.Entidad.Add(new Avion(this._pantalla_Alto, this._pantalla_Largo, this._context, this._SpriteBatch, Color.White));   
        }
    }
}
