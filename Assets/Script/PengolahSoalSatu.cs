using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PengolahSoalSatu : MonoBehaviour
{
    public TextAsset TesFormatif1;

    private string[] soal;

    private string[,] soalBag;

    int indexSoal;
    int maxSoal;
    bool ambilSoal;
    char kunciJ;

    //komponen ui
    public TMP_Text txtSoal, txtOpsiA, txtOpsiB, txtOpsiC, txtOpsiD;


    // Start is called before the first frame update
    void Start()
    {
        soal = TesFormatif1.ToString().Split('#');

        soalBag = new string[soal.Length,6];
        maxSoal = soal.Length; 
        OlahSoal();

        ambilSoal = true;
        TampilkanSoal();

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

    private void TampilkanSoal()
    {
        if (indexSoal < maxSoal)
        {
            if(ambilSoal)
            {
                txtSoal.text = soalBag[indexSoal, 0];
                txtOpsiA.text = soalBag[indexSoal,1];
                txtOpsiB.text = soalBag[indexSoal,2];
                txtOpsiC.text = soalBag[indexSoal,3];
                txtOpsiD.text = soalBag[indexSoal,4];
                kunciJ = soalBag[indexSoal, 5][0];

                ambilSoal = false;
            }
        }
    }

    public void Opsi(string opsiHuruf)
    {
        CheckJawaban(opsiHuruf[0]);
        indexSoal++;
        ambilSoal = true;
        TampilkanSoal();
    }

    private void CheckJawaban(char huruf)
    {
        if(huruf.Equals(kunciJ))
        {
            print("Benar!");
        }
        else 
        {
            print("Salah!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
