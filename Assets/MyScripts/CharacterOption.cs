using UnityEngine;

public class CharacterOption : MonoBehaviour
{
    public int id;

    public CharacterManager
    characterManager;

    public void OnClick()
    {
        characterManager.CharacterClicked(id);
    }
}
