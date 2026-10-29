using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
        {
            return;
        }

        if (keyboard.wKey.isPressed)
        {
            Debug.Log("玩家按了 W 鍵！");
        }

        if (keyboard.aKey.isPressed)
        {
            Debug.Log("玩家按了 A 鍵！");
        }

        if (keyboard.sKey.isPressed)
        {
            Debug.Log("玩家按了 S 鍵！");
        }

        if (keyboard.dKey.isPressed)
        {
            Debug.Log("玩家按了 D 鍵！");
        }
    }
}
