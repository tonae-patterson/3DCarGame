using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject DreamCar01Control;


    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        DreamCar01Control.GetComponent<CarAIControl>().enabled = true;
    }


}
