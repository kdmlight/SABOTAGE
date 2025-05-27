using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class CharacterManager : MonoBehaviour
{
    public Sprite previewImage;
    public Sprite[] characterSprites;

    public void CharacterClicked(int id)
    {
        previewImage.sprite = characterSprites[id];
    }
    public GameObject characterOptionPrefab;
    public Transform characterContaier;

    
}
