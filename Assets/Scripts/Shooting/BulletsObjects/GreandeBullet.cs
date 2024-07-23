
using UnityEngine;



namespace TestTusk

{

    public class GrenadeBullet : MonoBehaviour,IBullet

    {
        public float launchSpeed { get; set; }
        public float reloadtime { get; set; }
        public Vector2 _transform { get; set; }
        public Rigidbody2D rb { get; set; }

        void Start()
        {

            //   Launch();
            Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = new Vector3(diference.x, diference.y,0);

          

        }

        public void Launch()
        {
            _transform = new Vector2(10, 3);
            launchSpeed = 0.3f;
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(_transform.x, _transform.y) * launchSpeed;


        }
    }


}
