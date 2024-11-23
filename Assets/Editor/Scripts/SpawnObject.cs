using UnityEditor;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    private const int NumberOfPieces = 100;


    //���������� �� ������� Tool � Unity Editor ������ SpawnObject, ������� �������� ����� Spawn
    [MenuItem("Tools/SpawnObject")]
    private static void Spawn()
    {
        //��������� � �������� ������� ��� ����������������
        GameObject prefab = Resources.Load<GameObject>("BlockPiece");
        //�������� ������ ������� �� null 
        if (prefab == null)
        {
            Debug.Log("Prefab not found!");
            return;
        }
        //�������� �����, ��� �������� �������� ����� ���������� �� n ��������� ������
        for (int i = 0; i < NumberOfPieces / 10; i++)
        {
            for (int j = 0; j < NumberOfPieces / 10; j++)
            {
                //���������������� �������, ����� �� 20 ����� ��������������� ���� �� 1/20 = 0.05 ������ ��� ����, �.�. ������ ����� 0.05
                Instantiate(prefab, new Vector2(j / 20f, i / 20f), Quaternion.identity);
            }
        }
        /*�������������� �������� ��� �����������
        GameObject instance = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
        //������������ ����������� ������ ���������������� ����� Ctrl+Z
        Undo.RegisterCreatedObjectUndo(instance, "Spawned Object");
        //��������� ������������������ �������
        Selection.activeObject = instance;
        */
    }

}
