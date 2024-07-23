using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using TestTusk;

public class ItemValueView : MonoBehaviour
{

    public Item _item;
    public TextMeshProUGUI AmmoAmount;

    [SerializeField] private Button _shootbutton;


    private void OnEnable()
    {

        _shootbutton.onClick.AddListener(DeleteItemFromList);
    }

    private void OnDisable()
    {

        _shootbutton.onClick.RemoveListener(DeleteItemFromList);
    }




    void Update()
    {
       
        AmmoAmount.text = _item._bulletsCount.ToString();
       
    }


    private void DeleteItemFromList()
    {
        var inventory = GameObject.Find("Player").GetComponent<InventoryConntrol>();
        Destroy(gameObject, 1);
        inventory.DeleteItem(_item);


       

    }





}
