using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spellsheet : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown spellcastingclass;
    public Dropdown levelofplayer;
    public Dropdown abilitylevel;
    public Text spellcastingability;
    public Text ability;
    public Text dc;
    public Text attack;
    public int PB;
    public int skillmod;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int classes = 0;
        int level = 0;
        int clevel = 0;
        var holder =0;
        string mod;
        skillmod = 0;
        skillmod = abilitylevel.value + 1;
        skillmod = (skillmod - 10) / 2;
        classes = spellcastingclass.value;
        level = levelofplayer.value;
        
        if (classes == 8)
        {
            ability.text = "INT";
            spellcastingability.text = "INT";
        }
        if (classes == 1 || classes == 4 || classes == 6 || classes == 7)
        {
            ability.text = "CHA";
            spellcastingability.text = "CHA";
        }
        if (classes == 2 || classes == 3 || classes == 5)
        {
            ability.text = "WIS";
            spellcastingability.text = "WIS";
        }

        if (level < 4)
        {
            PB = 2;
        }
        else if (level < 7)
        {
            PB = 3;
        }
        else if (level < 11)
        {
            PB = 4;
        }
        else if (level < 15)
        {
            PB = 5;
        }
        else
        {
            PB = 6;
        }
        holder = 8 + PB + skillmod;
        dc.text = holder.ToString();
        holder = PB + skillmod;
        attack.text = holder.ToString();
    }
}
