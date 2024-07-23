
using UnityEngine;

namespace TestTusk
{

    public class AimMoving : MonoBehaviour
    {

        private Vector2 Direction;
        void FixedUpdate()
        {

         

            Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = diference; 

        }




    }

}

