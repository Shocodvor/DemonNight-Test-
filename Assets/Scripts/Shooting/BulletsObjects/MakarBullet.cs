using Unity.Burst.Intrinsics;
using UnityEngine;

namespace TestTusk
{

    public class MakarBullet : MonoBehaviour, IBullet
    {
        public float launchSpeed { get; set; }
        public float reloadtime { get; set; }
        public Vector2 _transform { get; set; }
        public Rigidbody2D rb { get; set; }
        public Transform Aim;

        void Start()
        {

            Launch();

        }

        public void Launch()
        {
          
            launchSpeed = 0.01f;
            rb = GetComponent<Rigidbody2D>();


          
            Aim = GameObject.FindGameObjectWithTag("Bull").transform;


            
            rb.velocity += new Vector2(Aim.position.x, Aim.position.y)* launchSpeed;


        }
    }
}