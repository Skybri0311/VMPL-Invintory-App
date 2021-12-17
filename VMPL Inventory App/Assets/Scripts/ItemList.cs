using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public ItemInputControler itemInputControler;

    private void Awake()
    {
        itemInputControler = FindObjectOfType<ItemInputControler>();
    }
    private void Start()
    {

    }
    public void AddItems()
    {
       var items = new List<Item>();

        items.Add(new Item());
        Debug.Log("Added Item");
    }

    
}
