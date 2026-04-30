using UnityEngine;

public class Sun : MonoBehaviour
{
    public StaticData staticData;

    private void Start()
    {
        staticData = new StaticData();
    }
    void Update()
    {
        staticData.RotateObject(gameObject);
    }

}