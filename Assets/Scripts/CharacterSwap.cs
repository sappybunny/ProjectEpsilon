using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterSwap : MonoBehaviour
{

    [SerializeField]
    private Transform character;
    [SerializeField]
    private List<Transform> possibleCharacters;

    private int currentCharacter;
    // Start is called before the first frame update
    void Start()
    {
        // Assigns selected character as first possible character
        if (character == null && possibleCharacters.Count >= 1)
        {
            character = possibleCharacters[0];
        }

        // Disables player control of every character except first possible character
        for (int i = 1; i < possibleCharacters.Count; i++)
        {
            possibleCharacters[i].GetComponent<PlayerInput>().DeactivateInput();
        }



    }


    public void SwapCharacterNext(InputAction.CallbackContext ctx)
    {

        // Increment current character value and set character to next in list
        if (currentCharacter == possibleCharacters.Count - 1)
        {
            currentCharacter = 0;
        }
        else
        {
            currentCharacter += 1;
        }

        character = possibleCharacters[currentCharacter];

        // Enable player control of the new character and disable it for all others
        character.GetComponent<PlayerInput>().ActivateInput();

        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if (i != currentCharacter)
            {
                possibleCharacters[i].GetComponent<PlayerInput>().DeactivateInput();
            }
        }


    }
}
