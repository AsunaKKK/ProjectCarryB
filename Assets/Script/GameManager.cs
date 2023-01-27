using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject PauseUi;

    public List<item> items = new List<item>();
    public List<int> itemnum = new List<int>();
    public GameObject[] slots;
    public static GameManager instance;


    private void Awake()
    {
        instance = this;
    }
    private void DisplayItem()
    {
        for (int i = 0; i < items.Count; i++)
        {
            slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;
            slots[i].transform.GetChild(2).GetComponent<Text>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(2).GetComponent<Text>().text = "X" + itemnum[i].ToString();
            slots[i].transform.GetChild(3).GetComponent<Text>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(3).GetComponent<Text>().text = "<----  Please Click Use Item Now";
            slots[i].transform.GetChild(1).gameObject.SetActive(true);

        }
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < items.Count)
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;
                slots[i].transform.GetChild(2).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(2).GetComponent<Text>().text = "X" + itemnum[i].ToString();
                slots[i].transform.GetChild(3).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(3).GetComponent<Text>().text = "<----  Please Click Use Item Now";
                slots[i].transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                slots[i].transform.GetChild(2).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(2).GetComponent<Text>().text = null;
                slots[i].transform.GetChild(3).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(3).GetComponent<Text>().text = null;
                slots[i].transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }

    public void AddItem(item itemss)
    {
        if (!items.Contains(itemss))
        {
            items.Add(itemss);
            itemnum.Add(1);
        }
        else
        {
            Debug.Log("You already have this item !!");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == itemss)
                {
                    itemnum[i]++;
                }
            }
        }
        DisplayItem();
    }

    public void RemoveItem(item itmea)
    {
        if (items.Contains(itmea))
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (itmea == items[i])
                {
                    itemnum[i]--;
                    if (itemnum[i] == 0)
                    {
                        items.Remove(itmea);
                        itemnum.Remove(itemnum[i]);
                    }
                }
            }
        }
        else
        {
            Debug.Log("This item is not");
        }
        DisplayItem();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                PauseUi.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                PauseUi.SetActive(false);
            }

        }
    }
}
