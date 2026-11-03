using UnityEngine;
using UnityEngine.InputSystem;

public class Speler : MonoBehaviour
{
    public float tempo = 3f;
    private CharacterController cc;
    
    void Start() { cc = GetComponent<CharacterController>();}

    void Update()
    {
        var k = Keyboard.current;
        Vector3 m = Vector3.zero;
        if (k.wKey.isPressed) m += transform.forward;
        if (k.sKey.isPressed) m -= transform.forward;
        if (k.dKey.isPressed) m += transform.right;
        if (k.aKey.isPressed) m -= transform.right;
        cc.Move(m * tempo * Time.deltaTime);
        float d = 90 * Time.deltaTime;
        if (k.rightArrowKey.isPressed) transform.Rotate(0, d, 0);
        if (k.leftArrowKey.isPressed) transform.Rotate(0, -d, 0);
    }
}