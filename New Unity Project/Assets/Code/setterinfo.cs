using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setterinfo : MonoBehaviour
{
    private int lvl;
    private int str; // a
    private int dex; // b
    private int con; // c
    private int intel; // d
    private int wis; // e
    private int cha; //f
    private string name; // g
    private string pc; // h
    private string ali; // i
    private string bg; // j
    private string race; //k
    private string[] lanuagelist = new string[16]; // list of lanuage that the player knows
    private string[] skillslist = new string[18]; // list of skill that the player has profionce in 
    private int lnum = 0; // keep track of how many lanuage they know
    private int snum = 0; // keep track of how many skill they are profionce in 
    
    public  void setter(int a, int b, int c, int d, int e, int f, string g, string h, string i, string j, string k)
    {
        // setting all the value to the right stats
        str = a;
        dex = b;
        con = c;
        intel = d;
        wis = e;
        cha = f;
        name = g;
        pc = h;
        ali = i;
        bg = j;
        race = k;
    }
    public string getname()
    {
        return name;
    }
    public string getpc()
    {
        return pc;
    }
    public string getali()
    {
        return ali;
    }
    public string getbg()
    {
        return bg;
    }
    public string getrace()
    {
        return race;
    }
    public int getstr()
    {
        return str;
    }
    public int getdex()
    {
        return dex;
    }
    public int getcon()
    {
        return con;
    }
    public int getintel()
    {
        return intel;
    }
    public int getwis()
    {
        return wis;
    }
    public int getcha()
    {
        return cha;
    }
    public void setstr (int A)
    {
        str = str + A;
    }
    public void setdex(int A)
    {
        dex = dex + A;
    }
    public void setcon(int A)
    {
        con = con + A;
    }
    public void setintel(int A)
    {
        intel = intel + A;
    }
    public void setwis(int A)
    {
        wis = wis + A;
    }
    public void setcha(int A)
    {
        cha = cha + A;
    }
    public void setlanuagelist(string words)
    {
        if (lnum < 17)
        {
            lanuagelist[lnum] = words;
            lnum++;
        }
    }
    public void setskilllist(string words)
    {
        if (snum < 19)
        {
            skillslist[snum] = words;
            snum++;
        }
    }
    public string getlanuagelist(int num)
    {
        return lanuagelist[num];
    }
}
