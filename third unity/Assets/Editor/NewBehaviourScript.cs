using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BasicObjectSpawner : EditorWindow
{
    string ObjectBaseName = "";
    GameObject[] selected = new GameObject[0];
    string newname;
    int objectId = 1;
    GameObject objecttospawn;
    float objectscale;
    float spawnradius = 5f;
    [MenuItem("Tools/Basic Object Spawner")]
    public static void ShowWindow()
    {
        GetWindow(typeof(BasicObjectSpawner));
    }
    public void OnGUI()
    {
        GUILayout.Label("Spawn new object", EditorStyles.boldLabel);
        selected = Selection.gameObjects;
        ObjectBaseName = EditorGUILayout.TextField("BaseName", ObjectBaseName);
        objectId = EditorGUILayout.IntField("Object Id", objectId);
        objectscale = EditorGUILayout.Slider("Scale",objectscale,0.5f,3f);
        spawnradius = EditorGUILayout.FloatField("spawn radius",spawnradius);
        objecttospawn = EditorGUILayout.ObjectField("perefab",objecttospawn,typeof(GameObject),true)as GameObject;
        EditorGUILayout.LabelField("selected objects" + selected.Length.ToString("000"));
        newname= EditorGUILayout.TextField("enter new name",newname);
        if (GUILayout.Button("spawn Object"))
            {
            spawnObject();
        }
        if (GUILayout.Button("Rename selected objects"))
        {
            rename();
        }
        Repaint();
    }
    private void spawnObject()
    {
        Vector2 spawnCircle = Random.insideUnitCircle * spawnradius;
        Vector3 spawnpos = new Vector3(spawnCircle.x, 2.01f, spawnCircle.y);

        GameObject newobject = Instantiate(objecttospawn, spawnpos, Quaternion.identity);
        newobject.name = ObjectBaseName;
        newobject.transform.localScale = Vector3.one * objectscale;

    }
    private void rename()
    {
        for(int i = 0;i<selected.Length;i++)
        {
            selected[i].name = newname;
        }
    }
}
