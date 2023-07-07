using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    [SerializeField] PointHUD pointHUD;
    bool gameStopped = false;

    public void StartGame() {
        StartCoroutine(CountPoints());
    }

    public void StopGame() {
        gameStopped = true;
    }

    private IEnumerator CountPoints() {
        while (!gameStopped) {
            pointHUD.Points += 5;

            yield return new WaitForSeconds (1);
        }
    }
}
