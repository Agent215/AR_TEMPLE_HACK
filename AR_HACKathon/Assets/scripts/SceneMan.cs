using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneMan : MonoBehaviour
{
    public string name;
    public string ticker;
    public string price;
    public Text DisplayName;
    public Text DisplayTicker;
    public Text DisplayPrice;
    public static int currentStock;
    

    public void Start()
    {
     
    }
    public void Stock1()
    {

        PlayerPrefs.SetInt("currentStock", 1);
        SceneManager.LoadScene("dataScene", LoadSceneMode.Single);

      
        currentStock = 1;

    }

    public void Stock2() {

        PlayerPrefs.SetInt("currentStock", 2);
        SceneManager.LoadScene("dataScene", LoadSceneMode.Single);
       
        currentStock = 2;

    }

    public void Stock3()
    {
        PlayerPrefs.SetInt("currentStock", 3);
        SceneManager.LoadScene("dataScene", LoadSceneMode.Single);
        
        currentStock = 3;
    }

    public void LoadMain() {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        DisplayName.text = name;
        DisplayTicker.text = ticker;
        DisplayPrice.text = price;
    }
}
