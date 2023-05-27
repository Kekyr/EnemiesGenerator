using System.Collections;
using UnityEngine;

public class EnemiesGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _delay;

    private WaitForSeconds _waitForOneSeconds;

    private void Awake()
    {
        _waitForOneSeconds = new WaitForSeconds(_delay);
    }

    private void Start()
    {
        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Instantiate(_enemyPrefab, transform.GetChild(i).position, Quaternion.identity);
            yield return _waitForOneSeconds;
        }
    }
}
