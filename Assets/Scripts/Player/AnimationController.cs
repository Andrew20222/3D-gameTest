using UnityEngine;
[RequireComponent(typeof(InputService))]
public class AnimationController : MonoBehaviour
{
    private const string SPEED_PARAMETER = "Speed";
    [SerializeField]
    private InputService _inputService;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private bl_Joystick _joystick;
    private void Update()
    { 
        SetValueParametersAnimation();
    }
    
    private void SetValueParametersAnimation()
    {
        float speed = new Vector2(_joystick.Horizontal, _joystick.Vertical).magnitude;
        _animator.SetFloat(SPEED_PARAMETER,speed);
    }
}
