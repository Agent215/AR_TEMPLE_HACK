using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class setText : MonoBehaviour
{
    public string name;
    public string ticker;
    public float price;

    public float dayChange;
    public float marketCap;

    public Text DisplayName;
    public Text DisplayTicker;
    public Text DisplayPrice;

    // Start is called before the first frame update
    void Start()
      {

        print("current stock # "+PlayerPrefs.GetInt("curcurrentStock"));

        if ( PlayerPrefs.GetInt("curcurrentStock") == 1)
        {

            ticker = GameObject.Find("SceneMAn").GetComponent<JsonExample>().symbolArray[0];
            price = GameObject.Find("SceneMAn").GetComponent<JsonExample>().priceArray[0];
            name = GameObject.Find("SceneMAn").GetComponent<JsonExample>().nameArray[0];
            dayChange = GameObject.Find("SceneMAn").GetComponent<JsonExample>().dayChangeArray[0];
            marketCap = GameObject.Find("SceneMAn").GetComponent<JsonExample>().marketCapArray[0];
        }

        if (PlayerPrefs.GetInt("curcurrentStock") == 2)
        {

            ticker = GameObject.Find("SceneMAn").GetComponent<JsonExample>().symbolArray[1];
            price = GameObject.Find("SceneMAn").GetComponent<JsonExample>().priceArray[1];
            name = GameObject.Find("SceneMAn").GetComponent<JsonExample>().nameArray[1];
            dayChange = GameObject.Find("SceneMAn").GetComponent<JsonExample>().dayChangeArray[1];
            marketCap = GameObject.Find("SceneMAn").GetComponent<JsonExample>().marketCapArray[1];
        }
        if (PlayerPrefs.GetInt("curcurrentStock") == 3)
        {

            ticker = GameObject.Find("SceneMAn").GetComponent<JsonExample>().symbolArray[2];
            price = GameObject.Find("SceneMAn").GetComponent<JsonExample>().priceArray[2];
            name = GameObject.Find("SceneMAn").GetComponent<JsonExample>().nameArray[2];
            dayChange = GameObject.Find("SceneMAn").GetComponent<JsonExample>().dayChangeArray[2];
            marketCap = GameObject.Find("SceneMAn").GetComponent<JsonExample>().marketCapArray[2];
        }


       
        DisplayName.text = name;
        DisplayTicker.text = ticker;
        DisplayPrice.text = price.ToString("0.00");
        

    }

}
