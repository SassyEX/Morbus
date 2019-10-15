﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class Archivos : MonoBehaviour
{
    BinaryFormatter fb;
    FileStream Informacion;
    DatosdeJuego Datos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Crear()
    {
        if (File.Exists(Application.persistentDataPath + "/Datos.d"))
        {
            Debug.Log("Ya tienes un archivo we");
        }
        else
        {
            fb = new BinaryFormatter();
            Informacion = File.Create(Application.persistentDataPath + "/Datos.d");
           Datos = new DatosdeJuego();
            Datos.Usuario = "Daniel";
            //nombre Personaje
            Datos.Personajes[0,0] = "aspirina";
           Datos.Personajes[1,0] = "paracetamol";
            Datos.Personajes[2,0] = "amoxicilina";
            Datos.Personajes[3,0] = "cloxacilina";
            Datos.Personajes[4,0] = "bortezomib";
            Datos.Personajes[5,0] = "lenalidomida";
            Datos.Personajes[6,0] = "vorinostat";
            Datos.Personajes[7,0] = "clavulanato";
            Datos.Personajes[8,0] = "penicilina";
            Datos.Personajes[9,0] = "eritromicina";
            Datos.Personajes[10,0] = "levofloxacino";
            Datos.Personajes[11,0] = "betanecol";
            Datos.Personajes[12,0] = "metoclopramida";
            Datos.Personajes[13,0] = "ibuprofeno";
            Datos.Personajes[14,0] = "sulfasalazina";
            Datos.Personajes[15,0] = "prednisona";
            Datos.Personajes[16,0] = "cortisol";
            Datos.Personajes[17,0] = "ampicilina";
            Datos.Personajes[18,0] = "piperacilina";
            Datos.Personajes[19,0] = "tazobactam";
            Datos.Personajes[20,0] = "metilprednisolona";
            Datos.Personajes[21,0] = "hidroxicloroquina";
            Datos.Personajes[22,0] = "sulfasalazina";
            Datos.Personajes[23,0] = "dexametasona";
            Datos.Personajes[24,0] = "vitamina B12";
            //Tipo
            Datos.Personajes[0,1] = "easy";
            Datos.Personajes[1,1] = "easy";
            Datos.Personajes[2,1] = "easy";
            Datos.Personajes[3,1] = "easy";
            Datos.Personajes[4,1] = "easy";
            Datos.Personajes[5,1] = "easy";
            Datos.Personajes[6,1] = "easy";
            Datos.Personajes[7,1] = "Complex";
            Datos.Personajes[8,1] = "Complex";
            Datos.Personajes[9,1] = "Complex";
            Datos.Personajes[10,1] = "Complex";
            Datos.Personajes[11,1] = "Complex";
            Datos.Personajes[12,1] = "Complex";
            Datos.Personajes[13,1] = "Complex";
            Datos.Personajes[14,1] = "Complex";
            Datos.Personajes[15,1] = "Complex";
            Datos.Personajes[16,1] = "Complex";
            Datos.Personajes[17,1] = "Complex";
            Datos.Personajes[18,1] = "Complex";
            Datos.Personajes[19,1] = "Complex";
            Datos.Personajes[20,1] = "Hard";
            Datos.Personajes[21,1] = "Hard";
            Datos.Personajes[22,1] = "Hard";
            Datos.Personajes[23,1] = "Hard";
            Datos.Personajes[24,1] = "Hard";
            //Cantidad
            Datos.Personajes[0, 2] = "2";
            Datos.Personajes[1, 2] = "0";
            Datos.Personajes[2, 2] = "0";
            Datos.Personajes[3, 2] = "0";
            Datos.Personajes[4, 2] = "0";
            Datos.Personajes[5, 2] = "1";
            Datos.Personajes[6, 2] = "0";
            Datos.Personajes[7, 2] = "0";
            Datos.Personajes[8, 2] = "0";
            Datos.Personajes[9, 2] = "0";
            Datos.Personajes[10, 2] = "0";
            Datos.Personajes[11, 2] = "1";
            Datos.Personajes[12, 2] = "0";
            Datos.Personajes[13, 2] = "0";
            Datos.Personajes[14, 2] = "0";
            Datos.Personajes[15, 2] = "0";
            Datos.Personajes[16, 2] = "0";
            Datos.Personajes[17, 2] = "0";
            Datos.Personajes[18, 2] = "0";
            Datos.Personajes[19, 2] = "0";
            Datos.Personajes[20, 2] = "0";
            Datos.Personajes[21, 2] = "1";
            Datos.Personajes[22, 2] = "1";
            Datos.Personajes[23, 2] = "0";
            Datos.Personajes[24, 2] = "0";
            //Descripciones
            Datos.Personajes[0, 3] = "Más comúnmente conocida como aspirina, nombre de una marca que se popularizó. Aspirina es de gran ayuda contra el dolor, fiebre e inflamación";
            Datos.Personajes[1, 3] = "El paracetamol cuenta con propiedades analgésicas, ayuda también contra el dolor, ya sea leve o moderado, es bueno contra los malestares";
            Datos.Personajes[2, 3] = "Amoxicilina es un antibiótico derivado de la penicilina, es útil para combatir un gran número de espectros de bacterias, se utiliza mayormente para tratar infecciones";
            Datos.Personajes[3, 3] = "Es un antibiótico perteneciente al grupo de las penicilinas, útil para uso intramuscular";
            Datos.Personajes[4, 3] = "Antibiótico utilizado en monoterapia o en conjunto con otros para tratar el linfoma";
            Datos.Personajes[5, 3] = "Medicamento derivado de la talidomina, se ha empleado desde el año 2004 y es útil para tratar el mieloma múltiple y la leucemia";
            Datos.Personajes[6, 3] = "Vorinostato tiene cierta complejidad en cuanto a sus acciones inhibidoras, fue el primero en la historia en ser utilizado para el tratamiento de linfomas";
            Datos.Personajes[7, 3] = "Cluvalanato es un antibiótico que realiza un buen trabajo colaborativo con otros fármacos, en conjunto para bajar la resistencia de bacterias";
            Datos.Personajes[8, 3] = "La Penicilina pertenece al grupo de antibióticos que combaten las infecciones, es de los primeros medicamentos en la historia que se vienen utilizando contra este tipo de tratamiento";
            Datos.Personajes[9, 3] = "La Eritromicina nos será de gran ayuda para impedir que las proteínas en las bacterias se desarrollen, éste compuesto fue encontrado por primera vez en los suelos del archipiélago de las Filipinas";
            Datos.Personajes[10, 3] = "Es considerado un antibiótico de amplio espectro, capaz de inhibir el enzima ADN girasa";
            Datos.Personajes[11, 3] = "Antibiótico útil a la hora de impedir la sintesis de proteínas en las bacterias. Sirve de gran ayuda para mejorar el vaciamiento gástrico";
            Datos.Personajes[12, 3] = "Se utiliza comúnmente para tratar la náusea y vómito y facilitar el vaciamiento gástrico";
            Datos.Personajes[13, 3] = "Es un antibiótico antiinflamatorio, se utiliza para el alivio sintomático del dolor, irritación y molestia en general";
            Datos.Personajes[14, 3] = "Se utiliza principalmente como agente antiinflamatorio en el tratamiento de la enfermedad inflamatoria intestinal";
            Datos.Personajes[15, 3] = "Es un fármaco sintético que se toma generalmente de forma oral, es usado para un gran número de afecciones como la colitis ulcerosa de manera moderada a grave";
            Datos.Personajes[16, 3] = "Es una hormona, cuya principal función es la de incrementar los niveles de azúcar en la sangre y ayudar al metabolismo de las grasas, proteínas y carbohidratos";
            Datos.Personajes[17, 3] = "Es un antibiótico que se ha usado a lo largo de la historia para tratar infecciones bacterianas";
            Datos.Personajes[18, 3] = "Perteneciente al grupo de los antibióticos betalactámicos, éste particular grupo se encarga de bajar la resistencia de agentes bacterianos, útil para la erradicación de acumulaciones sólidas de bilis";
            Datos.Personajes[19, 3] = "Al igual que la Piperacilina, es un agente que debilita la resistencia antimicrobiana de las bacterias. Lo que destaca de éste medicamento es su capacidad de añadirse a otros medicamentos y se presenta generalmente en forma de sal de sodio";
            Datos.Personajes[20, 3] = "Se utiliza en medicina por sus propiedades inmunosupresoras y antiinflamatorias. Por lo que resulta de gran utilidad ante casos de inflamación, hinchazón, calor, enrojecimiento y dolor";
            Datos.Personajes[21, 3] = "Se utiliza para reducir la inflamación en el tratamiento de la artritis reumatoide y del Lupus. Se diferencia de la cloroquina por la presencia de un grupo hidroxilo en el extremo de la cadena lateral";
            Datos.Personajes[22, 3] = "Se utiliza principalmente como agente antiinflamatorio en el tratamiento de la enfermedad inflamatoria intestinal y el artritis reumatoide";
            Datos.Personajes[23, 3] = "	Actúa como antiinflamatorio e inmunosupresor";
            Datos.Personajes[24, 3] = "También se le llama cobalamina gracias a que tiene un elemento muy especial, el cual es el cobalto. Ésta es una vitamina muy importante para el funcionamiento normal del sistema nervioso y de varias proteínas";
          
            fb.Serialize(Informacion, Datos);
            Informacion.Close();
            Debug.Log("Guarde");
        }
    }
    public void Guardar()
    {
        fb.Serialize(Informacion, Datos);
        Informacion.Close();
        Debug.Log("Guarde");
    }
    public void Cargar_Almacen(String Usuario, String [,] Personajes)
    {
        if (File.Exists(Application.persistentDataPath + "/Datos.d"))
        {
            fb = new BinaryFormatter();
            FileStream Informacion = File.OpenRead(Application.persistentDataPath + "/Datos.d");
            Datos = fb.Deserialize(Informacion) as DatosdeJuego;
            //texto = Datos.Text;
            Usuario = Datos.Usuario;
            for (int x = 0; x <4; x++)
            {
                for (int i = 0; i < 25; i++)
                {
                    Personajes[i, x] = Datos.Personajes[i, x];
                }
            }
        }
    }
    public void Borrar()
    {

        if (File.Exists(Application.persistentDataPath + "/Datos.d"))
        {
            File.Delete(Application.persistentDataPath + "/Datos.d");
        }
        else
        {
            Debug.Log("nada que borrar");
        }
    }
}

[Serializable()]
class DatosdeJuego : System.Object
{
    public String Usuario;
    public String [,] Personajes = new String[25, 4];
}