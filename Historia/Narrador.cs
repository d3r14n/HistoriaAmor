using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historia
{
    class Narrador
    {

        int amor = 0;
        int final = 0;

        private void aumentarAmor(int modificadorAmor)
        {
            amor = amor + modificadorAmor;
        }

        private void brokenHeart()
        {
            amor = 0;
        }

        public bool terminarRelacion()
        {
            brokenHeart();
            return true;
        }

        public int contarFinal()
        {
            if (amor < 0)
            {
                final = 1;
            }
            if (amor == 0)
            {
                final = 2;
            }
            if (amor > 0 && amor <= 5)
            {
                final = 3;
            }
            if (amor > 5 && amor <= 10)
            {
                final = 4;
            }
            if (amor > 10 && amor <= 15)
            {
                final = 5;
            }
            if (amor > 15 && amor <= 19)
            {
                final = 6;
            }
            if (amor == 20)
            {
                final = 7;
            }
            return final;
        }

        public string opcion(int numParrafo, char letraOpcion)
        {
            switch (numParrafo)
            {
                case 1:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Continuar";
                            break;
                        case 'B':
                            return "Continuar";
                            break;
                        case 'C':
                            return "Continuar";
                            break;
                        case 'D':
                            return "Continuar";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 0:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Levantarse";
                            break;
                        case 'B':
                            return "Buscar el Celular";
                            break;
                        case 'C':
                            return "5 Minutos Más";
                            break;
                        case 'D':
                            return "Dormir";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 5:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Saludarlo";
                            break;
                        case 'B':
                            return "Ammmm...";
                            break;
                        case 'C':
                            return "Quedarse observando";
                            break;
                        case 'D':
                            return "No hacer nada";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 8:
                    switch(letraOpcion)
                    {
                        case 'A':
                            return "Ir con él";
                            break;
                        case 'B':
                            return "Verlo desde la ventana";
                            break;
                        case 'C':
                            return "Llamar su atención";
                            break;
                        case 'D':
                            return "Ocultarse";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 9:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Contar un chiste";
                            break;
                        case 'B':
                            return "Presentarte";
                            break;
                        case 'C':
                            return "No decir nada";
                            break;
                        case 'D':
                            return "Preguntarle que tiene";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 18:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Presentarte";
                            break;
                        case 'B':
                            return "Invitarlo a sentarse";
                            break;
                        case 'C':
                            return "Saludarlo";
                            break;
                        case 'D':
                            return "Irte";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 19:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Elogiar";
                            break;
                        case 'B':
                            return "Aplaudir";
                            break;
                        case 'C':
                            return "Criticar";
                            break;
                        case 'D':
                            return "Abuchear";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 25:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Unirse a él";
                            break;
                        case 'B':
                            return "Apoyarlo";
                            break;
                        case 'C':
                            return "Ignorarlo";
                            break;
                        case 'D':
                            return "Reírse de él";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 30:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Elegir a Derian";
                            break;
                        case 'B':
                            return "Elegir a Derian";
                            break;
                        case 'C':
                            return "Elegir a Derian";
                            break;
                        case 'D':
                            return "Elegir a Derian";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 32:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Escuchar la canción";
                            break;
                        case 'B':
                            return "Aplaudir";
                            break;
                        case 'C':
                            return "Aplaudir antes";
                            break;
                        case 'D':
                            return "Irte";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 37:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Dejarlo";
                            break;
                        case 'B':
                            return "Seguir";
                            break;
                        case 'C':
                            return "No darle importancia";
                            break;
                        case 'D':
                            return "Buscar un regalo";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 42:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Disculparse";
                            break;
                        case 'B':
                            return "Comprarle algo";
                            break;
                        case 'C':
                            return "No darle importancia";
                            break;
                        case 'D':
                            return "Terminar con él";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                case 47:
                    switch (letraOpcion)
                    {
                        case 'A':
                            return "Siempre con él";
                            break;
                        case 'B':
                            return "Esperar lo mejor";
                            break;
                        case 'C':
                            return "Te da igual";
                            break;
                        case 'D':
                            return "Terminar con él";
                            break;
                        default:
                            return "ERROR";
                            break;
                    }
                    break;

                default:
                    return "¿Khe?";
                    break;
            }
        }

        public string contar(int numParrafo)
        {
            switch (numParrafo)
            {
                case 0:
                    //Inicio de la Historia
                    brokenHeart();
                    return "*Bip* *Bip* *Bip* *Bip* El despertador comenzó a sonar, el sol levemente aparecía al horizonte, \n un nuevo día estaba comenzando. Despertaste en tu cama, el celular se había caido \n debajo de la cama, y seguía sonando, hoy tenías que volver a clases, la idea no te entusiasmaba, \n pero sabías que sólo era cuestión de tiempo para tener que levantarte.";
                    break;

                case 1:
                    //0A: Levantarse
                    return "Te levantas, ves debajo de la cama y quitas la alarma del celular, ya estabas de pie, cambiandote,\n poco a poco el sueño desaparecía. Ya era hora de ir a la escuela, por lo que subiste al auto,\n y después de un viaje llegaste.";
                    break;

                case 2:
                    //0B: Buscar el celular
                    return "Sin levantarte, con la mano tratas de alcanzar el celular, jalas el cable del cargador hasta alcanzar \n el celular, apagas la alarma. Aunque ya no esté sonando, el sueño desapareció, \n el cerrar los ojos ya no te permite volver a dormir, por lo que te levantas y preparas. \n Ya era hora de ir a la escuela, por lo que subiste al auto, \n y después de un viaje llegaste.";
                    break;

                case 3:
                    //0C: 5 Minutos más
                    return "Sin levantarte, con la mano tratas de alcanzar el celular, jalas el cable del cargador hasta alcanzar \n el celular, suspendes la alarma, tratas de dormir un poco más. \n Poco tiempo pasa para que tu madre te grite que se hace tarde, además, \n el celular empieza a sonar nuevamente, abres lentamente los ojos, preparandote para irte, \n Ya era hora de ir a la escuela, por lo que subiste al auto, y después de un viaje llegaste.";
                    break;

                case 4:
                    //0D: Dormir
                    return "No te importa el sonido de la alarma, no quieres levantarte y no lo harás. Poco tiempo pasa para \n que tu madre te grite que se hace tarde, el celular no ha parado de sonar, \n abres lentamente los ojos, preparandote para irte, Ya era hora de ir a la escuela,  \n por lo que subiste al auto, y después de un viaje llegaste.";
                    break;

                case 5:
                    //Llegada a la Escuela
                    return "El sol iluminaba levemente los edificios, pero el frío seguía dominando, llegaste a tu aula, \n algunos de tus compañeros de salón ya habían llegado, pero eso poco te importaba, \n te perdiste en tus pensamientos completamente... en un momento un joven apareció, \n un joven que llamó tu atención, no lo conocías pero había algo \n que hizo que voltearas a verlo";
                    break;

                case 6:
                    //5A: Saludarlo
                    aumentarAmor(-1);
                    return "Vas a saludar al chico, pero al estar frente a el te aterras y no sabes \n que decir, lo saludas a pesar de ello, pero parece que no te hizo caso";
                    break;

                case 7:
                    //5BCD
                    return "El joven se sienta y tu tratas de pensar en otra cosa, esperando la clase. \n Las clases empezaron, tomaste apuntes y todo como siempre en todas tus clases.";
                    break;

                case 8:
                    //Receso
                    return "Inició el receso, todos salieron del salón, tu saliste pero te quedaste a \n pocos metros de la entrada al aula. Cuando te levantaste viste que el joven seguía dentro del salón.";
                    break;

                case 9:
                    //8A: Ir con él
                    aumentarAmor(2);
                    return "Decides ir con él, él te mira, pero pronto desvia la mirada hacía abajo, \n tu te sientas a lado.";
                    break;

                case 10:
                    //8BC: Ventana
                    aumentarAmor(1);
                    return "Él voltea a la ventana, pero no tarda mucho para que haga un mueca, \n una mueca feliz, pero desvía la mirada para abajo.";
                    break;

                case 11:
                    //8D: Ocultarse
                    aumentarAmor(-1);
                    return "Te ocultas, pero por alguna razón sientes que volteó a verte. \n Por lo que decides levantarte e ir con él.";
                    break;

                /*
                case 12:
                    //8BCD: Continuacion de 10 y 11
                    return "La campana suena para volver a clase.";
                    break;
                 */

                case 13:
                    //9A: Contar un chiste
                    aumentarAmor(1);
                    return "Contaste un chiste, él sonrio, no estabas segura de \n si le gustó o no, pensaste que tal vez tu chiste \n era muy tonto. La campana suena para volver a clase.";
                    break;

                case 14:
                    //9B: Presentarte
                    aumentarAmor(2);
                    return "Te presentas, él también lo hace, se llama Derian, un nombre curioso. \n La campana suena para volver a clase.";
                    break;

                case 15:
                    //9C: No decir nada
                    aumentarAmor(1);
                    return "No dices nada, él tampoco, el ambiente se siente un poco... incomodo. \n La campana suena para volver a clase.";
                    break;

                case 16:
                    //9D: Preguntarle que tiene
                    aumentarAmor(-1);
                    return "Le preguntas que tiene, te contesta que nada, aunque no suena seco \n la respuesta suena incompleta. La campana suena para volver a clase.";
                    break;

                case 17:
                    //Salida
                    return "Inician las clases, todo pasa normal.\n  Cuando acaban las clases esperas a que pasen por ti, mientras algunos \n de tus compañeros te acompañaron, personas que con el tiempo se convirtieron en tus amigos.";
                    break;

                case 18:
                    //Presentación
                    return "Durante la primer semana, un día cualquiera, mientras era el receso, el joven \n llegó con una guitarra, se presentó ante a ti y tus amigos que \n ahi se encontraban también.";
                    break;

                case 19:
                    //18ABCD:
                    aumentarAmor(1);
                    return "Antes de que puedas hacer algo, tu amiga le llama la atención la guitarra, \n el joven se sienta con ustedes y se pone a tocar la guitarra";
                    break;

                case 20:
                    //19A: Elogiar
                    aumentarAmor(1);
                    return "El joven parece sonrojarse, tus demas amigos también lo elogian por \n la manera en que tocó. A partir de ese día todos se hicieron amigos";
                    break;

                case 21:
                    //19B: Aplaudir
                    aumentarAmor(2);
                    return "Todos aplauden, el joven agradece el gesto. A partir de ese día todos se hicieron amigos.";
                    break;

                case 22:
                    //19C: Criticar
                    return "\"Entiendo que puedo mejorar\" contesta el joven, tu amiga le dice \n que tocó muy bien, el joven reitera que él no es bueno. \n El joven empezó a juntarse con ustedes.";
                    break;

                case 23:
                    //19D: Abuchear
                    aumentarAmor(-1);
                    return "\"Gracias, gracias\" contesta el joven a modo de burla, todos se ríen. \n A partir de ese día todos se hicieron amigos.";
                    break;

                case 24:
                    //Tiempo después
                    return "El tiempo ha pasado, el joven, llamado Derian, pasa tiempo con ustedes. \n Y así pasaron los meses, hasta que empezó febrero. \n Se acercaba el día de amor, 14 de febrero y no tienes novio.";
                    break;

                case 25:
                    //Twitter
                    return "Junto con tus amigos, deciden formar un hashtag a modo de broma \n #HoySaldreAMolestarParejas, curiosamente el joven se une \n a tu campaña, llevando pancartas y carteles, parece que \n se lo toma muy en serio.";
                    break;

                case 26:
                    //25A: Unirse a él
                    aumentarAmor(3);
                    return "Sonriendo decides hacer locuras con él, ayudandolo con sus carteles y \n demas papeles que pega por toda la escuela.";
                    break;

                case 27:
                    //25B: Apoyarlo
                    aumentarAmor(2);
                    return "Es divertido como algo que empezaste llenó de tanta energía a aquel joven \n que no salía ni hablaba con nadie, eso te hizo \n sentir muy bien.";
                    break;

                case 28:
                    //25C: Ignorarlo
                    aumentarAmor(1);
                    return "Lo que él decida hacer es su onda, lo que tú hagas es la tuya.";
                    break;

                case 29:
                    //25D: Reírse de él
                    aumentarAmor(-3);
                    return "Te ríes del ridiculo que hace, la gente raya sus papeles y nadie le hace \n caso, todos lo toman como un loco que gastó papel \n en algo que sólo era un tuit.";
                    break;

                case 30:
                    //Evelyng
                    return "Algunas otras personas también iniciaron a usar el hashtag, no muchas, \n pero unas cuantas. Ya casi no faltaba nada para el 14 de \n febrero. Una de tus amigas tuvo la idea de tener un novio falso durante la \n fecha únicamente. Decidiste únirte a su plan.";
                    break;

                case 31:
                    //30ABCD: Elegir a Derian
                    aumentarAmor(1);
                    return "Elegiste a Derian. Tú amiga también eligió a Derian.";
                    break;

                case 32:
                    //14 de Febrero
                    return "14 de febrero. El noviazgo falso inició el 13 de febrero, ambas esperaban \n un regalo para el día de san valentín, y Derian \n les dió un regalo, una canción.";
                    break;

                case 33:
                    //32A: Escuchar la canción
                    return "Escuchaste la canción, no la habías escuchado antes, pero era una bonita \n canción.";
                    break;

                case 34:
                    //32B: Aplaudir
                    aumentarAmor(2);
                    return "Tras escuchar la canción aplaudiste, era una bonita canción, y el sentimiento \n con la que la tocó le dio un toque especial.";
                    break;

                case 35:
                    //32C: Apludir antes
                    aumentarAmor(-1);
                    return "Aplaudiste antes de que Derian acabara su canción, la mueca en su rostro \n mostró que no le agradó que lo interrumpieras.";
                    break;

                case 36:
                    //32D: Irte
                    return "Te vas antes de que acabe de tocar, Derian sigue tocando la canción \n a tu amiga.";
                    break;

                case 37:
                    //Al día siguiente
                    return "Al día siguiente, tu amiga dejó a Derian.";
                    break;

                case 38:
                    //37A: Dejarlo TERMINAR
                    return "Terminas la relación falsa con él.";
                    break;

                case 39:
                    //37B: Seguir
                    aumentarAmor(1);
                    return "Sigues en la relación con él, puedes conseguir un regalo \n del mes.";
                    break;

                case 40:
                    //37C: No darle importancia
                    return "No haces caso, casi olvidas que sigue siendo tu \"novio\"";
                    break;

                case 41:
                    //37D: Buscar un regalo
                    aumentarAmor(3);
                    return "Buscas un regalo para darle, algo tarde pero vale por \n el 14 de febrero, decides darle unos dulces. Se ve feliz.";
                    break;

                case 42:
                    //Primer Mes
                    return "Llevan un mes, es 13 de marzo, Derian te regala un \n corazón de papel.";
                    break;

                case 43:
                    //42A: Disculparse
                    return "Te disculpas por no haber traido un regalo \n él te dice que no pasa nada.";
                    break;

                case 44:
                    //42B: Comprarle algo
                    aumentarAmor(1);
                    return "No habías preparado ningún regalo, pero le  \n compras algo, él sonrie.";
                    break;

                case 45:
                    //42C: No dar importancia
                    return "Si él decidió darte algo es su  problema.";
                    break;

                case 46:
                    //42D: Terminar con él TERMINAR
                    return "Terminas la relacion con él.";
                    break;

                case 47:
                    //Decision Final
                    return "Después de un tiempo juntos, han vivido muchas cosas \n y ahora debes decidir que quieres hacer: ";
                    break;

                case 48:
                    //47A: Siempre con él
                    aumentarAmor(3);
                    return "Decides quedarte siempre con Derian, a pesar \n de todo lo que pase.";
                    break;

                case 49:
                    //47B: Esperar lo mejor
                    return "Seguiras con él, esperas que pase lo mejor \n para los dos.";
                    break;

                case 50:
                    //47C: Te da igual
                    aumentarAmor(-4);
                    return "No te importa, no le das importancia.";
                    break;

                case 51:
                    //47D: Terminar TERMINAR
                    return "Terminas la relación con él.";
                    break;

                    //FINALES

                    //Final Malo
                case 60:
                    return "La relación siguió por un tiempo,  \n Derian era buena persona contigo pero tú no le hacías \n caso... un día se cansó y cortó contigo. \n FINAL MALO";
                    break;
                    //Final Malo Neutral
                case 61:
                    return "Terminaron. Cada quien siguió su camino. \n TERMINARON. FINAL MALO";
                    break;
                    //Final Neutral
                case 62:
                    return "Fue un duro comienzo, siguieron su \n relación, aunque no convivian mucho, seguían \n viendose, y de vez en cuando, dando algún \n detalle uno al otro. \n FINAL NEUTRAL";
                    break;
                    //Final Bueno Neutral
                case 63:
                    return "Se quieren, y es una relación que todos \n notan, se vuelven una linda pareja. \n FINAL NEUTRAL";
                    break;
                    //Final Bueno
                case 64:
                    return "Se vuelven muy cursis, y Derian te hace muy \n feliz, hacen locuras de vez en cuando \n y pasan muchos momentos muy bellos. \n FINAL BUENO";
                    break;
                    //Final Muy Bueno
                case 65:
                    return "Pasan los años y siguen juntos y felices \n hay regalos, bellos momentos, risas, juegos y \n mucho mucho amor, sientes que no \n habías sido asi de feliz antes. \n FINAL BUENO";
                    break;
                    //Final Perfecto
                case 66:
                    return "Se vuelven una pareja conocida en la escuela \n van a la universidad, y aunque no se ven \n tanto como antes, se siguen demostrando su \n amor, pasan los años y no dejan de estar enamorados. \n Se casan. Tienen una hija, y viven felices en su casa. Por siempre. \n EL FIN.";
                    break;

                default:
                    //Caso Default, fin inesperado de la historia, en caso de un error de programación
                    return "Un agujero negro apareció, al parecer la estructura espacio-tiempo se ha roto, \n algo dentro o fuera del universo ha desequilibrado el mundo como lo conocemos... \n nadie sabe que pasará... \n probablemente el universo colapsará y éste desaparecerá... \n tal vez en algún momento todo se reiniciará y volverá a existir...";
                    break;
            }
        }

    }
}
