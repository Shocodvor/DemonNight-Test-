using System.Collections;
using System.Collections.Generic;
using TestTusk;
using UnityEngine;

public class FolowCamera : MonoBehaviour
{

    [SerializeField] private View _view;
    private Vector3 _playerTransform;

   
    void Update()
    {

        if (_view != null)
        {
            _playerTransform = _view.PlayerPosition();
            transform.position = new Vector3(_playerTransform.x, _playerTransform.y, -10f);
        }
        
    }
}
