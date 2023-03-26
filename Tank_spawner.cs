using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_spawner : MonoBehaviour
{
    public Tank_View tank_view;
    void Start()
    {
        Createtank();
        //Instantiate(tank_view.gameObject,transform.position,Quaternion.identity);
    }
    private void Createtank()
    {   
        TankModel tank_model = new TankModel(30,30);
        Tank_controller tank_controller = new Tank_controller(tank_model,tank_view);
    }
    
}
