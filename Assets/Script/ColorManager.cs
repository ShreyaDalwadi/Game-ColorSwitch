using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public List<Color> colorlist=new List<Color>();
    public static ColorManager  inst;

 
    public Color ColorChange()
    {
        int value = Random.Range(0, colorlist.Count);
        return colorlist[value];

    }


   
}
