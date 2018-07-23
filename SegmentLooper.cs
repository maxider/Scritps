using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentLooper : MonoBehaviour
{

    public Transform parent;
    public GameObject spike;
    public GameObject coin;
    public GameObject[] Segments;

    private void OnTriggerEnter(Collider other)
    {
        //Find last Segment child in Segment GO
        Transform lastSegment = parent.GetChild(parent.childCount - 1);

        //next pos infront of newestSegment
        Vector3 nextPos = new Vector3(0, 0, lastSegment.position.z + lastSegment.localScale.z);
        GameObject segment = Instantiate(Segments[Random.Range(0, Segments.Length)], nextPos, Quaternion.identity, parent);
        GameObject spikeGO = Instantiate(spike, segment.transform);
        GameObject coinGO = Instantiate(coin, segment.transform);
        spikeGO.transform.localScale = new Vector3(spikeGO.transform.localScale.x / segment.transform.localScale.x, spikeGO.transform.localScale.y / segment.transform.localScale.y, spikeGO.transform.localScale.z / segment.transform.localScale.z);
        coinGO.transform.localScale = new Vector3(coinGO.transform.localScale.x / segment.transform.localScale.x, coinGO.transform.localScale.y / segment.transform.localScale.y, coinGO.transform.localScale.z / segment.transform.localScale.z);

        float temp = segment.transform.localScale.x/2;
        spikeGO.transform.Translate(Random.Range(-temp, temp), 0, 0);
        coinGO.transform.Translate(Random.Range(-temp, temp), 1f, 0);
    }



}
