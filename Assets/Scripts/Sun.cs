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
        transform.rotation = Quaternion.Euler(transform.eulerAngles + Vector3.up * Time.deltaTime * staticData.GetRotationSpeed());
    }

}