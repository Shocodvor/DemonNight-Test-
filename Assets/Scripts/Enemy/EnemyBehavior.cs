
using UnityEngine;

using static UnityEngine.GraphicsBuffer;
namespace TestTusk { 

public class EnemyBehavior : MonoBehaviour
{
        private Rigidbody2D rb;
        private Vector2 _moveDirection;
        private View _view;
        public float speed;
        private Transform _trasform;
        private PlayerHealth _playerHealth;

        public Transform Target;




        private void Awake()
        {

            rb = GetComponent<Rigidbody2D>();
            _view = GameObject.Find("Player").GetComponent<View>();
            _trasform =GetComponent<Transform>();
            _playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
            Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }



    


        private void Update()
        {
           
            var playerPosition = _view.PlayerPosition();

           
           
                Vector3 PlayerPosition = Target.position - transform.position;
                rb.velocity = PlayerPosition * speed * Time.deltaTime;

            

        }

        public void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.CompareTag("Player"))
            {
              

                if (Immortal._immortal == false)
                
                _playerHealth.ApllyDamage(50f);
            }

        }

           

 

        }
    }

