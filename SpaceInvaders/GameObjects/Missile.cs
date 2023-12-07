﻿using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Space_invaders.Properties;

namespace SpaceInvaders.GameObjects
{

    public class Missile : SimpleObject
    {
        private double vitesse;
        public Missile(Vecteur2D position, int vies)
           : base(position, Resources.projectile, vies)
        {
            this.vitesse = 10.0;
        }

        public override void Update(Keys key, Size gameSize)
        {
            Position.y = Position.y - vitesse;
            if(Position.y < 0)
            { 
                Vies = 0;
            }
        }
        // Rectangle englobant pour débugger
        public override void Draw(Graphics graphics, int largeur, int hauteur)
        {
            base.Draw(graphics, largeur, hauteur);

            // Dessiner le rectangle englobant
            /*
            Rectangle missileRect = new Rectangle((int)Position.x, (int)Position.y, gameInstance.largeurImageMissile, gameInstance.hauteurImageMissile);
            using (Pen pen = new Pen(Color.AntiqueWhite, 2))  // Couleur jaune pour le rectangle, épaisseur de 2
            {
                graphics.DrawRectangle(pen, missileRect);
            }
            */
        }

    }
    
}
