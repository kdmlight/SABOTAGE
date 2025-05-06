using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MyFormManager : MonoBehaviour
{
    public Selectable firstInput;

    private void OnEnable()
    {
        firstInput.Select();
    }
}
