using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlQuest : MonoBehaviour
{
//     [System.Serializable]
//     public class Soals
//     {
//         [System.Serializable]
//         public class ElementSoals
//         {
//             [TextArea]
//             public string stringSoal;

//             public string[] jawabans;

//             //public int jawabanBenar; //tulisan
//         }

//       public ElementSoals elementSoals;
//     }

//    // public List<Soal> soals;
    
//     public Soals[] soals;

//     // random index
    
//     public int[] indexRandomSoal;
//     public int[] indexRandomJawaban;
//     public int totalSoal;
//     public int urutanSoal;

//     [Header("UI soal dan jawaban")]
//     public Text textsoal;
//     public Text[] textJawabans;

    
//     // Start is called before the first frame update
//     void Start()
//     {
//         GenerateIndexRandomSoal();
//         GenerateIndexRandomJawaban();

//         GenerateSoal();
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     void GenerateIndexRandomJawaban()
//     {
//         indexRandomJawaban = new int[4];
//         for (int i = 0; i < indexRandomJawaban.Length; i++)
//         {
//             indexRandomJawaban[i] = i;
//         }

//         for (int i = 0; i < indexRandomJawaban.Length; i++)
//         {
//            int a = indexRandomJawaban[i];
//            int b = Random.Range(0, indexRandomJawaban.Length);
//            indexRandomJawaban[i] = indexRandomJawaban[b];
//            indexRandomJawaban[b] = a;
//         }
//     }

//     void GenerateIndexRandomSoal()
//     {
//        indexRandomSoal = new int [soals.Length];
//        for (int i = 0; i < indexRandomSoal.Length; i++)
//        {
//          indexRandomSoal[i] = i;
//        }

//         for (int i = 0; i < indexRandomSoal.Length; i++)
//         {
//             int a = indexRandomSoal[i];
//             int b = Random.Range(0, indexRandomSoal.Length);
//             indexRandomSoal[i] = indexRandomSoal[b];
//             indexRandomSoal[b] = a;
//         }
//     }

//     void GenerateSoal()
//     {
//         //update soal
//         textSoal.text = soals[indexRandomSoal[urutanSoal]].elementSoals.stringSoal;

//         // update jawaban
//         for (int i = 0; i < 4; i++) //abcd
//         {
//             textJawabans[i].text = soals[indexRandomSoal[urutanSoal]].elementSoals.stringJawabans[indexRandomJawaban[i]];
//         }
//     }
}

