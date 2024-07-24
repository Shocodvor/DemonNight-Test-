using System.Collections;
using System.Collections.Generic;
using TestTusk;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace TestTusk { 
public class RayH 
{
    public Transform target;
    int Dam;

   public void ShootRay(Transform _target, float _damg,Transform _aim)
    {

        {

            RaycastHit hit;

               // Vector2 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) ;

                Vector3 aim = new Vector3(_aim.position.x*100f,_aim.position.y*100f,0); 

                Ray ray = new Ray(_target.transform.position, _target.transform.position + aim);

                


                Physics.Raycast(ray, out hit);

                Debug.DrawLine(ray.origin, hit.point, Color.red);

                if (hit.collider != null)
            {

                Debug.Log(hit.collider);

                   
                hit.collider.TryGetComponent(out EnemyHealth _damage);

                    _damage.ApllyDamage(_damg);

                    Debug.Log(_damg);




                }

               
            }

    }


}

    }