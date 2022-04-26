using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int XP;
    public int currentPoint;
    public int lvlHero;

    // Update is called once per frame
    void Update()
    {
        UpdateXP(100);
    }

    public void UpdateXP(int exp)
    {
        XP += exp;
        int crntLevelHero = (int)(0.1f * Mathf.Sqrt(XP));

        if (crntLevelHero != lvlHero)
        {
            lvlHero = crntLevelHero;
            currentPoint += 1;
        }
        int xpnextLevel = (lvlHero + 1);

    }
}
