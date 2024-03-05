using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text text;
    private int number;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text").GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            number++;
        }
        text.text = $"SCORE : {number}";
    }

    public void Add()
    {
        number++;
    }
}
