using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrpt_spawnCard : MonoBehaviour
{

    public GameObject[] m_cards;
    [Space(5)]
    public TMP_Text m_nameText;

    //Private
    int currentIndex = 0;
    GameObject currentObject;
    scrpt_nameDescHolder _nameDesc;
    GameObject _spawner;


    void Start()
    {
        _spawner = this.gameObject;
        currentObject = Instantiate(m_cards[currentIndex]);
        currentObject.transform.SetParent(_spawner.transform);
    }

    public void Update()
    {
        currentObject.transform.rotation = _spawner.transform.rotation;
    }

    public void Previous()
    {
        Destroy(currentObject);
        currentIndex--;
        if (currentIndex > m_cards.Length || currentIndex < 0)
        {
            currentIndex = m_cards.Length - 1;
        }

        currentObject = Instantiate(m_cards[currentIndex]);
        _nameDesc = currentObject.GetComponent<scrpt_nameDescHolder>();
        m_nameText.text = _nameDesc.m_name;
        currentObject.transform.SetParent(_spawner.transform);
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
        _nameDesc = currentObject.GetComponent<scrpt_nameDescHolder>();
        m_nameText.text = _nameDesc.m_name;
        currentObject.transform.SetParent(_spawner.transform);
    }
}
