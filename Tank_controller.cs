using UnityEngine;

public class Tank_controller //monobehaviour is an unity class that provides some functions to take care of
{
    private TankModel tank_model;
    private Tank_View tank_view;
    private Rigidbody rb;
    public Tank_controller(TankModel _tankMODEL,Tank_View _tankVIEW)
    {
       tank_model =_tankMODEL;
       tank_view =  GameObject.Instantiate<Tank_View>(_tankVIEW);;
       tank_model.SetTankController(this);
       tank_view.SetTankController(this);
       rb = tank_view.GetRigidbody();
    }
    public void Move(float movement,float movement_speed)
    {
      rb.velocity = tank_view.transform.forward* movement*movement_speed;
    }
    public void Rotate(float rotate,float rotate_speed)
    {
      Vector3 vector = new Vector3(0f,rotate*rotate_speed,0f);
      Quaternion deltaRotation = Quaternion.Euler(vector*Time.deltaTime); //euler is the measurement of angles we are rotating
      rb.MoveRotation(rb.rotation*deltaRotation);
    }
    public TankModel GetTankModel()
    {
      return tank_model;
    }
}
