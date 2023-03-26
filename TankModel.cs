using UnityEngine;

public class TankModel 
{
    private Tank_controller tank_controller;
     public float movement_speed;
    public float rotate_speed;
    public TankModel(float _movement, float _rotation)
    {
      movement_speed= _movement;
      rotate_speed = _rotation;
    }
    public void SetTankController( Tank_controller _tankController)
    {
        tank_controller = _tankController;
    }
}
