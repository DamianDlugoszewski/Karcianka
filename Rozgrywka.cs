//Kod rozgrywki do projektu karcianki na podstawie gry "Wszystko albo nic"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rozgrywka : MonoBehaviour
{
    GameObject karta = null;
    GameObject srodek = null;
    public static float szybkosc = 1f;
    public static float szybkosc2 = 0.35f;
    public static int pomoc = 0;
    public static int pomoc2 = 0;
    public static int pomocq = 0;

    string kartaakt_wartosc = "";
    string kartaakt_kolor = "";

    public static string karta1_wartosc = "";
    public static string karta1_kolor = "";
    public static string karta2_wartosc = "";
    public static string karta2_kolor = "";
    public static string karta3_wartosc = "";
    public static string karta3_kolor = "";
    public static string karta4_wartosc = "";
    public static string karta4_kolor = "";
    public static string kartag1_wartosc = "";
    public static string kartag1_kolor = "";
    public static string kartag2_wartosc = "";
    public static string kartag2_kolor = "";
    public static string kartag3_wartosc = "";
    public static string kartag3_kolor = "";
    public static string kartag4_wartosc = "";
    public static string kartag4_kolor = "";


    void Start()
    {
        GameObject zad1 = GameObject.FindGameObjectWithTag("Zadanie1");
        GameObject zad2 = GameObject.FindGameObjectWithTag("Zadanie2");
        GameObject zad3 = GameObject.FindGameObjectWithTag("Zadanie3");
        GameObject zad4 = GameObject.FindGameObjectWithTag("Zadanie4");

        GameObject[] stos_zadan = GameObject.FindGameObjectsWithTag("Sztos_zadan");
        GameObject sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");

        GameObject poz_zad1 = GameObject.FindGameObjectWithTag("Poz_Zad1");
        GameObject poz_zad2 = GameObject.FindGameObjectWithTag("Poz_Zad2");
        GameObject poz_zad3 = GameObject.FindGameObjectWithTag("Poz_Zad3");
        GameObject poz_zad4 = GameObject.FindGameObjectWithTag("Poz_Zad4");

        Zbior_questy.ilosc_zrobionych = 0;
        Menu.GraSpauzowana = false;
        Debug.Log(Menu.GraSpauzowana);
    }

    // Update is called once per frame
    void Update()
    {
        //pozycje kart w rece (niewidoczne)
        GameObject poz1 = GameObject.Find("Pozycja1");
        GameObject poz2 = GameObject.Find("Pozycja2");
        GameObject poz3 = GameObject.Find("Pozycja3");
        GameObject poz4 = GameObject.Find("Pozycja4");

        GameObject karta_gry_zak = GameObject.FindGameObjectWithTag("Kartazak");
        GameObject karta_zad_zak = GameObject.FindGameObjectWithTag("Kartazadzak");

        GameObject sr1 = GameObject.FindGameObjectWithTag("Poz_Sr1");
        GameObject sr2 = GameObject.FindGameObjectWithTag("Poz_Sr2");
        GameObject sr3 = GameObject.FindGameObjectWithTag("Poz_Sr3");
        GameObject sr4 = GameObject.FindGameObjectWithTag("Poz_Sr4");

        GameObject zad1 = GameObject.FindGameObjectWithTag("Zadanie1");
        GameObject zad2 = GameObject.FindGameObjectWithTag("Zadanie2");
        GameObject zad3 = GameObject.FindGameObjectWithTag("Zadanie3");
        GameObject zad4 = GameObject.FindGameObjectWithTag("Zadanie4");

        GameObject kart_sr1 = GameObject.FindGameObjectWithTag("Srodek1");
        GameObject kart_sr2 = GameObject.FindGameObjectWithTag("Srodek2");
        GameObject kart_sr3 = GameObject.FindGameObjectWithTag("Srodek3");
        GameObject kart_sr4 = GameObject.FindGameObjectWithTag("Srodek4");

        GameObject[] sztoskart = GameObject.FindGameObjectsWithTag("Sztos_gry");

        GameObject[] stos_zadan = GameObject.FindGameObjectsWithTag("Sztos_zadan");
        GameObject sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");

        GameObject kart1 = GameObject.FindGameObjectWithTag("Karta1");
        GameObject kart2 = GameObject.FindGameObjectWithTag("Karta2");
        GameObject kart3 = GameObject.FindGameObjectWithTag("Karta3");
        GameObject kart4 = GameObject.FindGameObjectWithTag("Karta4");

        MonoBehaviour[] skrypty_sr1;
        MonoBehaviour[] skrypty_sr2;
        MonoBehaviour[] skrypty_sr3;
        MonoBehaviour[] skrypty_sr4;
        MonoBehaviour[] skrypty_akt;
        MonoBehaviour[] skrypty_g1;
        MonoBehaviour[] skrypty_g2;
        MonoBehaviour[] skrypty_g3;
        MonoBehaviour[] skrypty_g4;

        GameObject poz_zad1 = GameObject.FindGameObjectWithTag("Poz_Zad1");
        GameObject poz_zad2 = GameObject.FindGameObjectWithTag("Poz_Zad2");
        GameObject poz_zad3 = GameObject.FindGameObjectWithTag("Poz_Zad3");
        GameObject poz_zad4 = GameObject.FindGameObjectWithTag("Poz_Zad4");

        GameObject podsw1 = GameObject.FindGameObjectWithTag("Podsw1");
        GameObject podsw2 = GameObject.FindGameObjectWithTag("Podsw2");
        GameObject podsw3 = GameObject.FindGameObjectWithTag("Podsw3");
        GameObject podsw4 = GameObject.FindGameObjectWithTag("Podsw4");

        //zmienna pomocnicza
        if (zad1 == null || zad2==null || zad3==null || zad4 == null)
        {
            pomocq = 1;
        }

        //Wylosowanie kart gracza
        if (kart1 == null && sztoskart.Length != 0)
        {
            sztoskart[sztoskart.Length - 1].transform.position = poz1.transform.position;
            sztoskart[sztoskart.Length - 1].transform.tag = "Karta1";
        }
        if (kart2 == null && sztoskart.Length != 0)
        {
            sztoskart[sztoskart.Length - 1].transform.position = poz2.transform.position;
            sztoskart[sztoskart.Length - 1].transform.tag = "Karta2";
        }
        if (kart3 == null && sztoskart.Length != 0)
        {
            sztoskart[sztoskart.Length - 1].transform.position = poz3.transform.position;
            sztoskart[sztoskart.Length - 1].transform.tag = "Karta3";
        }
        if (kart4 == null && sztoskart.Length != 0)
        {
            sztoskart[sztoskart.Length - 1].transform.position = poz4.transform.position;
            sztoskart[sztoskart.Length - 1].transform.tag = "Karta4";
        }

        //Wylosowanie kart granych
        if (kart_sr1 == null)
        {
            kart1.transform.position = sr1.transform.position;
            kart1.transform.tag = "Srodek1";
        }
        if (kart_sr2 == null)
        {
            kart2.transform.position = sr2.transform.position;
            kart2.transform.tag = "Srodek2";
        }
        if (kart_sr3 == null)
        {
            kart3.transform.position = sr3.transform.position;
            kart3.transform.tag = "Srodek3";
        }
        if (kart_sr4 == null)
        {
            kart4.transform.position = sr4.transform.position;
            kart4.transform.tag = "Srodek4";
        }

        //Uzupełnianie zadań na stole
        if (zad1 == null && sprawdzenie != null)
        {
            stos_zadan[stos_zadan.Length - 1].transform.position = poz_zad1.transform.position;
            stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie1";
            sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");
        }
        if (zad2 == null && sprawdzenie != null)
        {
            stos_zadan[stos_zadan.Length - 1].transform.position = poz_zad2.transform.position;
            stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie2";
            sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");

        }
        if (zad3 == null && sprawdzenie != null)
        {
            stos_zadan[stos_zadan.Length - 1].transform.position = poz_zad3.transform.position;
            stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie3";
            sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");

        }
        if (zad4 == null && sprawdzenie != null)
        {
            stos_zadan[stos_zadan.Length - 1].transform.position = poz_zad4.transform.position;
            stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie4";
            sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");
        }

        //Wybór kart
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Wybór kart gracza
                if (hit.transform.tag == "Karta1" && pomoc == 0 && Menu.GraSpauzowana==false)
                {
                    karta = GameObject.FindGameObjectWithTag("Karta1");
                    pomoc2 = 1;
                    skrypty_akt = karta.GetComponents<MonoBehaviour>();
                    kartaakt_wartosc = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 2, 1);
                    kartaakt_kolor = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 3, 1);
                    podsw1.GetComponent<MeshRenderer>().enabled = true;
                    podsw2.GetComponent<MeshRenderer>().enabled = false;
                    podsw3.GetComponent<MeshRenderer>().enabled = false;
                    podsw4.GetComponent<MeshRenderer>().enabled = false;
                }
                else if (hit.transform.tag == "Karta2" && pomoc == 0 && Menu.GraSpauzowana == false)
                {
                    karta = GameObject.FindGameObjectWithTag("Karta2");
                    pomoc2 = 1;
                    skrypty_akt = karta.GetComponents<MonoBehaviour>();
                    kartaakt_wartosc = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 2, 1);
                    kartaakt_kolor = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 3, 1);
                    podsw1.GetComponent<MeshRenderer>().enabled = false;
                    podsw2.GetComponent<MeshRenderer>().enabled = true;
                    podsw3.GetComponent<MeshRenderer>().enabled = false;
                    podsw4.GetComponent<MeshRenderer>().enabled = false;
                }
                else if (hit.transform.tag == "Karta3" && pomoc == 0 && Menu.GraSpauzowana == false)
                {
                    karta = GameObject.FindGameObjectWithTag("Karta3");
                    pomoc2 = 1;
                    skrypty_akt = karta.GetComponents<MonoBehaviour>();
                    kartaakt_wartosc = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 2, 1);
                    kartaakt_kolor = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 3, 1);
                    podsw1.GetComponent<MeshRenderer>().enabled = false;
                    podsw2.GetComponent<MeshRenderer>().enabled = false;
                    podsw3.GetComponent<MeshRenderer>().enabled = true;
                    podsw4.GetComponent<MeshRenderer>().enabled = false;
                }
                else if (hit.transform.tag == "Karta4" && pomoc == 0 && Menu.GraSpauzowana == false)
                {
                    karta = GameObject.FindGameObjectWithTag("Karta4");
                    pomoc2 = 1;
                    skrypty_akt = karta.GetComponents<MonoBehaviour>();
                    kartaakt_wartosc = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 2, 1);
                    kartaakt_kolor = (skrypty_akt[1].ToString()).Substring(skrypty_akt[1].ToString().Length - 3, 1);
                    podsw1.GetComponent<MeshRenderer>().enabled = false;
                    podsw2.GetComponent<MeshRenderer>().enabled = false;
                    podsw3.GetComponent<MeshRenderer>().enabled = false;
                    podsw4.GetComponent<MeshRenderer>().enabled = true;
                }
                //wybór miejsca docelowego karty z ręki na środek
                if (hit.transform.tag == "Srodek1" && pomoc == 0 && pomoc2 == 1 && (kartaakt_kolor == karta1_kolor || kartaakt_wartosc == karta1_wartosc) && Menu.GraSpauzowana == false)
                {
                    srodek = GameObject.FindGameObjectWithTag("Poz_Sr1");
                    pomoc = 1;
                }
                else if (hit.transform.tag == "Srodek2" && pomoc == 0 && pomoc2 == 1 && (kartaakt_kolor == karta2_kolor || kartaakt_wartosc == karta2_wartosc) && Menu.GraSpauzowana == false)
                {
                    srodek = GameObject.FindGameObjectWithTag("Poz_Sr2");
                    pomoc = 2;
                }
                else if (hit.transform.tag == "Srodek3" && pomoc == 0 && pomoc2 == 1 && (kartaakt_kolor == karta3_kolor || kartaakt_wartosc == karta3_wartosc) && Menu.GraSpauzowana == false)
                {
                    srodek = GameObject.FindGameObjectWithTag("Poz_Sr3");
                    pomoc = 3;
                }
                else if (hit.transform.tag == "Srodek4" && pomoc == 0 && pomoc2 == 1 && (kartaakt_kolor == karta4_kolor || kartaakt_wartosc == karta4_wartosc) && Menu.GraSpauzowana == false)
                {
                    srodek = GameObject.FindGameObjectWithTag("Poz_Sr4");
                    pomoc = 4;
                }
            }
        }

        if (pomoc == 1)
        {
            karta.transform.position = Vector3.MoveTowards(karta.transform.position, GameObject.FindGameObjectWithTag("Poz_Sr1").transform.position, szybkosc * Time.deltaTime);

            if (karta.transform.position == GameObject.FindGameObjectWithTag("Poz_Sr1").transform.position)
            {
                GameObject karta_sr = GameObject.FindGameObjectWithTag("Srodek1");
                Destroy(karta_sr);
                karta.transform.gameObject.tag = "Srodek1";
                karta = null;
                pomoc = 0;
                pomoc2 = 0;
                podsw1.GetComponent<MeshRenderer>().enabled = false;
                podsw2.GetComponent<MeshRenderer>().enabled = false;
                podsw3.GetComponent<MeshRenderer>().enabled = false;
                podsw4.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        if (pomoc == 2)
        {
            karta.transform.position = Vector3.MoveTowards(karta.transform.position, GameObject.FindGameObjectWithTag("Poz_Sr2").transform.position, szybkosc * Time.deltaTime);

            if (karta.transform.position == GameObject.FindGameObjectWithTag("Poz_Sr2").transform.position)
            {
                GameObject karta_sr = GameObject.FindGameObjectWithTag("Srodek2");
                Destroy(karta_sr);
                karta.transform.gameObject.tag = "Srodek2";
                karta = null;
                pomoc = 0;
                pomoc2 = 0;
                podsw1.GetComponent<MeshRenderer>().enabled = false;
                podsw2.GetComponent<MeshRenderer>().enabled = false;
                podsw3.GetComponent<MeshRenderer>().enabled = false;
                podsw4.GetComponent<MeshRenderer>().enabled = false;
            }

        }
        if (pomoc == 3)
        {
            karta.transform.position = Vector3.MoveTowards(karta.transform.position, GameObject.FindGameObjectWithTag("Poz_Sr3").transform.position, szybkosc * Time.deltaTime);

            if (karta.transform.position == GameObject.FindGameObjectWithTag("Poz_Sr3").transform.position)
            {
                GameObject karta_sr = GameObject.FindGameObjectWithTag("Srodek3");
                Destroy(karta_sr);
                karta.transform.gameObject.tag = "Srodek3";
                karta = null;
                pomoc = 0;
                pomoc2 = 0;
                podsw1.GetComponent<MeshRenderer>().enabled = false;
                podsw2.GetComponent<MeshRenderer>().enabled = false;
                podsw3.GetComponent<MeshRenderer>().enabled = false;
                podsw4.GetComponent<MeshRenderer>().enabled = false;
            }

        }
        if (pomoc == 4)
        {
            karta.transform.position = Vector3.MoveTowards(karta.transform.position, GameObject.FindGameObjectWithTag("Poz_Sr4").transform.position, szybkosc * Time.deltaTime);

            if (karta.transform.position == GameObject.FindGameObjectWithTag("Poz_Sr4").transform.position)
            {
                GameObject karta_sr = GameObject.FindGameObjectWithTag("Srodek4");
                Destroy(karta_sr);
                karta.transform.gameObject.tag = "Srodek4";
                karta = null;
                pomoc = 0;
                pomoc2 = 0;
                podsw1.GetComponent<MeshRenderer>().enabled = false;
                podsw2.GetComponent<MeshRenderer>().enabled = false;
                podsw3.GetComponent<MeshRenderer>().enabled = false;
                podsw4.GetComponent<MeshRenderer>().enabled = false;
            }

        }

        //pobieranie koloru i wartości każdej karty na środku na podstawie nazwy skryptu
        if (kart_sr1 != null)
        {
            skrypty_sr1 = kart_sr1.GetComponents<MonoBehaviour>();
            karta1_wartosc = (skrypty_sr1[1].ToString()).Substring(skrypty_sr1[1].ToString().Length - 2, 1);
            karta1_kolor = (skrypty_sr1[1].ToString()).Substring(skrypty_sr1[1].ToString().Length - 3, 1);
        }
        if (kart_sr2 != null)
        {
            skrypty_sr2 = kart_sr2.GetComponents<MonoBehaviour>();
            karta2_wartosc = (skrypty_sr2[1].ToString()).Substring(skrypty_sr2[1].ToString().Length - 2, 1);
            karta2_kolor = (skrypty_sr2[1].ToString()).Substring(skrypty_sr2[1].ToString().Length - 3, 1);
        }
        if (kart_sr3 != null)
        {
            skrypty_sr3 = kart_sr3.GetComponents<MonoBehaviour>();
            karta3_wartosc = (skrypty_sr3[1].ToString()).Substring(skrypty_sr3[1].ToString().Length - 2, 1);
            karta3_kolor = (skrypty_sr3[1].ToString()).Substring(skrypty_sr3[1].ToString().Length - 3, 1);
        }
        if (kart_sr4 != null)
        {
            skrypty_sr4 = kart_sr4.GetComponents<MonoBehaviour>();
            karta4_wartosc = (skrypty_sr4[1].ToString()).Substring(skrypty_sr4[1].ToString().Length - 2, 1);
            karta4_kolor = (skrypty_sr4[1].ToString()).Substring(skrypty_sr4[1].ToString().Length - 3, 1);
        }

        //pobieranie koloru i wartości każdej karty gracza na podstawie nazwy skryptu
        if (kart1 != null)
        {
            skrypty_g1 = kart1.GetComponents<MonoBehaviour>();
            kartag1_wartosc = (skrypty_g1[1].ToString()).Substring(skrypty_g1[1].ToString().Length - 2, 1);
            kartag1_kolor = (skrypty_g1[1].ToString()).Substring(skrypty_g1[1].ToString().Length - 3, 1);
        }
        if (kart2 != null)
        {
            skrypty_g2 = kart2.GetComponents<MonoBehaviour>();
            kartag2_wartosc = (skrypty_g2[1].ToString()).Substring(skrypty_g2[1].ToString().Length - 2, 1);
            kartag2_kolor = (skrypty_g2[1].ToString()).Substring(skrypty_g2[1].ToString().Length - 3, 1);
        }
        if (kart3 != null)
        {
            skrypty_g3 = kart3.GetComponents<MonoBehaviour>();
            kartag3_wartosc = (skrypty_g3[1].ToString()).Substring(skrypty_g3[1].ToString().Length - 2, 1);
            kartag3_kolor = (skrypty_g3[1].ToString()).Substring(skrypty_g3[1].ToString().Length - 3, 1);
        }
        if (kart4 != null)
        {
            skrypty_g4 = kart4.GetComponents<MonoBehaviour>();
            kartag4_wartosc = (skrypty_g4[1].ToString()).Substring(skrypty_g4[1].ToString().Length - 2, 1);
            kartag4_kolor = (skrypty_g4[1].ToString()).Substring(skrypty_g4[1].ToString().Length - 3, 1);
        }
        
        
        if (pomocq == 1)
        {
            if (zad1 == null && sprawdzenie != null)
            {
                stos_zadan[stos_zadan.Length - 1].transform.position = Vector3.MoveTowards(stos_zadan[stos_zadan.Length - 1].transform.position, GameObject.FindGameObjectWithTag("Poz_Zad1").transform.position, szybkosc2 * Time.deltaTime);
                if (stos_zadan[stos_zadan.Length - 1].transform.position == GameObject.FindGameObjectWithTag("Poz_Zad1").transform.position)
                {
                    pomocq = 0;
                    stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie1";
                    sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");
                }
            }
            if (zad2 == null && sprawdzenie != null)
            {
                stos_zadan[stos_zadan.Length - 1].transform.position = Vector3.MoveTowards(stos_zadan[stos_zadan.Length - 1].transform.position, GameObject.FindGameObjectWithTag("Poz_Zad2").transform.position, szybkosc2 * Time.deltaTime);
                if (stos_zadan[stos_zadan.Length - 1].transform.position == GameObject.FindGameObjectWithTag("Poz_Zad2").transform.position)
                {
                    pomocq = 0;
                    stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie2";
                    sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");
                }
            }
            if (zad3 == null && sprawdzenie != null)
            {
                stos_zadan[stos_zadan.Length - 1].transform.position = Vector3.MoveTowards(stos_zadan[stos_zadan.Length - 1].transform.position, GameObject.FindGameObjectWithTag("Poz_Zad3").transform.position, szybkosc2 * Time.deltaTime);
                if (stos_zadan[stos_zadan.Length - 1].transform.position == GameObject.FindGameObjectWithTag("Poz_Zad3").transform.position)
                {
                    pomocq = 0;
                    stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie3";
                    sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");
                }
            }
            if (zad4 == null && sprawdzenie != null)
            {
                stos_zadan[stos_zadan.Length - 1].transform.position = Vector3.MoveTowards(stos_zadan[stos_zadan.Length - 1].transform.position, GameObject.FindGameObjectWithTag("Poz_Zad4").transform.position, szybkosc2 * Time.deltaTime);
                if (stos_zadan[stos_zadan.Length - 1].transform.position == GameObject.FindGameObjectWithTag("Poz_Zad4").transform.position)
                {
                    pomocq = 0;
                    stos_zadan[stos_zadan.Length - 1].transform.tag = "Zadanie4";
                    sprawdzenie = GameObject.FindGameObjectWithTag("Sztos_zadan");
                }
            }
        }
        
        //Usunięcie stosu kart gry
        if (sztoskart.Length == 0)
        {
            Destroy(karta_gry_zak);
        }
        //Usunięcie stosu zadań
        if (stos_zadan.Length == 0)
        {
            Destroy(karta_zad_zak);
        }

        //Przegrana, w przypadku wyczerpania kart do gry
        if (Zbior_questy.ilosc_zrobionych < Losowanie_quest.liczba_questow && kart1 == null && kart2 == null && kart3 == null && kart4 == null && Zbior_questy.ilosc_zrobionych != 0)
        {
            Debug.Log("Lose1");
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }

        //Przegrana, w przypadku braku możliwości ruchu
        if (kartag1_wartosc != karta1_wartosc && kartag1_kolor != karta1_kolor &&
            kartag1_wartosc != karta2_wartosc && kartag1_kolor != karta2_kolor &&
            kartag1_wartosc != karta3_wartosc && kartag1_kolor != karta3_kolor &&
            kartag1_wartosc != karta4_wartosc && kartag1_kolor != karta4_kolor &&
            kartag2_wartosc != karta1_wartosc && kartag2_kolor != karta1_kolor &&
            kartag2_wartosc != karta2_wartosc && kartag2_kolor != karta2_kolor &&
            kartag2_wartosc != karta3_wartosc && kartag2_kolor != karta3_kolor &&
            kartag2_wartosc != karta4_wartosc && kartag2_kolor != karta4_kolor &&
            kartag3_wartosc != karta1_wartosc && kartag3_kolor != karta1_kolor &&
            kartag3_wartosc != karta2_wartosc && kartag3_kolor != karta2_kolor &&
            kartag3_wartosc != karta3_wartosc && kartag3_kolor != karta3_kolor &&
            kartag3_wartosc != karta4_wartosc && kartag3_kolor != karta4_kolor &&
            kartag4_wartosc != karta1_wartosc && kartag4_kolor != karta1_kolor &&
            kartag4_wartosc != karta2_wartosc && kartag4_kolor != karta2_kolor &&
            kartag4_wartosc != karta3_wartosc && kartag4_kolor != karta3_kolor &&
            kartag4_wartosc != karta4_wartosc && kartag4_kolor != karta4_kolor && Zbior_questy.ilosc_zrobionych != 0)
        {
            Debug.Log("Lose2");
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
    }
}
