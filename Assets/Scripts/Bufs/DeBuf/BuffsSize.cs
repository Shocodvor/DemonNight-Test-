using TestTusk;
using UnityEngine;

public class BuffsSize : MonoBehaviour
{

    [SerializeField] private RectTransform _bufSize;

    [SerializeField] private int _size;

 void Start()
    {


        _bufSize = GetComponent<RectTransform>();
        _bufSize.localScale = new Vector3(GameboardFactory.cellCizeX* _size, GameboardFactory.cellCizeY* _size, 1);

    }


    void Update()
    {
        
    }
}
