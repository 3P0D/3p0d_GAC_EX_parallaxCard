using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt_spawnCard : MonoBehaviour
{

    public GameObject[] m_cards;
    public int currentIndex = 0;
    public GameObject currentObject;
    public GameObject spawner;

    void Start()
    {
        //Instantiate initial object
        currentObject = Instantiate(m_cards[currentIndex]);
        currentObject.transform.SetParent(spawner.transform);
    }

    public void Update()
    {
        currentObject.transform.rotation = spawner.transform.rotation;
    }

    public void Previous()
    {
        Destroy(currentObject);
        currentIndex--;
        if (currentIndex > m_cards.Length || currentIndex < 0)
        {
            currentIndex = 0;
        }

        currentObject = Instantiate(m_cards[currentIndex]);
        currentObject.transform.SetParent(spawner.transform);
    }

    public void Next()
    {
        Destroy(currentObject);
        currentIndex++;
        if (currentIndex > (m_cards.Length - 1) || currentIndex < 0)
        {
            currentIndex = 0;
        }
        currentObject = Instantiate(m_cards[currentIndex]);
        currentObject.transform.SetParent(spawner.transform);
    }
}
