using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Models
{
    public class ExplosionEffect : BaseEntity
    {
        private float _lifeTime {  get; set; }
        public float duration { get; set; } = 0.5f;
        public ExplosionEffect( float x , float y , float width , float height):base(x,y,width, height)
        { 

        }

        public void UpdateState(float deltatime)
        {
            _lifeTime += deltatime;

            if( _lifeTime >= duration )
            {
                IsActive = false;
            }
        }
    }
}
