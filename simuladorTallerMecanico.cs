

using System;

public class mecanica {
    public static void Main(string[] args) {
        Console.Write("Bienvenido al Simulador De Taller Mecanico, porfavor escriba su nombre de usuario ");
        
        /* Declaramos variables, validador, nombre del usuario,entrada,aviso, 
        dinero, cuota, dia, dias para la cuota,reputacion, experiencia, bonificacionDeExito y bonificacion de dinero 
        Explicacion de variables: 
        */
        bool menu = true; //booleano para manejo del menu
        bool validador = false; // el validador, este bool es el encargado en validar todo 
        string nombre = ValidarNombre(); // nombre de usuario
        string entrada = ""; // es el control del jugador lector de inputs
        string aviso = ""; // variable que se actualiza depende del error que se interponga
        int dinero = 0; // saldo del jugador
        int cuota = 0; // la cuota que debe llegar el jugador
        int dia = 1; // dia, un auto equivale a un dia
        int diasParaLaCuota = 0; // dias para llegar a la cuota 
        int reputacion = 1; // reputacion, mientras mas alto sea este numero mejores encargos de vehiculos
        int experiencia = 0; // experiencia, es como una moneda para comprar bonus
        
        int bonificacionDeExito = 1; // bonus de exito con este los encargos vienen con un mejor numero minimo 
        int bonificacionDeDineroPorEncargo = 0;// bonus de dinero por encargo 
        //-----------------------//
        
        /* declaramos random,la clase,  pago, costoDePiezas, el porcentaje de exito del jugador, 
        bonus, si es vehiculo especial, penalizacion, porcentaje de exito
        */
        Random rd = new Random();
        int numeroRandom = 0; // gracias a esta variable se genera todo lo que es aleatorio casi todo en el programa 
        string clase = ""; // clase del vehiculo 
        int pago = 0;// pago del cliente 
        int costoDePiezas = 0; // costo de piezas 
        int porcentajeDeExitoDeJugador = rd.Next(1,101); // el dado del jugador, estas son las probablidades del jugador 
        int bonus= 0; // bonus por encargo especial 
        bool esVehiculoEspecial = false; // se usa si un vehiculo es especial, con esta variable varian los precios y probabilidades
        int penalizacion = 0; // penalizacion por fallar las reparaciones 
        int porcentajeDeExito= 0; // porcentaje de exito de la computadora 
        //-----------------------//  
        //-----------------------//
        
        Console.WriteLine("=============================");
        Console.WriteLine("/////////////////////////////");
        Console.WriteLine("=============================");
        Console.WriteLine("");
        Console.WriteLine(" SIMULADOR DE TALLER MECANICO");
        Console.WriteLine("");
        Console.WriteLine("=============================");
        Console.WriteLine("/////////////////////////////");
        Console.WriteLine("=============================");
        Console.WriteLine("");

        /*
            Menu: utilizamos el switch, en la entrada recibe un string que escribe el jugador, relacionamos su string con su case, si es:
            1: Empezar a jugar: se actualiza la variable menu en false y sale de este bucle de elegir opciones y pasa a jugar.
            2: Configuracion: Aca hay dos opciones, cambiar nombre o volver, utilizamos otro switch adentro
                y preguntamos nuevamente el input por la entrada, si es 1, 
                    se le consulta el nombre al usuario otra vez dentro de un bucle while, 
                    esto es para evitar errores de validacion. 
                    Una vez que es correcto el usuario sale por el validador que esta en false
            3: Como jugar, basicamente texto para indicar como se juega.
            4: Creditos: Se imprime unos consolines de los creditos, nuevamente un bucle while con la variable validador para evitar errores de input
            5: Salir: se imprimen unos textos de agradecimiento lo importante es que aca utilizo Environment.Exit(0), gracias a esta linea se termina la ejecucion del programa.
        */
        while(menu)
        {
            
            Console.WriteLine("[1] Empezar a Jugar");
            Console.WriteLine("[2] Configuracion");
            Console.WriteLine("[3] Como Jugar");
            Console.WriteLine("[4] Creditos");
            Console.WriteLine("[5] Salir");
            
            entrada = Console.ReadLine().ToLower();
            switch(entrada)
            {
                case "1":
                    menu = false;
                    break;
                
                case "2":
                    Console.WriteLine("[1] Cambiar nombre de usuario");
                    Console.WriteLine("[2] Volver al menu principal");
                    validador = true;
                    while(validador)
                    {
                        entrada = Console.ReadLine().ToLower();
                        switch(entrada)
                        {
                                case "1":
                                        Console.WriteLine("");
                                        Console.WriteLine(nombre+ " Escribi tu nuevo nombre de usuario");
                                        validador = true;      
                                        while(validador)
                                        {
                                            nombre = Console.ReadLine();
                                            if(nombre.Length < 4|| nombre.Length>20)
                                            {
                                                Console.WriteLine("Escribi un nombre de 4 caracteres minimo y 20 como maximo. Reintenta otra vez");       
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Cambiaste tu nombre de usuario a "+ nombre+ " Correctamente ");
                                                Console.WriteLine("");
                                                validador = false;
                                            }
                                        }                                        
                                        break;
                                    
                                case "2":
                                        validador = false;
                                        break;
                                    
                                default:
                                        Console.WriteLine("Tecla incorrecta");
                                        break;         
                        }
                    }
                    break;
                case "3":
                    Tutorial();
                    Console.WriteLine("[1] Volver al menu principal");
                    validador = true;
                    while(validador)
                    {
                        entrada = Console.ReadLine().ToLower();
                        switch(entrada)
                        {
                            case "1":
                                    validador = false;
                                    break;
                            default:
                                Console.WriteLine("Tecla incorrecta");
                                break;
                                
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("");
                    Console.WriteLine("Creditos:");
                    Console.WriteLine("");
                    Console.WriteLine("Alumno: Juan Pablo Cespedes");
                    Console.WriteLine("Desarollado en el compilador C# de Programiz ");
                    Console.WriteLine("Universidad: Universidad Nacional Hurlingham ");
                    Console.WriteLine("");
                    Console.WriteLine("[1] Volver al menu principal");
                    validador = true;
                    while(validador)
                    {
                        entrada = Console.ReadLine().ToLower();
                        switch(entrada)
                        {
                            case "1":
                                    validador = false;
                                    break;
                            default:
                                Console.WriteLine("Tecla incorrecta");
                                break;
                                
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("");
                    Console.WriteLine("Muchas Gracias Por Jugar "+nombre+" Juego Creado Por: Juan Pablo Cespedes");
                    Console.WriteLine("");
                    menu = false;
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Tecla incorrecta");
                    Console.WriteLine("");
                    break;
            }
        }
        //-----------------------------------------//
        
            Console.WriteLine( nombre + " Selecciona La Dificultad");      
            Console.WriteLine( "[1] Facil");
            Console.WriteLine( "[2] Medio");
            Console.WriteLine( "[3] Dificil");
        // desactivamos la variable para poder reutilzarla y validar la dificultad.
        validador = false;
        // nuevamente validamos la dificultad, tiene que ser un input de los que se menciona 
        while(!validador)
        {
            entrada = Console.ReadLine().ToLower();
            if(entrada != "1" && entrada != "2" && entrada != "3")
            {
                Console.WriteLine("Escribi una dificultad adecuada, reintenta otra vez");
            }
            else
            {
                validador = true;
            }
        }
        //-----------------------//
        
        /* utilizamos este switch para seleccionar su dificultad, 
        asi relacionando y asignando sus variables dinero,cuota, reputacion y dias conforme la dificultad
        Entonces depende de la dificultand varian estas variables.
        */
        switch(entrada)
        {
            case "1":
                    dinero = 2000;
                    cuota = 10000;
                    reputacion = 2;
                    diasParaLaCuota = 25;
                    break;
                
            case "2":
                    dinero = 1500;
                    cuota = 25000;
                    diasParaLaCuota = 20;
                    break;
                
            default :
                    dinero = 1000;
                    cuota = 30000;
                    diasParaLaCuota = 15;
                    break;   
        }
        //-----------------------//
        
        /* Aca empieza la magia, en este bloque es donde el jugador entra en bucle, donde termina cuando gana cumpliendo la cuota o pierde con su saldo en negativo o no Llego a la cuota de dinero esperada.
        */
        do
            {
            /*
                en este bloque, el validador vuelve a falso. Esto es porque cada intento se sale del bucle con true y vuelve en false.
                Inicializamos variables para el bucle
                validador en falso
                Es vehiculo especial en falso
                el porcentaje de exito, aleatorio cada ronda
                numeroRandom = vehiculo que sale conforme la reputacion en el switch de abajo
            */
                
                validador = false;
                esVehiculoEspecial = false;
                porcentajeDeExitoDeJugador = rd.Next(1,101);
                numeroRandom = rd.Next(reputacion,10);
                
                Console.WriteLine("==================================================");
                Console.WriteLine("MECANICO: "+nombre+" | DIA:"+dia+"/"+ diasParaLaCuota+" | SALDO: $"+dinero);
                Console.WriteLine("CUOTA A ALCANZAR: $"+ cuota + " | REPUTACION "+ reputacion +" | EXP:"+experiencia);
                Console.WriteLine("==================================================");
            
                //-----------------------//
            
                /*Generamos un auto aleatorio con la variable de numeroRandom, se define su clase y se asignan a las variables:
                si es vehiculo especial, clase, coste de piezas, pago, penalizacion y probabilidad de exito.
                Hay 4 casos de vehiculos clase C
                Hay 3 casos de vehiculos clase B
                Hay 2 casos de vehiculos clase A
                Por cada clase hay un caso especial donde su reparacion Exitosa tiene un bonus de reputacion, dinero y experiencia
                y bueno aca ya estan incorporadas las variables de bonificacion.
            */  
                switch(numeroRandom)
                {
                    case 1:
                    case 2:
                    case 3:
                        clase = "C";
                        costoDePiezas = rd.Next(25,500);
                        pago = rd.Next(costoDePiezas+100,900);
                        pago = pago + (pago * bonificacionDeDineroPorEncargo /100);
                        penalizacion = 3;
                        porcentajeDeExito= rd.Next(35 + bonificacionDeExito,101);
                        break;
                    case 4:
                        esVehiculoEspecial = true;
                        clase = "C";
                        costoDePiezas = rd.Next(350,700);
                        pago = rd.Next(costoDePiezas+200,1500);
                        pago = pago + (pago * bonificacionDeDineroPorEncargo /100);
                        bonus = 1000;
                        penalizacion = 3;
                        porcentajeDeExito= rd.Next(30 + bonificacionDeExito,101);
                        break;             
                    case 5:
                    case 6:
                        clase = "B";
                        costoDePiezas = rd.Next(500,1000);
                        pago = rd.Next(costoDePiezas+250,2500);
                        pago = pago + (pago * bonificacionDeDineroPorEncargo /100);
                        penalizacion = 2;
                        porcentajeDeExito= rd.Next(25 + bonificacionDeExito,101);
                        break;
                    case 7:
                        esVehiculoEspecial = true;
                        clase = "B";
                        costoDePiezas = rd.Next(700,1500);
                        pago = rd.Next(costoDePiezas+300,3500);
                        pago = pago + (pago * bonificacionDeDineroPorEncargo /100);                        
                        bonus = 2000;
                        penalizacion = 2;
                        porcentajeDeExito= rd.Next(15+ bonificacionDeExito,101);
                        break;
                    case 8:
                        clase = "A";
                        costoDePiezas = rd.Next(800,2000);
                        pago = rd.Next(costoDePiezas+400,5000);
                        pago = pago + (pago * bonificacionDeDineroPorEncargo /100);
                        penalizacion = 1;
                        porcentajeDeExito= rd.Next(10 + bonificacionDeExito,101);
                        break;
                    default:
                        esVehiculoEspecial = true;
                        clase = "A";
                        costoDePiezas = rd.Next(1200,3000);
                        pago = rd.Next(costoDePiezas+700,7000);
                        pago = pago + (pago * bonificacionDeDineroPorEncargo /100);
                        bonus = 3000;
                        penalizacion = 1;
                        porcentajeDeExito= rd.Next(5 + bonificacionDeExito,101);
                        break;
                }
                ///--------------------------------------///
            
                /// Indicadores de estado con sus respectivas variables ///
                Console.WriteLine("-----------------------------");
                
                if(esVehiculoEspecial)
                {
                    Console.WriteLine(nombre + " En su taller llega un Vehiculo Especial de clase "+ clase);
                    Console.WriteLine("Su Reparacion exitosa Otorga un Bonus $$$ y Reputacion");
                    Console.WriteLine("Coste de arreglo: $"+costoDePiezas);
                    Console.WriteLine("Pago del cliente: $"+pago+ " Bonus $"+bonus);
                    Console.WriteLine("Ganancia Total Con Piezas Nuevas $"+((pago-costoDePiezas)+ bonus));
                    Console.WriteLine("Ganancia Total Con Piezas Usadas $"+((pago-costoDePiezas/2)+ bonus));
                }
                else{
                    Console.WriteLine(nombre + " En su taller llega un Vehiculo de clase "+ clase);
                    Console.WriteLine("Coste de arreglo: $"+costoDePiezas);
                    Console.WriteLine("Pago del cliente: $"+pago);
                    Console.WriteLine("Ganancia Total Con Piezas Nuevas $"+((pago-costoDePiezas)+ bonus));
                    Console.WriteLine("Ganancia Total Con Piezas Usadas $"+((pago-costoDePiezas/2)+ bonus));
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Porcentaje de Exito de reparacion con piezas nuevas: %"+porcentajeDeExito);
                numeroRandom = rd.Next(1,porcentajeDeExito+1); // porcentaje de piezas usadas
                Console.WriteLine("Porcentaje de Exito de reparacion con piezas usadas: %"+numeroRandom);
                Console.WriteLine("-----------------------------");
                ///--------------------------------------///
            
                /* En este bloque, asignamos con unos writeline los controles, utilizamos la entrada
                para asignar su eleccion mediante un switch con su respectivo case.
                Donde los casos que pueden ser 
                1: repararcon piezas nuevas con sus respectivos costoDePiezas
                2: reparar con piezas usadas con sus respectivos costoDePiezas esta vez divido por 2 
                3: Rechazar vehiculo, saltea el dia 
                Default: vuelve el bucle si utiliza un boton incorrecto o no dispone de fondos suficientes.

                En las opciones 1 y 2 sucede esto: el dia se actualiza, se actualzia la variable de exp y se resta el saldo o suma.
    
                Luego si la exp es >= 5 se muestran nuevas opciones de mejoras.
                
                4: Mejora de bonificaion en reparaciones exitocas
                5: Mejora de bonificacion en probablidades de exito
                6: Mejora de reputacion esta cuesta 10exp
                7: caso especial si no puede comprar las piezas usadas, se juega todo el dinero para ganar un bonus y dinero
                Luego de su seleccion, sea cual sea de estas 3, con la variable validador en true pasamos al siguiente dia y salimos de este bucle para volver devulta a elegir otro vehiculo generado aleatoriamente.
            
                Internamente:
                    utilizamos el if para validar las probablidades de exito conforme el numero random que 
                    salio de su respectiva clase, y si las probablidades son menor o igual, la reparacion es un exito.
                    Si la reparacion es un exito con piezas nuevas : se resta el dinero con las piezas nuevas, y se
                    le paga y da exp, si es un auto especial se le asigna un bonus de dinero y se suma su reputacion,se suma 1 de experiencia 
                    
                    si la reparacion es un exito con piezas usadas : es lo mismo nada mas que el coste de piezas 
                    se divide por 2,se suma 1 de experiencia 
    
                    si la reparacion no es un exito, se resta conforme la variable de su penalizacion en la clase 
                    de su vehiculo asignado y se suma 1 de experiencia 
                    En casos de mejora, se actualizan su variables correspondientes y vuelve al bucle para eleigr una opcion de las principales sea 1,2 o 3
                
                */
                while(!validador)
                {
                    aviso = "Ingresa una tecla valida, reintenta otra vez";
                    Console.WriteLine("[1] Reparar vehiculo con piezas nuevas $"+ costoDePiezas);
                    Console.WriteLine("[2] Reparar vehiculo con piezas usadas $"+ costoDePiezas/2);
                    Console.WriteLine("[3] Rechazar vehiculo");
                    if(experiencia - 5 >=0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Tenes "+experiencia+"EXP podes gastarla en las siguientes mejoras");
                        Console.WriteLine("[4] Gastar 5exp para obtener un +5% en reparaciones exitosas. Actualmente tenes +%"+bonificacionDeExito);
                        Console.WriteLine("[5] Gastar 5exp para obtener un +5% de dinero por encargo. Actualmente tenes +%"+bonificacionDeDineroPorEncargo);
                        Console.WriteLine("[6] Gastar 10exp para comprar +1 de reputacion");
                        Console.WriteLine("-----------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------");
                    }
                    
                    if(dinero <=costoDePiezas/ 2 )
                    {
                        Console.WriteLine("[7] TODO o NADA repara este vehiculo con todo tu dinero Porcentaje de exito %??");     
                    }
                    
                    entrada = Console.ReadLine().ToLower();
                    if(entrada == "1" && dinero < costoDePiezas || entrada == "2"&&dinero <costoDePiezas/2)
                    {
                        aviso = "No podes pagar el precio de las piezas";
                        entrada = "9";
                    }
                    if(entrada =="7" && dinero>costoDePiezas/2)
                    {
                        aviso = "Tecla Incorrecta";
                        entrada = "9";
                    }
                        
                    switch(entrada)
                    {
                        case "1":
                                validador = true;
                                dia++;
                                experiencia = experiencia + 1;
                                if(porcentajeDeExitoDeJugador<= porcentajeDeExito)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Reparacion realizada con exito, Le pagaron  $"+ (pago+bonus));
                                    Console.WriteLine("");
                                    dinero = (dinero - costoDePiezas) + pago + bonus;
                                    if( esVehiculoEspecial && reputacion < 8)
                                    {
                                        experiencia = experiencia + 1;
                                        reputacion++;
                                    }
                                    else
                                    {
                                        experiencia = experiencia + 1;
                                    }
                                }
                                else
                                {
                                    dia++;
                                    Console.WriteLine("");
                                    Console.WriteLine("Reparacion fallada, Rompiste Piezas Nuevas, se te descuentan $"+ costoDePiezas / penalizacion);
                                    Console.WriteLine("");
                                    dinero = dinero - costoDePiezas / penalizacion;
                                }
                                break;
                        case "2":
                                validador = true;
                                dia++;
                                experiencia = experiencia + 1;
                                if(porcentajeDeExitoDeJugador<= numeroRandom)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Reparacion realizada con exito, le pagaron  $"+ (pago+bonus));
                                    Console.WriteLine("");
                                    dinero = (dinero - costoDePiezas / 2) + pago + bonus;
                                    if( esVehiculoEspecial && reputacion < 8)
                                    {
                                        experiencia = experiencia + 1;
                                        reputacion++;
                                    }
                                    else
                                    {
                                        experiencia = experiencia + 1;
                                    }
                                }
                                else
                                {
                                    dia++;
                                    Console.WriteLine("");
                                    Console.WriteLine("Reparacion fallada, rompiste piezas, se te descuentan $"+ costoDePiezas / penalizacion);
                                    Console.WriteLine("");
                                    dinero = dinero - costoDePiezas / penalizacion;
                                }
                                break;
                        case "3":
                                dia++;
                                validador = true;
                                Console.WriteLine("");
                                Console.WriteLine("Usted Rechazo el Trabajo");
                                Console.WriteLine("");
                                break;
                        case "4":
                                if(experiencia - 5 >=0 && bonificacionDeExito <26)
                                {
                                    experiencia = experiencia -5;
                                    bonificacionDeExito = bonificacionDeExito + 5;
                                    porcentajeDeExito = porcentajeDeExito + 5;
                                    numeroRandom = numeroRandom + 5;
                                    Console.WriteLine("Usted Compro un +5% en reparaciones exitosas ");
                                    Console.WriteLine("");
                                    Console.WriteLine("Nuevos Porcentajes de Exito de reparacion con piezas nuevas: %"+porcentajeDeExito);
                
                Console.WriteLine("Nuevos Porcentajes de Exito de reparacion con piezas usadas: %"+numeroRandom);
                                    Console.WriteLine("-----------------------------");                                                                   
                                }
                                else
                                {
                                    if(bonificacionDeExito>=26)
                                    {
                                        aviso= "Alcanzaste el bonus maximo de mejoras de exito";
                                    }
                                    Console.WriteLine(aviso);
                                    Console.WriteLine("");
                                    entrada = "9";
                                }
                                break;
                        case "5":
                                if(experiencia - 5 >=0)
                                {
                                    experiencia = experiencia -5;
                                    bonificacionDeDineroPorEncargo = bonificacionDeDineroPorEncargo + 5;
                                    pago = pago + (pago * bonificacionDeDineroPorEncargo /100);
                                    Console.WriteLine("Usted Compro un +5% en encargos ");
                                    Console.WriteLine("Nueva Ganancia Total Con Piezas Nuevas $"+((pago-costoDePiezas)+ bonus));
                    Console.WriteLine("Nueva Ganancia Total Con Piezas Usadas $"+((pago-costoDePiezas/2)+ bonus));
                                    Console.WriteLine("-----------------------------");     
                                }
                                else
                                {
                                    Console.WriteLine(aviso);
                                    Console.WriteLine("");
                                    entrada = "9";
                                }
                                break;
                        case "6":
                                if(experiencia - 10 >=0 && reputacion <8)
                                {
                                    experiencia = experiencia -10;
                                    Console.WriteLine("Usted Compro +1 de Reputacion ");
                                    reputacion = reputacion + 1;
                                    
                                }
                                else
                                {
                                    if(experiencia>=5 && experiencia <10)
                                    {
                                        
                                    aviso = "No tenes suficiente experiencia para comprar esta mejora";
                                    }
                                    if(experiencia -10 >=0 && reputacion == 8)
                                    {
                                        aviso = "Alcanzaste el limite de Reputacion";
                                    }
                                    Console.WriteLine(aviso);
                                    Console.WriteLine("");
                                    entrada = "9";
                                }
                                break;
                        case "7":
                                validador = true;
                                dia++;
                                experiencia = experiencia + 2;
                                if(porcentajeDeExitoDeJugador<= porcentajeDeExito)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Reparacion realizada con exito, le pagaron  $"+ (pago+bonus+1500));
                                    Console.WriteLine("Bonus de TODO o NADA, +$1500");
                                    Console.WriteLine("");
                                    dinero = (dinero - dinero) + pago + 1500+ bonus;
                                    if( esVehiculoEspecial && reputacion < 8)
                                    {
                                        experiencia = experiencia + 1;
                                        reputacion++;
                                    }
                                    else
                                    {
                                        experiencia = experiencia + 1;
                                    }
                                }
                                else
                                {
                                    dia++;
                                    Console.WriteLine("");
                                    Console.WriteLine("Reparacion Fallada, Rompiste TODO, se te descuenta todo tu dinero $"+ (dinero - dinero));
                                    Console.WriteLine("");
                                    dinero = dinero - dinero;
                                }
                            break;
                        default:
                                Console.WriteLine("");
                                Console.WriteLine(aviso);
                                Console.WriteLine("");
                                break;
                    }
                }
          ///--------------------------------------///
             
         }while(dinero >0 && dia <= diasParaLaCuota && dinero <= cuota);
    /*
        Dependa como fue el rendimiento en la partida, se muestran distintos mensajes personalizados a la situacion.
        basicamente comparamos variables con otras y asi sabemos la situacion por la cual perdio.
    */
    if(dinero<=0)
            {
                Console.WriteLine(nombre + " Perdiste, te quedaste sin dinero para comprar piezas");
            }
    else if (dinero>= cuota)
            {
            Console.WriteLine("Felicitaciones "+nombre+ " GANASTE!,Llegaste a la meta de la cuota con exito $"+ dinero+ "//$"+cuota+ " fuiste un gran mecanico, con "+ ((diasParaLaCuota - dia)+ 1) +" dias restantes");
            }
    else{
            Console.WriteLine(nombre +" Perdiste, llego el dia de la cuota y no llegaste a la cantidad de dinero propuesta "+cuota +"///"+ dinero);
            }
    
Console.WriteLine("");
Console.WriteLine("Muchas Gracias Por Jugar "+nombre+" Juego Creado Por: Juan Pablo Cespedes");
Console.WriteLine("");
    }
   static string ValidarNombre()
    {
        string nombre;
        while(true)
        {
            nombre = Console.ReadLine();
            if(nombre.Length < 4|| nombre.Length>20)
            {
                Console.WriteLine("Escribi un nombre de 4 caracteres minimo y 20 como maximo,Reintenta otra vez");       
            }
            else
            {
                return nombre;
            }
        }
    }
    static void Tutorial()
    {
                    Console.WriteLine("");
                    Console.WriteLine("Tutorial Completo");
                    Console.WriteLine("");
                    Console.WriteLine("Jugabilidad: Presiona el boton indicado y despues ENTER");
                    Console.WriteLine("");
                    Console.WriteLine("El juego se basa en llegar a una cuota de dinero en una cantidad de dias predefiniadas por la dificultad,deberas decidir, Si:" );
                    Console.WriteLine("[1] Reparar Vehiculo con piezas nuevas");
                    Console.WriteLine("[2] Utilizar piezas usadas para arreglarlo");
                    Console.WriteLine("[3] Rechazar vehiculo");
                    Console.WriteLine("Lo interesante es Ver las probablidades de exito  que hay en el momento y ver que opcion te conviene mas para ganar mas dinero o bien o  no arriesgar y saltear el dia.");
                    Console.WriteLine("Si arriesgaste de mas no hay problema, tenes tu ultimo tiro de suerte con:");
                    Console.WriteLine("[7] TODO o NADA, Consiste en gastar todo tu dinero para poder reparar el vehiculo y reponerte con un bonus especial de $$$, Caso contrario Perdes directamente.");
                    Console.WriteLine("Nota: este input solo aparece cuando tu dinero es menor que el coste de piezas usadas");
                    Console.WriteLine("");
                    Console.WriteLine("Recompensas:");                
                    Console.WriteLine("Si reparas correctamente un vehiculo estandar, obtenes experiencia y la paga");
                    Console.WriteLine("Si reparas correctamente un vehiculo ESPECIAL, obtenes el doble de experiencia, la paga con bonus y ganas + 1 de reputacion Maximo 6");
                    Console.WriteLine("Caso contrario si fallas durante la reparacion se te descuentan las piezas sean Nuevas o Usadas y por supuesto ganas +1 de experiencia");
                    Console.WriteLine("Cada dia tenes un vehiculo para arreglar si lo rechazas, perdes el dia.");
                    Console.WriteLine("");
                    Console.WriteLine("ELEMENTOS DE HUD:");
                    Console.WriteLine("DIA: el dia actual / dia de la fecha ");
                    Console.WriteLine("SALDO: tu dinero para reparar vehiculos ");
                    Console.WriteLine("CUOTA: a alcanzar : la meta de la cuota ");
                    Console.WriteLine("REPUTACION: a medida que arregles vehiculos especiales o compres una mejora de reputacion se aumenta, Con un maximo de 8");
                    Console.WriteLine("EXP: la experiencia ");
                    Console.WriteLine("");
                    Console.WriteLine("MEJORAS:");
                    Console.WriteLine("Cuando tenes 5exp podes comprar una bonificacion:");
                    Console.WriteLine(" +%5 Bonificacion de probabilidades de exito, maximo 5 compras de este mismo");
                    Console.WriteLine(" +%5 Bonificacion de bonus de dinero por encargo,sin limite");
                    Console.WriteLine("O Cuando tenes 10xp podes comprar Reputacion, maximo 8");
                    Console.WriteLine("");  
    }

}