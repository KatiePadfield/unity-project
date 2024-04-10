using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public List<Image> images = new List<Image>();

    private Dictionary<int, string> items = new Dictionary<int, string>
{
    { 0, null },
    { 1, null },
    { 2, null },
    { 3, null },
    { 4, null },
    { 5, null },
    { 6, null },
    { 7, null },
    { 8, null },
    { 9, null }
};

    public void AddItem(GameObject gameObject)
    {
        bool added = false;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                items[i] = gameObject.GetComponent<Item>().name;
                images[i].sprite = gameObject.GetComponent<Item>().image;

                Destroy(gameObject);
                GameObject.Find("PlayerCapsule").GetComponent<PlayerCollisions>().PressF.SetActive(false);
                added = true;
                break;
            }
        }

        if (!added)
        {
            Debug.LogWarning("Inventory is full. Cannot add item.");
        }
    }
}
