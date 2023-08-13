using UnityEngine;

public class HideMouseCursor : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true; // Set the cursor to be initially visible
    }

    void Update()
    {
        if (IsMouseOverGameWindow())
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
    }

    bool IsMouseOverGameWindow()
    {
        Rect gameWindowRect = new Rect(0, 0, Screen.width, Screen.height);
        return gameWindowRect.Contains(Input.mousePosition);
    }
}
