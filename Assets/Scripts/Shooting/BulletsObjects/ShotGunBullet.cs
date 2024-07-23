using UnityEngine;

namespace TestTusk
{

    public class ShotGunBullet : MonoBehaviour, IBullet
    {
        public float launchSpeed { get; set; }
        public float reloadtime { get; set; }
        public Vector2 _transform { get; set; }
        public Rigidbody2D rb { get; set; }
        private Transform Aim;
        private int random;

        void Start()
        {
            random = Random.Range(1,5);
            Launch();

        }

        public void Launch()
        {
            
            
            rb = GetComponent<Rigidbody2D>();

            Aim = GameObject.FindGameObjectWithTag("Bull").transform;



            rb.velocity += new Vector2(Aim.position.x, Aim.position.y*random);
           


        }
    }
}