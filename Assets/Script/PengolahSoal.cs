using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengolahSoal : MonoBehaviour
{
    public TextAsset assetsSoal;

    private string[] soal;

    private string[,] soalBag;

    // Start is called before the first frame update
    void Start()
    {
        soal = assetsSoal.ToString().Split('#');

        soalBag = new string[soal.Length, 6];

        OlahSoal();

        print(soalBag[1,3]);
    }

    private void OlahSoal()
    {
        for(int i=0; i<soal.Length; i++)
        {
            string[] tempSoal = soal[i].Split('+');
            for(int j = 0; j < tempSoal.Length; j++)
            {
                soalBag[i, j] = tempSoal[j];
                continue;
            }
            continue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
