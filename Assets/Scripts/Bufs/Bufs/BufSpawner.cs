using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace TestTusk
{

    public class BufSpawner : MonoBehaviour
    {
        private float random;

        void Start()
        {

          
            random = (Random.Range(3, 8));

            StartCoroutine(TemplarBonus());

            StartCoroutine(WeaponrBonus());


        }


        IEnumerator TemplarBonus()

        {

            yield return new WaitForSeconds(27.0f);

            var random = (Random.Range(1, 2));
            Bufs bufs = new Bufs();

            if (random == 1)

            {
                ImmortalSpawn(bufs._immortalBuff);

            }

            if (random == 2)

            {
                MultiSpeed(bufs._multispeed);

            }

            StartCoroutine(TemplarBonus());

        }

        IEnumerator WeaponrBonus()

        {

            yield return new WaitForSeconds(10.0f);

            Bufs bufs = new Bufs();

            WeaponBonus(bufs.weaponbonus);

            StartCoroutine(WeaponrBonus());
        }

            public void ImmortalSpawn(GameObject Imoortalbuf)
            {


                Instantiate(Imoortalbuf, new Vector2(transform.position.x + random, transform.position.y), Quaternion.identity);


            }

        


        public void MultiSpeed(GameObject MultySpeed)
        {


            Instantiate(MultySpeed, new Vector2(transform.position.x + random, transform.position.y), Quaternion.identity);


        }

        public void WeaponBonus(GameObject weapon)
        {


            Instantiate(weapon, new Vector2(transform.position.x + random, transform.position.y), Quaternion.identity);


        }





    }

}
