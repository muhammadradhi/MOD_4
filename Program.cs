using System;
using System.Collections.Generic;

namespace Modul4_103022400055
{
    public class KodePaket
    {
        private Dictionary<string, string> tabelKode = new Dictionary<string, string>
        {
            {"Basic", "P201"}, {"Standard", "P202"}, {"Premium", "P203"},
            {"Unlimited", "P204"}, {"Gaming", "P205"}, {"Streaming", "P206"},
            {"Family", "P207"}, {"Business", "P208"}, {"Student", "P209"},
            {"Traveler", "P210"}
        };

        public string GetKodePaket(string namaPaket)
        {
            if (tabelKode.ContainsKey(namaPaket))
            {
                return tabelKode[namaPaket];
            }
            return "Perubahan state tidak valid";
        }
    }

    public class MesinKopi
    {
        public enum State { OFF, STANDBY, BREWING, MAINTENANCE }
        public State currentState;

        public MesinKopi()
        {
            currentState = State.OFF;
        }

        public void Transisi(State nextState)
        {
            bool valid = false;

            switch (currentState)
            {
                case State.OFF:
                    if (nextState == State.STANDBY) valid = true;
                    break;
                case State.STANDBY:
                    if (nextState == State.BREWING || nextState == State.MAINTENANCE || nextState == State.OFF)
                        valid = true;
                    break;
                case State.BREWING:
                    if (nextState == State.STANDBY) valid = true;
                    break;
                case State.MAINTENANCE:
                    if (nextState == State.STANDBY) valid = true;
                    break;
            }

            if (valid)
            {
                Console.WriteLine($"Mesin {currentState} berubah menjadi {nextState}");
                currentState = nextState;
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        KodePaket kp = new KodePaket();
    //        Console.WriteLine("Kode Paket Student: " + kp.GetKodePaket("Student"));
    //        Console.WriteLine();

    //        MesinKopi mesin = new MesinKopi();
    //        mesin.Transisi(MesinKopi.State.STANDBY);
    //        mesin.Transisi(MesinKopi.State.BREWING);
    //        mesin.Transisi(MesinKopi.State.STANDBY);
    //        mesin.Transisi(MesinKopi.State.MAINTENANCE);
    //        mesin.Transisi(MesinKopi.State.STANDBY);
    //        mesin.Transisi(MesinKopi.State.OFF);
    //        mesin.Transisi(MesinKopi.State.BREWING);

    //        Console.ReadKey();
    //    }
    //}
}