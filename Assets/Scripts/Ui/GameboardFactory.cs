
using System.Collections.Generic;
using TestTusk;
using UnityEngine;


namespace TestTusk
{
    public class GameboardFactory : MonoBehaviour
    {

        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _root;

        public static float cellCizeX;
        public static float cellCizeY;

     

       



        public void Create(GameObject prefab, Vector2Int size, float spacing, Transform root)
        {
           

            for (int x = 0; x < size.x; x++)
            {
                for (int y = 0; y < size.y; y++)
                {
                    Vector3 position = new(x * spacing, y * spacing);

                    GameObject cell = Object.Instantiate(prefab, position + root.position, Quaternion.identity, root);


                       

                    
                    
                }

            }

           
        }



        void Awake()
        {
            Vector2Int _size = new Vector2Int(30, 40);


            Create(_prefab, _size, 3f, _root);

            GetCellSize();

        }


        void GetCellSize()
        {

            var cellTransform = _prefab.GetComponent<Transform>();
            var cellSizeX = cellTransform.localScale.x;
            var cellSizeY = cellTransform.localScale.y;

            cellCizeX = cellSizeX;
            cellCizeY = cellSizeY;

        



        }
    }
}