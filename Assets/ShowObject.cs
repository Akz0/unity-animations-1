using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowObject : MonoBehaviour
{
    public void Show(string ObjectTag)
    {
        GameObject.FindWithTag(ObjectTag).GetComponent<TextMeshProUGUI>().enabled = true;
    }
}
