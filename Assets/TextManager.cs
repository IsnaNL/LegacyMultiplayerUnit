using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextManager : MonoBehaviour
{
    public static TextManager t_Instance;
    TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        t_Instance = this;
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
   public void SetText(string textToSet)
    {
        textMesh.text = textToSet;
    }
}
