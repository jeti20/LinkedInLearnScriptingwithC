using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//Skrypt sprawia, ¿e co sekunda wzrasta wartoœæ w polu teksotwym w canvas. Mo¿e s³u¿yæ do liczenia czasu
public class Timer : MonoBehaviour
{
    private TextMeshProUGUI myText = null;
    private float timeElapsed = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        myText.text = timeElapsed.ToString("00");
    }
}
