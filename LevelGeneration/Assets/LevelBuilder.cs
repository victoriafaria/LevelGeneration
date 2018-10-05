using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour {

    public TextAsset m_File;

    public List<LevelObject> m_Objects;

    public void Start() {

    
        string[] lines = m_File.text.Replace("\r", "").Split('\n');

        for (int i = 0; i < lines.Length; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                char symbol = lines[i][j];
                for (int k = 0; k < m_Objects.Count; k++)
                {
                    if (symbol == m_Objects[k].m_Symbol) {

                        Vector3 position = new Vector3(j, -i, 0.0f);
                        GameObject go = Instantiate(m_Objects[k].m_Object, position, Quaternion.identity);
                    }
                }
            }
        }
    }

}
