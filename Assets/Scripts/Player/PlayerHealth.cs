using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject carObject;
    public GameObject particle;

    public PlayerController playerController;
    public ScoreController scoreController;

    private PlayerHealth playerHealth;

    [Space(10)]
    public GameObject gameOverPanel;
    public float timeToShowGameOverPanel = 5.0f;

    private bool destroyed = false;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (!col.gameObject.CompareTag("Enemy") || destroyed)
            return;

        Instantiate(particle, transform.position, transform.rotation);
        playerController.enabled = false;
        carObject.SetActive(false);
        playerHealth.enabled = false;

        destroyed = true;

        GetComponent<BoxCollider>().enabled = false;
        scoreController.startScore = false;
        StartCoroutine(ShowCredits());
    }

    private IEnumerator ShowCredits()
    {
        yield return new WaitForSeconds(timeToShowGameOverPanel);

        gameOverPanel.SetActive(true);
    }
}
