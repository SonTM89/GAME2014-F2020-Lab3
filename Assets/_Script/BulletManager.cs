using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BulletManager : MonoBehaviour
{
    public GameObject bullet;
    public int maxBullets;

    public Queue<GameObject> m_bulletPool;
    

    // Start is called before the first frame update
    void Start()
    {
        _BuildBulletPool();
    }

    private void _BuildBulletPool()
    {
        // Create empty Queue structure
        m_bulletPool = new Queue<GameObject>();

        for (int count = 0; count < maxBullets; count++)
        {
            var tempBullet = Instantiate(bullet);
            tempBullet.SetActive(false);
            tempBullet.transform.parent = transform;
            m_bulletPool.Enqueue(tempBullet);
        }
    }

    public GameObject GetBullet(Vector3 position)
    {
        var newbullet = m_bulletPool.Dequeue();
        newbullet.SetActive(true);
        newbullet.transform.position = position;

        return newbullet;
    }

    public void ReturnBullet(GameObject returnedBullet)
    {
        returnedBullet.SetActive(false);
        m_bulletPool.Enqueue(returnedBullet);
    }
}
