using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public GameObject gameObjectToMove;

    public GameObject inventoryPanel;
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

    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(0).position;
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(1).position;
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(2).position;
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(3).position;
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(4).position;
        }

        if (Input.GetKey(KeyCode.Alpha6))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(5).position;
        }

        if (Input.GetKey(KeyCode.Alpha7))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(6).position;
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(7).position;
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {

            gameObjectToMove.transform.position = inventoryPanel.transform.GetChild(8).position;
        }


    }
}


