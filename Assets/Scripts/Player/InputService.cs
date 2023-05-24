using UnityEngine;

public class InputService : MonoBehaviour
{
    private float _inputHorizontal;
    public float InputHorizontal
    {
        get { return _inputHorizontal; }
    }
    
    private float _inputVertical;
    public float InputVertical
    {
        get { return _inputVertical; }
    }

    [SerializeField]
    private bl_Joystick _joystick;
  
    private void Update()
    {
        SetInputWithJoustick();
    }

    private void SetInputWithJoustick()
    {
        _inputHorizontal = _joystick.Horizontal;
        _inputVertical = _joystick.Vertical;
    }
}
