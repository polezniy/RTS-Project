﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EditorUI : MonoBehaviour
{
    public Button exitButton;
    public Button[] buttonsArray = new Button[4]; // Array to hold buttons
    ObjectsManager objectManagerRef;
    void Start()
    {
        exitButton.onClick.AddListener(ExitEditor);
        objectManagerRef = GetComponent<ObjectsManager>();

        for (int i = 0; i < buttonsArray.Length; i++)
        {
            buttonsArray[i].image.sprite = objectManagerRef.prefabArray[i].gameObject.GetComponent<WorldObject>().icon; // Shortcut?
            buttonsArray[i].gameObject.AddComponent<EditorButton>().prefab = objectManagerRef.prefabArray[i]; // Adding a script to the button and assigning a prefab at the same time
        }
    }

    void Update()
    {
        for (int i = 0; i < buttonsArray.Length; i++)
        {
            //Add a listener to each button to spawn an assigned object
        }
    }

    void ExitEditor()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
