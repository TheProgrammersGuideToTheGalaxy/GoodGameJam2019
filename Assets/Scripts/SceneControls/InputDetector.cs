using UnityEngine;
using UnityEngine.Events;

public class InputDetector : MonoBehaviour
{
    [SerializeField] private string onButtonDownName = "Jump";
    [SerializeField] private UnityEvent callMethod;

    private void Update()
    {
        if (Input.GetButtonDown(onButtonDownName))
        {
            callMethod.Invoke();
        }
    }
}