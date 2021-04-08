using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LocalController : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            this.GetComponent<PlayerController>().enabled = true;
            GetComponentInChildren<Camera>().enabled = true;
        }
        else
        {
            this.GetComponent<PlayerController>().enabled = false;
            GetComponentInChildren<Camera>().enabled = false;
        }
    }
    public void SetWinner(GameObject winner)
    {
        if (isLocalPlayer && winner == this.gameObject)
        {
            TextManager.t_Instance.SetText("YouWin");
            Time.timeScale = 0.5f;
        }
        else
        {
            TextManager.t_Instance.SetText("YouLose");
            Time.timeScale = 0.5f;

        }
    }
   
}
