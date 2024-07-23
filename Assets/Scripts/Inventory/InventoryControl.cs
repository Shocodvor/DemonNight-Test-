using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


namespace TestTusk
{
    public class InventoryConntrol : MonoBehaviour
    {

        [SerializeField] private List<Item> ItemsInventory = new List<Item>();

        [SerializeField] private Transform _ItemContent;
        [SerializeField] private Item _alreadyInCollectionItem;
    

        private void Add(Item _item, GameObject ItemObject)
        {

          
            if (_alreadyInCollectionItem != _item)
            {
                ItemsInventory.Insert(0, _item);
                Instantiate(ItemObject, _ItemContent);
               

            }

        }

        public void DeleteItem (Item _item)


        {

            foreach (var item in ItemsInventory)
            {

                if (_item == item)


                    ItemsInventory.Remove(item);

            }





        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Item"))
            {

                var It = col.GetComponent<ItemPickedUp>().item;
                It._bulletsCount++;

                var prefab = col.GetComponent<ItemPickedUp>()._prefabButton;

                _alreadyInCollectionItem = null;
                ListItems(It, prefab);

            }
        }

        private void ListItems(Item _item,GameObject ItemObject)
        {
       
            foreach (var item in ItemsInventory)
            {
              
                if (_item == item)


                    _alreadyInCollectionItem = _item;

            }

         
            Add(_item, ItemObject);


        }
        }
    }
