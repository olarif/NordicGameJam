using UnityEngine;
using System.Collections;
using TMPro;

public class scr_score_UI : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        //testing
        score = score + 1;
    }
}


/*
using UnityEngine;
using System.Collections;
using TMPro;

public class ExampleClass : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    
    void Example()
    {
        textDisplay.text = "Example Text"      
    }
}
*/