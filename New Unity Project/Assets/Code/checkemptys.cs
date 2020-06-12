using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class checkemptys : MonoBehaviour
{
    // Start is called before the first frame update
    public Text name;
    public Dropdown race;
    public Dropdown pclass;
    public Dropdown aligement;
    public Dropdown BG;
    public Text str;
    public Text dex;
    public Text con;
    public Text intell;
    public Text wis;
    public Text cha;
    public GameObject enter;
    public setterinfo si;
    public GameObject first;
    public GameObject second;
    public GameObject third;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (string.IsNullOrEmpty(name.text) != true && string.IsNullOrEmpty(str.text)!= true && string.IsNullOrEmpty(dex.text) != true && string.IsNullOrEmpty(con.text) != true &&
            string.IsNullOrEmpty(intell.text) != true && string.IsNullOrEmpty(wis.text) != true && string.IsNullOrEmpty(cha.text) != true && 
            race.value>0 && pclass.value>0 && aligement.value>0 && BG.value>0)
        {
            enter.active = true;
        }else
        {
            enter.active = false;

        }
    }

    public void setterin()
    {        
        si.setter(int.Parse(str.text.ToString()), int.Parse(dex.text.ToString()), int.Parse(con.text.ToString()), int.Parse(intell.text.ToString()), int.Parse(wis.text.ToString()),
            int.Parse(cha.text.ToString()), name.text.ToString(),pclass.options[pclass.value].text.ToString(),aligement.options[aligement.value].text.ToString(),
            BG.options[BG.value].text.ToString(),race.options[race.value].text.ToString());

        first.active = false;
        second.active = true;
    }
    public void tobackground()
    {
        second.active = false;
        third.active = true;
    }
}
