using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    public int XP;
    public int currentLevel;

    // Update is called once per frame
    void Update()
    {
        UpdateXP(5);
    }

    public void UpdateXp(int xp)
    {
        XP += xp;
        int crntLevel = (int)(0.1f * Mathf.Sqrt(XP));

        if(crntLevel != currentLevel)
        {
            currentLevel = crntLevel;
        }

        int xpnextLevel = 100 * (currentLevel + 1) * (currentLevel + 1);
        int differencexp = xpnextLevel - XP;

        int totaldiff = xpnextLevel - (100 * currentLevel * currentLevel);
    }
}
