using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int exp =0;

    public Character()
    {
        Reset();
    }
    public Character(string name)
    {
        this.Name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat($"Hero: {Name} - {exp}");
    }

    private void Reset()
    {
        this.Name = "Not Assigned";
        this.exp = 0;
    }
}
