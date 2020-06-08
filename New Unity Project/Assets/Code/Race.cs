using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Race : MonoBehaviour
{
    public setterinfo si;
    public Dropdown subrace;
    public Text orace;
    public Text other; // for other option in the race
    public Text other1;
    public Text other2;
    public Text other3;
    public Text other4;
    public Dropdown[] Dother;
    public Button submit;

    // Start is called before the first frame update
    void Start()
    {
        
        switch (si.getrace())
        {
            case "Dwarf":
                {
                    Debug.Log("Dwarf");
                    subrace.options.Add(new Dropdown.OptionData() { text ="Hill" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Mountain" });
                    Dother[0].gameObject.active = true;
                    other.text = "Tool Proficiency";
                    Dother[0].options.Add(new Dropdown.OptionData() { text = "Smith's Tools" });
                    Dother[0].options.Add(new Dropdown.OptionData() { text = "Brewer's Supplies" });
                    Dother[0].options.Add(new Dropdown.OptionData() { text = "Mason's Tools" });
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Dwarvish");
                    break;
                }
            case "Elf":
                {
                    Debug.Log("Elf");
                    Language(Dother[0]);
                    subrace.options.Add(new Dropdown.OptionData() { text = "High" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Wood" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Drow" });
                    WCantrip(Dother[1]);
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Elvish");
                    checkLanguage(Dother[0]);
                    break;
                }
            case "Halfling":
                {
                    Debug.Log("Halfling");
                    subrace.options.Add(new Dropdown.OptionData() { text = "Lightfoot" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Stout" });
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Halfling");
                    break;
                }
            case "Human":
                {
                    Debug.Log("Human");
                    subrace.options.Add(new Dropdown.OptionData() { text = "Standerd" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Variant" });
                    Language(Dother[0]);
                    Dother[0].gameObject.active = true;
                    other.text = "Pick a Language";
                    si.setlanuagelist("Common");
                    Ability(Dother[1]);
                    Ability(Dother[2]); 
                    skills(Dother[3]);                  
                    feat(Dother[4]);
                    checkLanguage(Dother[0]);
                    break;
                }
            case "Dragonborn":
                {
                    Debug.Log("Dragonborn");
                    subrace.options.Add(new Dropdown.OptionData() { text = "Black" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Blue" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Brass" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Bronze" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Copper" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Gold" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Green" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Red" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Silver" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "White" });
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Draconic");
                    break;
                }
            case "Gnome":
                {
                    Debug.Log("Gnome");
                    subrace.options.Add(new Dropdown.OptionData() { text = "Forest" });
                    subrace.options.Add(new Dropdown.OptionData() { text = "Rock" });
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Gnomish");
                    break;
                }
            case "Half-Elf":
                {
                    Debug.Log("Half-elf");
                    orace.text = "Thier are no subraces";
                    subrace.gameObject.active = false;
                    other.text = "pick a Language";
                    Dother[0].gameObject.active = true;
                    Language(Dother[0]);
                    other1.text = "pick a Skill";
                    Dother[1].gameObject.active = true;
                    skills(Dother[1]);
                    other2.text = "pick another Skill";
                    Dother[2].gameObject.active = true;
                    skills(Dother[2]);
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Elvish");
                    Debug.Log("checks");
                    checkLanguage(Dother[0]);
                    break;
                }
            case "Half-Orc":
                {
                    Debug.Log("Half-orc");
                    orace.text = "Thier are no subraces";
                    subrace.gameObject.active = false;
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Orc");
                    break;
                }
            case "Tiefling":
                {
                    Debug.Log("Tiefling");
                    orace.text = "Thier are no subraces";
                    subrace.gameObject.active = false;
                    si.setlanuagelist("Common");
                    si.setlanuagelist("Infernal");
                    break;
                }
        }
    }
    void Update()
    {
        if (si.getrace() == "Elf")
        {
            if (subrace.value == 1)
            {
                other.text = "Language";
                other1.text = "Pick one Wizard Cantrip";
                Dother[0].gameObject.active = true;
                Dother[1].gameObject.active = true;
            }
            else
            {
                other.text = "";
                other1.text = "";
                trunoffdropdown(0);
            }
        }
        if (si.getrace() == "Human")
        {
            if (subrace.value == 2)
            {
                other1.text = "Pick an Ability";
                Dother[1].gameObject.active = true;
                other2.text = "Pick a different Ability";
                Dother[2].gameObject.active = true;
                other3.text = "Pick a Skill";
                Dother[3].gameObject.active = true;
                other4.text = "Pick a feet";
                Dother[4].gameObject.active = true;
            }
            else
            {
                other1.text = "";
                other2.text = "";
                other3.text = "";
                other4.text = "";
                trunoffdropdown(1);
            }
        }
        if (subrace.value>0 || subrace.IsActive () == false) { 
            int activeDropdowns = checkactivedropdwon();
            int num = 0;
            for (int t = 0; t < activeDropdowns; t++)
            {
                if (Dother[t].value > 0)
                {
                    num++;
                }
            }
            if (num == activeDropdowns)
            {
                submit.gameObject.active = true;
            }
            else
            {
                submit.gameObject.active = false;
            }
            for (int q = 0; q < Dother.Length; q++)
            {
                for (int i = q + 1; i < Dother.Length; i++)
                {
                    if (Dother[i].IsActive() == true)
                        nodopps(Dother[q], Dother[i]);
                }
            }
        }
    }
    void Language(Dropdown A)
    {
        A.options.Add(new Dropdown.OptionData() { text = "Common" });
        A.options.Add(new Dropdown.OptionData() { text = "Dwarvish" });
        A.options.Add(new Dropdown.OptionData() { text = "Elvish" });
        A.options.Add(new Dropdown.OptionData() { text = "Giant" });
        A.options.Add(new Dropdown.OptionData() { text = "Gnomish" });
        A.options.Add(new Dropdown.OptionData() { text = "Goblin" });
        A.options.Add(new Dropdown.OptionData() { text = "Halfing" });
        A.options.Add(new Dropdown.OptionData() { text = "Orc" });
        A.options.Add(new Dropdown.OptionData() { text = "Abyssal" });
        A.options.Add(new Dropdown.OptionData() { text = "Celestial" });
        A.options.Add(new Dropdown.OptionData() { text = "Draconic" });
        A.options.Add(new Dropdown.OptionData() { text = "Deep Speech" });
        A.options.Add(new Dropdown.OptionData() { text = "Infernal" });
        A.options.Add(new Dropdown.OptionData() { text = "Primordial" });
        A.options.Add(new Dropdown.OptionData() { text = "Sylvan" });
        A.options.Add(new Dropdown.OptionData() { text = "Undercommon" });
    }
    void skills(Dropdown A)
    {
        A.options.Add(new Dropdown.OptionData() { text ="Acrobatics" });
        A.options.Add(new Dropdown.OptionData() { text = "Animal Handling" });
        A.options.Add(new Dropdown.OptionData() { text = "Arcana" });
        A.options.Add(new Dropdown.OptionData() { text = "Athletics" });
        A.options.Add(new Dropdown.OptionData() { text = "Deception" });
        A.options.Add(new Dropdown.OptionData() { text = "History" });
        A.options.Add(new Dropdown.OptionData() { text = "Insigh" });
        A.options.Add(new Dropdown.OptionData() { text = "Intimidation" });
        A.options.Add(new Dropdown.OptionData() { text = "Investigation" });
        A.options.Add(new Dropdown.OptionData() { text = "Medicine" });
        A.options.Add(new Dropdown.OptionData() { text = "Nature" });
        A.options.Add(new Dropdown.OptionData() { text = "Perception" });
        A.options.Add(new Dropdown.OptionData() { text = "Performance" });
        A.options.Add(new Dropdown.OptionData() { text = "Persuasion" });
        A.options.Add(new Dropdown.OptionData() { text = "Religion" });
        A.options.Add(new Dropdown.OptionData() { text = "Sleight of Hand" });
        A.options.Add(new Dropdown.OptionData() { text = "Stealth" });
        A.options.Add(new Dropdown.OptionData() { text = "Survival" });
    }
    void feat(Dropdown A)
    {
        A.options.Add(new Dropdown.OptionData() { text = "Alert" });
        A.options.Add(new Dropdown.OptionData() { text = "Athlete" });
        A.options.Add(new Dropdown.OptionData() { text = "Actor" });
        A.options.Add(new Dropdown.OptionData() { text = "Charger" });
        A.options.Add(new Dropdown.OptionData() { text = "Crossbow Expert" });
        A.options.Add(new Dropdown.OptionData() { text = "Defensice Duelist" });
        A.options.Add(new Dropdown.OptionData() { text = "Dual Wielder" });
        A.options.Add(new Dropdown.OptionData() { text = "Dungeon Delver" });
        A.options.Add(new Dropdown.OptionData() { text = "Durable" });
        A.options.Add(new Dropdown.OptionData() { text = "Elemental Adept" });
        A.options.Add(new Dropdown.OptionData() { text = "Grappler" });
        A.options.Add(new Dropdown.OptionData() { text = "Great Weapon Master" });
        A.options.Add(new Dropdown.OptionData() { text = "Healer" });
        A.options.Add(new Dropdown.OptionData() { text = "Heavily Armored" });
        A.options.Add(new Dropdown.OptionData() { text = "Heavy Armor Master" });
        A.options.Add(new Dropdown.OptionData() { text = "Inspiring Leard" });
        A.options.Add(new Dropdown.OptionData() { text = "Keen Mind" });
        A.options.Add(new Dropdown.OptionData() { text = "Lightly Armored" });
        A.options.Add(new Dropdown.OptionData() { text = "Linguist" });
        A.options.Add(new Dropdown.OptionData() { text = "Lucky" });
        A.options.Add(new Dropdown.OptionData() { text = "Mage Slayer" });
        A.options.Add(new Dropdown.OptionData() { text = "Magic Initiate" });
        A.options.Add(new Dropdown.OptionData() { text = "Martial Adept" });
        A.options.Add(new Dropdown.OptionData() { text = "Medium Armor Master" });
        A.options.Add(new Dropdown.OptionData() { text = "Mobile" });
        A.options.Add(new Dropdown.OptionData() { text = "Moderately Armored" });
        A.options.Add(new Dropdown.OptionData() { text = "Mounted Combatant" });
        A.options.Add(new Dropdown.OptionData() { text = "Observant" });
        A.options.Add(new Dropdown.OptionData() { text = "Polearm Master" });
        A.options.Add(new Dropdown.OptionData() { text = "Resilient" });
        A.options.Add(new Dropdown.OptionData() { text = "Ritual Caster" });
        A.options.Add(new Dropdown.OptionData() { text = "Savage Attacker" });
        A.options.Add(new Dropdown.OptionData() { text = "Sentinel" });
        A.options.Add(new Dropdown.OptionData() { text = "Sharphooter" });
        A.options.Add(new Dropdown.OptionData() { text = "Shield Master" });
        A.options.Add(new Dropdown.OptionData() { text = "Skilled" });
        A.options.Add(new Dropdown.OptionData() { text = "Skulker" });
        A.options.Add(new Dropdown.OptionData() { text = "Spell Sniper" });
        A.options.Add(new Dropdown.OptionData() { text = "Tavern Brawler" });
        A.options.Add(new Dropdown.OptionData() { text = "Tough" });
        A.options.Add(new Dropdown.OptionData() { text = "War Caster" });
        A.options.Add(new Dropdown.OptionData() { text = "Weapon Master" });
    }
    void Ability(Dropdown A)
    {
        A.options.Add(new Dropdown.OptionData() { text = "Strength" });
        A.options.Add(new Dropdown.OptionData() { text = "Decterity" });
        A.options.Add(new Dropdown.OptionData() { text = "Constitution" });
        A.options.Add(new Dropdown.OptionData() { text = "Intelligence" });
        A.options.Add(new Dropdown.OptionData() { text = "Wesdom" });
        A.options.Add(new Dropdown.OptionData() { text = "Charisma" });

    }
    void WCantrip(Dropdown A)
    {
        A.options.Add(new Dropdown.OptionData() { text = "Acid Splash" });
        A.options.Add(new Dropdown.OptionData() { text = "Blade Ward" });
        A.options.Add(new Dropdown.OptionData() { text = "Chill Touch" });
        A.options.Add(new Dropdown.OptionData() { text = "Dancing Lights" });
        A.options.Add(new Dropdown.OptionData() { text = "Fire Bolt" });
        A.options.Add(new Dropdown.OptionData() { text = "Friends" });
        A.options.Add(new Dropdown.OptionData() { text = "Light" });
        A.options.Add(new Dropdown.OptionData() { text = "Mage Hand" });
        A.options.Add(new Dropdown.OptionData() { text = "Mending" });
        A.options.Add(new Dropdown.OptionData() { text = "Message" });
        A.options.Add(new Dropdown.OptionData() { text = "Minor Illusion" });
        A.options.Add(new Dropdown.OptionData() { text = "Poison Spray" });
        A.options.Add(new Dropdown.OptionData() { text = "Prestidigitation" });
        A.options.Add(new Dropdown.OptionData() { text = "Ray of Frost" });
        A.options.Add(new Dropdown.OptionData() { text = "Shocking Grasp" });
        A.options.Add(new Dropdown.OptionData() { text = "True Strike" });

    }
    void nodopps(Dropdown A, Dropdown B)
    {
        
        if (A.options[A.value].text == B.options[B.value].text && A.value!=0 && B.value!=0)
        {
            submit.gameObject.active = false;
            Debug.Log("SAME " + A.options[A.value].text + " , " + B.options[B.value].text);
        }
    }
    void trunoffdropdown(int s)
    {
        for(int i = s; i < Dother.Length; i++)
        {
            Dother[i].gameObject.active = false;
        }
    }
    void checkLanguage(Dropdown A)
    {
        for (int i = 0; i < 16; i++)
        {
            for (int q = 0; q < A.options.Count; q++)
            {
                if (A.options[q].text == si.getlanuagelist(i))
                {
                    A.options.RemoveAt(q);
                }
            }
        }
    }
     int checkactivedropdwon()
    {
        int num = 0;
        for (int i = 0; i < Dother.Length; i++)
        {
            if (Dother[i].IsActive() == true)
            {
                num++;
            }
        }
        return num;
    }
    public void raceset()
    {
        // check to see if all opstion are check 

    }
}
