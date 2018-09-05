﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmon
{
    class Program
    {
        static void Main()
        {
            //objetos necesarios en el juego
            Poder Ember = new Poder(10, 1, "Fuego", null, "Ember");
            Poder FireFang = new Poder(11, 2, "Fuego", null, "Fire Fang");
            Poder FireSpin = new Poder(14, 3, "Fuego", null, "Fire Spin");
            Poder Flamethrower = new Poder(15, 5, "Fuego", "Confusion", "Flamethrower");
            Poder Iceshard = new Poder(12, 3, "Hielo", null, "Ice Shard");
            Poder FrostBreath = new Poder(10, 2, "Hielo", null, "Frost Breath");
            Poder PowderSnow = new Poder(6, 1, "Hielo", null, "Powder Snow");
            Poder Hypothemia = new Poder(0, 1, "Hielo", "Sueño", "Hypothemia");
            Poder WaterGun = new Poder(5, 2, "Agua", null, "Water Gun");
            Poder PoisonGun = new Poder(5, 4, "Agua", "Veneno", "Poison Gun");
            Poder Bubble = new Poder(12, 4, "Agua", null, "Bubble");
            Poder Waterfall = new Poder(16, 5, "Agua", null, "Waterfall");
            Poder ThunderShock = new Poder(5, 2, "Electro", null, "Thunder Shock");
            Poder Spark = new Poder(6, 5, "Electro", "Paralisis", "Spark");
            Poder ChargeBeam = new Poder(8, 4, "Electro", null, "Charge Beam");
            Poder VoltSwitch = new Poder(20, 6, "Electro", null, "Volt Switch");

            List<Poder> charmonpow = new List<Poder>();
            charmonpow.Add(ThunderShock);
            charmonpow.Add(Spark);
            charmonpow.Add(Ember);
            charmonpow.Add(Flamethrower);

            Bitmon Charmon = new Bitmon(108, 15, 128, "Charmon", "Fuego", null, charmonpow);

            List<Poder> bitpow = new List<Poder>();
            bitpow.Add(Ember);
            bitpow.Add(FireFang);
            bitpow.Add(FireSpin);
            bitpow.Add(Flamethrower);

            Bitmon Bitmeleon = new Bitmon(140, 20, 160, "Bitmeleon", "Fuego", null, bitpow);

            List<Poder> pikapow = new List<Poder>();
            pikapow.Add(ChargeBeam);
            pikapow.Add(VoltSwitch);
            pikapow.Add(FireFang);
            pikapow.Add(FireSpin);

            Bitmon Pikamon = new Bitmon(102, 17, 124, "Pikamon", "Electro", null, pikapow);

            List<Poder> qwertypow = new List<Poder>();
            qwertypow.Add(ThunderShock);
            qwertypow.Add(Spark);
            qwertypow.Add(ChargeBeam);
            qwertypow.Add(VoltSwitch);

            Bitmon Qwertymon = new Bitmon(154, 22, 200, "Qwertymon", "Electro", null, qwertypow);

            List<Poder> squipow = new List<Poder>();
            squipow.Add(FrostBreath);
            squipow.Add(PowderSnow);
            squipow.Add(Bubble);
            squipow.Add(Waterfall);

            Bitmon Squimon = new Bitmon(142, 13, 112, "Squimon", "Agua", null, squipow);

            List<Poder> worpow = new List<Poder>();
            worpow.Add(WaterGun);
            worpow.Add(PoisonGun);
            worpow.Add(Bubble);
            worpow.Add(Waterfall);

            Bitmon Worbito = new Bitmon(176, 19, 144, "Worbito", "Agua", null, worpow);

            List<Poder> icepow = new List<Poder>();
            icepow.Add(PoisonGun);
            icepow.Add(Iceshard);
            icepow.Add(Hypothemia);
            icepow.Add(WaterGun);

            Bitmon Icemon = new Bitmon(110, 12, 128, "Icemon", "Hielo", null, icepow);

            List<Poder> dragpow = new List<Poder>();
            dragpow.Add(Iceshard);
            dragpow.Add(FrostBreath);
            dragpow.Add(PowderSnow);
            dragpow.Add(Hypothemia);

            Bitmon Dragonice = new Bitmon(152, 20, 170, "Dragonice", "Hielo", null, dragpow);

            List<Poder> tiripow = new List<Poder>();
            tiripow.Add(Flamethrower);
            tiripow.Add(Hypothemia);
            tiripow.Add(PoisonGun);
            tiripow.Add(Spark);

            Bitmon Tirimon = new Bitmon(136, 17, 132, "Tirimon", "Normal", null, tiripow);

            List<Poder> naidopow = new List<Poder>();
            naidopow.Add(FireSpin);
            naidopow.Add(Iceshard);
            naidopow.Add(Waterfall);
            naidopow.Add(VoltSwitch);

            Bitmon Naidormon = new Bitmon(128, 16, 142, "Naidormon", "Normal", null, naidopow);

            List<Bitmon> disponibles = new List<Bitmon>();
            disponibles.Add(Charmon);
            disponibles.Add(Bitmeleon);
            disponibles.Add(Pikamon);
            disponibles.Add(Qwertymon);
            disponibles.Add(Squimon);
            disponibles.Add(Worbito);
            disponibles.Add(Icemon);
            disponibles.Add(Dragonice);
            disponibles.Add(Tirimon);
            disponibles.Add(Naidormon);

            //listo programa
            List<Bitmon> eq1 = new List<Bitmon>();
            List<Bitmon> eq2 = new List<Bitmon>();

            Console.WriteLine("Bienvenidos a BITMON STADIUM\n");
            Console.WriteLine("Ingrese Nombre Jugador 1:  \n");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("\nIngrese Nombre Jugador 2:  \n");
            string nombre2 = Console.ReadLine();

            Console.WriteLine("\nLa batalla está a punto de comenzar!!! \n");
            Console.WriteLine("Los Bitmons disponibles son los siguientes!!: \n");

            Modelo md1 = new Modelo();

            md1.Mostrar(disponibles);

            Console.WriteLine("\n ################################################################################## \n");

            Console.WriteLine("\n" + nombre1 + " ingresa el nombre de tu primer Bitmon!(primer caracter en mayuscula) \n");
            md1.Addequipo(disponibles,eq1);
            Console.Clear();
            Console.WriteLine("\n################################################################################## \n");
            Console.WriteLine("\n" + nombre2 + " ingresa el nombre de tu primer Bitmon!(primer caracter en mayuscula) \n");
            md1.Mostrar(disponibles);
            md1.Addequipo(disponibles, eq2);
            Console.Clear();
            Console.WriteLine("\n################################################################################## \n");
            Console.WriteLine("\n" + nombre2 + " ingresa el nombre de tu segundo Bitmon!(primer caracter en mayuscula)\n ");
            md1.Mostrar(disponibles);
            md1.Addequipo(disponibles, eq2);
            Console.Clear();
            Console.WriteLine("\n################################################################################## \n");
            Console.WriteLine("\n" + nombre1 + " ingresa el nombre de  tu segundo Bitmon(primer caracter en mayuscula)! \n");
            md1.Mostrar(disponibles);
            md1.Addequipo(disponibles, eq1);
            Console.Clear();
            Console.WriteLine("\n################################################################################## \n");
            Console.WriteLine("\n" + nombre1 + " ingresa el nombre de tu ultimo Bitmon!(primer caracter en mayuscula)\n ");
            md1.Mostrar(disponibles);
            md1.Addequipo(disponibles, eq1);
            Console.Clear();
            Console.WriteLine("\n################################################################################## \n");
            Console.WriteLine("\n"+nombre2 + " ingresa el nombre de tu ultimo Bitmon!(primer caracter en mayuscula)\n ");
            md1.Mostrar(disponibles);
            md1.Addequipo(disponibles, eq2);
            Console.WriteLine("\n################################################################################## \n");

            Jugador jg1 = new Jugador(null, eq1, nombre1,1);
            Jugador jg2 = new Jugador(null, eq2, nombre2,2);

            List<Jugador> listas = new List<Jugador>();
            listas.Add(jg1);
            listas.Add(jg2);

            Lucha lucha = new Lucha(listas,1,1,"activa");
            lucha.MsjeBatalla();
            Console.WriteLine("\n################################################################################## \n");
            Console.Clear();
            lucha.Turn();
            Console.WriteLine("\n################################################################################## \n");
            lucha.SelectAct();
            Console.WriteLine("\n################################################################################## \n");
            
            Console.ReadKey();
        }
    }
}
