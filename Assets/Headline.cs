using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Headline : MonoBehaviour
{
    public int width;

    string headlines =
    "Jupiter Furious Over Lack of Sacrifices — Sends ‘Mild’ Thunderstorm                             " +
    "Neptune Declares War on Fishermen: ‘Maybe Stop Overfishing My Oceans?’                             " +
    "Cupid Strikes Wrong Target Again — Senator Falls in Love with His Own Reflection                             " +
    "Mercury Accused of Insider Trading: ‘It’s Not a Crime If You’re the God of Commerce’                             " +
    "Bacchus Cancels Wine Blessings After City’s Last Party Gets ‘Out of Hand’                              " +
    "Mars Annoyed by Lack of Wars This Month — Mysterious Border Skirmish Ensues                             " +
    "Pluto Reminds Everyone He Exists — Romans Pretend Not to Hear                             " +
    "Diana Complains About Deforestation — Hunters Suddenly Go Missing                             " +
    "Minerva Institutes Mandatory Philosophy Classes — Soldiers Unamused                             " +
    "Ceres Blames Poor Harvest on Lack of Worship — Farmers Start Praying Immediately                             " +
    "Janus Conflicted About Next Year—Refuses to Give a Straight Answer                             " +
    "Vulcan Unleashes Volcanic Eruption — Claims Romans ‘Needed a Wake-Up Call’                              " +
    "Fortuna Laughs as Roman Economy Takes Another Wild Turn                                                                      ";

    int offset;
    int w;

    TMP_Text txtField;

    // Start is called before the first frame update
    void Start()
    {
        txtField = GetComponent<TMP_Text>();
        offset = 0;
        StartCoroutine("Scroller");
        w = 1;
    }

    IEnumerator Scroller()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);

            if (w < width)
                w++;
            else
                offset++;

            if (offset == headlines.Length - width)
            { 
                offset = 0;
                w = 1;
            }  

            txtField.text = headlines.Substring(offset, w); ;
        }
    }
}
