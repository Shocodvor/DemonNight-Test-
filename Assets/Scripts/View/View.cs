
using UnityEngine;
using UnityEngine.EventSystems;

namespace TestTusk
{


    public class View:MonoBehaviour
    {

       
        private Vector2 _moveDirection;
        private PlayerData _playerData;
        public Transform _playerTransform;
        private Rigidbody2D rb;

        public float speed;




        private void Awake()
        {
        

            rb = GetComponent<Rigidbody2D>();

            PlayerPosition();


            speed = 1f;

        }

        public Vector3 PlayerPosition ()


        {
           var _position = _playerTransform.transform.localPosition;
          
            return _position;
        }





         public void Initatlise(PlayerData _model)
         {

           _playerData = _model;



          }


        public void FixedUpdate()
        {
            float MoveDistanseX = GameboardFactory.cellCizeX * 4;
            float MoveDistanseY = GameboardFactory.cellCizeY * 4;

            _moveDirection = new Vector2 (_playerData.Direction.x, _playerData.Direction.y);

            rb.velocity = new Vector2(_moveDirection.x * MoveDistanseX*speed, _moveDirection.y * MoveDistanseY*speed);

        }




    }


}
