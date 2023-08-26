
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

public class script : MonoBehaviour
{
    string HeroName = "Barak";
    int HeroPower = 400;
    string VillainName = "shadow";
    int VillainPower = 200;
    float playerspeed = 2.7f;
    // Start is called before the first frame update
    void Start()
    {
        if (HeroPower >= VillainPower)
            print("hero power is stronger");
        else if (HeroPower < VillainPower)
            print("heropower is = to villan power");
        print(playerspeed);
        SetSpeed(2.5f);
        print(playerspeed);

    }


    // Update is called once per frame
    void Update()
    {

    }

    void SetSpeed(float speed)
    {
        playerspeed = speed;
    }
}
  