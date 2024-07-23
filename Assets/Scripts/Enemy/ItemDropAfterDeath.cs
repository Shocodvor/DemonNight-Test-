using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace TestTusk
{

    public class ItemDropAfterDeath : MonoBehaviour
    {
        public Transform enemyTransform;
        Vector3 enemPos;

        public void Start ()


        {
            var _position = enemyTransform.transform.localPosition;
            _position = enemPos;

         
        }


        public GameObject[] RandomItems;

       public void ItemDrop()
        {

            var randomElement = RandomItems[Random.Range(0, RandomItems.Length)];
            Instantiate(randomElement, enemPos, Quaternion.identity);


        }


    }

}