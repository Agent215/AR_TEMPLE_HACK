using System.Collections.Generic;
using UnityEngine;

public class JsonExample : MonoBehaviour
{

    public VehiclesList VehicleList = new VehiclesList();
    public string[] symbolArray = new string[3];
    public string[] nameArray = new string[3];
    public float[] priceArray = new float[3];
    public float[] dayChangeArray = new float[3];
    public float[] marketCapArray = new float[3];


    // Start is called before the first frame update
    void Start()
    {
        
        
        TextAsset asset = Resources.Load("Vehicles2") as TextAsset;
        if (asset != null)
        {
            int i = 0;
            VehicleList = JsonUtility.FromJson<VehiclesList>(asset.text);
            foreach (Vehicles vehicle in VehicleList.Vehicles)
            {

                symbolArray[i] = vehicle.symbol;
                nameArray[i] = vehicle.name;
                priceArray[i] = vehicle.price;
                dayChangeArray[i] = vehicle.day_change;
                marketCapArray[i] = vehicle.market_Cap;

                print(vehicle.name);
                print(vehicle.price);
                print(vehicle.day_change);
                print(vehicle.market_Cap);
                print(vehicle.symbol);
                i++;
            }

        }
        else
        {
            print("Asset is null");

        }
        




    }


}
