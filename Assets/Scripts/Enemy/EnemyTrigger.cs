using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (!col.CompareTag("Enemy"))
            return;

            col.gameObject.SetActive(false);
    }
}
