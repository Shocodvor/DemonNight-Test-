
using UnityEngine;

namespace TestTusk
{


    public class InputKeyboardAxis : MonoBehaviour
    {

        public Transform target;
        private Rigidbody2D rb;

        private PlayerData playerData;

        [SerializeField] private View _view;



        private   void Start()
            {
                PlayerData playerData = new PlayerData();
                init(playerData);

            rb = GetComponent<Rigidbody2D>();
        }


            public void init(PlayerData pl)

            {
                this.playerData = pl;
                _view.Initatlise(pl);

            }

            void Update()
        {

            Vector3 relativePos = target.position - transform.position;

            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.forward);

            transform.rotation = rotation;




            Vector2 _moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));


            ///rb.velocity = new Vector2(_moveDirection.x*10f, _moveDirection.y*10f);

            this.playerData.Move(_moveDirection);


        }
    }



}



