using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class wizardspell : MonoBehaviour, IPointerEnterHandler
{
    public setterinfo si;
    public Dropdown spells;
    public Spells check;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (si.getrace() == "Elf")
        {         
          Debug.Log( check.spells(spells.options[spells.value].text.ToString()));            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
