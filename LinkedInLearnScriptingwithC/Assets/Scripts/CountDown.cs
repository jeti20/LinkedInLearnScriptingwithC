using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CountDown : MonoBehaviour
{// Skrypt pozwala stworzyæ odliczanie na ekranie i zablokowanie ruchu postaci poprzez rigidbody, odblokowuje po zjechaniu liczb
    // Start is called before the first frame update

    public string[] messages; //3, 2, 1, Go
    public float Interval = 1f;
    private TextMeshProUGUI UIText;
    public GameObject theCube;
    public GameObject napis;

    public  IEnumerator Start()
    {
        theCube.GetComponent<Moving>().enabled = false;
        UIText = GetComponent<TextMeshProUGUI>();
        

        int messageDisplay = messages.Length - 1;

        while (messageDisplay >= 0)
        {
            UIText.text = messages[messageDisplay];
            yield return new WaitForSeconds(Interval);
            messageDisplay -= 1;
        }
        

        theCube.GetComponent<Moving>().enabled = true;
        napis.SetActive(false);
    } 

    
}
