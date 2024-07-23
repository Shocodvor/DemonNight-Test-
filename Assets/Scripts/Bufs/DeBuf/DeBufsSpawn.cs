using System.Collections;
using System.Collections.Generic;
using TestTusk;
using UnityEngine;
using UnityEngine.UIElements;


namespace TestTusk { 
public class DeBufsSpawn: MonoBehaviour
{

        [SerializeField] private Transform Grid;
      

        void Start()
    {
          
            
            DeBuf deBuf = new DeBuf();
          


            for (int i = 0; i < 3; i++)
        {
                SpawnSlowSpeed(deBuf._slowSpeedBuf);

              


            }

            for (int j = 0; j < 2; j++)
            {

                SpawnDeadDeBuf(deBuf._deadBuf);


            }



        }


        public void SpawnSlowSpeed(GameObject _debuf)
        {

            var SpaceBetwenSpawn = GameboardFactory.cellCizeX;

            Instantiate(_debuf, new Vector2(Random.Range(0, 50) 
                + GameboardFactory.cellCizeX*3, Random.Range(110, 10) 
                + GameboardFactory.cellCizeY*3), Quaternion.identity,Grid);
          

        }

        public void SpawnDeadDeBuf(GameObject _debuf)
        {
            Instantiate(_debuf, new Vector2(Random.Range(0, 50) + GameboardFactory.cellCizeX * 3, Random.Range(110, 10) + GameboardFactory.cellCizeY * 3), Quaternion.identity,Grid);

        }




    }


}
