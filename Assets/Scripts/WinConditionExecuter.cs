using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionExecuter : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<LocalController>().SetWinner(other.gameObject);
    }
}
