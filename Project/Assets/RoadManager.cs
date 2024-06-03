using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject roadSection;
    public float sectionLength = 100f;
    public int maxSections = 3;
    public List<GameObject> sections = new List<GameObject>();

    private void Start()
    {
        Vector3 spawnPosition = new Vector3(-5, 5, 40 + sectionLength);
        GameObject section = Instantiate(roadSection, spawnPosition, Quaternion.identity);
        sections.Add(section);

    }

    public void AddNewSection()
    {
        GameObject lastSection = sections[sections.Count - 1];
        Vector3 newPosition = lastSection.transform.position + new Vector3(0, 0, sectionLength);

        GameObject newSection = Instantiate(roadSection, newPosition, Quaternion.identity);
        sections.Add(newSection);

        if (sections.Count > maxSections)
        {
            GameObject oldSection = sections[0];
            sections.RemoveAt(0);
            Destroy(oldSection);
        }
    }
}