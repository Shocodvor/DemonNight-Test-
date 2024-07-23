using UnityEngine;



namespace TestTusk
{

    public class PlayerData
    {

        private AimMoving _joystick;

        public Vector2 Direction;

        protected float speed;




        public void Move(Vector2 _direction ) {

            Direction = _direction;
   

        }


        public void Stop()
        {

            Direction = Vector2.zero;



        }


    }







}


