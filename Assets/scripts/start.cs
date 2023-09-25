using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class start : MonoBehaviour
{
    public TextMeshProUGUI textStart;
    void Update()
    {
        if (Time.timeScale == 0) textStart.text = "'bat dau bang SPACE'";
        else textStart.text = "'SPACE to bay'";
    }
}
