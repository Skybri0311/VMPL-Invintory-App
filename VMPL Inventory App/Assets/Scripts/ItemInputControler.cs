using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInputControler : MonoBehaviour
{
    public string _itemID;
    public string _itemName;
    public string _width;
    public string _height;
    public string _depth;
    public string _color;
    public string _price;
    public Item item;
    public List<Item> items;
    public bool isPainting;
    public bool isOrnament;
    public bool isDoubleSided;
    public bool isCoster;
    public bool isEaselPainting;

    public ItemList itemList;

    public ItemInputControler(string itemID, string itemName, string width, string height, string depth, string color, string price)
    {
        _itemID = itemID;
    }


    private void Awake()
    {
        itemList = FindObjectOfType<ItemList>();
        items = new List<Item>();
        item = new Item();
    }

    public void ReadSKUField(string itemSKU)
    {
        item.Id = itemSKU;
        Debug.Log(item.Id+"Logged");
    }

    public void ReadItemName(string inputItemName)
    {
        item.Name = inputItemName;
        Debug.Log(item.Name+"Logged");
    }

    public void ReadItemWidth(string inputWidth)
    {
        item.Width = inputWidth;
        Debug.Log(item.Width+"Logged");
    }

    public void ReadItemHeight(string inputHeight)
    {
        item.Height = inputHeight;
        Debug.Log(item.Height+"Logged");
    }

    public void ReadItemDepth(string inputDepth)
    {
        item.Depth = inputDepth;
        Debug.Log(item.Depth+"Logged");
    }
    public void ReadInputWeight(string inputWeight)
    {
        item.Weight = inputWeight;
        Debug.Log(item.Weight+"Logged");
    }

    public void ReadItemColor(string inputColor)
    {
        item.Color = inputColor;
        Debug.Log(item.Color+"Logged");
    }

    public void ReadItemPrice(string inputPrice)
    {
        item.Price = inputPrice;
        Debug.Log(item.Price+"Logged");
    }

    public void AddItemToList()
    {
        itemList.AddItems();
    }
}

